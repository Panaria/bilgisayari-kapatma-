using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgisayarı_kapatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sor;
            sor = MessageBox.Show("Bilgisayar Kapatılsın mı?" , "Uyarı" , MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (sor == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-s");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sor;
            sor = MessageBox.Show("Bilgisayar Yeniden Başlatılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sor == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-r");
            }
        }
    }
}
