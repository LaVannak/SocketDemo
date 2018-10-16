namespace SocketDemo
{
    partial class frmServer
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
            this.btnListen = new System.Windows.Forms.Button();
            this.lstRecived = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(13, 13);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(222, 23);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Start";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // lstRecived
            // 
            this.lstRecived.FormattingEnabled = true;
            this.lstRecived.Location = new System.Drawing.Point(13, 43);
            this.lstRecived.Name = "lstRecived";
            this.lstRecived.Size = new System.Drawing.Size(222, 95);
            this.lstRecived.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(179, 145);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(13, 145);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(160, 20);
            this.txtMsg.TabIndex = 3;
            this.txtMsg.TextChanged += new System.EventHandler(this.txtMsg_TextChanged);
            this.txtMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMsg_KeyDown);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 188);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lstRecived);
            this.Controls.Add(this.btnListen);
            this.Name = "frmServer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.DoubleClick += new System.EventHandler(this.frmServer_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.ListBox lstRecived;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

