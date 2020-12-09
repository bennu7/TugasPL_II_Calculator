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
    public partial class SuperHasil : Form
    {
        public SuperHasil()
        {
            InitializeComponent();
            
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            //membuat objek dari form anak / sub class
            SubHitung frmHitung = new SubHitung();
            //update berlangganan(subscribe) dengan menambahkan event dari form anak dan +=
            frmHitung.OnProses += new SubHitung.ProsesEventHandler(OnMenhgitungCalculatorHandler);
            frmHitung.ShowDialog();
        }


        //mendaftarkan Event Handler (subscribe)
        private void OnMenhgitungCalculatorHandler(string operasi, string jnisOperasi, int a, int b, int hasil) {
            lsbxHasil.Items.Add(string.Format("Hasil dari {0} {1} {2} {3} = {4}", operasi, a, jnisOperasi, b, hasil));
        }
            

    }
}
