using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Kutuphane_Takip_Programi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public OleDbConnection baglan = new OleDbConnection("Provider=MICROSOFT.JET.OLEDB.4.0;Data Source=KutuphaneDB.mdb");
        public OleDbCommand komut = new OleDbCommand();
        public OleDbDataAdapter adabte = new OleDbDataAdapter();
        public DataSet dtstt = new DataSet();
        public void listele()
        {
            baglan.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kitapbil", baglan);
            adtr.Fill(dtstt, "kitapbil");
            kitap_dataGridView1.DataSource = dtstt.Tables["kitapbil"];
            adabte.Dispose();
            baglan.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            listele();
            //label12 .Text = "Şuanda " + (kitap_dataGridView1.Rows.Count - 1).ToString() + " Adet Kitap Bulunmaktadır.";
            OleDbDataAdapter a = new OleDbDataAdapter("select * from kitapbil", baglan);
            DataSet ds = new DataSet();
            a.Fill(ds, "d");
            kitap_dataGridView1.DataSource = ds.Tables["d"];
            kitap_dataGridView1.Columns[0].Visible = false;
            kitap_dataGridView1.Columns[1].Visible = false;
        }

        private void btKaydetKitap_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "INSERT INTO kitapbil(Barkod_No,Kitap_Adi,Yayinevi,Yazar,Stok_Sayisi,Kategorisi,Basim_Tarihi,Sayfa_Say) VALUES ('" + tbBarkodNoKitap.Text + "','" + tbKitapAdiKitap.Text + "','" + tbYayinEviKitap.Text + "','" + tbYazarAdiKitap.Text + "','" + tbStokSayisiKitap.Text + "','" + tbKitapTuruKitap.Text + "','" + tbBasimTarihiKitap.Text + "','" + tbSayfaSayisiKitap.Text + "')";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            //dtstt.Tables["kitapbil"].Clear();
            listele();
            MessageBox.Show("Kayıt işlemi tamamlandı ! ");
        }

        private void btGuncelleKitap_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "UPDATE kitapbil SET Barkod_No='" + tbBarkodNoKitap.Text + "',Kitap_Adi='" + tbKitapAdiKitap.Text + "',Yayinevi='" + tbYayinEviKitap.Text + "',Yazar='" + tbYazarAdiKitap.Text + "',Stok_Sayisi='" + tbStokSayisiKitap.Text + "',Kategorisi='" + tbKitapTuruKitap.Text + "',Basim_Tarihi='" + tbBasimTarihiKitap.Text + "',Sayfa_Say='" + tbSayfaSayisiKitap.Text + "' WHERE Oto_ID=" + tbIDKitap.Text + ""; 
            
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            MessageBox.Show("Bilgiler Güncellendi.");
            dtstt.Tables["kitapbil"].Clear();
            listele();
        }
       
        private void btTemizleKitap_Click(object sender, EventArgs e)
        {
            tbBarkodNoKitap.Text = "";
            tbBasimTarihiKitap.Text = "";
            tbIDKitap.Text = "";
            tbKitapAdiKitap.Text = "";
            tbKitapTuruKitap.Text = "";
            tbSayfaSayisiKitap.Text = "";
            tbStokSayisiKitap.Text = "";
            tbYayinEviKitap.Text = "";
            tbYazarAdiKitap.Text = "";
        }

        private void btSilKitap_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "DELETE from kitapbil WHERE Oto_ID=" + tbIDKitap.Text + "";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            MessageBox.Show("Silme işlemi tamamlandı.");
            dtstt.Tables["kitapbil"].Clear();
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDBDataSet2.kitapbil' table. You can move, or remove it, as needed.
            this.kitapbilTableAdapter.Fill(this.kutuphaneDBDataSet2.kitapbil);

        }
    }
}
