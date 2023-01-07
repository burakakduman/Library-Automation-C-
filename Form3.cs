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
    public partial class Form3 : Form
    {
        public Form3()
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
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From okuyucubil", baglan);
            adtr.Fill(dtstt, "okuyucubil");

            okuyucu_dataGridView1.DataSource = dtstt.Tables["okuyucubil"];
            adabte.Dispose();
            
            baglan.Close();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            //listele();
            //okuyucu_dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btKaydetOkuyucu_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "INSERT INTO okuyucubil(TC_No,Adi_Syd,Sinifi,Okulno,Dogm_Yeri,Dogm_Trh,Cnsyt,Adres,Cep_Tel,E_Posta,Uyelik_Tar) VALUES ('" + tbTCOkuyucu.Text + "','" + tbAdOkuyucu.Text + "','" + tbSinifOkuyucu.Text + "','" + tbNoOkuyucu.Text + "','" + tbDogumYeriOkuyucu.Text + "','" + tbDogumTarihiOkuyucu.Text + "','" + tbCinsiyetOkuyucu.Text + "','" + tbAdresOkuyucu.Text + "','" + tbTelefonOkuyucu.Text  + "','" + tbEpostaOkuyucu.Text + "','" + tbUyelikTarihiOkuyucu.Text + "')";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            //dtstt.Tables["okuyucubil"].Clear();
            listele();
            MessageBox.Show("Kayıt işlemi tamamlandı ! ");
        }
        private void btSilOkuyucu_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "DELETE from okuyucubil WHERE Oto_ID=" + tbDuzenlenecekIDOkuyucu.Text + "";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            MessageBox.Show("Silme işlemi tamamlandı.");
            //dtstt.Tables["okuyucubil"].Clear();
            listele();
        }

        private void btGuncelleOkuyucu_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;

            komut.CommandText = "UPDATE okuyucubil SET TC_No='" + tbTCOkuyucu.Text + "',Adi_Syd='" + tbAdOkuyucu.Text + "',Sinifi='" + tbSinifOkuyucu.Text + "',Okulno='" + tbNoOkuyucu.Text + "',Dogm_Yeri='" + tbDogumYeriOkuyucu.Text + "',Dogm_Trh='" + tbDogumTarihiOkuyucu.Text + "',Cnsyt='" + tbCinsiyetOkuyucu.Text + "',Adres='" + tbAdresOkuyucu.Text + "',Cep_Tel='" + tbTelefonOkuyucu.Text + "',E_Posta='" + tbEpostaOkuyucu.Text + "',Uyelik_Tar='" + tbUyelikTarihiOkuyucu.Text + "'WHERE Oto_ID=" + tbDuzenlenecekIDOkuyucu.Text + "";                  


            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            MessageBox.Show("Bilgiler Güncellendi.");

            //dtstt.Tables["okuyucubil"].Clear();
            listele();
        }
       
        private void btTemizleOkuyucu_Click(object sender, EventArgs e)
        {
            tbAdOkuyucu.Text = "";
            tbAdresOkuyucu.Text = "";
            tbNoOkuyucu.Text = "";
            tbTelefonOkuyucu.Text = "";
            tbCinsiyetOkuyucu.Text = "";
            tbDogumYeriOkuyucu.Text = "";
            tbDogumTarihiOkuyucu.Text = "";
            tbDuzenlenecekIDOkuyucu.Text = "";
            tbEpostaOkuyucu.Text = "";
            tbSinifOkuyucu.Text = "";
            tbTCOkuyucu.Text = "";
            tbUyelikTarihiOkuyucu.Text = "";
        }

        private void YenileOkuyucu_Click(object sender, EventArgs e)
        {
            dtstt.Tables["okuyucubil"].Clear();
            listele();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDBDataSet.okuyucubil' table. You can move, or remove it, as needed.
            this.okuyucubilTableAdapter.Fill(this.kutuphaneDBDataSet.okuyucubil);

        }
    }
}
