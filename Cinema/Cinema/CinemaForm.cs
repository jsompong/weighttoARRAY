using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public partial class CinemaForm : Form
    {
    
        SerialPort port = new SerialPort("COM10", 9600, Parity.None, 8, StopBits.One);   // Set the COM5 serial port to speed = 9600 baud, parity = none, data bits = 8, stop bits = 1
        private Cinema cinema = new Cinema();

        public CinemaForm()
        {
            InitializeComponent();
            this.sendRead.Text = "- - - - - -";
            port.ReadTimeout = 2000;            // set read time out to 2 seconds
            port.DtrEnable = true;
            port.ReadTimeout = 2000;
            port.WriteTimeout = 2000;
            port.DataReceived += new
            SerialDataReceivedEventHandler(port_DataReceived);
            port.Open();            // open serial port
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);         //Enable Event Handler
            SetintDataFromStorage();
         
        }
        //  public static class YourStorage
        //{
        //  public static object Storage1;
        //public static string StringStorage;

        //}
        private void cinemaPictureBox_Paint(object sender, PaintEventArgs e)
        {
            cinema.Draw(e.Graphics);
            //  cinema.plotDraw(e.Graphics);
        }

        private void CinemaForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) { MessageBox.Show("ZM510 string in " + port); }
            zm510.Text = "รูปแบบ String ที่ ZM510 : 002, T301, 049, [, 105,], 032, T001, 049, [, 087, 053,], 032, T005, 049, 013, 010, end";
            WtBox.Text = "10";
            SIMUtimer.Enabled = true;
        }
        private void CinemaForm_FromClosing(object sender, EventArgs e)
        {
            port.Close();
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int intBuffer;
                intBuffer = port.BytesToRead;
                byte[] byteBuffer = new byte[intBuffer];
                //SerialPort sp = (SerialPort)sender;         // Show all the incoming data in the port's
                ///  _elements.Reply += sp.ReadExisting();
                // port.Read(byteBuffer, 0, intBuffer);
                //port.Read(byteBuffer, 0, intBuffer);         //<--- YOU ARE READING (AND DISCARDING) DATA HERE

                // port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);         //Enable Event Handler                                                                      
                this.Invoke(new EventHandler(DoUpDate));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // new EventHandler(DoUpDate);
            //DoUpDate();
            //  sendRead.Text = port.ReadLine();
        }
        private void DoUpDate(object s, EventArgs e)
        {
            sendRead.Text = port.ReadLine();
            //sendRead.Text += port.ReadLine();
        }

        private void SetintDataFromStorage()
        {
            YourStorage.tempWT = 0;                     // WtBox.Text;
            YourStorage.temparray = 160;
            YourStorage.xStart = 10;
            YourStorage.YequalBoth = 5;
            YourStorage.currentY = 5;
            YourStorage.Yaxis = 5;
        }

        private void cinemaPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void STARTbutton_Click(object sender, EventArgs e)
        {
            if (label5.Visible == false) { label5.Visible = true; }
            if (CONSecutiveBox.Visible == false) { CONSecutiveBox.Visible = true; }
            if (label6.Visible == false) { label6.Visible = true; }
            if (FINconsecBox.Visible == false) { FINconsecBox.Visible = true; }
            FINconsecBox.Text = ""; CONSecutiveBox.Text = "";
            string input = sendRead.Text;            // Part 1: get substring starting at index 2.   // ... This continues until the end of the string.
            string result = input.Substring(2);
            string sub = result.Substring(0, 7);                // Get first seven characters
            CONSecutiveBox.Text = sub;
            CONSECtimer.Enabled = true;
        }

        private void CONSECtimer_Tick(object sender, EventArgs e)
        {
            try
            {
                string input = sendRead.Text;            // Part 1: get substring starting at index 2.   // ... This continues until the end of the string.
                string result = input.Substring(2);
                string sub = result.Substring(0, 7);                // Get first seven characters
                FINconsecBox.Text = sub;
                int x = Int32.Parse(FINconsecBox.Text);
                int y = Int32.Parse(CONSecutiveBox.Text);
                int z = x - y;
                RESULT.Text = "ใน 1 วินาที ได้ String ค่าน้ำหนัก " + z.ToString() + " บรรทัด";
                CONSECtimer.Enabled = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("String ค่าน้ำหนัก รูปแบบไม่ถูกต้อง หรือ ปัญหาเนื่องจาก COM Port");                      //ex.Message
            }
        }

        private void WtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SIMUtimer_Tick(object sender, EventArgs e)
        {
            string wtString = WtBox.Text;
            int number = int.Parse(wtString);
            number = number + 20;
            wtString = number.ToString();
            WtBox.Text = wtString;
            YourStorage.tempWT = number;                 // wtString;
        }

        private void Ymovetimer_Tick(object sender, EventArgs e)
        {
            List<Auction> auctions = new List<Auction>();

            YourStorage.temparray = YourStorage.temparray - 1;
            
            if   (YourStorage.temparray == 1)     {
                MessageBox.Show("alll weight capturted to the array");
                // var items = WTlistBox.Items.Cast<string>().ToArray();                // Convert ListBox items to a string array
                //  var items = WTlistBox.Items.Cast<int>().ToArray();                // Convert ListBox items to a string array
                // Assuming you have a ListBox named listBox1
                string[] lines = new String[150];           // Declaration with size
                  //  int[] numbers = new int[5]; 
                ListBox.ObjectCollection items = WTlistBox.Items;
                //string[] array = items.Cast<string>().ToArray();
                int[] Warray = items.Cast<int>().ToArray();

                // File.AppendAllLines("h:/Cinema/test.text", (items.ToString));                // Append the items to the text file
                // MessageBox.Show("alll weight capturted to the test.text");
                string karray = "";
                for (int ijk = 0; ijk < 149; ijk++)
                {      String wtcv =  Warray[ijk].ToString();
                    lines[ijk] = wtcv;
                   karray = karray + "  " + wtcv;
                  //  int wtS = GlobalData.tempKW[ijk];
                 }
                MessageBox.Show(karray);
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);              //write to Documents  folder
                //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Writezm510.txt")))
                using (StreamWriter outputFile = new StreamWriter(Path.Combine("h:/Cinema/", "Writenzm510.txt")))
                {
                    foreach (string line in lines)        outputFile.WriteLine(line);
                }
                MessageBox.Show("alll weight capturted writen  to the 'Writezm510.txt'  " );
                // foreach (Auction item in auctions)
                // foreach (tempKW item in GlobalData.tempKW[])

                // {
                // your code to handle items here
                // }
                Ymovetimer.Enabled = false;
            }
                //YourStorage.currentY = YourStorage.currentY + 5;
                // while (YourStorage.temparray < 150)
           

                // Add items to the ListBox
             WTlistBox.Items.Add(YourStorage.tempWT);
            // From anywhere in your code...
           // GlobalData.tempKW[YourStorage.temparray] = YourStorage.tempWT;
            //auctions.Add(auctionID );
            // auctions.Add(quantity get);
            //Auction.Add(auction object);
            // Auction(Auction)
            if (LeDBox.BackColor == Color.Lime)
            {           LeDBox.BackColor = Color.Red;                   return;                             }                     // Set the background color to red
            if (LeDBox.BackColor == Color.Red)
            {       LeDBox.BackColor = Color.Lime;                      return;                              }

            //      for (int ij = 0; ij < 214748364; ij++)
            //    { }


            //}
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int[] evenNums = new int[150];
            YourStorage.temparray = 150;
            Ymovetimer.Enabled = true;
        }

        public static class YourStorage
        {
            public static string name;
            public static int Yaxis, YequalBoth, xStart;
            public static int tempWT, currentY, temparray;
         //   private static Timer aTimer;
           // aTimer = new Timer(2000);            // Create a timer with a two second interval.
        }
        public class DrawTextForm : Form
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                Graphics g = e.Graphics;                  // Create a Graphics object

                string drawString = "Hello, World!";             // Define the text to draw
                Font drawFont = new Font("Arial", 16);                 // Create a font
                SolidBrush drawBrush = new SolidBrush(Color.Black);               // Create a brush
                float x = 150.0F;               // Set the position to draw the text
                float y = 50.0F;
                g.DrawString(drawString, drawFont, drawBrush, x, y);                 // Draw the text
                drawFont.Dispose();              // Dispose of the objects
                drawBrush.Dispose();
            }
        }

        private void WTlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LeDBox_Click(object sender, EventArgs e)
        {

        }
    }

    public static class GlobalData
    {
        //public static string[] tempKW = new string[160];
        public static int[] tempKW = new int[160];
    }

    public class Auction
    {
        public string auctionID { get; set; }
        public string itemName { get; set; }
        public string itemID { get; set; }
        public string bid { get; set; }
        public string buyout { get; set; }
        public int quantity { get; set; }
    }

    public class MyTimer
    {
      //  private volatile Timer _timer = new Timer();
        private volatile bool _requestStop = false;
        private MyElapsedEventHandler _eventHander;
        private MyElapsedEventHandlerWithParam _eventHandlerWithParam;
        private object _param;

        public MyTimer(int interval, MyElapsedEventHandler elapsedEventHandler, bool autoReset = false)
        {
        //    _timer.Interval = interval;
          //  _timer.Elapsed += ElapsedWrapper;
          ///  _timer.AutoReset = autoReset;

            _eventHander = elapsedEventHandler;

            Start();
        }

        public MyTimer(int interval, MyElapsedEventHandlerWithParam elapsedEventHandler, object param, bool autoReset = false)
        {
          //  _timer.Interval = interval;
          //  _timer.Elapsed += ElapsedWrapperWithParam;
         //   _timer.AutoReset = autoReset;

            _eventHandlerWithParam = elapsedEventHandler;
            _param = param;

            Start();
        }

        private void ElapsedWrapper(object sender, ElapsedEventArgs e)
        {
            if (!_requestStop && _eventHander != null)
            {
                _eventHander();
            }
        }

        private void ElapsedWrapperWithParam(object sender, ElapsedEventArgs e)
        {
            if (!_requestStop && _eventHandlerWithParam != null)
            {
                _eventHandlerWithParam(_param);
            }
        }

        public void Stop()
        {
            _requestStop = true;
         //   _timer.Stop();
        }

        public void Start()
        {
            _requestStop = false;
         //   _timer.Start();
        }
    }

    public delegate void MyElapsedEventHandlerWithParam(object param);
    public delegate void MyElapsedEventHandler();


}
