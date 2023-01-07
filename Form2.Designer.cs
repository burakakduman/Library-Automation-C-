namespace Kutuphane_Takip_Programi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AraOkuldataGridView1 = new System.Windows.Forms.DataGridView();
            this.otoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiSydDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okulnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogmYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogmTrhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnsytDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyelikTarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okuyucubilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDBDataSet = new Kutuphane_Takip_Programi.KutuphaneDBDataSet();
            this.AraBarkoddataGridView2 = new System.Windows.Forms.DataGridView();
            this.otoIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapbilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDBDataSet1 = new Kutuphane_Takip_Programi.KutuphaneDBDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOkulNoAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBarkodNoAra = new System.Windows.Forms.TextBox();
            this.btYenile1 = new System.Windows.Forms.Button();
            this.btYenile2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btUye = new System.Windows.Forms.Button();
            this.btKitap = new System.Windows.Forms.Button();
            this.btCikis = new System.Windows.Forms.Button();
            this.btUyelik = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btOkulNoAra = new System.Windows.Forms.Button();
            this.btBarkodNoAra = new System.Windows.Forms.Button();
            this.okuyucubilTableAdapter = new Kutuphane_Takip_Programi.KutuphaneDBDataSetTableAdapters.okuyucubilTableAdapter();
            this.kitapbilTableAdapter = new Kutuphane_Takip_Programi.KutuphaneDBDataSet1TableAdapters.kitapbilTableAdapter();
            this.btEmanet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AraOkuldataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okuyucubilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AraBarkoddataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapbilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // AraOkuldataGridView1
            // 
            this.AraOkuldataGridView1.AllowUserToAddRows = false;
            this.AraOkuldataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AraOkuldataGridView1.AutoGenerateColumns = false;
            this.AraOkuldataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AraOkuldataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.otoIDDataGridViewTextBoxColumn,
            this.tcNoDataGridViewTextBoxColumn,
            this.adiSydDataGridViewTextBoxColumn,
            this.sinifiDataGridViewTextBoxColumn,
            this.okulnoDataGridViewTextBoxColumn,
            this.dogmYeriDataGridViewTextBoxColumn,
            this.dogmTrhDataGridViewTextBoxColumn,
            this.cnsytDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.cepTelDataGridViewTextBoxColumn,
            this.ePostaDataGridViewTextBoxColumn,
            this.uyelikTarDataGridViewTextBoxColumn});
            this.AraOkuldataGridView1.DataSource = this.okuyucubilBindingSource;
            this.AraOkuldataGridView1.Location = new System.Drawing.Point(20, 114);
            this.AraOkuldataGridView1.Name = "AraOkuldataGridView1";
            this.AraOkuldataGridView1.Size = new System.Drawing.Size(495, 263);
            this.AraOkuldataGridView1.TabIndex = 4;
            this.AraOkuldataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AraOkuldataGridView1_CellClick);
            // 
            // otoIDDataGridViewTextBoxColumn
            // 
            this.otoIDDataGridViewTextBoxColumn.DataPropertyName = "Oto_ID";
            this.otoIDDataGridViewTextBoxColumn.HeaderText = "Oto_ID";
            this.otoIDDataGridViewTextBoxColumn.Name = "otoIDDataGridViewTextBoxColumn";
            // 
            // tcNoDataGridViewTextBoxColumn
            // 
            this.tcNoDataGridViewTextBoxColumn.DataPropertyName = "Tc_No";
            this.tcNoDataGridViewTextBoxColumn.HeaderText = "Tc_No";
            this.tcNoDataGridViewTextBoxColumn.Name = "tcNoDataGridViewTextBoxColumn";
            // 
            // adiSydDataGridViewTextBoxColumn
            // 
            this.adiSydDataGridViewTextBoxColumn.DataPropertyName = "Adi_Syd";
            this.adiSydDataGridViewTextBoxColumn.HeaderText = "Adi_Syd";
            this.adiSydDataGridViewTextBoxColumn.Name = "adiSydDataGridViewTextBoxColumn";
            // 
            // sinifiDataGridViewTextBoxColumn
            // 
            this.sinifiDataGridViewTextBoxColumn.DataPropertyName = "Sinifi";
            this.sinifiDataGridViewTextBoxColumn.HeaderText = "Sinifi";
            this.sinifiDataGridViewTextBoxColumn.Name = "sinifiDataGridViewTextBoxColumn";
            // 
            // okulnoDataGridViewTextBoxColumn
            // 
            this.okulnoDataGridViewTextBoxColumn.DataPropertyName = "Okulno";
            this.okulnoDataGridViewTextBoxColumn.HeaderText = "Okulno";
            this.okulnoDataGridViewTextBoxColumn.Name = "okulnoDataGridViewTextBoxColumn";
            // 
            // dogmYeriDataGridViewTextBoxColumn
            // 
            this.dogmYeriDataGridViewTextBoxColumn.DataPropertyName = "Dogm_Yeri";
            this.dogmYeriDataGridViewTextBoxColumn.HeaderText = "Dogm_Yeri";
            this.dogmYeriDataGridViewTextBoxColumn.Name = "dogmYeriDataGridViewTextBoxColumn";
            // 
            // dogmTrhDataGridViewTextBoxColumn
            // 
            this.dogmTrhDataGridViewTextBoxColumn.DataPropertyName = "Dogm_Trh";
            this.dogmTrhDataGridViewTextBoxColumn.HeaderText = "Dogm_Trh";
            this.dogmTrhDataGridViewTextBoxColumn.Name = "dogmTrhDataGridViewTextBoxColumn";
            // 
            // cnsytDataGridViewTextBoxColumn
            // 
            this.cnsytDataGridViewTextBoxColumn.DataPropertyName = "Cnsyt";
            this.cnsytDataGridViewTextBoxColumn.HeaderText = "Cnsyt";
            this.cnsytDataGridViewTextBoxColumn.Name = "cnsytDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // cepTelDataGridViewTextBoxColumn
            // 
            this.cepTelDataGridViewTextBoxColumn.DataPropertyName = "Cep_Tel";
            this.cepTelDataGridViewTextBoxColumn.HeaderText = "Cep_Tel";
            this.cepTelDataGridViewTextBoxColumn.Name = "cepTelDataGridViewTextBoxColumn";
            // 
            // ePostaDataGridViewTextBoxColumn
            // 
            this.ePostaDataGridViewTextBoxColumn.DataPropertyName = "E_Posta";
            this.ePostaDataGridViewTextBoxColumn.HeaderText = "E_Posta";
            this.ePostaDataGridViewTextBoxColumn.Name = "ePostaDataGridViewTextBoxColumn";
            // 
            // uyelikTarDataGridViewTextBoxColumn
            // 
            this.uyelikTarDataGridViewTextBoxColumn.DataPropertyName = "Uyelik_Tar";
            this.uyelikTarDataGridViewTextBoxColumn.HeaderText = "Uyelik_Tar";
            this.uyelikTarDataGridViewTextBoxColumn.Name = "uyelikTarDataGridViewTextBoxColumn";
            // 
            // okuyucubilBindingSource
            // 
            this.okuyucubilBindingSource.DataMember = "okuyucubil";
            this.okuyucubilBindingSource.DataSource = this.kutuphaneDBDataSet;
            // 
            // kutuphaneDBDataSet
            // 
            this.kutuphaneDBDataSet.DataSetName = "KutuphaneDBDataSet";
            this.kutuphaneDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AraBarkoddataGridView2
            // 
            this.AraBarkoddataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AraBarkoddataGridView2.AutoGenerateColumns = false;
            this.AraBarkoddataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AraBarkoddataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.otoIDDataGridViewTextBoxColumn1,
            this.barkodNoDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yayineviDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.stokSayisiDataGridViewTextBoxColumn,
            this.kategorisiDataGridViewTextBoxColumn,
            this.basimTarihiDataGridViewTextBoxColumn,
            this.sayfaSayDataGridViewTextBoxColumn});
            this.AraBarkoddataGridView2.DataSource = this.kitapbilBindingSource;
            this.AraBarkoddataGridView2.Location = new System.Drawing.Point(537, 114);
            this.AraBarkoddataGridView2.Name = "AraBarkoddataGridView2";
            this.AraBarkoddataGridView2.Size = new System.Drawing.Size(495, 263);
            this.AraBarkoddataGridView2.TabIndex = 5;
            this.AraBarkoddataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // otoIDDataGridViewTextBoxColumn1
            // 
            this.otoIDDataGridViewTextBoxColumn1.DataPropertyName = "Oto_ID";
            this.otoIDDataGridViewTextBoxColumn1.HeaderText = "Oto_ID";
            this.otoIDDataGridViewTextBoxColumn1.Name = "otoIDDataGridViewTextBoxColumn1";
            // 
            // barkodNoDataGridViewTextBoxColumn
            // 
            this.barkodNoDataGridViewTextBoxColumn.DataPropertyName = "Barkod_No";
            this.barkodNoDataGridViewTextBoxColumn.HeaderText = "Barkod_No";
            this.barkodNoDataGridViewTextBoxColumn.Name = "barkodNoDataGridViewTextBoxColumn";
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "Kitap_Adi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "Kitap_Adi";
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // yayineviDataGridViewTextBoxColumn
            // 
            this.yayineviDataGridViewTextBoxColumn.DataPropertyName = "Yayinevi";
            this.yayineviDataGridViewTextBoxColumn.HeaderText = "Yayinevi";
            this.yayineviDataGridViewTextBoxColumn.Name = "yayineviDataGridViewTextBoxColumn";
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            this.yazarDataGridViewTextBoxColumn.DataPropertyName = "Yazar";
            this.yazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            this.yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            // 
            // stokSayisiDataGridViewTextBoxColumn
            // 
            this.stokSayisiDataGridViewTextBoxColumn.DataPropertyName = "Stok_Sayisi";
            this.stokSayisiDataGridViewTextBoxColumn.HeaderText = "Stok_Sayisi";
            this.stokSayisiDataGridViewTextBoxColumn.Name = "stokSayisiDataGridViewTextBoxColumn";
            // 
            // kategorisiDataGridViewTextBoxColumn
            // 
            this.kategorisiDataGridViewTextBoxColumn.DataPropertyName = "Kategorisi";
            this.kategorisiDataGridViewTextBoxColumn.HeaderText = "Kategorisi";
            this.kategorisiDataGridViewTextBoxColumn.Name = "kategorisiDataGridViewTextBoxColumn";
            // 
            // basimTarihiDataGridViewTextBoxColumn
            // 
            this.basimTarihiDataGridViewTextBoxColumn.DataPropertyName = "Basim_Tarihi";
            this.basimTarihiDataGridViewTextBoxColumn.HeaderText = "Basim_Tarihi";
            this.basimTarihiDataGridViewTextBoxColumn.Name = "basimTarihiDataGridViewTextBoxColumn";
            // 
            // sayfaSayDataGridViewTextBoxColumn
            // 
            this.sayfaSayDataGridViewTextBoxColumn.DataPropertyName = "Sayfa_Say";
            this.sayfaSayDataGridViewTextBoxColumn.HeaderText = "Sayfa_Say";
            this.sayfaSayDataGridViewTextBoxColumn.Name = "sayfaSayDataGridViewTextBoxColumn";
            // 
            // kitapbilBindingSource
            // 
            this.kitapbilBindingSource.DataMember = "kitapbil";
            this.kitapbilBindingSource.DataSource = this.kutuphaneDBDataSet1;
            // 
            // kutuphaneDBDataSet1
            // 
            this.kutuphaneDBDataSet1.DataSetName = "KutuphaneDBDataSet1";
            this.kutuphaneDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ara(ID)";
            // 
            // tbOkulNoAra
            // 
            this.tbOkulNoAra.Location = new System.Drawing.Point(63, 89);
            this.tbOkulNoAra.Name = "tbOkulNoAra";
            this.tbOkulNoAra.Size = new System.Drawing.Size(131, 20);
            this.tbOkulNoAra.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(215, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ÖĞRENCİ LİSTESİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(742, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "KİTAP LİSTESİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(537, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ara(ID)";
            // 
            // tbBarkodNoAra
            // 
            this.tbBarkodNoAra.Location = new System.Drawing.Point(583, 89);
            this.tbBarkodNoAra.Name = "tbBarkodNoAra";
            this.tbBarkodNoAra.Size = new System.Drawing.Size(139, 20);
            this.tbBarkodNoAra.TabIndex = 11;
            // 
            // btYenile1
            // 
            this.btYenile1.Location = new System.Drawing.Point(274, 87);
            this.btYenile1.Name = "btYenile1";
            this.btYenile1.Size = new System.Drawing.Size(84, 23);
            this.btYenile1.TabIndex = 12;
            this.btYenile1.Text = "Yenile";
            this.btYenile1.UseVisualStyleBackColor = true;
            this.btYenile1.Click += new System.EventHandler(this.btYenile1_Click);
            // 
            // btYenile2
            // 
            this.btYenile2.Location = new System.Drawing.Point(802, 87);
            this.btYenile2.Name = "btYenile2";
            this.btYenile2.Size = new System.Drawing.Size(78, 23);
            this.btYenile2.TabIndex = 13;
            this.btYenile2.Text = "Yenile";
            this.btYenile2.UseVisualStyleBackColor = true;
            this.btYenile2.Click += new System.EventHandler(this.btYenile2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Toplam Üye Sayısı : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(175, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(531, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Toplam Kitap Sayısı : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(696, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 33;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // btUye
            // 
            this.btUye.Location = new System.Drawing.Point(12, 12);
            this.btUye.Name = "btUye";
            this.btUye.Size = new System.Drawing.Size(75, 23);
            this.btUye.TabIndex = 40;
            this.btUye.Text = "Üye İşlemleri";
            this.btUye.UseVisualStyleBackColor = true;
            this.btUye.Click += new System.EventHandler(this.btUye_Click_1);
            // 
            // btKitap
            // 
            this.btKitap.Location = new System.Drawing.Point(94, 12);
            this.btKitap.Name = "btKitap";
            this.btKitap.Size = new System.Drawing.Size(82, 23);
            this.btKitap.TabIndex = 41;
            this.btKitap.Text = "Kitap İşlemleri";
            this.btKitap.UseVisualStyleBackColor = true;
            this.btKitap.Click += new System.EventHandler(this.btKitap_Click);
            // 
            // btCikis
            // 
            this.btCikis.Location = new System.Drawing.Point(453, 12);
            this.btCikis.Name = "btCikis";
            this.btCikis.Size = new System.Drawing.Size(75, 23);
            this.btCikis.TabIndex = 42;
            this.btCikis.Text = "Çıkış";
            this.btCikis.UseVisualStyleBackColor = true;
            this.btCikis.Click += new System.EventHandler(this.btCikis_Click);
            // 
            // btUyelik
            // 
            this.btUyelik.Location = new System.Drawing.Point(182, 12);
            this.btUyelik.Name = "btUyelik";
            this.btUyelik.Size = new System.Drawing.Size(86, 23);
            this.btUyelik.TabIndex = 43;
            this.btUyelik.Text = "Üyelik İşlemleri";
            this.btUyelik.UseVisualStyleBackColor = true;
            this.btUyelik.Click += new System.EventHandler(this.btUyelik_Click_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Castellar", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(550, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(472, 35);
            this.label20.TabIndex = 44;
            this.label20.Text = "KÜTÜPHANE TAKİP SİSTEMİ";
            // 
            // btOkulNoAra
            // 
            this.btOkulNoAra.Location = new System.Drawing.Point(200, 87);
            this.btOkulNoAra.Name = "btOkulNoAra";
            this.btOkulNoAra.Size = new System.Drawing.Size(68, 23);
            this.btOkulNoAra.TabIndex = 45;
            this.btOkulNoAra.Text = "Ara";
            this.btOkulNoAra.UseVisualStyleBackColor = true;
            this.btOkulNoAra.Click += new System.EventHandler(this.btOkulNoAra_Click);
            // 
            // btBarkodNoAra
            // 
            this.btBarkodNoAra.Location = new System.Drawing.Point(728, 87);
            this.btBarkodNoAra.Name = "btBarkodNoAra";
            this.btBarkodNoAra.Size = new System.Drawing.Size(68, 23);
            this.btBarkodNoAra.TabIndex = 46;
            this.btBarkodNoAra.Text = "Ara";
            this.btBarkodNoAra.UseVisualStyleBackColor = true;
            this.btBarkodNoAra.Click += new System.EventHandler(this.btBarkodNoAra_Click);
            // 
            // okuyucubilTableAdapter
            // 
            this.okuyucubilTableAdapter.ClearBeforeFill = true;
            // 
            // kitapbilTableAdapter
            // 
            this.kitapbilTableAdapter.ClearBeforeFill = true;
            // 
            // btEmanet
            // 
            this.btEmanet.Location = new System.Drawing.Point(274, 12);
            this.btEmanet.Name = "btEmanet";
            this.btEmanet.Size = new System.Drawing.Size(92, 23);
            this.btEmanet.TabIndex = 47;
            this.btEmanet.Text = "Emanet İşlemleri";
            this.btEmanet.UseVisualStyleBackColor = true;
            this.btEmanet.Click += new System.EventHandler(this.btEmanet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Hakkında";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane_Takip_Programi.Properties.Resources.arkaplan21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btEmanet);
            this.Controls.Add(this.btBarkodNoAra);
            this.Controls.Add(this.btOkulNoAra);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btUyelik);
            this.Controls.Add(this.btCikis);
            this.Controls.Add(this.btKitap);
            this.Controls.Add(this.btUye);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btYenile2);
            this.Controls.Add(this.btYenile1);
            this.Controls.Add(this.tbBarkodNoAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOkulNoAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AraBarkoddataGridView2);
            this.Controls.Add(this.AraOkuldataGridView1);
            this.Name = "Form2";
            this.Text = "Kütüphane Takip Programı";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AraOkuldataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okuyucubilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AraBarkoddataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapbilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView AraOkuldataGridView1;
        private System.Windows.Forms.DataGridView AraBarkoddataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOkulNoAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBarkodNoAra;
        private System.Windows.Forms.Button btYenile1;
        private System.Windows.Forms.Button btYenile2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btUye;
        private System.Windows.Forms.Button btKitap;
        private System.Windows.Forms.Button btCikis;
        private System.Windows.Forms.Button btUyelik;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btOkulNoAra;
        private System.Windows.Forms.Button btBarkodNoAra;
        private KutuphaneDBDataSet kutuphaneDBDataSet;
        private System.Windows.Forms.BindingSource okuyucubilBindingSource;
        private KutuphaneDBDataSetTableAdapters.okuyucubilTableAdapter okuyucubilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn otoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiSydDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okulnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogmYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogmTrhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnsytDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyelikTarDataGridViewTextBoxColumn;
        private KutuphaneDBDataSet1 kutuphaneDBDataSet1;
        private System.Windows.Forms.BindingSource kitapbilBindingSource;
        private KutuphaneDBDataSet1TableAdapters.kitapbilTableAdapter kitapbilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn otoIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btEmanet;
        private System.Windows.Forms.Button button1;
    }
}

