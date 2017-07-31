using ReadSerialInputFromUSB;
using System;

namespace ReadFromArduino
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialInformation.GetPorts();

            var serialInformation = new SerialInformation();

            serialInformation.ReadFromPort();

            Console.ReadKey();

            serialInformation.SerialPort.Close();
        }
    }
}
