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

            // Налаштування порту
            if (port == null)
            {
                port = new SerialPort("COM6", 9600); // Вкажіть свій COM-порт
                port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived); // Додано обробник події
                port.Open();
            }
        }

        // Закриття порту при закритті форми
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }

        // Надсилання даних на плату
        private void button1_Click(object sender, EventArgs e)
        {
            PortWrite("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PortWrite("0");
        }

        // Метод для запису в порт
        private void PortWrite(string message)
        {
            port.Write(message);
        }

        // Обробник події для отримання даних з порту
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = port.ReadExisting(); // Читання даних з порту
            this.Invoke(new MethodInvoker(delegate
            {
                // Оновлення label залежно від отриманих даних
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
