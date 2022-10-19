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
    public partial class ogrenciler : Form
    {
        public ogrenciler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Execute ogrenci5",bgl.baglanti());
            da1.Fill(dt1);
            grd5.DataSource = dt1;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute ogrenci6", bgl.baglanti());
            da2.Fill(dt2);
            grd6.DataSource = dt2;

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Execute ogrenci7", bgl.baglanti());
            da3.Fill(dt3);
            grd7.DataSource = dt3;


            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Execute ogrenci8", bgl.baglanti());
            da4.Fill(dt4);
            grd8.DataSource = dt4;
        }
        void sehirekle()
        {
            SqlCommand komut = new SqlCommand("select * from iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        private void ogrenciler_Load(object sender, EventArgs e)
        {
            listele();
            sehirekle();
            temizle();           
            velilistesi();
        }

        
        void velilistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id,(anne+ '|' +baba)as 'annebaba' from veliler ",bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "id";
            lookUpEdit1.Properties.DisplayMember = "annebaba";
            lookUpEdit1.Properties.DataSource = dt;

        }
        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            cmbilce.Text = "";
            SqlCommand komut = new SqlCommand("select * from ilceler where sehir=@sehir", bgl.baglanti());
            komut.Parameters.AddWithValue("@sehir", cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            msktc.Text = "";
            mskogno.Text = "";
            dateEdit1.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            rchadres.Text = "";
            cmbsinif.Text = "";
            radioerkek.Checked = false;
            radiokadın.Checked = false;
            pictureEdit1.Text = "";

        }
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                txtid.Text = dr["id"].ToString();
                txtad.Text = dr["ad"].ToString();
                txtsoyad.Text = dr["soyad"].ToString();
                msktc.Text = dr["tc"].ToString();
                mskogno.Text = dr["no"].ToString();
                cmbsinif.Text = dr["sinif"].ToString();
                lookUpEdit1.Text = dr["annebaba"].ToString();
                txtid.Text = dr["id"].ToString();
                if (dr["cinsiyet"].ToString()=="E")
                {
                    radioerkek.Checked = true;
                }
                else
                {
                    radiokadın.Checked = true;
                }
                cmbil.Text = dr["il"].ToString();
                cmbilce.Text = dr["ilce"].ToString();
                dateEdit1.Text = dr["dotar"].ToString();
                rchadres.Text = dr["adres"].ToString();
                yeniyol = "C:\\Users\\CASPER\\Documents\\Visual Studio 2015\\Projects\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["foto"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
        }

       

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["id"].ToString();
                txtad.Text = dr["ad"].ToString();
                txtsoyad.Text = dr["soyad"].ToString();
                msktc.Text = dr["tc"].ToString();
                mskogno.Text = dr["no"].ToString();
                cmbsinif.Text = dr["sinif"].ToString();
                txtid.Text = dr["id"].ToString();
                lookUpEdit1.Text = dr["annebaba"].ToString();
                txtid.Text = dr["id"].ToString();
                if (dr["cinsiyet"].ToString() == "E")
                {
                    radioerkek.Checked = true;
                }
                else
                {
                    radiokadın.Checked = true;
                }
                cmbil.Text = dr["il"].ToString();
                cmbilce.Text = dr["ilce"].ToString();
                dateEdit1.Text = dr["dotar"].ToString();
                rchadres.Text = dr["adres"].ToString();
                yeniyol = "C:\\Users\\CASPER\\Documents\\Visual Studio 2015\\Projects\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["foto"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["id"].ToString();
                txtad.Text = dr["ad"].ToString();
                txtsoyad.Text = dr["soyad"].ToString();
                msktc.Text = dr["tc"].ToString();
                mskogno.Text = dr["no"].ToString();
                cmbsinif.Text = dr["sinif"].ToString();
                txtid.Text = dr["id"].ToString();
                lookUpEdit1.Text = dr["annebaba"].ToString();
                txtid.Text = dr["id"].ToString();
                if (dr["cinsiyet"].ToString() == "E")
                {
                    radioerkek.Checked = true;
                }
                else
                {
                    radiokadın.Checked = true;
                }
                cmbil.Text = dr["il"].ToString();
                cmbilce.Text = dr["ilce"].ToString();
                dateEdit1.Text = dr["dotar"].ToString();
                rchadres.Text = dr["adres"].ToString();
                yeniyol = "C:\\Users\\CASPER\\Documents\\Visual Studio 2015\\Projects\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["foto"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView4.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["id"].ToString();
                txtad.Text = dr["ad"].ToString();
                txtsoyad.Text = dr["soyad"].ToString();
                msktc.Text = dr["tc"].ToString();
                mskogno.Text = dr["no"].ToString();
                cmbsinif.Text = dr["sinif"].ToString();
                txtid.Text = dr["id"].ToString();
                txtid.Text = dr["id"].ToString();
                lookUpEdit1.Text = dr["annebaba"].ToString();
                if (dr["cinsiyet"].ToString() == "E")
                {
                    radioerkek.Checked = true;
                }
                else
                {
                    radiokadın.Checked = true;
                }
                cmbil.Text = dr["il"].ToString();
                cmbilce.Text = dr["ilce"].ToString();
                dateEdit1.Text = dr["dotar"].ToString();
                rchadres.Text = dr["adres"].ToString();
                yeniyol = "C:\\Users\\CASPER\\Documents\\Visual Studio 2015\\Projects\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["foto"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
        }
        public string cinsiyet;
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_ogrenciler (ad,no,sinif,dotar,cinsiyet,soyad,tc,il,ilce,adres,foto,veliid)values(@ad,@no,@sinif,@dotar,@cinsiyet,@soyad,@tc,@il,@ilce,@adres,@foto,@veliid)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@tc", msktc.Text);
            komut.Parameters.AddWithValue("@no", mskogno.Text);
            komut.Parameters.AddWithValue("@dotar", dateEdit1.Text);
            komut.Parameters.AddWithValue("@il", cmbil.Text);
            if (radioerkek.Checked==true)
            {
                komut.Parameters.AddWithValue("@cinsiyet", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@cinsiyet", cinsiyet = "K");
            }
            komut.Parameters.AddWithValue("@ilce", cmbilce.Text);
            komut.Parameters.AddWithValue("@adres", rchadres.Text);
            komut.Parameters.AddWithValue("@sinif", cmbsinif.Text);
            komut.Parameters.AddWithValue("@veliid", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@foto", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("EKLENDİ");
            listele();
            temizle();  
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
            pictureEdit1.Image =Image.FromFile(yeniyol);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
                SqlCommand komut = new SqlCommand("update  tbl_ogrenciler set ad=@ad,soyad=@soyad,tc=@tc,no=@no,dotar=@dotar,il=@il,ilce=@ilce,adres=@adres,cinsiyet=@cinsiyet,foto=@foto,veliid=@veliid where id=@id", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@tc", msktc.Text);
            komut.Parameters.AddWithValue("@no", mskogno.Text);
            komut.Parameters.AddWithValue("@dotar", dateEdit1.Text);
            komut.Parameters.AddWithValue("@il", cmbil.Text);
            if (radioerkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@cinsiyet", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@cinsiyet", cinsiyet = "K");
            }
            komut.Parameters.AddWithValue("@ilce", cmbilce.Text);
            komut.Parameters.AddWithValue("@adres", rchadres.Text);
            komut.Parameters.AddWithValue("@sinif", cmbsinif.Text);
            komut.Parameters.AddWithValue("@foto", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.Parameters.AddWithValue("@veliid", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("GÜncellendi");
            listele();
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_ogrenciler where id=@id", bgl.baglanti());
            komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("SİlİNDİ");
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            nufuscuzdani frm = new nufuscuzdani();
            if (dr!=null)
            {
                frm.ad = dr["ad"].ToString();
                frm.soyad = dr["soyad"].ToString();
                frm.tc = dr["tc"].ToString();
                frm.cinsiyet = dr["cinsiyet"].ToString();
                frm.dogtarihi = dr["dotar"].ToString();
                frm.uzanti= "C:\\Users\\CASPER\\Documents\\Visual Studio 2015\\Projects\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["foto"].ToString();

            }
            frm.Show();
        }
    }
}
