namespace RS232CommunicationApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.TextBox textBoxReceived;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxReceived = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // comboBoxPorts
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 12);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);

            // buttonRefresh
            this.buttonRefresh.Location = new System.Drawing.Point(139, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);

            // buttonConnect
            this.buttonConnect.Location = new System.Drawing.Point(220, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.Text = "Połącz";
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);

            // textBoxSend
            this.textBoxSend.Location = new System.Drawing.Point(12, 50);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(283, 20);

            // buttonSend
            this.buttonSend.Location = new System.Drawing.Point(301, 48);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.Text = "Wyślij";
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);

            // textBoxReceived
            this.textBoxReceived.Location = new System.Drawing.Point(12, 85);
            this.textBoxReceived.Multiline = true;
            this.textBoxReceived.Name = "textBoxReceived";
            this.textBoxReceived.ReadOnly = true;
            this.textBoxReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceived.Size = new System.Drawing.Size(364, 100);

            // textBoxLog
            this.textBoxLog.Location = new System.Drawing.Point(12, 195);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(364, 100);

            // Form1
            this.ClientSize = new System.Drawing.Size(390, 310);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxReceived);
            this.Controls.Add(this.textBoxLog);
            this.Name = "Form1";
            this.Text = "RS-232 Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
