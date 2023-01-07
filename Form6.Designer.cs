namespace Kutuphane_Takip_Programi
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okuyucuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verilişTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iadeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetbilBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDBDataSet6 = new Kutuphane_Takip_Programi.KutuphaneDBDataSet6();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOkuyucuID = new System.Windows.Forms.TextBox();
            this.tbKitapID = new System.Windows.Forms.TextBox();
            this.tbVerilisTarihi = new System.Windows.Forms.TextBox();
            this.tbIadeTarihi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmanetID = new System.Windows.Forms.TextBox();
            this.btKaydetEmanet = new System.Windows.Forms.Button();
            this.btGuncelleEmanet = new System.Windows.Forms.Button();
            this.btSilEmanet = new System.Windows.Forms.Button();
            this.btTemizleEmanet = new System.Windows.Forms.Button();
            this.kutuphaneDBDataSet3 = new Kutuphane_Takip_Programi.KutuphaneDBDataSet3();
            this.kutuphaneDBDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDBDataSet4 = new Kutuphane_Takip_Programi.KutuphaneDBDataSet4();
            this.emanetbilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emanetbilTableAdapter = new Kutuphane_Takip_Programi.KutuphaneDBDataSet4TableAdapters.emanetbilTableAdapter();
            this.kutuphaneDBDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emanetbilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emanetbilBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.emanetbilBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDBDataSet5 = new Kutuphane_Takip_Programi.KutuphaneDBDataSet5();
            this.emanetbilBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.emanetbilTableAdapter1 = new Kutuphane_Takip_Programi.KutuphaneDBDataSet5TableAdapters.emanetbilTableAdapter();
            this.btYenileEmanet = new System.Windows.Forms.Button();
            this.emanetbilBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.emanetbilTableAdapter2 = new Kutuphane_Takip_Programi.KutuphaneDBDataSet6TableAdapters.emanetbilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMANET İŞLEMLERİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.otoIDDataGridViewTextBoxColumn,
            this.okuyucuIDDataGridViewTextBoxColumn,
            this.kitapIDDataGridViewTextBoxColumn,
            this.verilişTarihiDataGridViewTextBoxColumn,
            this.iadeTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emanetbilBindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(253, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 153);
            this.dataGridView1.TabIndex = 1;
            // 
            // otoIDDataGridViewTextBoxColumn
            // 
            this.otoIDDataGridViewTextBoxColumn.DataPropertyName = "Oto_ID";
            this.otoIDDataGridViewTextBoxColumn.HeaderText = "Oto_ID";
            this.otoIDDataGridViewTextBoxColumn.Name = "otoIDDataGridViewTextBoxColumn";
            // 
            // okuyucuIDDataGridViewTextBoxColumn
            // 
            this.okuyucuIDDataGridViewTextBoxColumn.DataPropertyName = "Okuyucu_ID";
            this.okuyucuIDDataGridViewTextBoxColumn.HeaderText = "Okuyucu_ID";
            this.okuyucuIDDataGridViewTextBoxColumn.Name = "okuyucuIDDataGridViewTextBoxColumn";
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            this.kitapIDDataGridViewTextBoxColumn.DataPropertyName = "Kitap_ID";
            this.kitapIDDataGridViewTextBoxColumn.HeaderText = "Kitap_ID";
            this.kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            // 
            // verilişTarihiDataGridViewTextBoxColumn
            // 
            this.verilişTarihiDataGridViewTextBoxColumn.DataPropertyName = "Veriliş_Tarihi";
            this.verilişTarihiDataGridViewTextBoxColumn.HeaderText = "Veriliş_Tarihi";
            this.verilişTarihiDataGridViewTextBoxColumn.Name = "verilişTarihiDataGridViewTextBoxColumn";
            // 
            // iadeTarihiDataGridViewTextBoxColumn
            // 
            this.iadeTarihiDataGridViewTextBoxColumn.DataPropertyName = "İade_Tarihi";
            this.iadeTarihiDataGridViewTextBoxColumn.HeaderText = "İade_Tarihi";
            this.iadeTarihiDataGridViewTextBoxColumn.Name = "iadeTarihiDataGridViewTextBoxColumn";
            // 
            // emanetbilBindingSource6
            // 
            this.emanetbilBindingSource6.DataMember = "emanetbil";
            this.emanetbilBindingSource6.DataSource = this.kutuphaneDBDataSet6;
            // 
            // kutuphaneDBDataSet6
            // 
            this.kutuphaneDBDataSet6.DataSetName = "KutuphaneDBDataSet6";
            this.kutuphaneDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Okuyucu ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kitap ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Veriliş Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "İade Tarihi";
            // 
            // tbOkuyucuID
            // 
            this.tbOkuyucuID.Location = new System.Drawing.Point(106, 81);
            this.tbOkuyucuID.Name = "tbOkuyucuID";
            this.tbOkuyucuID.Size = new System.Drawing.Size(126, 20);
            this.tbOkuyucuID.TabIndex = 8;
            // 
            // tbKitapID
            // 
            this.tbKitapID.Location = new System.Drawing.Point(106, 107);
            this.tbKitapID.Name = "tbKitapID";
            this.tbKitapID.Size = new System.Drawing.Size(126, 20);
            this.tbKitapID.TabIndex = 9;
            // 
            // tbVerilisTarihi
            // 
            this.tbVerilisTarihi.Location = new System.Drawing.Point(106, 134);
            this.tbVerilisTarihi.Name = "tbVerilisTarihi";
            this.tbVerilisTarihi.Size = new System.Drawing.Size(126, 20);
            this.tbVerilisTarihi.TabIndex = 10;
            // 
            // tbIadeTarihi
            // 
            this.tbIadeTarihi.Location = new System.Drawing.Point(106, 160);
            this.tbIadeTarihi.Name = "tbIadeTarihi";
            this.tbIadeTarihi.Size = new System.Drawing.Size(126, 20);
            this.tbIadeTarihi.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Düzenlenecek Emanet ID";
            // 
            // tbEmanetID
            // 
            this.tbEmanetID.Location = new System.Drawing.Point(148, 227);
            this.tbEmanetID.Name = "tbEmanetID";
            this.tbEmanetID.Size = new System.Drawing.Size(84, 20);
            this.tbEmanetID.TabIndex = 13;
            // 
            // btKaydetEmanet
            // 
            this.btKaydetEmanet.Location = new System.Drawing.Point(13, 253);
            this.btKaydetEmanet.Name = "btKaydetEmanet";
            this.btKaydetEmanet.Size = new System.Drawing.Size(177, 50);
            this.btKaydetEmanet.TabIndex = 14;
            this.btKaydetEmanet.Text = "KAYDET";
            this.btKaydetEmanet.UseVisualStyleBackColor = true;
            this.btKaydetEmanet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btGuncelleEmanet
            // 
            this.btGuncelleEmanet.Location = new System.Drawing.Point(196, 253);
            this.btGuncelleEmanet.Name = "btGuncelleEmanet";
            this.btGuncelleEmanet.Size = new System.Drawing.Size(169, 50);
            this.btGuncelleEmanet.TabIndex = 15;
            this.btGuncelleEmanet.Text = "GÜNCELLE";
            this.btGuncelleEmanet.UseVisualStyleBackColor = true;
            this.btGuncelleEmanet.Click += new System.EventHandler(this.btGuncelleEmanet_Click);
            // 
            // btSilEmanet
            // 
            this.btSilEmanet.Location = new System.Drawing.Point(371, 253);
            this.btSilEmanet.Name = "btSilEmanet";
            this.btSilEmanet.Size = new System.Drawing.Size(151, 50);
            this.btSilEmanet.TabIndex = 16;
            this.btSilEmanet.Text = "SİL";
            this.btSilEmanet.UseVisualStyleBackColor = true;
            this.btSilEmanet.Click += new System.EventHandler(this.btSilEmanet_Click);
            // 
            // btTemizleEmanet
            // 
            this.btTemizleEmanet.Location = new System.Drawing.Point(528, 253);
            this.btTemizleEmanet.Name = "btTemizleEmanet";
            this.btTemizleEmanet.Size = new System.Drawing.Size(183, 50);
            this.btTemizleEmanet.TabIndex = 17;
            this.btTemizleEmanet.Text = "TEMİZLE";
            this.btTemizleEmanet.UseVisualStyleBackColor = true;
            this.btTemizleEmanet.Click += new System.EventHandler(this.btTemizleEmanet_Click);
            // 
            // kutuphaneDBDataSet3
            // 
            this.kutuphaneDBDataSet3.DataSetName = "KutuphaneDBDataSet3";
            this.kutuphaneDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kutuphaneDBDataSet3BindingSource
            // 
            this.kutuphaneDBDataSet3BindingSource.DataSource = this.kutuphaneDBDataSet3;
            this.kutuphaneDBDataSet3BindingSource.Position = 0;
            // 
            // kutuphaneDBDataSet4
            // 
            this.kutuphaneDBDataSet4.DataSetName = "KutuphaneDBDataSet4";
            this.kutuphaneDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emanetbilBindingSource
            // 
            this.emanetbilBindingSource.DataMember = "emanetbil";
            this.emanetbilBindingSource.DataSource = this.kutuphaneDBDataSet4;
            // 
            // emanetbilTableAdapter
            // 
            this.emanetbilTableAdapter.ClearBeforeFill = true;
            // 
            // kutuphaneDBDataSet4BindingSource
            // 
            this.kutuphaneDBDataSet4BindingSource.DataSource = this.kutuphaneDBDataSet4;
            this.kutuphaneDBDataSet4BindingSource.Position = 0;
            // 
            // emanetbilBindingSource1
            // 
            this.emanetbilBindingSource1.DataMember = "emanetbil";
            this.emanetbilBindingSource1.DataSource = this.kutuphaneDBDataSet4BindingSource;
            // 
            // emanetbilBindingSource2
            // 
            this.emanetbilBindingSource2.DataMember = "emanetbil";
            this.emanetbilBindingSource2.DataSource = this.kutuphaneDBDataSet4BindingSource;
            // 
            // emanetbilBindingSource3
            // 
            this.emanetbilBindingSource3.DataMember = "emanetbil";
            this.emanetbilBindingSource3.DataSource = this.kutuphaneDBDataSet4;
            // 
            // kutuphaneDBDataSet5
            // 
            this.kutuphaneDBDataSet5.DataSetName = "KutuphaneDBDataSet5";
            this.kutuphaneDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emanetbilBindingSource4
            // 
            this.emanetbilBindingSource4.DataMember = "emanetbil";
            this.emanetbilBindingSource4.DataSource = this.kutuphaneDBDataSet5;
            // 
            // emanetbilTableAdapter1
            // 
            this.emanetbilTableAdapter1.ClearBeforeFill = true;
            // 
            // btYenileEmanet
            // 
            this.btYenileEmanet.Location = new System.Drawing.Point(253, 191);
            this.btYenileEmanet.Name = "btYenileEmanet";
            this.btYenileEmanet.Size = new System.Drawing.Size(458, 56);
            this.btYenileEmanet.TabIndex = 18;
            this.btYenileEmanet.Text = "LİSTEYİ GÜNCELLE";
            this.btYenileEmanet.UseVisualStyleBackColor = true;
            this.btYenileEmanet.Click += new System.EventHandler(this.btYenileEmanet_Click);
            // 
            // emanetbilBindingSource5
            // 
            this.emanetbilBindingSource5.DataMember = "emanetbil";
            this.emanetbilBindingSource5.DataSource = this.kutuphaneDBDataSet4BindingSource;
            // 
            // emanetbilTableAdapter2
            // 
            this.emanetbilTableAdapter2.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane_Takip_Programi.Properties.Resources.arkaplan2;
            this.ClientSize = new System.Drawing.Size(723, 315);
            this.Controls.Add(this.btYenileEmanet);
            this.Controls.Add(this.btTemizleEmanet);
            this.Controls.Add(this.btSilEmanet);
            this.Controls.Add(this.btGuncelleEmanet);
            this.Controls.Add(this.btKaydetEmanet);
            this.Controls.Add(this.tbEmanetID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIadeTarihi);
            this.Controls.Add(this.tbVerilisTarihi);
            this.Controls.Add(this.tbKitapID);
            this.Controls.Add(this.tbOkuyucuID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Emanet İşlemleri";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetbilBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kutuphaneDBDataSet3BindingSource;
        private KutuphaneDBDataSet3 kutuphaneDBDataSet3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOkuyucuID;
        private System.Windows.Forms.TextBox tbKitapID;
        private System.Windows.Forms.TextBox tbVerilisTarihi;
        private System.Windows.Forms.TextBox tbIadeTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmanetID;
        private System.Windows.Forms.Button btKaydetEmanet;
        private System.Windows.Forms.Button btGuncelleEmanet;
        private System.Windows.Forms.Button btSilEmanet;
        private System.Windows.Forms.Button btTemizleEmanet;
        private KutuphaneDBDataSet4 kutuphaneDBDataSet4;
        private System.Windows.Forms.BindingSource emanetbilBindingSource;
        private KutuphaneDBDataSet4TableAdapters.emanetbilTableAdapter emanetbilTableAdapter;
        private System.Windows.Forms.BindingSource kutuphaneDBDataSet4BindingSource;
        private System.Windows.Forms.BindingSource emanetbilBindingSource1;
        private System.Windows.Forms.BindingSource emanetbilBindingSource2;
        private System.Windows.Forms.BindingSource emanetbilBindingSource3;
        private KutuphaneDBDataSet5 kutuphaneDBDataSet5;
        private System.Windows.Forms.BindingSource emanetbilBindingSource4;
        private KutuphaneDBDataSet5TableAdapters.emanetbilTableAdapter emanetbilTableAdapter1;
        private System.Windows.Forms.Button btYenileEmanet;
        private System.Windows.Forms.BindingSource emanetbilBindingSource5;
        private KutuphaneDBDataSet6 kutuphaneDBDataSet6;
        private System.Windows.Forms.BindingSource emanetbilBindingSource6;
        private KutuphaneDBDataSet6TableAdapters.emanetbilTableAdapter emanetbilTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn otoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okuyucuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verilişTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iadeTarihiDataGridViewTextBoxColumn;
    }
}