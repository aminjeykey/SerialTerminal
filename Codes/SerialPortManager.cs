//created by Amin Jalali, St.number : 973663044 Univercity of Isfahan, 01.16.2023

using System.IO.Ports;

namespace SerialTerminal.Codes
{
    internal class SerialPortManager
    {

        public SerialPortManager() {}

        public string[] GetSerialPortNames()
        {
            return SerialPort.GetPortNames();
        }

        public SerialPort OpenSerialConnection(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits, Handshake serialHandshake, int serialWriteTimeout)
        {
            SerialPort serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);
            serialPort.Handshake = serialHandshake;
            serialPort.WriteTimeout = serialWriteTimeout;
            if (!serialPort.IsOpen)
            {
                serialPort.Open();
            }
            return serialPort;
        }

        public void CloseSerialConnection(SerialPort serialPort)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        public void SerialPortWrite(SerialPort serialPort, string message)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(message);
            }
        }
        public string SerialPortReadExisting(SerialPort serialPort)
        {
            string serialPortValue = "";
            if(serialPort.IsOpen)
            {
                serialPortValue = serialPort.ReadExisting();
            }
            return serialPortValue;
        }
    }
}
