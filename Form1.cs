//created by Amin Jalali, St.number : 973663044 Univercity of Isfahan, 01.16.2023

using System;
using System.Windows.Forms;
using SerialTerminal.Codes;

namespace SerialTerminal
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();

            serialPortManager = new SerialPortManager(historyList);
            Console.WriteLine("Serial Port Manager Created.");
            UIUtility.RefreshDropDown(portComboBox);
            Console.WriteLine("Port Combo Box Refreshed.");
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string portName = portComboBox.SelectedItem.ToString();
            UIUtility.AddInputToHistory(historyList, $"connecting to port: {portName}...");
            int baudRate = int.Parse(baudrateComboBox.SelectedItem.ToString());
            System.IO.Ports.Parity parity = System.IO.Ports.Parity.None;
            switch (parityComboBox.SelectedItem.ToString())
            {
                case "none":
                    parity = System.IO.Ports.Parity.None;
                    break;
                case "even":
                    parity = System.IO.Ports.Parity.Even;
                    break;
                case "odd":
                    parity = System.IO.Ports.Parity.Odd;
                    break;
                case "mark":
                    parity = System.IO.Ports.Parity.Mark;
                    break;
                case "space":
                    parity = System.IO.Ports.Parity.Space;
                    break;
            }
            int dataBits = int.Parse(dataBitComboBox.SelectedItem.ToString());
            System.IO.Ports.StopBits stopBits = System.IO.Ports.StopBits.None;
            switch (stopBitComboBox.SelectedItem.ToString())
            {
                case "none":
                    stopBits = System.IO.Ports.StopBits.None;
                    break;
                case "1":
                    stopBits = System.IO.Ports.StopBits.One;
                    break;
                case "2":
                    stopBits = System.IO.Ports.StopBits.Two;
                    break;
                case "1.5":
                    stopBits = System.IO.Ports.StopBits.OnePointFive;
                    break;
            }
            System.IO.Ports.Handshake handshake = System.IO.Ports.Handshake.None;
            switch (handshakeComboBox.SelectedItem.ToString())
            {
                case "none":
                     handshake = System.IO.Ports.Handshake.None;
                    break;
                case "RTS":
                    handshake = System.IO.Ports.Handshake.RequestToSend;
                    break;
                case "Xon / Xoff":
                    handshake = System.IO.Ports.Handshake.XOnXOff;
                    break;
                case "RTS + Xon / Xoff":
                    handshake = System.IO.Ports.Handshake.RequestToSendXOnXOff;
                    break;
            }
            serialPort = serialPortManager.OpenSerialConnection(portName, baudRate, parity, dataBits, stopBits, handshake, 500);
            UIUtility.AddInputToHistory(historyList, $"connected to port: {portName}.");
        }

        private void closeConBbutton_Click(object sender, EventArgs e)
        {
            UIUtility.AddInputToHistory(historyList, $"closing connection to port: {serialPort.PortName}...");
            serialPortManager.CloseSerialConnection(serialPort);
            UIUtility.AddInputToHistory(historyList, "connection closed.");
        }

        private void rescanButton_Click(object sender, EventArgs e)
        {
            UIUtility.AddInputToHistory(historyList, "rescanning ports...");
            string[] portNames = serialPortManager.GetSerialPortNames();
            portComboBox.Items.Clear();
            UIUtility.FillDropDownValues(portComboBox, portNames);
            UIUtility.AddInputToHistory(historyList, "scan complete.");
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string data = inputTextBox.Text;
            if (!data.Equals("") && data != null)
            {
                UIUtility.AddInputToHistory(historyList, "sending:");
                serialPortManager.SerialPortWrite(serialPort, data);
                UIUtility.AddInputToHistory(historyList, data);
            }
            inputTextBox.ResetText();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            UIUtility.ClearHistory(historyList);
        }

        private void streamCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            serialPortManager.FeedCurrentSerialPort(serialPort);
            if (streamCheckBox.Checked)
            {
                inputTextBox.TextChanged += serialPortManager.OnInputChnaged;
                sendButton.Enabled = false;
            }
            else
            {
                inputTextBox.TextChanged -= serialPortManager.OnInputChnaged;
                sendButton.Enabled = true;
            }
        }
    }
}
