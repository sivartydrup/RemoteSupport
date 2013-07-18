namespace MiniApp
{
    partial class MiniApp
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
            this.textBoxConnectCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(51, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(99, 13);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Come here for help!";
            // 
            // textBoxConnectCode
            // 
            this.textBoxConnectCode.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxConnectCode.Enabled = false;
            this.textBoxConnectCode.Location = new System.Drawing.Point(72, 34);
            this.textBoxConnectCode.Name = "textBoxConnectCode";
            this.textBoxConnectCode.Size = new System.Drawing.Size(56, 20);
            this.textBoxConnectCode.TabIndex = 1;
            this.textBoxConnectCode.Text = "888 888";
            this.textBoxConnectCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MiniApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 65);
            this.Controls.Add(this.textBoxConnectCode);
            this.Controls.Add(this.labelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MiniApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Support";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textBoxConnectCode;
    }
}

