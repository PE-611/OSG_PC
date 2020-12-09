using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Test_COM
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new OSG());

            SerialPort _serialPort = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);

            _serialPort.Handshake = Handshake.None;


        }
    }
}
