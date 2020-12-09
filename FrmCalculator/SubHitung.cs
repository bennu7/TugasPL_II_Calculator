using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCalculator
{
    public partial class SubHitung : Form
    {
        

        public SubHitung()
        {
            InitializeComponent();
            cmbxList.SelectedIndex = 0;//memulai dari penambahan
        }

        //mendeklarasikan tipe dari event
        public delegate void ProsesEventHandler(string operasi, string jnisOperasi, int a, int b, int hasil);

        //membuat event dengan tipe data ProsesEventHandler
        public event ProsesEventHandler OnProses;

        private void btnProses_Click(object sender, EventArgs e)
        {
            
            string jnisOperasi = string.Empty; //dari combobox
            string cbxLower = cmbxList.Text.ToLower();
            //string jnisOperasi = " ";
            int hasil = 0;
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            switch (cmbxList.SelectedIndex)
            {
                case 0:
                    hasil = a + b;
                    jnisOperasi = "+";
                    break;
                case 1:
                    hasil = a - b;
                    jnisOperasi = "-";
                    break;
                case 2:
                    hasil = a * b;
                    jnisOperasi = "*";
                    break;
                case 3:
                    hasil = a / b;
                    jnisOperasi = "/";
                    break;

            }
            OnProses(cbxLower, jnisOperasi, a, b, hasil);
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
