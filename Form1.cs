using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace C__Translate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool test()
        {
            string adres = "https://www.google.com.tr/";
            try
            {
                WebRequest istek = WebRequest.Create(adres);
                WebResponse yanit = istek.GetResponse();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (test())
            {
                this.Text = "Baglantı Var";

            }
            else
            {
                this.Text = "Baglantı Yok";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Türkçe";
            label2.Text = "İngilizce";
            webBrowser1.Navigate("https://translate.google.com.tr/#tr/en/");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "English";
            label2.Text = "Turkish";
            webBrowser1.Navigate("https://translate.google.com.tr/#en/tr/");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                richTextBox2.Text=webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
            else if(radioButton2.Checked == true)
            {
                richTextBox2.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richTextBox2.Text;
        }
    }
}
