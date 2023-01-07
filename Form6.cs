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
    public partial class Form6 : Form
    {
        public Form6()
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
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From emanetbil", baglan);
            adtr.Fill(dtstt, "emanetbil");

            dataGridView1.DataSource = dtstt.Tables["emanetbil"];
            adabte.Dispose();

            baglan.Close();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDBDataSet6.emanetbil' table. You can move, or remove it, as needed.
            this.emanetbilTableAdapter2.Fill(this.kutuphaneDBDataSet6.emanetbil);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "INSERT INTO emanetbil(Okuyucu_ID,Kitap_ID,Veriliş_Tarihi,İade_Tarihi) VALUES ('" + tbOkuyucuID.Text + "','" + tbKitapID.Text + "','" + tbVerilisTarihi.Text + "','" + tbIadeTarihi.Text + "')";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            //dtstt.Tables["emanetbil"].Clear();
            listele();
            MessageBox.Show("Kayıt işlemi tamamlandı ! ");

        }

        private void btYenileEmanet_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btGuncelleEmanet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "UPDATE emanetbil SET Okuyucu_ID='" + tbOkuyucuID.Text + "',Kitap_ID='" + tbKitapID.Text + "',Veriliş_Tarihi='" + tbVerilisTarihi.Text + "',İade_Tarihi='" + tbIadeTarihi.Text +  "' WHERE Oto_ID=" +tbEmanetID.Text.ToString() + "";

            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            MessageBox.Show("Bilgiler Güncellendi.");
            //dtstt.Tables["kitapbil"].Clear();
            listele();
        }

        private void btSilEmanet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "DELETE from emanetbil WHERE Oto_ID=" + tbEmanetID.Text + "";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            MessageBox.Show("Silme işlemi tamamlandı.");
            //dtstt.Tables["kitapbil"].Clear();
            listele();
        }

        private void btTemizleEmanet_Click(object sender, EventArgs e)
        {
            tbEmanetID.Text = "";
            tbIadeTarihi.Text = "";
            tbKitapID.Text = "";
            tbOkuyucuID.Text = "";
            tbVerilisTarihi.Text="";
        }
    }
}
