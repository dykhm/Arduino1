using System;
using System.Windows.Forms;
using System.IO.Ports;


namespace WinFormsApp1
{
    internal static class Program
    {
      
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    
}