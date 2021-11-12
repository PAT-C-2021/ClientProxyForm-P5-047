using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxyForm_P5_20190140047
{
    public partial class Form1 : Form
    {
        ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHasil_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textBox1.Text);
            int angka2 = Convert.ToInt32(textBox2.Text);

            double hTambah = obj.Tambah(angka1, angka2);
            double hKurang = obj.Kurang(angka1, angka2);
            double hKali = obj.Kali(angka1, angka2);
            double hBagi = obj.Bagi(angka1, angka2);

            labelPenjumlahan.Text = hTambah.ToString();
            labelPengurangan.Text = hKurang.ToString();
            labelPerkalian.Text = hKali.ToString();
            labelPembagian.Text = hBagi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
