using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort port;

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

            // ������������ �����
            if (port == null)
            {
                port = new SerialPort("COM6", 9600); // ������ ��� COM-����
                port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived); // ������ �������� ��䳿
                port.Open();
            }
        }

        // �������� ����� ��� ������� �����
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }

        // ���������� ����� �� �����
        private void button1_Click(object sender, EventArgs e)
        {
            PortWrite("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PortWrite("0");
        }

        // ����� ��� ������ � ����
        private void PortWrite(string message)
        {
            port.Write(message);
        }

        // �������� ��䳿 ��� ��������� ����� � �����
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = port.ReadExisting(); // ������� ����� � �����
            this.Invoke(new MethodInvoker(delegate
            {
                // ��������� label ������� �� ��������� �����
                if (data.Contains("1"))
                {
                    statusLabel.Text = "Button State: Pressed";
                }
                else if (data.Contains("0"))
                {
                    statusLabel.Text = "Button State: Released";
                }
            }));
        }
    }
}
