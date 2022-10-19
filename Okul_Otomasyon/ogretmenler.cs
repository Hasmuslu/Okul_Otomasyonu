using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Okul_Otomasyon
{
    public partial class ogretmenler : Form
    {
        public ogretmenler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_ogretmenler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void ogretmenler_Load(object sender, EventArgs e)
        {
            listele();
            ilekle();
            bransekle();
            temizle();

        }
        void ilekle()
        {
            SqlCommand komut = new SqlCommand("select* from iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[1]);

            }
            bgl.baglanti().Close();

        }
        void bransekle()
        {
            SqlCommand komut = new SqlCommand("select* from tbl_brans", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbbrans.Properties.Items.Add(dr[1]);

            }
            bgl.baglanti().Close();

        }
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            msktc.Text = "";
            msktel.Text = "";
            txtmail.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            rchadres.Text = "";
            cmbbrans.Text = "";
            pictureBox1.ImageLocation= "";
        }
        private void cmbilce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select* from ilceler where sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[1]);

            }
            bgl.baglanti().Close();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_ogretmenler (ad,soyad,tc,tel,mail,il,ilce,adres,brans,foto)values(@ad,@soyad,@tc,@tel,@mail,@il,@ilce,@adres,@brans,@foto)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@tc", msktc.Text);
            komut.Parameters.AddWithValue("@tel", msktel.Text);
            komut.Parameters.AddWithValue("@mail", txtmail.Text);
            komut.Parameters.AddWithValue("@il", cmbil.Text);
            komut.Parameters.AddWithValue("@ilce", cmbilce.Text);
            komut.Parameters.AddWithValue("@adres", rchadres.Text);
            komut.Parameters.AddWithValue("@brans", cmbbrans.Text);
            komut.Parameters.AddWithValue("@foto", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("EKLENDİ");
            listele();
            temizle();

        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["id"].ToString();
                txtad.Text = dr["ad"].ToString();
                txtsoyad.Text = dr["soyad"].ToString();
                msktc.Text = dr["tc"].ToString();
                msktel.Text = dr["tel"].ToString();
                txtmail.Text = dr["mail"].ToString();
                cmbil.Text = dr["il"].ToString();
                cmbilce.Text = dr["ilce"].ToString();
                rchadres.Text = dr["adres"].ToString();
                cmbbrans.Text = dr["brans"].ToString();
                yeniyol = "C:\\Users\\CASPER\\Documents\\Visual Studio 2015\\Projects\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["foto"].ToString();
                pictureBox1.ImageLocation = yeniyol;
            }
        }

        public string yeniyol;
        private void btnresim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası | *.jpg;*png;*nef | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\CASPER\\Documents\\Visual Studio 2015\\Projects\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pictureBox1.ImageLocation = yeniyol;

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  tbl_ogretmenler set ad=@ad,soyad=@soyad,tc=@tc,tel=@tel,mail=@mail,il=@il,ilce=@ilce,adres=@adres,brans=@brans,foto=@foto where id=@id", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@tc", msktc.Text);
            komut.Parameters.AddWithValue("@tel", msktel.Text);
            komut.Parameters.AddWithValue("@mail", txtmail.Text);
            komut.Parameters.AddWithValue("@il", cmbil.Text);
            komut.Parameters.AddWithValue("@ilce", cmbilce.Text);
            komut.Parameters.AddWithValue("@adres", rchadres.Text);
            komut.Parameters.AddWithValue("@brans", cmbbrans.Text);
            komut.Parameters.AddWithValue("@foto", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncellendi");
            listele();
            temizle();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_ogretmenler where id=@id", bgl.baglanti());
            komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("SİlİNDİ");
            listele();

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
