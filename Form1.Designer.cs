//created by Amin Jalali, St.number : 973663044 Univercity of Isfahan, 01.16.2023

namespace SerialTerminal
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.historyList = new System.Windows.Forms.ListBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baudrateComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.rescanButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.streamCheckBox = new System.Windows.Forms.CheckBox();
            this.closeConBbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataBitComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stopBitComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.handshakeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.historyList);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // historyList
            // 
            this.historyList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyList.FormattingEnabled = true;
            resources.ApplyResources(this.historyList, "historyList");
            this.historyList.Name = "historyList";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sendButton.FlatAppearance.BorderSize = 10;
            resources.ApplyResources(this.sendButton, "sendButton");
            this.sendButton.Name = "sendButton";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // inputTextBox
            // 
            resources.ApplyResources(this.inputTextBox, "inputTextBox");
            this.inputTextBox.Name = "inputTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // baudrateComboBox
            // 
            this.baudrateComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.baudrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudrateComboBox.FormattingEnabled = true;
            this.baudrateComboBox.Items.AddRange(new object[] {
            resources.GetString("baudrateComboBox.Items"),
            resources.GetString("baudrateComboBox.Items1"),
            resources.GetString("baudrateComboBox.Items2"),
            resources.GetString("baudrateComboBox.Items3"),
            resources.GetString("baudrateComboBox.Items4"),
            resources.GetString("baudrateComboBox.Items5"),
            resources.GetString("baudrateComboBox.Items6"),
            resources.GetString("baudrateComboBox.Items7"),
            resources.GetString("baudrateComboBox.Items8"),
            resources.GetString("baudrateComboBox.Items9"),
            resources.GetString("baudrateComboBox.Items10"),
            resources.GetString("baudrateComboBox.Items11"),
            resources.GetString("baudrateComboBox.Items12"),
            resources.GetString("baudrateComboBox.Items13")});
            resources.ApplyResources(this.baudrateComboBox, "baudrateComboBox");
            this.baudrateComboBox.Name = "baudrateComboBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // portComboBox
            // 
            this.portComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Items.AddRange(new object[] {
            resources.GetString("portComboBox.Items"),
            resources.GetString("portComboBox.Items1")});
            resources.ApplyResources(this.portComboBox, "portComboBox");
            this.portComboBox.Name = "portComboBox";
            // 
            // rescanButton
            // 
            this.rescanButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rescanButton.FlatAppearance.BorderSize = 10;
            resources.ApplyResources(this.rescanButton, "rescanButton");
            this.rescanButton.Name = "rescanButton";
            this.rescanButton.UseVisualStyleBackColor = false;
            this.rescanButton.Click += new System.EventHandler(this.rescanButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.connectButton.FlatAppearance.BorderSize = 10;
            resources.ApplyResources(this.connectButton, "connectButton");
            this.connectButton.Name = "connectButton";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.FlatAppearance.BorderSize = 10;
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // streamCheckBox
            // 
            resources.ApplyResources(this.streamCheckBox, "streamCheckBox");
            this.streamCheckBox.Name = "streamCheckBox";
            this.streamCheckBox.UseVisualStyleBackColor = true;
            this.streamCheckBox.CheckedChanged += new System.EventHandler(this.streamCheckBox_CheckedChanged);
            // 
            // closeConBbutton
            // 
            this.closeConBbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.closeConBbutton.FlatAppearance.BorderSize = 10;
            resources.ApplyResources(this.closeConBbutton, "closeConBbutton");
            this.closeConBbutton.Name = "closeConBbutton";
            this.closeConBbutton.UseVisualStyleBackColor = false;
            this.closeConBbutton.Click += new System.EventHandler(this.closeConBbutton_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dataBitComboBox
            // 
            this.dataBitComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataBitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBitComboBox.FormattingEnabled = true;
            this.dataBitComboBox.Items.AddRange(new object[] {
            resources.GetString("dataBitComboBox.Items"),
            resources.GetString("dataBitComboBox.Items1"),
            resources.GetString("dataBitComboBox.Items2"),
            resources.GetString("dataBitComboBox.Items3")});
            resources.ApplyResources(this.dataBitComboBox, "dataBitComboBox");
            this.dataBitComboBox.Name = "dataBitComboBox";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // parityComboBox
            // 
            this.parityComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] {
            resources.GetString("parityComboBox.Items"),
            resources.GetString("parityComboBox.Items1"),
            resources.GetString("parityComboBox.Items2"),
            resources.GetString("parityComboBox.Items3"),
            resources.GetString("parityComboBox.Items4")});
            resources.ApplyResources(this.parityComboBox, "parityComboBox");
            this.parityComboBox.Name = "parityComboBox";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // stopBitComboBox
            // 
            this.stopBitComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.stopBitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitComboBox.FormattingEnabled = true;
            this.stopBitComboBox.Items.AddRange(new object[] {
            resources.GetString("stopBitComboBox.Items"),
            resources.GetString("stopBitComboBox.Items1"),
            resources.GetString("stopBitComboBox.Items2")});
            resources.ApplyResources(this.stopBitComboBox, "stopBitComboBox");
            this.stopBitComboBox.Name = "stopBitComboBox";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // handshakeComboBox
            // 
            this.handshakeComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.handshakeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.handshakeComboBox.FormattingEnabled = true;
            this.handshakeComboBox.Items.AddRange(new object[] {
            resources.GetString("handshakeComboBox.Items"),
            resources.GetString("handshakeComboBox.Items1"),
            resources.GetString("handshakeComboBox.Items2"),
            resources.GetString("handshakeComboBox.Items3")});
            resources.ApplyResources(this.handshakeComboBox, "handshakeComboBox");
            this.handshakeComboBox.Name = "handshakeComboBox";
            // 
            // mainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stopBitComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.handshakeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataBitComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.parityComboBox);
            this.Controls.Add(this.closeConBbutton);
            this.Controls.Add(this.streamCheckBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.rescanButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baudrateComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox historyList;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox baudrateComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button rescanButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox streamCheckBox;
        private System.Windows.Forms.Button closeConBbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dataBitComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox stopBitComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox handshakeComboBox;
        private SerialTerminal.Codes.SerialPortManager serialPortManager;
        private System.IO.Ports.SerialPort serialPort;
    }
}

