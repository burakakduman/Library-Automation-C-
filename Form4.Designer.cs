namespace Kutuphane_Takip_Programi
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbBarkodNoKitap = new System.Windows.Forms.TextBox();
            this.tbKitapTuruKitap = new System.Windows.Forms.TextBox();
            this.tbKitapAdiKitap = new System.Windows.Forms.TextBox();
            this.tbYazarAdiKitap = new System.Windows.Forms.TextBox();
            this.tbYayinEviKitap = new System.Windows.Forms.TextBox();
            this.tbSayfaSayisiKitap = new System.Windows.Forms.TextBox();
            this.tbBasimTarihiKitap = new System.Windows.Forms.TextBox();
            this.tbStokSayisiKitap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btKaydetKitap = new System.Windows.Forms.Button();
            this.btGuncelleKitap = new System.Windows.Forms.Button();
            this.kitap_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapbilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDBDataSet2 = new Kutuphane_Takip_Programi.KutuphaneDBDataSet2();
            this.label10 = new System.Windows.Forms.Label();
            this.tbIDKitap = new System.Windows.Forms.TextBox();
            this.btSilKitap = new System.Windows.Forms.Button();
            this.btTemizleKitap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kitapbilTableAdapter = new Kutuphane_Takip_Programi.KutuphaneDBDataSet2TableAdapters.kitapbilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapbilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Kayıt Formu";
            // 
            // tbBarkodNoKitap
            // 
            this.tbBarkodNoKitap.Location = new System.Drawing.Point(102, 39);
            this.tbBarkodNoKitap.Name = "tbBarkodNoKitap";
            this.tbBarkodNoKitap.Size = new System.Drawing.Size(134, 20);
            this.tbBarkodNoKitap.TabIndex = 1;
            // 
            // tbKitapTuruKitap
            // 
            this.tbKitapTuruKitap.Location = new System.Drawing.Point(358, 39);
            this.tbKitapTuruKitap.Name = "tbKitapTuruKitap";
            this.tbKitapTuruKitap.Size = new System.Drawing.Size(134, 20);
            this.tbKitapTuruKitap.TabIndex = 2;
            // 
            // tbKitapAdiKitap
            // 
            this.tbKitapAdiKitap.Location = new System.Drawing.Point(102, 68);
            this.tbKitapAdiKitap.Name = "tbKitapAdiKitap";
            this.tbKitapAdiKitap.Size = new System.Drawing.Size(134, 20);
            this.tbKitapAdiKitap.TabIndex = 3;
            // 
            // tbYazarAdiKitap
            // 
            this.tbYazarAdiKitap.Location = new System.Drawing.Point(102, 93);
            this.tbYazarAdiKitap.Name = "tbYazarAdiKitap";
            this.tbYazarAdiKitap.Size = new System.Drawing.Size(134, 20);
            this.tbYazarAdiKitap.TabIndex = 4;
            // 
            // tbYayinEviKitap
            // 
            this.tbYayinEviKitap.Location = new System.Drawing.Point(102, 119);
            this.tbYayinEviKitap.Name = "tbYayinEviKitap";
            this.tbYayinEviKitap.Size = new System.Drawing.Size(134, 20);
            this.tbYayinEviKitap.TabIndex = 5;
            this.tbYayinEviKitap.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbSayfaSayisiKitap
            // 
            this.tbSayfaSayisiKitap.Location = new System.Drawing.Point(358, 67);
            this.tbSayfaSayisiKitap.Name = "tbSayfaSayisiKitap";
            this.tbSayfaSayisiKitap.Size = new System.Drawing.Size(134, 20);
            this.tbSayfaSayisiKitap.TabIndex = 6;
            // 
            // tbBasimTarihiKitap
            // 
            this.tbBasimTarihiKitap.Location = new System.Drawing.Point(358, 93);
            this.tbBasimTarihiKitap.Name = "tbBasimTarihiKitap";
            this.tbBasimTarihiKitap.Size = new System.Drawing.Size(134, 20);
            this.tbBasimTarihiKitap.TabIndex = 7;
            // 
            // tbStokSayisiKitap
            // 
            this.tbStokSayisiKitap.Location = new System.Drawing.Point(358, 119);
            this.tbStokSayisiKitap.Name = "tbStokSayisiKitap";
            this.tbStokSayisiKitap.Size = new System.Drawing.Size(134, 20);
            this.tbStokSayisiKitap.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Barkod NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kitap Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yazar Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yayın Evi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(259, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kitap Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(259, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sayfa Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(259, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "BasımTarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(259, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Stok Sayısı";
            // 
            // btKaydetKitap
            // 
            this.btKaydetKitap.Location = new System.Drawing.Point(19, 184);
            this.btKaydetKitap.Name = "btKaydetKitap";
            this.btKaydetKitap.Size = new System.Drawing.Size(117, 65);
            this.btKaydetKitap.TabIndex = 17;
            this.btKaydetKitap.Text = "KAYDET";
            this.btKaydetKitap.UseVisualStyleBackColor = true;
            this.btKaydetKitap.Click += new System.EventHandler(this.btKaydetKitap_Click);
            // 
            // btGuncelleKitap
            // 
            this.btGuncelleKitap.Location = new System.Drawing.Point(142, 184);
            this.btGuncelleKitap.Name = "btGuncelleKitap";
            this.btGuncelleKitap.Size = new System.Drawing.Size(114, 64);
            this.btGuncelleKitap.TabIndex = 18;
            this.btGuncelleKitap.Text = "GÜNCELLE";
            this.btGuncelleKitap.UseVisualStyleBackColor = true;
            this.btGuncelleKitap.Click += new System.EventHandler(this.btGuncelleKitap_Click_1);
            // 
            // kitap_dataGridView1
            // 
            this.kitap_dataGridView1.AutoGenerateColumns = false;
            this.kitap_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitap_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.otoIDDataGridViewTextBoxColumn,
            this.barkodNoDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yayineviDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.stokSayisiDataGridViewTextBoxColumn,
            this.kategorisiDataGridViewTextBoxColumn,
            this.basimTarihiDataGridViewTextBoxColumn,
            this.sayfaSayDataGridViewTextBoxColumn});
            this.kitap_dataGridView1.DataSource = this.kitapbilBindingSource;
            this.kitap_dataGridView1.Location = new System.Drawing.Point(498, 9);
            this.kitap_dataGridView1.Name = "kitap_dataGridView1";
            this.kitap_dataGridView1.Size = new System.Drawing.Size(447, 169);
            this.kitap_dataGridView1.TabIndex = 19;
            // 
            // otoIDDataGridViewTextBoxColumn
            // 
            this.otoIDDataGridViewTextBoxColumn.DataPropertyName = "Oto_ID";
            this.otoIDDataGridViewTextBoxColumn.HeaderText = "Oto_ID";
            this.otoIDDataGridViewTextBoxColumn.Name = "otoIDDataGridViewTextBoxColumn";
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
            this.kitapbilBindingSource.DataSource = this.kutuphaneDBDataSet2;
            // 
            // kutuphaneDBDataSet2
            // 
            this.kutuphaneDBDataSet2.DataSetName = "KutuphaneDBDataSet2";
            this.kutuphaneDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Düzenlenecek Kitap ID";
            // 
            // tbIDKitap
            // 
            this.tbIDKitap.Location = new System.Drawing.Point(142, 158);
            this.tbIDKitap.Name = "tbIDKitap";
            this.tbIDKitap.Size = new System.Drawing.Size(349, 20);
            this.tbIDKitap.TabIndex = 21;
            // 
            // btSilKitap
            // 
            this.btSilKitap.Location = new System.Drawing.Point(262, 184);
            this.btSilKitap.Name = "btSilKitap";
            this.btSilKitap.Size = new System.Drawing.Size(111, 63);
            this.btSilKitap.TabIndex = 22;
            this.btSilKitap.Text = "SİL";
            this.btSilKitap.UseVisualStyleBackColor = true;
            this.btSilKitap.Click += new System.EventHandler(this.btSilKitap_Click);
            // 
            // btTemizleKitap
            // 
            this.btTemizleKitap.Location = new System.Drawing.Point(379, 184);
            this.btTemizleKitap.Name = "btTemizleKitap";
            this.btTemizleKitap.Size = new System.Drawing.Size(112, 62);
            this.btTemizleKitap.TabIndex = 23;
            this.btTemizleKitap.Text = "TEMİZLE";
            this.btTemizleKitap.UseVisualStyleBackColor = true;
            this.btTemizleKitap.Click += new System.EventHandler(this.btTemizleKitap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(447, 60);
            this.button1.TabIndex = 24;
            this.button1.Text = "LİSTEYİ YENİLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kitapbilTableAdapter
            // 
            this.kitapbilTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane_Takip_Programi.Properties.Resources.arkaplan2;
            this.ClientSize = new System.Drawing.Size(957, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btTemizleKitap);
            this.Controls.Add(this.btSilKitap);
            this.Controls.Add(this.tbIDKitap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.kitap_dataGridView1);
            this.Controls.Add(this.btGuncelleKitap);
            this.Controls.Add(this.btKaydetKitap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStokSayisiKitap);
            this.Controls.Add(this.tbBasimTarihiKitap);
            this.Controls.Add(this.tbSayfaSayisiKitap);
            this.Controls.Add(this.tbYayinEviKitap);
            this.Controls.Add(this.tbYazarAdiKitap);
            this.Controls.Add(this.tbKitapAdiKitap);
            this.Controls.Add(this.tbKitapTuruKitap);
            this.Controls.Add(this.tbBarkodNoKitap);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Kitap Kayıt Formu";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.kitap_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapbilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBarkodNoKitap;
        private System.Windows.Forms.TextBox tbKitapTuruKitap;
        private System.Windows.Forms.TextBox tbKitapAdiKitap;
        private System.Windows.Forms.TextBox tbYazarAdiKitap;
        private System.Windows.Forms.TextBox tbYayinEviKitap;
        private System.Windows.Forms.TextBox tbSayfaSayisiKitap;
        private System.Windows.Forms.TextBox tbBasimTarihiKitap;
        private System.Windows.Forms.TextBox tbStokSayisiKitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btKaydetKitap;
        private System.Windows.Forms.Button btGuncelleKitap;
        private System.Windows.Forms.DataGridView kitap_dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbIDKitap;
        private System.Windows.Forms.Button btSilKitap;
        private System.Windows.Forms.Button btTemizleKitap;
        private System.Windows.Forms.Button button1;
        private KutuphaneDBDataSet2 kutuphaneDBDataSet2;
        private System.Windows.Forms.BindingSource kitapbilBindingSource;
        private KutuphaneDBDataSet2TableAdapters.kitapbilTableAdapter kitapbilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn otoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayDataGridViewTextBoxColumn;
    }
}