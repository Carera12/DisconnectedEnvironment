namespace DisconnectedEnvironment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusMahasiswa = new System.Windows.Forms.Label();
            this.NamaMahasiswa = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.Label();
            this.TahunMasuk = new System.Windows.Forms.Label();
            this.cbxTahunMasuk = new System.Windows.Forms.ComboBox();
            this.cbxStatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.NIM = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(467, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // StatusMahasiswa
            // 
            this.StatusMahasiswa.AutoSize = true;
            this.StatusMahasiswa.Location = new System.Drawing.Point(182, 342);
            this.StatusMahasiswa.Name = "StatusMahasiswa";
            this.StatusMahasiswa.Size = new System.Drawing.Size(115, 16);
            this.StatusMahasiswa.TabIndex = 1;
            this.StatusMahasiswa.Text = "Status mahasiswa";
            this.StatusMahasiswa.Click += new System.EventHandler(this.StatusMahasiswa_Click);
            // 
            // NamaMahasiswa
            // 
            this.NamaMahasiswa.AutoSize = true;
            this.NamaMahasiswa.Location = new System.Drawing.Point(182, 266);
            this.NamaMahasiswa.Name = "NamaMahasiswa";
            this.NamaMahasiswa.Size = new System.Drawing.Size(115, 16);
            this.NamaMahasiswa.TabIndex = 2;
            this.NamaMahasiswa.Text = "Nama Mahasiswa";
            this.NamaMahasiswa.Click += new System.EventHandler(this.cbxNama_Click);
            // 
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.Location = new System.Drawing.Point(371, 304);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(43, 16);
            this.txtNIM.TabIndex = 3;
            this.txtNIM.Text = "txtNIM";
            this.txtNIM.Click += new System.EventHandler(this.label3_Click);
            // 
            // TahunMasuk
            // 
            this.TahunMasuk.AutoSize = true;
            this.TahunMasuk.Location = new System.Drawing.Point(182, 380);
            this.TahunMasuk.Name = "TahunMasuk";
            this.TahunMasuk.Size = new System.Drawing.Size(88, 16);
            this.TahunMasuk.TabIndex = 4;
            this.TahunMasuk.Text = "Tahun Masuk";
            this.TahunMasuk.Click += new System.EventHandler(this.TahunMasuk_Click);
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.FormattingEnabled = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(374, 380);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(121, 24);
            this.cbxTahunMasuk.TabIndex = 5;
            this.cbxTahunMasuk.SelectedIndexChanged += new System.EventHandler(this.cbxTahunMasuk_SelectedIndexChanged);
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.FormattingEnabled = true;
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(374, 342);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(121, 24);
            this.cbxStatusMahasiswa.TabIndex = 6;
            this.cbxStatusMahasiswa.SelectedIndexChanged += new System.EventHandler(this.cbxStatusMahasiswa_SelectedIndexChanged);
            // 
            // cbxNama
            // 
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Location = new System.Drawing.Point(374, 266);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(121, 24);
            this.cbxNama.TabIndex = 7;
            this.cbxNama.SelectedIndexChanged += new System.EventHandler(this.cbxNama_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(557, 326);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(557, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(640, 49);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(58, 33);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(557, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(182, 304);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(154, 16);
            this.NIM.TabIndex = 12;
            this.NIM.Text = "Nomer Induk Mahasiswa";
            this.NIM.Click += new System.EventHandler(this.NIM_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.TahunMasuk);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.NamaMahasiswa);
            this.Controls.Add(this.StatusMahasiswa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Data Status Mahasiswa";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label StatusMahasiswa;
        private System.Windows.Forms.Label NamaMahasiswa;
        private System.Windows.Forms.Label txtNIM;
        private System.Windows.Forms.Label TahunMasuk;
        private System.Windows.Forms.ComboBox cbxTahunMasuk;
        private System.Windows.Forms.ComboBox cbxStatusMahasiswa;
        private System.Windows.Forms.ComboBox cbxNama;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Button button1;
    }
}