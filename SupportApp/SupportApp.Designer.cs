namespace SupportApp
{
    partial class SupportApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelConnectCode = new System.Windows.Forms.Label();
            this.textBoxConnectCode = new System.Windows.Forms.TextBox();
            this.radioButtonRemoteDesktop = new System.Windows.Forms.RadioButton();
            this.radioButtonSendFile = new System.Windows.Forms.RadioButton();
            this.radioButtonReceiveFile = new System.Windows.Forms.RadioButton();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(30, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(96, 13);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "You\'re here to help";
            // 
            // labelConnectCode
            // 
            this.labelConnectCode.AutoSize = true;
            this.labelConnectCode.Location = new System.Drawing.Point(12, 42);
            this.labelConnectCode.Name = "labelConnectCode";
            this.labelConnectCode.Size = new System.Drawing.Size(78, 13);
            this.labelConnectCode.TabIndex = 1;
            this.labelConnectCode.Text = "Connect Code:";
            // 
            // textBoxConnectCode
            // 
            this.textBoxConnectCode.Location = new System.Drawing.Point(96, 39);
            this.textBoxConnectCode.Name = "textBoxConnectCode";
            this.textBoxConnectCode.Size = new System.Drawing.Size(56, 20);
            this.textBoxConnectCode.TabIndex = 2;
            this.textBoxConnectCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButtonRemoteDesktop
            // 
            this.radioButtonRemoteDesktop.AutoSize = true;
            this.radioButtonRemoteDesktop.Checked = true;
            this.radioButtonRemoteDesktop.Location = new System.Drawing.Point(39, 65);
            this.radioButtonRemoteDesktop.Name = "radioButtonRemoteDesktop";
            this.radioButtonRemoteDesktop.Size = new System.Drawing.Size(105, 17);
            this.radioButtonRemoteDesktop.TabIndex = 3;
            this.radioButtonRemoteDesktop.TabStop = true;
            this.radioButtonRemoteDesktop.Text = "Remote Desktop";
            this.radioButtonRemoteDesktop.UseVisualStyleBackColor = true;
            // 
            // radioButtonSendFile
            // 
            this.radioButtonSendFile.AutoSize = true;
            this.radioButtonSendFile.Location = new System.Drawing.Point(39, 88);
            this.radioButtonSendFile.Name = "radioButtonSendFile";
            this.radioButtonSendFile.Size = new System.Drawing.Size(69, 17);
            this.radioButtonSendFile.TabIndex = 4;
            this.radioButtonSendFile.TabStop = true;
            this.radioButtonSendFile.Text = "Send File";
            this.radioButtonSendFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonReceiveFile
            // 
            this.radioButtonReceiveFile.AutoSize = true;
            this.radioButtonReceiveFile.Location = new System.Drawing.Point(39, 111);
            this.radioButtonReceiveFile.Name = "radioButtonReceiveFile";
            this.radioButtonReceiveFile.Size = new System.Drawing.Size(84, 17);
            this.radioButtonReceiveFile.TabIndex = 5;
            this.radioButtonReceiveFile.TabStop = true;
            this.radioButtonReceiveFile.Text = "Receive File";
            this.radioButtonReceiveFile.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(39, 134);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // SupportApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 171);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.radioButtonReceiveFile);
            this.Controls.Add(this.radioButtonSendFile);
            this.Controls.Add(this.radioButtonRemoteDesktop);
            this.Controls.Add(this.textBoxConnectCode);
            this.Controls.Add(this.labelConnectCode);
            this.Controls.Add(this.labelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SupportApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Support";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelConnectCode;
        private System.Windows.Forms.TextBox textBoxConnectCode;
        private System.Windows.Forms.RadioButton radioButtonRemoteDesktop;
        private System.Windows.Forms.RadioButton radioButtonSendFile;
        private System.Windows.Forms.RadioButton radioButtonReceiveFile;
        private System.Windows.Forms.Button buttonConnect;
    }
}

