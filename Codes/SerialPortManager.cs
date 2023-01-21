//created by Amin Jalali, St.number : 973663044 Univercity of Isfahan, 01.16.2023

using System.IO.Ports;
using System;
using System.Windows.Forms;
using SerialTerminal.Codes;

namespace SerialTerminal.Codes
{
    internal class SerialPortManager
    {
        private ListBox historyList;
        private SerialPort serialPort;

        public SerialPortManager(System.Windows.Forms.ListBox historyList)
        {
            this.historyList = historyList; // feed listbox to fill it with received data.
        }

        public void FeedCurrentSerialPort(SerialPort serialPort)
        {
            this.serialPort = serialPort;
        }

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
            serialPort.DataReceived += BufferDataChanged;
            return serialPort;
        }

        public void CloseSerialConnection(SerialPort serialPort)
        {
            //try
            //{
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
            //} catch(NullReferenceException e) { }
        }

        public void SerialPortWrite(SerialPort serialPort, string message)
        {
            //try
            //{
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Write(message);
                }
            }
            //} catch(NullReferenceException e) { }
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

        public void BufferDataChanged(object sender, System.EventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            if (serialPort != null)
            {
                UIUtility.AddInputToHistory(historyList, "Data Recieved:");
                UIUtility.AddInputToHistory(historyList, SerialPortReadExisting(serialPort));
            }
        }

        public void OnInputChnaged(object sender, System.EventArgs e)
        {
            RichTextBox input = (RichTextBox)sender;
            SerialPortWrite(serialPort, input.Text);
            string dataRecieved = SerialPortReadExisting(serialPort);
            if (!dataRecieved.Equals(""))
            {
                UIUtility.AddInputToHistory(historyList, dataRecieved);
            }
        }
    }
}
