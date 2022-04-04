using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;

namespace chatnumara
{
   
public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkay_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Lütfen Dosya Kaydetme Yerini Seçin";
            saveFileDialog1.Filter = "(*.doc)|*.doc|(*.txt)|*.txt|Tüm dosyalar(*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.ShowDialog();
            StreamWriter Kaydet = new StreamWriter(saveFileDialog1.FileName);
            foreach (string yazi in lstyok.Items)
            {
                Kaydet.WriteLine(yazi); //yoklama olarak kaydetme
            }
            Kaydet.Close();
        }

        private void btnisle_Click(object sender, EventArgs e)
        {

           
            textBox1.Text="Sınıf mevcudu: " + (numaralar.Length-1);
            foreach (string i in numaralar)

            {

                lstyok.Items.Add(i);//yoklama listesini yazdırıyoruz

            }

        }


        string[] numaralar; 
        private void btnchat_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.ShowDialog();
            rtbgelen.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
            string[] ogrenci = System.IO.File.ReadAllLines(openFile1.FileName);

            for (int i = 0; i < ogrenci.Length; i++)
            {
                ogrenci[i] = ogrenci[i].Substring(15, 10);//chat dosyamıza göre numaraların başlangıç karekter sıralamsı 15 karekterden itibaren 10 karekter alıyor
            }
            numaralar = ogrenci.Distinct().ToArray();//seçilmiş olan tabiri var 1 defa alıyor.
            Array.Sort(numaralar);//numara sıralaması
        }

    }
}
