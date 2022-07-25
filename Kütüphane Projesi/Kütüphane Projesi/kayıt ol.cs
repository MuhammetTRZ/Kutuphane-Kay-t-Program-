using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kütüphane_Projesi
{
    public partial class kayıt_ol : Form
    {
        public kayıt_ol()
        {
            InitializeComponent();
        }
        OleDbConnection bağlanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source="+Application.StartupPath+"\\vt.accdb");
        DataTable tablo = new DataTable();

        public void güncelle()
        {

            bağlanti.Open();
            tablo.Clear();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * From Kutuphane",bağlanti);
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adap.Dispose();
            bağlanti.Close();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            bağlanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO Kutuphane(isim,soyisim,yas,telnumarası) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            komut.Dispose();
            bağlanti.Close();
            güncelle();

        }

        private void kayıt_ol_Load(object sender, EventArgs e)
        {
            güncelle();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            OleDbCommand komut = new OleDbCommand("Delete From  Kutuphane Where Kimlik=" + Convert.ToInt16(textBox5.Text), bağlanti);
            komut.ExecuteNonQuery();
            komut.Dispose();
            bağlanti.Close();
            güncelle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Kutuphane SET isim='" + textBox1.Text+ "',soyisim='" + textBox2.Text + "',yas='" + textBox3.Text+ "',telnumarası='" + textBox4.Text + "' WHERE Kimlik=" + Convert.ToInt16(textBox5.Text),bağlanti);
            komut.ExecuteNonQuery();
            komut.Dispose();
            bağlanti.Close();
            güncelle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            tablo.Clear();
            OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Kutuphane Where Kimlik="+Convert.ToInt16(textBox5.Text),bağlanti);
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adap.Dispose();
            bağlanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silmek istediğiniz kişinin kimlik No'sunu 'Kimlik' kısmına girmeniz ve sile basmanız yeterlidir.");




        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bulmak istediğiniz kişinin kimlik No'sunu 'Kimlik' kısmına girmeniz ve Bula basmanız yeterlidir.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgilerini güncellemek istediğiniz kişinin biligilerinini yeniden girdikten sonra 'kimlik' Nosunu Kimlik kısnmınna girip güncelle butonuna basmanız yeterlidir");
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }
    }
}
