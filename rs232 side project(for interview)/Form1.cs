using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using DM8600DX_RS232_Convert;

namespace rs232_side_project_for_interview_
{
    public partial class Form1 : Form
    {
        SerialPort readerserialport;
        SerialPort plcserialport;
        SetupIni myIni;
        private static String[] rates = { "2400", "4800", "9600", "19200", "38400", "43000", "56000", "57600", "115200" };
        private static String[] paritys = { "None", "Odd", "Even", "Mark", "Space" };
        private static String[] dataBits = { "5", "6", "7", "8" };
        private static String[] stopBits = { "0", "1", "1.5", "2" };
        string RunPath = @"C:\Pancotech";
        string RunIni = @"C:\Pancotech\system.ini";

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            readerserialport = new SerialPort();
            plcserialport = new SerialPort();
            //  myIni = new SetupIni();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.LabelEdit = false;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("�ɶ�", 150);
            listView1.Columns.Add("�T������", 100);
            listView1.Columns.Add("�B�����", 512);
            LoadRs232Par();
            CreatParameter();
            //AutoConnect();

        }
        private void LoadRs232Par() //Load�]�w�� ���K�}�ҳo�Ө禡
        {
            string[] mPorts = SerialPort.GetPortNames();

            foreach (string mPort in mPorts)
            {
                cmportname2.Items.Add(mPort);
                plcportname.Items.Add(mPort);
            }
            foreach (string rate in rates)
            {
                cmbaudrate1.Items.Add(rate);
                cmbaudrate2.Items.Add(rate);
            }
            cmbaudrate1.SelectedIndex = 2; cmbaudrate2.SelectedIndex = 2; //9600 
            foreach (string parity in paritys)
            {
                cmparity1.Items.Add(parity);
                cmparity2.Items.Add(parity);
            }
            cmparity1.SelectedIndex = 0; cmparity2.SelectedIndex = 0;
            foreach (string databit in dataBits)
            {
                cmdatabits1.Items.Add(databit);
                cmdatabits2.Items.Add(databit);
            }
            cmdatabits1.SelectedIndex = 3; cmdatabits2.SelectedIndex = 3;
            foreach (string stopbit in stopBits)
            {
                cmstopbits1.Items.Add(stopbit);
                cmstopbits2.Items.Add(stopbit);
            }
            cmstopbits1.SelectedIndex = 1; 
            cmstopbits2.SelectedIndex = 1;

        }
        private void CreatParameter()
        {
            try
            {
                if (Directory.Exists(RunPath) == false)
                {
                    Directory.CreateDirectory(RunPath);
                }
                if (System.IO.File.Exists(RunIni) == false)
                {
                    //Camera�w�]�Ѽ�                  
                    myIni.IniWriteValue("BCRSIDE", "com", "", RunIni);
                    myIni.IniWriteValue("BCRSIDE", "rates", "9600", RunIni);
                    myIni.IniWriteValue("BCRSIDE", "paritys", "None", RunIni);
                    myIni.IniWriteValue("BCRSIDE", "dataBits", "8", RunIni);
                    myIni.IniWriteValue("BCRSIDE", "stopBits", "1", RunIni);
                    myIni.IniWriteValue("PLCSIDE", "com", "", RunIni);
                    myIni.IniWriteValue("PLCSIDE", "rates", "9600", RunIni);
                    myIni.IniWriteValue("PLCSIDE", "paritys", "None", RunIni);
                    myIni.IniWriteValue("PLCSIDE", "dataBits", "8", RunIni);
                    myIni.IniWriteValue("PLCSIDE", "stopBits", "1", RunIni);
                    myIni.IniWriteValue("PLCSIDE", "EndString", "0", RunIni);
                    //Ū�^
                    label1.Text = myIni.IniReadValue("BCRSIDE", "com", RunIni);
                    cmbaudrate1.Text = myIni.IniReadValue("BCRSIDE", "rates", RunIni);
                    cmparity1.Text = myIni.IniReadValue("BCRSIDE", "paritys", RunIni);
                    cmdatabits1.Text = myIni.IniReadValue("BCRSIDE", "dataBits", RunIni);
                    cmstopbits1.Text = myIni.IniReadValue("BCRSIDE", "stopBits", RunIni);
                    cmportname2.Text = myIni.IniReadValue("PLCSIDE", "com", RunIni);
                    cmbaudrate2.Text = myIni.IniReadValue("PLCSIDE", "rates", RunIni);
                    cmparity2.Text = myIni.IniReadValue("PLCSIDE", "paritys", RunIni);
                    cmdatabits2.Text = myIni.IniReadValue("PLCSIDE", "dataBits", RunIni);
                    cmstopbits2.Text = myIni.IniReadValue("PLCSIDE", "stopBits", RunIni);
                    string ac = myIni.IniReadValue("PLCSIDE", "EndString", RunIni);

                }
            }
            catch
            {
            }
        }
        private void AutoConnect()
        {
            try
            {
                //readerside
                if (cmportname2.Text != "") //port1
                {
                    if (readerserialport.IsOpen)
                    {
                        readerserialport.Close();
                    }
                    readerserialport.PortName = cmportname2.Text;
                    readerserialport.BaudRate = Convert.ToInt16(cmbaudrate1.Text); //16�i�� label2 ��baudrate 
                    readerserialport.DataBits = Convert.ToInt16(cmdatabits1.Text);
                    switch (cmdatabits1.Text)
                    {
                        case "0":
                            readerserialport.StopBits = StopBits.None; break;
                        case "1":
                            readerserialport.StopBits = StopBits.One; break;
                        case "1.5":
                            readerserialport.StopBits = StopBits.OnePointFive; break;
                        case "2":
                            readerserialport.StopBits = StopBits.Two; break;
                    }
                    switch (cmparity1.Text)
                    {
                        case "Name":
                            readerserialport.Parity = Parity.None; break;
                        case "Odd":
                            readerserialport.Parity = Parity.Odd; break;
                        case "Even":
                            readerserialport.Parity = Parity.Even; break;
                        case "Mark":
                            readerserialport.Parity = Parity.Mark; break;
                        case "Space":
                            readerserialport.Parity = Parity.Space; break;
                    }
                    readerserialport.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived); //�U����void ��k
                    readerserialport.Open();
                    if (readerserialport.IsOpen)
                    {
                        readerstatus.BackColor = Color.Lime;
                        btnreaderplcside.Enabled = false;
                    }
                }
                //plcside
                if (plcserialport.IsOpen)
                {
                    plcserialport.Close();
                }
                plcserialport.PortName = plcportname.Text;
                plcserialport.BaudRate = Convert.ToInt16(cmbaudrate2.Text);
                plcserialport.DataBits = Convert.ToInt16(cmdatabits2.Text);
                switch (cmstopbits2.Text)
                {
                    case "0":
                        plcserialport.StopBits = StopBits.None; break;
                    case "1":
                        plcserialport.StopBits = StopBits.One; break;
                    case "1.5":
                        plcserialport.StopBits = StopBits.OnePointFive; break;
                    case "2":
                        plcserialport.StopBits = StopBits.Two; break;
                }
                switch (cmparity2.Text)
                {
                    case "None":
                        plcserialport.Parity = Parity.None; break;
                    case "Odd":
                        plcserialport.Parity = Parity.Odd; break;
                    case "Even":
                        plcserialport.Parity = Parity.Even; break;
                    case "Mark":
                        plcserialport.Parity = Parity.Mark; break;
                    case "Space":
                        plcserialport.Parity = Parity.Space; break;
                }
                plcserialport.Open();
                if (plcserialport.IsOpen)
                {
                    plcsidelight.BackColor = Color.Green;
                    plcsideclosebtn.Enabled = false;
                }
            }
            catch { SystemMessage(1, "Com port �}�Ҳ��`"); }
            
        }
        void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string ReadData = readerserialport.ReadExisting();
            SystemMessage(2, "BCRŪ���H��:" + ReadData);
            if (plcserialport.IsOpen == false)
            {
                SystemMessage(2, "PLC COM PORT ���s��");
            }
            else
            {
                string ResultID = "";
                if (radcr.Checked == true)
                {
                    ResultID = ReadData + "\r";
                }
                if (radcrlf.Checked == true)
                {
                    ResultID = ReadData + "\r\n";
                }
                else if (radnone.Checked == true)
                {
                    ResultID = ReadData;
                }
                plcserialport.Write(ResultID);
                SystemMessage(2, "BCR�o�e" + ReadData + "��PLC����");

            }
        }

        private void SystemMessage(int msgType, string RunLog) //��kprivate
        {
            try
            {
                string mmsg = "";
                switch (msgType)
                {
                    case 1:
                        mmsg = "�q�T�H��";
                        break;
                    case 2:
                        mmsg = "Ū���H��";
                        break;
                }
                //�ɶ�
                string TotalDay = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                //ListView �M��
                if (listView1.Items.Count > 999) { listView1.Items[listView1.Items.Count - 1].Remove(); }
                var item = new ListViewItem(TotalDay);
                item.SubItems.Add(mmsg);
                item.SubItems.Add(RunLog);
                listView1.Items.Insert(0, item);
            }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmportname2.Text == plcportname.Text)
                {
                    MessageBox.Show("Com���|�]�m���ۦP,�Э��s�g");
                    return;
                }
            }
            catch
            {

            }
        }
   
    
        private void button2_Click(object sender, EventArgs e) //close
        {
            try
            {
                plcserialport.Close();
                plcsideclosebtn.Enabled = true;
                plcsidelight.BackColor= Color.Red;
                }
            catch(Exception ex) 
            {

            }
        }

        private void btnreaderplcside_Click(object sender, EventArgs e) //connect�s�u
        {
            if (plcportname.Text != "")
            {
                if(plcserialport.IsOpen) 
                {
                    plcserialport.Close();
                }
                plcserialport.PortName = plcportname.Text;
                plcserialport.BaudRate = Convert.ToInt16(cmbaudrate2.Text);
                plcserialport.DataBits = Convert.ToInt16(cmdatabits2.Text);
                switch (cmstopbits2.Text)
                {
                    case "0":
                        plcserialport.StopBits = StopBits.None;
                        break;
                    case "1":
                        plcserialport.StopBits = StopBits.One;
                        break;
                    case "1.5":
                        plcserialport.StopBits = StopBits.OnePointFive;
                        break;
                    case "2":
                        plcserialport.StopBits = StopBits.Two;
                        break;
                }
                switch (cmparity2.Text)
                {
                    case "None":
                        plcserialport.Parity = Parity.None;
                        break;
                    case "Odd":
                        plcserialport.Parity = Parity.Odd;
                        break;
                    case "Even":
                        plcserialport.Parity = Parity.Even;
                        break;
                    case "Mark":
                        plcserialport.Parity = Parity.Mark;
                        break;
                    case "Space":
                        plcserialport.Parity = Parity.Space;
                        break;
                }
               plcserialport.Open();
                if (plcserialport.IsOpen)
                {
                    plcsidelight.BackColor = Color.Lime;
                    btnreaderplcside.Enabled = false;
                }
            }
        }
    }
            
}