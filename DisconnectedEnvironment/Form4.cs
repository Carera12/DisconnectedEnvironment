using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedEnvironment
{
    public partial class Form4 : Form
    {
        private string stringConnection = "Data Source=RARAIMUT\\CANDRARAKU;Initial Catalog=Aktivity6PABD;Persist Security Info=True;User ID=sa;Password=Rera1234";
        private SqlConnection koneksi;
        

        public Form4()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.status_mahasiswa";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void cbNama()
        {
            koneksi.Open();
            string str = "SELECT nama_mahasiswa FROM mahasiswa";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxNama.DisplayMember = "nama_mahasiswa";
            cbxNama.ValueMember = "nim";
            cbxNama.DataSource = ds.Tables[0];
        }
        private void cbTahunMasuk()
        {
            int y = DateTime.Now.Year - 2010;
            string[] type = new string[y];
            int i = 0;
            for (i = 0; i - 1 < type.Length; i++)
            {
                if (i == 0)
                {
                    cbxTahunMasuk.Items.Add("2010");
                }
                else
                {
                    int l = 2010 + i;
                    cbxTahunMasuk.Items.Add(l.ToString());
                }
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aktivity6PABDDataSet.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.aktivity6PABDDataSet.mahasiswa);

        }

        private void cbxNama_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string nim = "";
            string strs = "select nim from dbo.mahasiswa where nama_mahasiswa = @nm";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@nm", NamaMahasiswa.Text));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                nim = dr["nim"].ToString();
            }
            dr.Close();
            koneksi.Close();
            txtNIM.Text = nim;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxTahunMasuk.Enabled = true;
            cbxNama.Enabled = true;
            cbxStatusMahasiswa.Enabled = true;
            txtNIM.Visible = true;
            cbTahunMasuk();
            cbNama();
            btnClear.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nim = txtNIM.Text;
            string statusMahasiswa = cbxStatusMahasiswa.SelectedItem.ToString();
            string tahunMasuk = cbxTahunMasuk.SelectedItem.ToString();

            int count = 0;
            string tempKodeStatus = "";
            string kodeStatus = "";

            koneksi.Open();
            string query = "SELECT COUNT(*) FROM status_mahasiswa";
            SqlCommand command = new SqlCommand(query, koneksi);
            count = (int)command.ExecuteScalar();

            if (count == 0)
            {
                kodeStatus = "1";
            }
            else
            {
                query = "SELECT TOP 1 id_status FROM status_mahasiswa ORDER BY id_status DESC";
                command = new SqlCommand(query, koneksi);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tempKodeStatus = reader.GetString(0);
                }
                reader.Close();

                int tempKode = int.Parse(tempKodeStatus);
                tempKode++;
                kodeStatus = tempKode.ToString();
            }

            query = "INSERT INTO status_mahasiswa (id_status, nim, status_mhs, tahun_masuk) VALUES (@id_status, @nim, @status_mahasiswa, @tahun_masuk)";
            command = new SqlCommand(query, koneksi);
            command.Parameters.AddWithValue("@id_status", kodeStatus);
            command.Parameters.AddWithValue("@nim", nim);
            command.Parameters.AddWithValue("@status_mahasiswa", statusMahasiswa);
            command.Parameters.AddWithValue("@tahun_masuk", tahunMasuk);
            command.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan");

            refreshform();
            dataGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        
        private void refreshform()
        {
            cbxNama.Enabled = false;
            cbxStatusMahasiswa.Enabled = false;
            cbxTahunMasuk.Enabled = false;
            cbxNama.SelectedIndex = -1;
            cbxStatusMahasiswa.SelectedIndex = -1;
            cbxTahunMasuk.SelectedIndex = -1;
            txtNIM.Visible = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void cbxNama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxStatusMahasiswa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxTahunMasuk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void NIM_Click(object sender, EventArgs e)
        {

        }

        private void StatusMahasiswa_Click(object sender, EventArgs e)
        {

        }

        private void TahunMasuk_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
