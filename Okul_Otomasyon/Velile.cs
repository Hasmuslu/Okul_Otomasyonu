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
    public partial class Velile : Form
    {
        public Velile()
        {
            InitializeComponent();
        }
        DbOkulEntities db = new DbOkulEntities();
        
        void listele()
        {
            var query = from item in db.veliler
                        select new { item.id, item.anne, item.baba, item.tel1, item.tel2, item.mail };

            gridControl1.DataSource = query.ToList();
        }
        private void Velile_Load(object sender, EventArgs e)
        {
            listele();
            temizle();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            veliler veli = new veliler();
            veli.anne = txtanne.Text;
            veli.baba = txtbaba.Text;
            veli.tel1 = msktel1.Text;
            veli.tel2 = msktel2.Text;
            veli.mail = txtmail.Text;
            db.veliler.Add(veli);
            db.SaveChanges();
            listele();
            temizle();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            txtid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id").ToString();
            txtanne.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "anne").ToString();
            txtbaba.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "baba").ToString();
            msktel1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "tel1").ToString();
            msktel2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "tel2").ToString();
            txtmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mail").ToString();
            
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id").ToString());
            //var item = db.veliler.Find(id);
            //item.anne = txtanne.Text;
            //item.baba = txtbaba.Text;
            //item.tel1 = msktel1.Text;
            //item.tel2 = msktel2.Text;
            //item.mail = txtmail.Text;
            //db.SaveChanges();
            //listele();
            //temizle();
            using (DbOkulEntities db = new DbOkulEntities())
            {
                var item = db.veliler.FirstOrDefault(x => x.id == id);
                item.anne = txtanne.Text;
                item.baba = txtbaba.Text;
                item.tel1 = msktel1.Text;
                item.tel2 = msktel2.Text;
                item.mail = txtmail.Text;
                db.SaveChanges();
                listele();
                temizle();
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id").ToString());
            //var item = db.veliler.Find(id);
            //db.veliler.Remove(item);
            //db.SaveChanges();
            //listele();
            //temizle();

            using (DbOkulEntities db = new DbOkulEntities())
            {
                var item = db.veliler.First(x=>x.id == id);
                db.veliler.Remove(item);
                db.veliler.Remove(item);
                db.SaveChanges();
                listele();
                temizle();
            }
        }
        void temizle()
        {
            txtid.Text = "";
            txtanne.Text = "";
            txtbaba.Text = "";
            msktel1.Text = "";
            msktel2.Text = "";
            txtmail.Text = "";
        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
