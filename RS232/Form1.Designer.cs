using System.Windows.Forms;

namespace RS232CommunicationApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Kontrolki
        private System.Windows.Forms.Label labelDataBits, labelParity, labelStopBits, labelFlowControl, labelTerminator, labelCustomTerminator, labelMode, labelTimeout;
        private System.Windows.Forms.TextBox textBoxCustomTerminator, textBoxSend, textBoxReceive;
        private System.Windows.Forms.RadioButton radioText, radioBinary;
        private System.Windows.Forms.Button buttonSend, buttonConnect, buttonPing;
        private System.Windows.Forms.CheckBox checkBoxUseTimeout;

        private void InitializeComponent()
        {
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.labelFlowControl = new System.Windows.Forms.Label();
            this.labelTerminator = new System.Windows.Forms.Label();
            this.labelCustomTerminator = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelTimeout = new System.Windows.Forms.Label();
            this.textBoxCustomTerminator = new System.Windows.Forms.TextBox();
            this.radioText = new System.Windows.Forms.RadioButton();
            this.radioBinary = new System.Windows.Forms.RadioButton();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonPing = new System.Windows.Forms.Button();
            this.checkBoxUseTimeout = new System.Windows.Forms.CheckBox();
            this.numericTimeout = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTerminator = new System.Windows.Forms.ComboBox();
            this.comboBoxFlowControl = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDataBits
            // 
            this.labelDataBits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDataBits.Location = new System.Drawing.Point(235, 18);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(100, 17);
            this.labelDataBits.TabIndex = 4;
            this.labelDataBits.Text = "Data bits:";
            // 
            // labelParity
            // 
            this.labelParity.Location = new System.Drawing.Point(341, 18);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(42, 17);
            this.labelParity.TabIndex = 6;
            this.labelParity.Text = "Parity:";
            // 
            // labelStopBits
            // 
            this.labelStopBits.Location = new System.Drawing.Point(469, 18);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(100, 17);
            this.labelStopBits.TabIndex = 8;
            this.labelStopBits.Text = "Stop bits:";
            // 
            // labelFlowControl
            // 
            this.labelFlowControl.Location = new System.Drawing.Point(12, 76);
            this.labelFlowControl.Name = "labelFlowControl";
            this.labelFlowControl.Size = new System.Drawing.Size(49, 14);
            this.labelFlowControl.TabIndex = 10;
            this.labelFlowControl.Text = "Flow:";
            // 
            // labelTerminator
            // 
            this.labelTerminator.Location = new System.Drawing.Point(154, 76);
            this.labelTerminator.Name = "labelTerminator";
            this.labelTerminator.Size = new System.Drawing.Size(66, 14);
            this.labelTerminator.TabIndex = 12;
            this.labelTerminator.Text = "Terminator:";
            // 
            // labelCustomTerminator
            // 
            this.labelCustomTerminator.Location = new System.Drawing.Point(288, 76);
            this.labelCustomTerminator.Name = "labelCustomTerminator";
            this.labelCustomTerminator.Size = new System.Drawing.Size(100, 15);
            this.labelCustomTerminator.TabIndex = 14;
            this.labelCustomTerminator.Text = "Custom:";
            // 
            // labelMode
            // 
            this.labelMode.Location = new System.Drawing.Point(294, 120);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(49, 12);
            this.labelMode.TabIndex = 16;
            this.labelMode.Text = "Mode:";
            // 
            // labelTimeout
            // 
            this.labelTimeout.Location = new System.Drawing.Point(439, 72);
            this.labelTimeout.Name = "labelTimeout";
            this.labelTimeout.Size = new System.Drawing.Size(100, 20);
            this.labelTimeout.TabIndex = 19;
            this.labelTimeout.Text = "Timeout:";
            // 
            // textBoxCustomTerminator
            // 
            this.textBoxCustomTerminator.Location = new System.Drawing.Point(291, 94);
            this.textBoxCustomTerminator.Name = "textBoxCustomTerminator";
            this.textBoxCustomTerminator.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomTerminator.TabIndex = 15;
            // 
            // radioText
            // 
            this.radioText.Location = new System.Drawing.Point(291, 135);
            this.radioText.Name = "radioText";
            this.radioText.Size = new System.Drawing.Size(52, 24);
            this.radioText.TabIndex = 17;
            this.radioText.Text = "Text";
            // 
            // radioBinary
            // 
            this.radioBinary.Location = new System.Drawing.Point(349, 135);
            this.radioBinary.Name = "radioBinary";
            this.radioBinary.Size = new System.Drawing.Size(57, 24);
            this.radioBinary.TabIndex = 18;
            this.radioBinary.Text = "Binary";
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(12, 135);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(273, 20);
            this.textBoxSend.TabIndex = 22;
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Location = new System.Drawing.Point(15, 176);
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.Size = new System.Drawing.Size(671, 20);
            this.textBoxReceive.TabIndex = 23;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(412, 136);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 24;
            this.buttonSend.Text = "Send";
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(611, 38);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 25;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonPing
            // 
            this.buttonPing.Location = new System.Drawing.Point(494, 136);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(75, 23);
            this.buttonPing.TabIndex = 26;
            this.buttonPing.Text = "Ping";
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // checkBoxUseTimeout
            // 
            this.checkBoxUseTimeout.Location = new System.Drawing.Point(442, 92);
            this.checkBoxUseTimeout.Name = "checkBoxUseTimeout";
            this.checkBoxUseTimeout.Size = new System.Drawing.Size(104, 24);
            this.checkBoxUseTimeout.TabIndex = 21;
            this.checkBoxUseTimeout.Text = "Timeout";
            // 
            // numericTimeout
            // 
            this.numericTimeout.Location = new System.Drawing.Point(513, 95);
            this.numericTimeout.Name = "numericTimeout";
            this.numericTimeout.Size = new System.Drawing.Size(120, 20);
            this.numericTimeout.TabIndex = 20;
            // 
            // comboBoxTerminator
            // 
            this.comboBoxTerminator.Location = new System.Drawing.Point(157, 93);
            this.comboBoxTerminator.Name = "comboBoxTerminator";
            this.comboBoxTerminator.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTerminator.TabIndex = 13;
            // 
            // comboBoxFlowControl
            // 
            this.comboBoxFlowControl.Location = new System.Drawing.Point(12, 93);
            this.comboBoxFlowControl.Name = "comboBoxFlowControl";
            this.comboBoxFlowControl.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFlowControl.TabIndex = 11;
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.Location = new System.Drawing.Point(472, 38);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStopBits.TabIndex = 9;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.Location = new System.Drawing.Point(342, 38);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(111, 21);
            this.comboBoxParity.TabIndex = 7;
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.Location = new System.Drawing.Point(238, 38);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(88, 21);
            this.comboBoxDataBits.TabIndex = 5;
            // 
            // labelBaud
            // 
            this.labelBaud.Location = new System.Drawing.Point(120, 18);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(100, 17);
            this.labelBaud.TabIndex = 2;
            this.labelBaud.Text = "Baud:";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Location = new System.Drawing.Point(123, 38);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(97, 21);
            this.comboBoxBaudRate.TabIndex = 3;
            // 
            // labelPort
            // 
            this.labelPort.Location = new System.Drawing.Point(12, 18);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(100, 17);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Port:";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 38);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(88, 21);
            this.comboBoxPorts.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(718, 266);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.labelBaud);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.labelDataBits);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.labelParity);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.labelStopBits);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.labelFlowControl);
            this.Controls.Add(this.comboBoxFlowControl);
            this.Controls.Add(this.labelTerminator);
            this.Controls.Add(this.comboBoxTerminator);
            this.Controls.Add(this.labelCustomTerminator);
            this.Controls.Add(this.textBoxCustomTerminator);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.radioText);
            this.Controls.Add(this.radioBinary);
            this.Controls.Add(this.labelTimeout);
            this.Controls.Add(this.numericTimeout);
            this.Controls.Add(this.checkBoxUseTimeout);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.textBoxReceive);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonPing);
            this.Name = "Form1";
            this.Text = "Konfigurator RS-232";
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private NumericUpDown numericTimeout;
        private ComboBox comboBoxTerminator;
        private ComboBox comboBoxFlowControl;
        private ComboBox comboBoxStopBits;
        private ComboBox comboBoxParity;
        private ComboBox comboBoxDataBits;
        private Label labelBaud;
        private ComboBox comboBoxBaudRate;
        private Label labelPort;
        private ComboBox comboBoxPorts;
    }
}
