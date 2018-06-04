using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace win_talkClient
{
    public partial class Form1 : Form
    {
        #region//声名变量
        IPAddress HostIP = IPAddress.Parse("127.0.0.1");
        IPEndPoint point;
        Socket socket;
        bool flag = true;
        #endregion

       

       #region//声名委托
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
           textBox2.AppendText(text + "\r\n");
       }
        #endregion

       #region//进程
       private void Proccess()
        {
            if (socket.Connected)
            {
                while (flag)
                {
                    byte[] receiveByte = new byte[64];
                    socket.Receive(receiveByte, receiveByte.Length, 0);
                    string strInfo = Encoding.BigEndianUnicode.GetString(receiveByte);
                    this.Invoke(new SetTextCallback(SetText),new object[]{strInfo});
                    
                }
            }
        }
       #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] sendByte = new Byte[64];
                string sendStr = this.textBox1.Text + "：" + this.textBox3.Text+"\r\n";
                sendByte = Encoding.BigEndianUnicode.GetBytes(sendStr.ToCharArray());
                socket.Send(sendByte, sendByte.Length, 0);


            }
            catch { }
        }
        
        public Form1()
            {
                InitializeComponent();
            }

        private void Form1_Load(object sender, EventArgs e)
            {

            }

         private void button1_Click(object sender, EventArgs e)
            {
                HostIP = IPAddress.Parse("127.0.0.1");
                try
                {
                    point = new IPEndPoint(HostIP, Int32.Parse("11000"));
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(point);

                    Thread thread = new Thread(new ThreadStart(Proccess));
                    thread.Start();
                }
                catch(Exception ey)
                {
                    MessageBox.Show("服务器没有开启\r\n"+ey.Message);
                }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            socket.Close();
        }
    }
}