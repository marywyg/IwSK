using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;

namespace RS232CommunicationApp
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private Stopwatch pingTimer = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void RefreshPorts()
        {
            comboBoxPorts.Items.Clear();
            comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
            if (comboBoxPorts.Items.Count > 0)
                comboBoxPorts.SelectedIndex = 0;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort = new SerialPort(comboBoxPorts.Text, 9600, Parity.None, 8, StopBits.One);
                serialPort.Handshake = Handshake.None;
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
                textBoxLog.AppendText($"[INFO] Połączono z {serialPort.PortName}\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia: " + ex.Message);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                string message = textBoxSend.Text;
                pingTimer.Restart();
                serialPort.WriteLine(message);
                textBoxLog.AppendText($"[TX] {message}\r\n");
            }
            else
            {
                MessageBox.Show("Nie połączono z portem COM.");
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string received = serialPort.ReadExisting();
            pingTimer.Stop();

            Invoke(new Action(() =>
            {
                textBoxReceived.AppendText(received + "\r\n");
                textBoxLog.AppendText($"[RX] {received.Trim()} (Ping: {pingTimer.ElapsedMilliseconds} ms)\r\n");
            }));
        }
    }
}
