namespace ScriptCreate___Trend
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.RB_WRITE = new System.Windows.Forms.RadioButton();
            this.RB_READ = new System.Windows.Forms.RadioButton();
            this.TB_Class_ValueSet = new System.Windows.Forms.RichTextBox();
            this.TB_Status = new System.Windows.Forms.RichTextBox();
            this.CB_Sayfa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_DosyaYolu = new System.Windows.Forms.TextBox();
            this.B_ClassOlustur = new System.Windows.Forms.Button();
            this.B_DosyaAc = new System.Windows.Forms.Button();
            this.B_DosyaSec = new System.Windows.Forms.Button();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.CHB_ilksatir = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // RB_WRITE
            // 
            this.RB_WRITE.AutoSize = true;
            this.RB_WRITE.Enabled = false;
            this.RB_WRITE.Location = new System.Drawing.Point(1166, 14);
            this.RB_WRITE.Name = "RB_WRITE";
            this.RB_WRITE.Size = new System.Drawing.Size(61, 17);
            this.RB_WRITE.TabIndex = 23;
            this.RB_WRITE.Text = "WRITE";
            this.RB_WRITE.UseVisualStyleBackColor = true;
            // 
            // RB_READ
            // 
            this.RB_READ.AutoSize = true;
            this.RB_READ.Checked = true;
            this.RB_READ.Location = new System.Drawing.Point(1092, 14);
            this.RB_READ.Name = "RB_READ";
            this.RB_READ.Size = new System.Drawing.Size(55, 17);
            this.RB_READ.TabIndex = 22;
            this.RB_READ.TabStop = true;
            this.RB_READ.Text = "READ";
            this.RB_READ.UseVisualStyleBackColor = true;
            // 
            // TB_Class_ValueSet
            // 
            this.TB_Class_ValueSet.Location = new System.Drawing.Point(6, 360);
            this.TB_Class_ValueSet.Name = "TB_Class_ValueSet";
            this.TB_Class_ValueSet.ReadOnly = true;
            this.TB_Class_ValueSet.Size = new System.Drawing.Size(1360, 365);
            this.TB_Class_ValueSet.TabIndex = 20;
            this.TB_Class_ValueSet.Text = ".";
            // 
            // TB_Status
            // 
            this.TB_Status.Location = new System.Drawing.Point(7, 728);
            this.TB_Status.Name = "TB_Status";
            this.TB_Status.ReadOnly = true;
            this.TB_Status.Size = new System.Drawing.Size(1362, 20);
            this.TB_Status.TabIndex = 19;
            this.TB_Status.Text = "";
            // 
            // CB_Sayfa
            // 
            this.CB_Sayfa.FormattingEnabled = true;
            this.CB_Sayfa.Location = new System.Drawing.Point(530, 12);
            this.CB_Sayfa.Name = "CB_Sayfa";
            this.CB_Sayfa.Size = new System.Drawing.Size(177, 21);
            this.CB_Sayfa.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "VALUE SET";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dosya";
            // 
            // TB_DosyaYolu
            // 
            this.TB_DosyaYolu.Location = new System.Drawing.Point(42, 12);
            this.TB_DosyaYolu.Name = "TB_DosyaYolu";
            this.TB_DosyaYolu.Size = new System.Drawing.Size(249, 20);
            this.TB_DosyaYolu.TabIndex = 12;
            this.TB_DosyaYolu.Text = "C:\\DB96.xls";
            // 
            // B_ClassOlustur
            // 
            this.B_ClassOlustur.Location = new System.Drawing.Point(1233, 8);
            this.B_ClassOlustur.Name = "B_ClassOlustur";
            this.B_ClassOlustur.Size = new System.Drawing.Size(136, 28);
            this.B_ClassOlustur.TabIndex = 10;
            this.B_ClassOlustur.Text = "CLASS OLUŞTUR";
            this.B_ClassOlustur.UseVisualStyleBackColor = true;
            this.B_ClassOlustur.Click += new System.EventHandler(this.B_ClassOlustur_Click);
            // 
            // B_DosyaAc
            // 
            this.B_DosyaAc.Location = new System.Drawing.Point(354, 11);
            this.B_DosyaAc.Name = "B_DosyaAc";
            this.B_DosyaAc.Size = new System.Drawing.Size(173, 23);
            this.B_DosyaAc.TabIndex = 9;
            this.B_DosyaAc.Text = "Secilli Excel Dosyasını Aç";
            this.B_DosyaAc.UseVisualStyleBackColor = true;
            this.B_DosyaAc.Click += new System.EventHandler(this.B_DosyaAc_Click);
            // 
            // B_DosyaSec
            // 
            this.B_DosyaSec.Location = new System.Drawing.Point(297, 11);
            this.B_DosyaSec.Name = "B_DosyaSec";
            this.B_DosyaSec.Size = new System.Drawing.Size(54, 23);
            this.B_DosyaSec.TabIndex = 11;
            this.B_DosyaSec.Text = "Seç";
            this.B_DosyaSec.UseVisualStyleBackColor = true;
            this.B_DosyaSec.Click += new System.EventHandler(this.B_DosyaSec_Click);
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(5, 37);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(1364, 295);
            this.DGV1.TabIndex = 8;
            // 
            // CHB_ilksatir
            // 
            this.CHB_ilksatir.AutoSize = true;
            this.CHB_ilksatir.Checked = true;
            this.CHB_ilksatir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHB_ilksatir.Location = new System.Drawing.Point(714, 14);
            this.CHB_ilksatir.Name = "CHB_ilksatir";
            this.CHB_ilksatir.Size = new System.Drawing.Size(102, 17);
            this.CHB_ilksatir.TabIndex = 24;
            this.CHB_ilksatir.Text = "İlk satır tablo adı";
            this.CHB_ilksatir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 758);
            this.Controls.Add(this.CHB_ilksatir);
            this.Controls.Add(this.RB_WRITE);
            this.Controls.Add(this.RB_READ);
            this.Controls.Add(this.TB_Class_ValueSet);
            this.Controls.Add(this.TB_Status);
            this.Controls.Add(this.CB_Sayfa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_DosyaYolu);
            this.Controls.Add(this.B_ClassOlustur);
            this.Controls.Add(this.B_DosyaAc);
            this.Controls.Add(this.B_DosyaSec);
            this.Controls.Add(this.DGV1);
            this.Name = "Form1";
            this.Text = "ID TOOLS - WinCC Trend Scripti Oluşturma Programı";
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RB_WRITE;
        private System.Windows.Forms.RadioButton RB_READ;
        private System.Windows.Forms.RichTextBox TB_Class_ValueSet;
        private System.Windows.Forms.RichTextBox TB_Status;
        private System.Windows.Forms.ComboBox CB_Sayfa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_DosyaYolu;
        private System.Windows.Forms.Button B_ClassOlustur;
        private System.Windows.Forms.Button B_DosyaAc;
        private System.Windows.Forms.Button B_DosyaSec;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.CheckBox CHB_ilksatir;
    }
}

