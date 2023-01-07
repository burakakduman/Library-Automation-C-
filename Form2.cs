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
    public partial class Form2 : Form
    {
        public Form2()
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
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From kitapbil", baglan);
            adtr.Fill(dtstt, "kitapbil");
            AraBarkoddataGridView2.DataSource = dtstt.Tables["kitapbil"];
            adabte.Dispose();
            baglan.Close();
           
            int kayıtsayisi2 = AraBarkoddataGridView2.RowCount-1;
            
            label13.Text = kayıtsayisi2.ToString();
            AraBarkoddataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        
        }
        
        


        public void listele2()
        {
            baglan.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From okuyucubil", baglan);
            adtr.Fill(dtstt, "okuyucubil");
            AraOkuldataGridView1.DataSource = dtstt.Tables["okuyucubil"];
            adabte.Dispose();
            baglan.Close();
            int kayıtsayisi1 = AraOkuldataGridView1.RowCount;
            label11.Text = kayıtsayisi1.ToString();
            AraOkuldataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btCikis_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Form1 frm1 = new Form1();
            frm1.Visible = true;
            this.Close();
        }

        private void btYenile1_Click(object sender, EventArgs e)
        {
            
            listele2();

            
        }

        private void btUye_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void btKitap_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void btUyelik_Click_1(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void btYenile2_Click(object sender, EventArgs e)
        {

            listele();

        }

        private void btOkulNoAra_Click(object sender, EventArgs e)
        {
            adabte = new OleDbDataAdapter("Select * from okuyucubil where Oto_ID Like '" + tbOkulNoAra.Text + "%'", baglan);
            dtstt = new DataSet();
            baglan.Open();
            adabte.Fill(dtstt, "okuyucubil");
            baglan.Close();
            AraOkuldataGridView1.DataSource = dtstt.Tables["okuyucubil"];
        }

        private void btBarkodNoAra_Click(object sender, EventArgs e)
        {
            adabte = new OleDbDataAdapter("Select * from kitapbil where Oto_ID Like '" + tbBarkodNoAra.Text + "%'", baglan);
            dtstt = new DataSet();
            baglan.Open();
            adabte.Fill(dtstt, "kitapbil");
            baglan.Close();
            AraBarkoddataGridView2.DataSource = dtstt.Tables["kitapbil"];
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void AraOkuldataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDBDataSet1.kitapbil' table. You can move, or remove it, as needed.
            this.kitapbilTableAdapter.Fill(this.kutuphaneDBDataSet1.kitapbil);
            AraBarkoddataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            int kayıtsayisi2 = AraBarkoddataGridView2.RowCount - 1;
            label13.Text = kayıtsayisi2.ToString();
            // TODO: This line of code loads data into the 'kutuphaneDBDataSet.okuyucubil' table. You can move, or remove it, as needed.
            this.okuyucubilTableAdapter.Fill(this.kutuphaneDBDataSet.okuyucubil);
            AraOkuldataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            int kayıtsayisi1 = AraOkuldataGridView1.RowCount;
            label11.Text = kayıtsayisi1.ToString();
        }

        private void btEmanet_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }
    }
}
