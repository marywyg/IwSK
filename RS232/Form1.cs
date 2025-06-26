using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;

namespace RS232CommunicationApp
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();

            comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
            comboBoxBaudRate.Items.AddRange(new object[] {
                "150", "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"
            });
            comboBoxDataBits.Items.AddRange(new object[] { "7", "8" });
            comboBoxParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            comboBoxStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            comboBoxFlowControl.Items.AddRange(new object[] { "None", "RTS/CTS", "XON/XOFF" });
            comboBoxTerminator.Items.AddRange(new object[] { "Brak", "CR", "LF", "CRLF", "Własny" });
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            try
            {
                serialPort.PortName = comboBoxPorts.Text;
                serialPort.BaudRate = int.Parse(comboBoxBaudRate.Text);
                serialPort.DataBits = int.Parse(comboBoxDataBits.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text);

                switch (comboBoxFlowControl.Text)
                {
                    case "None":
                        serialPort.Handshake = Handshake.None;
                        break;
                    case "RTS/CTS":
                        serialPort.Handshake = Handshake.RequestToSend;
                        break;
                    case "XON/XOFF":
                        serialPort.Handshake = Handshake.XOnXOff;
                        break;
                }

                if (checkBoxUseTimeout.Checked)
                {
                    serialPort.ReadTimeout = (int)numericTimeout.Value;
                    serialPort.WriteTimeout = (int)numericTimeout.Value;
                }

                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
                MessageBox.Show("Połączono");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia: " + ex.Message);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string data = textBoxSend.Text;

            if (comboBoxTerminator.Text == "CR") data += "\r";
            else if (comboBoxTerminator.Text == "LF") data += "\n";
            else if (comboBoxTerminator.Text == "CRLF") data += "\r\n";
            else if (comboBoxTerminator.Text == "Własny") data += textBoxCustomTerminator.Text;

            try
            {
                if (radioBinary.Checked)
                {
                    byte[] bin = Convert.FromBase64String(data.Replace(" ", ""));
                    serialPort.Write(bin, 0, bin.Length);
                }
                else
                {
                    serialPort.Write(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd wysyłania: " + ex.Message);
            }
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                serialPort.Write("PING\n");
                string response = serialPort.ReadLine();
                stopwatch.Stop();
                MessageBox.Show($"Odpowiedź: {response} w {stopwatch.ElapsedMilliseconds} ms");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd PING: " + ex.Message);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string received = serialPort.ReadExisting();
            Invoke(new Action(() =>
            {
                textBoxReceive.AppendText(received);
            }));
        }
    }
}
