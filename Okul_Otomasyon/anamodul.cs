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
    public partial class anamodul : Form
    {
        public anamodul()
        {
            InitializeComponent();
        }
        ogretmenler frm;
        ogrenciler frm1;
        Velile veli;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new ogretmenler();
                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm.IsDisposed)
            {
                 frm1 = new ogrenciler();
                 frm1.MdiParent = this;
                 frm1.Show();
            }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (veli == null || veli.IsDisposed)
            {
                veli = new Velile();
                veli.MdiParent = this;
                veli.Show();
            }

        }
    }
}

