using System.Windows.Forms;

namespace RS232CommunicationApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Kontrolki
        private System.Windows.Forms.Label labelPort, labelBaud, labelDataBits, labelParity, labelStopBits, labelFlowControl, labelTerminator, labelCustomTerminator, labelMode, labelTimeout;
        private System.Windows.Forms.ComboBox comboBoxPorts, comboBoxBaudRate, comboBoxDataBits, comboBoxParity, comboBoxStopBits, comboBoxFlowControl, comboBoxTerminator;
        private System.Windows.Forms.TextBox textBoxCustomTerminator, textBoxSend, textBoxReceive;
        private System.Windows.Forms.RadioButton radioText, radioBinary;
        private System.Windows.Forms.Button buttonSend, buttonConnect, buttonPing;
        private System.Windows.Forms.NumericUpDown numericTimeout;
        private System.Windows.Forms.CheckBox checkBoxUseTimeout;

        private void InitializeComponent()
        {
            // Inicjalizacja komponentów
            components = new System.ComponentModel.Container();

            // Etykiety
            labelPort = new Label() { Text = "Port COM:", Location = new System.Drawing.Point(10, 10) };
            labelBaud = new Label() { Text = "Baud Rate:", Location = new System.Drawing.Point(120, 10) };
            labelDataBits = new Label() { Text = "Data Bits:", Location = new System.Drawing.Point(230, 10) };
            labelParity = new Label() { Text = "Parity:", Location = new System.Drawing.Point(290, 10) };
            labelStopBits = new Label() { Text = "Stop Bits:", Location = new System.Drawing.Point(380, 10) };
            labelFlowControl = new Label() { Text = "Flow Control:", Location = new System.Drawing.Point(470, 10) };

            labelTerminator = new Label() { Text = "Terminator:", Location = new System.Drawing.Point(10, 60) };
            labelCustomTerminator = new Label() { Text = "Własny:", Location = new System.Drawing.Point(120, 60) };

            labelMode = new Label() { Text = "Tryb:", Location = new System.Drawing.Point(180, 60) };
            labelTimeout = new Label() { Text = "Timeout (ms):", Location = new System.Drawing.Point(380, 60) };

            // ComboBoxy
            comboBoxPorts = new ComboBox() { Location = new System.Drawing.Point(10, 30), Width = 100 };
            comboBoxBaudRate = new ComboBox() { Location = new System.Drawing.Point(120, 30), Width = 100 };
            comboBoxDataBits = new ComboBox() { Location = new System.Drawing.Point(230, 30), Width = 50 };
            comboBoxParity = new ComboBox() { Location = new System.Drawing.Point(290, 30), Width = 80 };
            comboBoxStopBits = new ComboBox() { Location = new System.Drawing.Point(380, 30), Width = 80 };
            comboBoxFlowControl = new ComboBox() { Location = new System.Drawing.Point(470, 30), Width = 100 };

            comboBoxTerminator = new ComboBox() { Location = new System.Drawing.Point(10, 80), Width = 100 };
            textBoxCustomTerminator = new TextBox() { Location = new System.Drawing.Point(120, 80), Width = 50 };

            // RadioButtony
            radioText = new RadioButton() { Location = new System.Drawing.Point(180, 80), Text = "Text", Checked = true };
            radioBinary = new RadioButton() { Location = new System.Drawing.Point(240, 80), Text = "Binary" };

            // TextBoxy
            textBoxSend = new TextBox() { Location = new System.Drawing.Point(10, 110), Width = 300 };
            textBoxReceive = new TextBox() { Location = new System.Drawing.Point(10, 140), Width = 300, Height = 100, Multiline = true, ScrollBars = ScrollBars.Vertical };

            // Przyciski
            buttonSend = new Button() { Location = new System.Drawing.Point(320, 110), Text = "Wyślij" };
            buttonConnect = new Button() { Location = new System.Drawing.Point(580, 30), Text = "Połącz" };
            buttonPing = new Button() { Location = new System.Drawing.Point(320, 140), Text = "PING" };

            // Timeout
            numericTimeout = new NumericUpDown() { Location = new System.Drawing.Point(470, 80), Maximum = 10000, Value = 1000 };
            checkBoxUseTimeout = new CheckBox() { Location = new System.Drawing.Point(580, 80), Text = "Użyj Timeout" };

            // Dodanie kontrolek
            this.Controls.AddRange(new Control[]
            {
                labelPort, comboBoxPorts,
                labelBaud, comboBoxBaudRate,
                labelDataBits, comboBoxDataBits,
                labelParity, comboBoxParity,
                labelStopBits, comboBoxStopBits,
                labelFlowControl, comboBoxFlowControl,
                labelTerminator, comboBoxTerminator,
                labelCustomTerminator, textBoxCustomTerminator,
                labelMode, radioText, radioBinary,
                labelTimeout, numericTimeout, checkBoxUseTimeout,
                textBoxSend, textBoxReceive,
                buttonSend, buttonConnect, buttonPing
            });

            // Okno
            this.Text = "Konfigurator RS-232";
            this.ClientSize = new System.Drawing.Size(700, 260);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }
    }
}
