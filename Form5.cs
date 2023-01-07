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

namespace Kutuphane_Takip_Programi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public OleDbConnection baglan = new OleDbConnection("Provider=MICROSOFT.JET.OLEDB.4.0;Data Source=KutuphaneDB.mdb");
        public OleDbCommand komut = new OleDbCommand();
        public OleDbDataAdapter adabte = new OleDbDataAdapter();
        public DataSet dtstt = new DataSet();
        public void listele()
        {
            baglan.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kullanici", baglan);
            adtr.Fill(dtstt, "kullanici");
            SifredataGridView1.DataSource = dtstt.Tables["kullanici"];
            adabte.Dispose();
            baglan.Close();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            
           /* listele();*/
        }
        private void btKaydetSifre_Click_1(object sender, EventArgs e)
        {

            
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "UPDATE kullanici SET k_adi='" + tbIDSifre.Text + "',k_sifre='" + tbYeniSifreSifre.Text + "' WHERE k_adi='" + tbIDSifre.Text.ToString() + "'"; ;

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglan.Close();
            //dtstt.Tables["üyebil"].Clear();
            listele();
                MessageBox.Show("Şifreniz Degiştirilmiştir Program Yeniden Başlatılıyor...");
                Application.Restart(); ;
            
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDBDataSet7.kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter1.Fill(this.kutuphaneDBDataSet7.kullanici);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "INSERT INTO kullanici(k_adi,k_sifre) VALUES ('" + tbIDSifre.Text + "','" + tbYeniSifreSifre.Text +  "')";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            listele();
            MessageBox.Show("Yeni Üye Eklendi ! ");
            MessageBox.Show("Program Yeniden Başlatılacak.");
            Application.Restart(); ;
        }
    }
}
