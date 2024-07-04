namespace OOP_Movie_App
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kitap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mevcut_filmler = new System.Windows.Forms.ListBox();
            this.ad_tb = new System.Windows.Forms.TextBox();
            this.soyad_tb = new System.Windows.Forms.TextBox();
            this.gun_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kirala_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.kiralıikçkr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kitap,
            this.Kisi,
            this.Sure});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(392, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(449, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Kitap
            // 
            this.Kitap.HeaderText = "Kitap";
            this.Kitap.MinimumWidth = 6;
            this.Kitap.Name = "Kitap";
            this.Kitap.ReadOnly = true;
            this.Kitap.Width = 125;
            // 
            // Kisi
            // 
            this.Kisi.HeaderText = "Kisi";
            this.Kisi.MinimumWidth = 6;
            this.Kisi.Name = "Kisi";
            this.Kisi.ReadOnly = true;
            this.Kisi.Width = 125;
            // 
            // Sure
            // 
            this.Sure.HeaderText = "Tutar";
            this.Sure.MinimumWidth = 6;
            this.Sure.Name = "Sure";
            this.Sure.ReadOnly = true;
            this.Sure.Width = 125;
            // 
            // mevcut_filmler
            // 
            this.mevcut_filmler.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mevcut_filmler.BackColor = System.Drawing.SystemColors.Info;
            this.mevcut_filmler.FormattingEnabled = true;
            this.mevcut_filmler.ItemHeight = 16;
            this.mevcut_filmler.Location = new System.Drawing.Point(12, 67);
            this.mevcut_filmler.Name = "mevcut_filmler";
            this.mevcut_filmler.Size = new System.Drawing.Size(374, 660);
            this.mevcut_filmler.TabIndex = 1;
            this.mevcut_filmler.SelectedIndexChanged += new System.EventHandler(this.mevcut_filmler_SelectedIndexChanged);
            // 
            // ad_tb
            // 
            this.ad_tb.BackColor = System.Drawing.Color.Wheat;
            this.ad_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ad_tb.Location = new System.Drawing.Point(483, 463);
            this.ad_tb.Name = "ad_tb";
            this.ad_tb.Size = new System.Drawing.Size(111, 22);
            this.ad_tb.TabIndex = 2;
            this.ad_tb.TextChanged += new System.EventHandler(this.ad_tb_TextChanged);
            // 
            // soyad_tb
            // 
            this.soyad_tb.BackColor = System.Drawing.Color.Wheat;
            this.soyad_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soyad_tb.Location = new System.Drawing.Point(653, 463);
            this.soyad_tb.Name = "soyad_tb";
            this.soyad_tb.Size = new System.Drawing.Size(111, 22);
            this.soyad_tb.TabIndex = 3;
            // 
            // gun_tb
            // 
            this.gun_tb.BackColor = System.Drawing.Color.Wheat;
            this.gun_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gun_tb.Location = new System.Drawing.Point(572, 529);
            this.gun_tb.Name = "gun_tb";
            this.gun_tb.Size = new System.Drawing.Size(111, 22);
            this.gun_tb.TabIndex = 4;
            this.gun_tb.TextChanged += new System.EventHandler(this.gun_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adınız";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadınız";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kiralamak istediğiniz gün";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // kirala_btn
            // 
            this.kirala_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.kirala_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kirala_btn.Location = new System.Drawing.Point(449, 610);
            this.kirala_btn.Name = "kirala_btn";
            this.kirala_btn.Size = new System.Drawing.Size(111, 38);
            this.kirala_btn.TabIndex = 9;
            this.kirala_btn.Text = "Kirala";
            this.kirala_btn.UseVisualStyleBackColor = false;
            this.kirala_btn.Click += new System.EventHandler(this.kirala_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(63, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 39);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Listedeki Filmler";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(483, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 39);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Kiralanan Filmler";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // kiralıikçkr
            // 
            this.kiralıikçkr.BackColor = System.Drawing.Color.LightCoral;
            this.kiralıikçkr.Location = new System.Drawing.Point(576, 610);
            this.kiralıikçkr.Name = "kiralıikçkr";
            this.kiralıikçkr.Size = new System.Drawing.Size(107, 38);
            this.kiralıikçkr.TabIndex = 12;
            this.kiralıikçkr.Text = "Kiralıktan Çıkar";
            this.kiralıikçkr.UseVisualStyleBackColor = false;
            this.kiralıikçkr.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(912, 760);
            this.Controls.Add(this.kiralıikçkr);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kirala_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gun_tb);
            this.Controls.Add(this.soyad_tb);
            this.Controls.Add(this.ad_tb);
            this.Controls.Add(this.mevcut_filmler);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox mevcut_filmler;
        private System.Windows.Forms.TextBox ad_tb;
        private System.Windows.Forms.TextBox soyad_tb;
        private System.Windows.Forms.TextBox gun_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kirala_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button kiralıikçkr;
    }
}

