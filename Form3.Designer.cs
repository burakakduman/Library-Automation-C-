namespace Kutuphane_Takip_Programi
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btKaydetOkuyucu = new System.Windows.Forms.Button();
            this.btTemizleOkuyucu = new System.Windows.Forms.Button();
            this.tbTCOkuyucu = new System.Windows.Forms.TextBox();
            this.tbAdOkuyucu = new System.Windows.Forms.TextBox();
            this.tbNoOkuyucu = new System.Windows.Forms.TextBox();
            this.tbDogumTarihiOkuyucu = new System.Windows.Forms.TextBox();
            this.tbDogumYeriOkuyucu = new System.Windows.Forms.TextBox();
            this.tbTelefonOkuyucu = new System.Windows.Forms.TextBox();
            this.tbEpostaOkuyucu = new System.Windows.Forms.TextBox();
            this.tbCinsiyetOkuyucu = new System.Windows.Forms.TextBox();
            this.tbUyelikTarihiOkuyucu = new System.Windows.Forms.TextBox();
            this.tbAdresOkuyucu = new System.Windows.Forms.TextBox();
            this.okuyucu_dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.btSilOkuyucu = new System.Windows.Forms.Button();
            this.btGuncelleOkuyucu = new System.Windows.Forms.Button();
            this.tbDuzenlenecekIDOkuyucu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSinifOkuyucu = new System.Windows.Forms.TextBox();
            this.YenileOkuyucu = new System.Windows.Forms.Button();
            this.okuyucubilTableAdapter = new Kutuphane_Takip_Programi.KutuphaneDBDataSetTableAdapters.okuyucubilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.okuyucu_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okuyucubilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "OKUYUCU KAYIT FORMU ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad-Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(265, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doğum Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(265, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Doğum Yeri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(265, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(265, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "E-Posta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(265, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Üyelik Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cinsiyet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Adres";
            // 
            // btKaydetOkuyucu
            // 
            this.btKaydetOkuyucu.Location = new System.Drawing.Point(12, 233);
            this.btKaydetOkuyucu.Name = "btKaydetOkuyucu";
            this.btKaydetOkuyucu.Size = new System.Drawing.Size(121, 48);
            this.btKaydetOkuyucu.TabIndex = 12;
            this.btKaydetOkuyucu.Text = "KAYDET";
            this.btKaydetOkuyucu.UseVisualStyleBackColor = true;
            this.btKaydetOkuyucu.Click += new System.EventHandler(this.btKaydetOkuyucu_Click);
            // 
            // btTemizleOkuyucu
            // 
            this.btTemizleOkuyucu.Location = new System.Drawing.Point(390, 234);
            this.btTemizleOkuyucu.Name = "btTemizleOkuyucu";
            this.btTemizleOkuyucu.Size = new System.Drawing.Size(100, 48);
            this.btTemizleOkuyucu.TabIndex = 13;
            this.btTemizleOkuyucu.Text = "TEMİZLE";
            this.btTemizleOkuyucu.UseVisualStyleBackColor = true;
            this.btTemizleOkuyucu.Click += new System.EventHandler(this.btTemizleOkuyucu_Click);
            // 
            // tbTCOkuyucu
            // 
            this.tbTCOkuyucu.Location = new System.Drawing.Point(88, 36);
            this.tbTCOkuyucu.Name = "tbTCOkuyucu";
            this.tbTCOkuyucu.Size = new System.Drawing.Size(149, 20);
            this.tbTCOkuyucu.TabIndex = 14;
            // 
            // tbAdOkuyucu
            // 
            this.tbAdOkuyucu.Location = new System.Drawing.Point(88, 63);
            this.tbAdOkuyucu.Name = "tbAdOkuyucu";
            this.tbAdOkuyucu.Size = new System.Drawing.Size(149, 20);
            this.tbAdOkuyucu.TabIndex = 15;
            // 
            // tbNoOkuyucu
            // 
            this.tbNoOkuyucu.Location = new System.Drawing.Point(88, 116);
            this.tbNoOkuyucu.Name = "tbNoOkuyucu";
            this.tbNoOkuyucu.Size = new System.Drawing.Size(149, 20);
            this.tbNoOkuyucu.TabIndex = 17;
            // 
            // tbDogumTarihiOkuyucu
            // 
            this.tbDogumTarihiOkuyucu.Location = new System.Drawing.Point(341, 36);
            this.tbDogumTarihiOkuyucu.Name = "tbDogumTarihiOkuyucu";
            this.tbDogumTarihiOkuyucu.Size = new System.Drawing.Size(149, 20);
            this.tbDogumTarihiOkuyucu.TabIndex = 18;
            // 
            // tbDogumYeriOkuyucu
            // 
            this.tbDogumYeriOkuyucu.Location = new System.Drawing.Point(341, 62);
            this.tbDogumYeriOkuyucu.Name = "tbDogumYeriOkuyucu";
            this.tbDogumYeriOkuyucu.Size = new System.Drawing.Size(149, 20);
            this.tbDogumYeriOkuyucu.TabIndex = 19;
            // 
            // tbTelefonOkuyucu
            // 
            this.tbTelefonOkuyucu.Location = new System.Drawing.Point(341, 89);
            this.tbTelefonOkuyucu.Name = "tbTelefonOkuyucu";
            this.tbTelefonOkuyucu.Size = new System.Drawing.Size(149, 20);
            this.tbTelefonOkuyucu.TabIndex = 20;
            // 
            // tbEpostaOkuyucu
            // 
            this.tbEpostaOkuyucu.Location = new System.Drawing.Point(341, 115);
            this.tbEpostaOkuyucu.Name = "tbEpostaOkuyucu";
            this.tbEpostaOkuyucu.Size = new System.Drawing.Size(149, 20);
            this.tbEpostaOkuyucu.TabIndex = 21;
            // 
            // tbCinsiyetOkuyucu
            // 
            this.tbCinsiyetOkuyucu.Location = new System.Drawing.Point(88, 143);
            this.tbCinsiyetOkuyucu.Name = "tbCinsiyetOkuyucu";
            this.tbCinsiyetOkuyucu.Size = new System.Drawing.Size(149, 20);
            this.tbCinsiyetOkuyucu.TabIndex = 22;
            // 
            // tbUyelikTarihiOkuyucu
            // 
            this.tbUyelikTarihiOkuyucu.Location = new System.Drawing.Point(341, 142);
            this.tbUyelikTarihiOkuyucu.Name = "tbUyelikTarihiOkuyucu";
            this.tbUyelikTarihiOkuyucu.Size = new System.Drawing.Size(149, 20);
            this.tbUyelikTarihiOkuyucu.TabIndex = 23;
            // 
            // tbAdresOkuyucu
            // 
            this.tbAdresOkuyucu.Location = new System.Drawing.Point(88, 170);
            this.tbAdresOkuyucu.Name = "tbAdresOkuyucu";
            this.tbAdresOkuyucu.Size = new System.Drawing.Size(402, 20);
            this.tbAdresOkuyucu.TabIndex = 24;
            // 
            // okuyucu_dataGridView1
            // 
            this.okuyucu_dataGridView1.AutoGenerateColumns = false;
            this.okuyucu_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.okuyucu_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.okuyucu_dataGridView1.DataSource = this.okuyucubilBindingSource;
            this.okuyucu_dataGridView1.Location = new System.Drawing.Point(513, 12);
            this.okuyucu_dataGridView1.Name = "okuyucu_dataGridView1";
            this.okuyucu_dataGridView1.Size = new System.Drawing.Size(532, 215);
            this.okuyucu_dataGridView1.TabIndex = 25;
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
            // btSilOkuyucu
            // 
            this.btSilOkuyucu.Location = new System.Drawing.Point(139, 233);
            this.btSilOkuyucu.Name = "btSilOkuyucu";
            this.btSilOkuyucu.Size = new System.Drawing.Size(123, 48);
            this.btSilOkuyucu.TabIndex = 26;
            this.btSilOkuyucu.Text = "SİL";
            this.btSilOkuyucu.UseVisualStyleBackColor = true;
            this.btSilOkuyucu.Click += new System.EventHandler(this.btSilOkuyucu_Click_1);
            // 
            // btGuncelleOkuyucu
            // 
            this.btGuncelleOkuyucu.Location = new System.Drawing.Point(268, 234);
            this.btGuncelleOkuyucu.Name = "btGuncelleOkuyucu";
            this.btGuncelleOkuyucu.Size = new System.Drawing.Size(116, 47);
            this.btGuncelleOkuyucu.TabIndex = 27;
            this.btGuncelleOkuyucu.Text = "GÜNCELLE";
            this.btGuncelleOkuyucu.UseVisualStyleBackColor = true;
            this.btGuncelleOkuyucu.Click += new System.EventHandler(this.btGuncelleOkuyucu_Click_1);
            // 
            // tbDuzenlenecekIDOkuyucu
            // 
            this.tbDuzenlenecekIDOkuyucu.Location = new System.Drawing.Point(131, 207);
            this.tbDuzenlenecekIDOkuyucu.Name = "tbDuzenlenecekIDOkuyucu";
            this.tbDuzenlenecekIDOkuyucu.Size = new System.Drawing.Size(359, 20);
            this.tbDuzenlenecekIDOkuyucu.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(13, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Düzenlenecek Üye TC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sınıf";
            // 
            // tbSinifOkuyucu
            // 
            this.tbSinifOkuyucu.Location = new System.Drawing.Point(88, 88);
            this.tbSinifOkuyucu.Name = "tbSinifOkuyucu";
            this.tbSinifOkuyucu.Size = new System.Drawing.Size(149, 20);
            this.tbSinifOkuyucu.TabIndex = 31;
            // 
            // YenileOkuyucu
            // 
            this.YenileOkuyucu.Location = new System.Drawing.Point(513, 234);
            this.YenileOkuyucu.Name = "YenileOkuyucu";
            this.YenileOkuyucu.Size = new System.Drawing.Size(532, 47);
            this.YenileOkuyucu.TabIndex = 32;
            this.YenileOkuyucu.Text = "LİSTEYİ YENİLE";
            this.YenileOkuyucu.UseVisualStyleBackColor = true;
            this.YenileOkuyucu.Click += new System.EventHandler(this.YenileOkuyucu_Click);
            // 
            // okuyucubilTableAdapter
            // 
            this.okuyucubilTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane_Takip_Programi.Properties.Resources.arkaplan2;
            this.ClientSize = new System.Drawing.Size(1057, 294);
            this.Controls.Add(this.YenileOkuyucu);
            this.Controls.Add(this.tbSinifOkuyucu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbDuzenlenecekIDOkuyucu);
            this.Controls.Add(this.btGuncelleOkuyucu);
            this.Controls.Add(this.btSilOkuyucu);
            this.Controls.Add(this.okuyucu_dataGridView1);
            this.Controls.Add(this.tbAdresOkuyucu);
            this.Controls.Add(this.tbUyelikTarihiOkuyucu);
            this.Controls.Add(this.tbCinsiyetOkuyucu);
            this.Controls.Add(this.tbEpostaOkuyucu);
            this.Controls.Add(this.tbTelefonOkuyucu);
            this.Controls.Add(this.tbDogumYeriOkuyucu);
            this.Controls.Add(this.tbDogumTarihiOkuyucu);
            this.Controls.Add(this.tbNoOkuyucu);
            this.Controls.Add(this.tbAdOkuyucu);
            this.Controls.Add(this.tbTCOkuyucu);
            this.Controls.Add(this.btTemizleOkuyucu);
            this.Controls.Add(this.btKaydetOkuyucu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Okuyucu Kayıt Formu";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.okuyucu_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okuyucubilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btKaydetOkuyucu;
        private System.Windows.Forms.Button btTemizleOkuyucu;
        private System.Windows.Forms.TextBox tbTCOkuyucu;
        private System.Windows.Forms.TextBox tbAdOkuyucu;
        private System.Windows.Forms.TextBox tbNoOkuyucu;
        private System.Windows.Forms.TextBox tbDogumTarihiOkuyucu;
        private System.Windows.Forms.TextBox tbDogumYeriOkuyucu;
        private System.Windows.Forms.TextBox tbTelefonOkuyucu;
        private System.Windows.Forms.TextBox tbEpostaOkuyucu;
        private System.Windows.Forms.TextBox tbCinsiyetOkuyucu;
        private System.Windows.Forms.TextBox tbUyelikTarihiOkuyucu;
        private System.Windows.Forms.TextBox tbAdresOkuyucu;
        private System.Windows.Forms.DataGridView okuyucu_dataGridView1;
        private System.Windows.Forms.Button btSilOkuyucu;
        private System.Windows.Forms.Button btGuncelleOkuyucu;
        private System.Windows.Forms.TextBox tbDuzenlenecekIDOkuyucu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSinifOkuyucu;
        private System.Windows.Forms.Button YenileOkuyucu;
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
    }
}