namespace GTMT
{
    partial class COMPortTerminal
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
            this.components = new System.ComponentModel.Container();
            this.btPS = new System.Windows.Forms.Button();
            this.btOP = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.txbSend = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btPS
            // 
            this.btPS.Location = new System.Drawing.Point(12, 28);
            this.btPS.Name = "btPS";
            this.btPS.Size = new System.Drawing.Size(99, 37);
            this.btPS.TabIndex = 0;
            this.btPS.Text = "Port Settings";
            this.btPS.UseVisualStyleBackColor = true;
            this.btPS.Click += new System.EventHandler(this.btPS_Click);
            // 
            // btOP
            // 
            this.btOP.Location = new System.Drawing.Point(204, 28);
            this.btOP.Name = "btOP";
            this.btOP.Size = new System.Drawing.Size(99, 37);
            this.btOP.TabIndex = 0;
            this.btOP.Text = "Open Port";
            this.btOP.UseVisualStyleBackColor = true;
            this.btOP.Click += new System.EventHandler(this.btOP_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(204, 204);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(99, 37);
            this.btSend.TabIndex = 0;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(12, 115);
            this.tbxPort.Multiline = true;
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(264, 66);
            this.tbxPort.TabIndex = 1;
            // 
            // txbSend
            // 
            this.txbSend.Location = new System.Drawing.Point(12, 204);
            this.txbSend.Name = "txbSend";
            this.txbSend.Size = new System.Drawing.Size(170, 20);
            this.txbSend.TabIndex = 1;
            // 
            // COMPortTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 262);
            this.Controls.Add(this.txbSend);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btOP);
            this.Controls.Add(this.btPS);
            this.Name = "COMPortTerminal";
            this.Text = "COM Port Terminal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPS;
        private System.Windows.Forms.Button btOP;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.TextBox txbSend;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

