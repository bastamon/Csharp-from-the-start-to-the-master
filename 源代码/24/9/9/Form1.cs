using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace _
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = "邮件测试.txt";
            MailAddress from = new MailAddress("tsoft@163.com");   //设置邮件发送人
            MailAddress to = new MailAddress("tsoft@163.com");     //设置邮件接收人
            MailMessage message = new MailMessage(from,to);        //实例化一个MaileMessage类对象
            message.Subject = "邮件测试";                          //设置发送邮件的主题
            message.Body = "邮件正文";                             //设置发送邮件的内容
            //为要发送的邮件创建附件信息
            Attachment myAttachment = new Attachment(file, System.Net.Mime.MediaTypeNames.Application.Octet);
            //为附件添加时间信息
            System.Net.Mime.ContentDisposition disposition = myAttachment.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(file);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
            message.Attachments.Add(myAttachment);             //将创建的附件添加到邮件中
            //实例化SmtpClient邮件发送类对象
            SmtpClient client = new SmtpClient("192.168.1.97", 25);
            //设置用于验证发件人身份的凭据
            client.Credentials = new System.Net.NetworkCredential("tsoft", "111");
            //发送邮件
            client.Send(message);
            MessageBox.Show("发送成功");
        }
    }
}