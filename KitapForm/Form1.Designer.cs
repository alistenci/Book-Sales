namespace KitapForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblYazar = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbKategori = new ComboBox();
            txtKitapAdi = new TextBox();
            txtYazar = new TextBox();
            cmbYayinevi = new ComboBox();
            txtSayfa = new TextBox();
            Kitaplar = new ListBox();
            btnSatis = new Button();
            label2 = new Label();
            txtFiyat = new TextBox();
            lblToplam = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori";
            // 
            // lblYazar
            // 
            lblYazar.AutoSize = true;
            lblYazar.Location = new Point(188, 78);
            lblYazar.Name = "lblYazar";
            lblYazar.Size = new Size(58, 15);
            lblYazar.TabIndex = 1;
            lblYazar.Text = "Kitap Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 130);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Yazarı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 176);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Yayınevi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 222);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Sayfa Sayısı";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(275, 33);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(213, 23);
            cmbKategori.TabIndex = 5;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(275, 78);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(213, 23);
            txtKitapAdi.TabIndex = 6;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(275, 127);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(213, 23);
            txtYazar.TabIndex = 7;
            // 
            // cmbYayinevi
            // 
            cmbYayinevi.FormattingEnabled = true;
            cmbYayinevi.Location = new Point(275, 176);
            cmbYayinevi.Name = "cmbYayinevi";
            cmbYayinevi.Size = new Size(213, 23);
            cmbYayinevi.TabIndex = 8;
            cmbYayinevi.SelectedIndexChanged += cmbYayinevi_SelectedIndexChanged;
            // 
            // txtSayfa
            // 
            txtSayfa.Location = new Point(275, 219);
            txtSayfa.Name = "txtSayfa";
            txtSayfa.Size = new Size(213, 23);
            txtSayfa.TabIndex = 9;
            // 
            // Kitaplar
            // 
            Kitaplar.FormattingEnabled = true;
            Kitaplar.ItemHeight = 15;
            Kitaplar.Location = new Point(576, 33);
            Kitaplar.Name = "Kitaplar";
            Kitaplar.Size = new Size(604, 244);
            Kitaplar.TabIndex = 10;
            // 
            // btnSatis
            // 
            btnSatis.Location = new Point(275, 310);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(213, 47);
            btnSatis.TabIndex = 11;
            btnSatis.Text = "Satış Yap";
            btnSatis.UseVisualStyleBackColor = true;
            btnSatis.Click += btnSatis_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 271);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 12;
            label2.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(275, 268);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(213, 23);
            txtFiyat.TabIndex = 13;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(576, 326);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(89, 15);
            lblToplam.TabIndex = 14;
            lblToplam.Text = "Sipariş Toplamı:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 537);
            Controls.Add(lblToplam);
            Controls.Add(txtFiyat);
            Controls.Add(label2);
            Controls.Add(btnSatis);
            Controls.Add(Kitaplar);
            Controls.Add(txtSayfa);
            Controls.Add(cmbYayinevi);
            Controls.Add(txtYazar);
            Controls.Add(txtKitapAdi);
            Controls.Add(cmbKategori);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblYazar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblYazar;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbKategori;
        private TextBox txtKitapAdi;
        private TextBox txtYazar;
        private ComboBox cmbYayinevi;
        private TextBox txtSayfa;
        private ListBox Kitaplar;
        private Button btnSatis;
        private Label label2;
        private TextBox txtFiyat;
        private Label lblToplam;
    }
}