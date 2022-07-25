using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void kayıtOlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayıt_ol frm = new kayıt_ol();
            frm.Show();
        }

        private void kitapBağışlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayıt_ol frm = new kayıt_ol();
            frm.Show();
        }
    }
}
