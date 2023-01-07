namespace Kutuphane_Takip_Programi
{
    partial class Form5
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
            this.tbIDSifre = new System.Windows.Forms.TextBox();
            this.tbYeniSifreSifre = new System.Windows.Forms.TextBox();
            this.btKaydetSifre = new System.Windows.Forms.Button();
            this.SifredataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDBDataSet7 = new Kutuphane_Takip_Programi.KutuphaneDBDataSet7();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDBDataSet3 = new Kutuphane_Takip_Programi.KutuphaneDBDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.kullaniciTableAdapter = new Kutuphane_Takip_Programi.KutuphaneDBDataSet3TableAdapters.kullaniciTableAdapter();
            this.kullaniciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTableAdapter1 = new Kutuphane_Takip_Programi.KutuphaneDBDataSet7TableAdapters.kullaniciTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SifredataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜYELİK İŞLEMLERİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yeni Şifre";
            // 
            // tbIDSifre
            // 
            this.tbIDSifre.Location = new System.Drawing.Point(95, 85);
            this.tbIDSifre.Name = "tbIDSifre";
            this.tbIDSifre.Size = new System.Drawing.Size(177, 20);
            this.tbIDSifre.TabIndex = 3;
            // 
            // tbYeniSifreSifre
            // 
            this.tbYeniSifreSifre.Location = new System.Drawing.Point(95, 133);
            this.tbYeniSifreSifre.Name = "tbYeniSifreSifre";
            this.tbYeniSifreSifre.Size = new System.Drawing.Size(177, 20);
            this.tbYeniSifreSifre.TabIndex = 4;
            // 
            // btKaydetSifre
            // 
            this.btKaydetSifre.Location = new System.Drawing.Point(158, 181);
            this.btKaydetSifre.Name = "btKaydetSifre";
            this.btKaydetSifre.Size = new System.Drawing.Size(114, 50);
            this.btKaydetSifre.TabIndex = 7;
            this.btKaydetSifre.Text = "Şifre Güncelle";
            this.btKaydetSifre.UseVisualStyleBackColor = true;
            this.btKaydetSifre.Click += new System.EventHandler(this.btKaydetSifre_Click_1);
            // 
            // SifredataGridView1
            // 
            this.SifredataGridView1.AutoGenerateColumns = false;
            this.SifredataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SifredataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.kadiDataGridViewTextBoxColumn});
            this.SifredataGridView1.DataSource = this.kullaniciBindingSource2;
            this.SifredataGridView1.Location = new System.Drawing.Point(320, 19);
            this.SifredataGridView1.Name = "SifredataGridView1";
            this.SifredataGridView1.Size = new System.Drawing.Size(297, 157);
            this.SifredataGridView1.TabIndex = 9;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            // 
            // kadiDataGridViewTextBoxColumn
            // 
            this.kadiDataGridViewTextBoxColumn.DataPropertyName = "k_adi";
            this.kadiDataGridViewTextBoxColumn.HeaderText = "k_adi";
            this.kadiDataGridViewTextBoxColumn.Name = "kadiDataGridViewTextBoxColumn";
            // 
            // kullaniciBindingSource2
            // 
            this.kullaniciBindingSource2.DataMember = "kullanici";
            this.kullaniciBindingSource2.DataSource = this.kutuphaneDBDataSet7;
            // 
            // kutuphaneDBDataSet7
            // 
            this.kutuphaneDBDataSet7.DataSetName = "KutuphaneDBDataSet7";
            this.kutuphaneDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "kullanici";
            this.kullaniciBindingSource.DataSource = this.kutuphaneDBDataSet3;
            // 
            // kutuphaneDBDataSet3
            // 
            this.kutuphaneDBDataSet3.DataSetName = "KutuphaneDBDataSet3";
            this.kutuphaneDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "LİSTELE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciBindingSource1
            // 
            this.kullaniciBindingSource1.DataMember = "kullanici";
            this.kullaniciBindingSource1.DataSource = this.kutuphaneDBDataSet3;
            // 
            // kullaniciTableAdapter1
            // 
            this.kullaniciTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 49);
            this.button2.TabIndex = 12;
            this.button2.Text = "Yeni Üye Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane_Takip_Programi.Properties.Resources.arkaplan2;
            this.ClientSize = new System.Drawing.Size(629, 243);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SifredataGridView1);
            this.Controls.Add(this.btKaydetSifre);
            this.Controls.Add(this.tbYeniSifreSifre);
            this.Controls.Add(this.tbIDSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Şifre Değişikliği";
            this.Load += new System.EventHandler(this.Form5_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.SifredataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIDSifre;
        private System.Windows.Forms.TextBox tbYeniSifreSifre;
        private System.Windows.Forms.Button btKaydetSifre;
        private System.Windows.Forms.DataGridView SifredataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private KutuphaneDBDataSet3 kutuphaneDBDataSet3;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private KutuphaneDBDataSet3TableAdapters.kullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.BindingSource kullaniciBindingSource1;
        private KutuphaneDBDataSet7 kutuphaneDBDataSet7;
        private System.Windows.Forms.BindingSource kullaniciBindingSource2;
        private KutuphaneDBDataSet7TableAdapters.kullaniciTableAdapter kullaniciTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}