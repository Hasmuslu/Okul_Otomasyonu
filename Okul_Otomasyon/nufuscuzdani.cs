using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_Otomasyon
{
    public partial class nufuscuzdani : Form
    {
        public nufuscuzdani()
        {
            InitializeComponent();
        }
        public string ad, soyad, tc, cinsiyet, dogtarihi, uzanti;

        private void nufuscuzdani_Load(object sender, EventArgs e)
        {
            lblad.Text = ad;
            lblsoyad.Text = soyad;
            lbltc.Text = tc;
            lblcinsiyet.Text = cinsiyet;
            lbldt.Text = dogtarihi;
            pictureEdit1.Image = Image.FromFile(uzanti);
        }
    }
}
