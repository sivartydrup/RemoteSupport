using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;

namespace ControlCentre
{
    public partial class ControlCentre : ServiceBase
    {
        public ControlCentre()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Thread ThreadHandlerThread = new Thread(new ThreadStart(ThreadHandler));
            ThreadHandlerThread.Start();
        }

        protected override void OnStop()
        {

        }

        public void ThreadHandler()
        {
            Socket IncomingSocket;
            Thread SocketHandlerThread;
            NetworkStream IncomingNetworkStream;
            StreamReader IncomingStreamReader;
            TcpListener IncomingListener = new TcpListener(8081);
            IncomingListener.Start();

            while (true)
            {
                IncomingSocket = IncomingListener.AcceptSocket();

                if (IncomingSocket.Connected)
                {
                    Boolean WaitingToTransfer = true;
                    while (WaitingToTransfer)
                    {
                        IncomingNetworkStream = new NetworkStream(IncomingSocket);
                        IncomingStreamReader = new StreamReader(IncomingNetworkStream);

                        String TypeOfConnection = IncomingStreamReader.ReadLine();

                        if (TypeOfConnection == "MA")
                        {
                            Thread MiniAppThread = new Thread(() => MiniHandler(IncomingSocket));
                            MiniAppThread.Start();
                            WaitingToTransfer = false;
                        }
                        else if (TypeOfConnection == "SA")
                        {
                            Thread SupportAppThread = new Thread(() => SupportHandler(IncomingSocket));
                            SupportAppThread.Start();
                            WaitingToTransfer = false;
                        }
                    }
                }
            }

        }

        public void MiniHandler(Socket IncomingSocket)
        {

        }

        public void SupportHandler(Socket IncomingSocket)
        {

        }
    }
}
