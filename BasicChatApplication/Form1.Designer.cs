namespace BasicChatApplication
{
    partial class Form1
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
            this.txtOuput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblServerInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOuput
            // 
            this.txtOuput.Location = new System.Drawing.Point(12, 64);
            this.txtOuput.Multiline = true;
            this.txtOuput.Name = "txtOuput";
            this.txtOuput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOuput.Size = new System.Drawing.Size(721, 282);
            this.txtOuput.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 352);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(611, 51);
            this.txtInput.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(629, 352);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 51);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(445, 32);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(178, 26);
            this.txtIpAddress.TabIndex = 3;
            this.txtIpAddress.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(633, 32);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 26);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "1234";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblServerInfo
            // 
            this.lblServerInfo.AutoSize = true;
            this.lblServerInfo.Location = new System.Drawing.Point(13, 13);
            this.lblServerInfo.Name = "lblServerInfo";
            this.lblServerInfo.Size = new System.Drawing.Size(81, 20);
            this.lblServerInfo.TabIndex = 5;
            this.lblServerInfo.Text = "Listening :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Send Message To:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblServerInfo);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOuput);
            this.Name = "Form1";
            this.Text = "Basic Chat Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOuput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblServerInfo;
        private System.Windows.Forms.Label label1;
    }
}

