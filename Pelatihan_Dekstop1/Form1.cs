using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAI.Chat;

namespace NaraEdu
{
    public partial class Form1 : Form
    {
        private ChatClient chatClient;
        string koneksi = "Data Source=DESKTOP-L27N0PB\\SQLEXPRESS01;Initial Catalog=smkti2026;Integrated Security=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }
        int jumlahCewek = 0;
        int jumlahCowok = 0;
        string cewek = "";
        string cowok = "";
        int total = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(koneksi))
            {
                conn.Open();
                string q1 = "select * from Siswa";
                using (SqlDataAdapter da = new SqlDataAdapter(q1, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataDgv.DataSource = dt;
                }

                string q2 = "select JenisKelamin from Siswa";
                using (SqlDataReader dr = new SqlCommand(q2, conn).ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string jenis = dr["JenisKelamin"].ToString();
                        if (jenis == "L")
                        {
                            jumlahCowok++;
                        }
                        else if (jenis == "P")
                        {
                            jumlahCewek++;
                        }

                        total = jumlahCowok + jumlahCewek;

                    }
                }

                
                TotalLbl.Text = "Total : " + total.ToString();
                SiswaLbl.Text = "Siswa : " + jumlahCowok.ToString();
                SiswiLbl.Text = "Siswi : " + jumlahCewek.ToString();

                if (DataDgv.SelectedRows.Count == 0)
                {
                    EditBtn.Enabled = false;
                    DeleteBtn.Enabled = false;
                }
                else
                {
                    EditBtn.Enabled = true;
                    DeleteBtn.Enabled = true;
                }



            }
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddDataFrmcs addDataFrmcs = new AddDataFrmcs();
            addDataFrmcs.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            SearchTxt.Text = "";
            using (SqlConnection conn = new SqlConnection(koneksi))
            {
                conn.Open();
                string q1 = "select * from Siswa";
                using (SqlDataAdapter da = new SqlDataAdapter(q1, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataDgv.DataSource = dt;
                }

                int total = 0;
                int jumlahCewek = 0;
                int jumlahCowok = 0;
                string q2 = "select JenisKelamin from Siswa";
                using (SqlDataReader dr = new SqlCommand(q2, conn).ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string jenis = dr["JenisKelamin"].ToString();
                        if (jenis == "L")
                        {
                            jumlahCowok++;
                        }
                        else if (jenis == "P")
                        {
                            jumlahCewek++;
                        }

                        total = jumlahCowok + jumlahCewek;
                    }
                }
                TotalLbl.Text = "Total : " +total.ToString();
                SiswaLbl.Text = "Siswa : " + jumlahCowok.ToString();
                SiswiLbl.Text = "Siswi : " + jumlahCewek.ToString();

                if (DataDgv.SelectedRows.Count == 0)
                {
                    EditBtn.Enabled = false;
                    DeleteBtn.Enabled = false;

                }
                else
                {
                    EditBtn.Enabled = true;
                    DeleteBtn.Enabled = true;

                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DataDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin diedit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                
                if(DataDgv.Rows.Count > 0)
                {
                    var row = DataDgv.SelectedRows[0];

                    int id = Convert.ToInt32(row.Cells["id"].Value);
                    string nisn = row.Cells["nisn"].Value.ToString();
                    string nama = row.Cells["nama"].Value.ToString();
                    string tempat = row.Cells["tempat"].Value.ToString();
                    DateTime lahir = Convert.ToDateTime(row.Cells["tanggal"].Value);
                    string kelamin = row.Cells["jenis"].Value.ToString();
                    string alamat = row.Cells["alamat"].Value.ToString();
                    string nomor = row.Cells["nomor"].Value.ToString();
                    string email = row.Cells["email"].Value.ToString();
                    int masuk = Convert.ToInt32(row.Cells["masuk"].Value);
                    int status = Convert.ToInt32(row.Cells["status"].Value);
                    string create = row.Cells["create"].Value.ToString();

                    EditDataFrm editDataFrmcs = new EditDataFrm(id, nisn, nama, tempat, lahir, kelamin, alamat, nomor, email, masuk, status, create);
                    editDataFrmcs.ShowDialog();
                }
            }
           
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchTxt.Text == "")
            {
                SearchTxt.Text = "";
                using (SqlConnection conn = new SqlConnection(koneksi))
                {
                    conn.Open();
                    string q1 = "select * from Siswa";
                    using (SqlDataAdapter da = new SqlDataAdapter(q1, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DataDgv.DataSource = dt;
                    }

                    int total = 0;
                    int jumlahCewek = 0;
                    int jumlahCowok = 0;
                    string q2 = "select JenisKelamin from Siswa";
                    using (SqlDataReader dr = new SqlCommand(q2, conn).ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string jenis = dr["JenisKelamin"].ToString();
                            if (jenis == "L")
                            {
                                jumlahCowok++;
                            }
                            else if (jenis == "P")
                            {
                                jumlahCewek++;
                            }

                            total = jumlahCowok + jumlahCewek;
                        }
                    }
                    TotalLbl.Text = "Total : " + total.ToString();
                    SiswaLbl.Text = "Siswa : " + jumlahCowok.ToString();
                    SiswiLbl.Text = "Siswi : " + jumlahCewek.ToString();

                    if (DataDgv.SelectedRows.Count == 0)
                    {
                        EditBtn.Enabled = false;
                        DeleteBtn.Enabled = false;

                    }
                    else
                    {
                        EditBtn.Enabled = true;
                        DeleteBtn.Enabled = true;

                    }

                }
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(koneksi))
                {
                    conn.Open();
                    string q1 = "select * from Siswa where SiswaID  like '%" + SearchTxt.Text + "%' or NISN  like '%" + SearchTxt.Text + "%'  or NISN  like '%" + SearchTxt.Text + "%' or NamaLengkap  like '%" + SearchTxt.Text + "%' or TempatLahir  like '%" + SearchTxt.Text + "%' or TanggalLahir  like '%" + SearchTxt.Text + "%' or JenisKelamin  like '%" + SearchTxt.Text + "%' or Alamat   like '%" + SearchTxt.Text + "%' or NomorHP  like '%" + SearchTxt.Text + "%' or Email  like '%" + SearchTxt.Text + "%' or TahunMasuk  like '%" + SearchTxt.Text + "%' or IsAktif   like '%" + SearchTxt.Text + "%' or CreatedAt   like '%" + SearchTxt.Text + "%' or UpdatedAt  like '%" + SearchTxt.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(q1, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DataDgv.DataSource = dt;
                    }
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (DataDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                if (DataDgv.Rows.Count > 0)
                {
                    if(MessageBox.Show("Anda yakin ingin menghapus data ini?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                       
                        int id = Convert.ToInt32(DataDgv.SelectedRows[0].Cells["id"].Value);
                        using (SqlConnection conn = new SqlConnection(koneksi))
                        {
                            conn.Open();
                            string q1 = "delete from Siswa where SiswaID = " + id + "";
                            using (SqlCommand cmd = new SqlCommand(q1, conn))
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Data Berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                    else
                    {
                        return;
                    }

                    
                }
            }
        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (SearchTxt.Text == "")
                {
                    SearchTxt.Text = "";
                    using (SqlConnection conn = new SqlConnection(koneksi))
                    {
                        conn.Open();
                        string q1 = "select * from Siswa";
                        using (SqlDataAdapter da = new SqlDataAdapter(q1, conn))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            DataDgv.DataSource = dt;
                        }

                        int total = 0;
                        int jumlahCewek = 0;
                        int jumlahCowok = 0;
                        string q2 = "select JenisKelamin from Siswa";
                        using (SqlDataReader dr = new SqlCommand(q2, conn).ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string jenis = dr["JenisKelamin"].ToString();
                                if (jenis == "L")
                                {
                                    jumlahCowok++;
                                }
                                else if (jenis == "P")
                                {
                                    jumlahCewek++;
                                }

                                total = jumlahCowok + jumlahCewek;
                            }
                        }
                        TotalLbl.Text = "Total : " + total.ToString();
                        SiswaLbl.Text = "Siswa : " + jumlahCowok.ToString();
                        SiswiLbl.Text = "Siswi : " + jumlahCewek.ToString();

                        if (DataDgv.SelectedRows.Count == 0)
                        {
                            EditBtn.Enabled = false;
                            DeleteBtn.Enabled = false;

                        }
                        else
                        {
                            EditBtn.Enabled = true;
                            DeleteBtn.Enabled = true;

                        }

                    }
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(koneksi))
                    {
                        conn.Open();
                        string q1 = "select * from Siswa where SiswaID  like '%" + SearchTxt.Text + "%' or NISN  like '%" + SearchTxt.Text + "%'  or NISN  like '%" + SearchTxt.Text + "%' or NamaLengkap  like '%" + SearchTxt.Text + "%' or TempatLahir  like '%" + SearchTxt.Text + "%' or TanggalLahir  like '%" + SearchTxt.Text + "%' or JenisKelamin  like '%" + SearchTxt.Text + "%' or Alamat   like '%" + SearchTxt.Text + "%' or NomorHP  like '%" + SearchTxt.Text + "%' or Email  like '%" + SearchTxt.Text + "%' or TahunMasuk  like '%" + SearchTxt.Text + "%' or IsAktif   like '%" + SearchTxt.Text + "%' or CreatedAt   like '%" + SearchTxt.Text + "%' or UpdatedAt  like '%" + SearchTxt.Text + "%'";
                        using (SqlDataAdapter da = new SqlDataAdapter(q1, conn))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            DataDgv.DataSource = dt;
                        }
                    }
                }
            }else if (e.Control && e.KeyCode == Keys.T)
            {
                AddDataFrmcs addDataFrmcs = new AddDataFrmcs();
                addDataFrmcs.ShowDialog();

            }else if (e.Control && e.KeyCode == Keys.Back)
            {
                MessageBox.Show("Pilih data yang ingin dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                MessageBox.Show("Pilih data yang ingin diedit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (e.Control && e.KeyCode == Keys.Tab)
            {
                DataDgv.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                SearchTxt.Text = "";
                using (SqlConnection conn = new SqlConnection(koneksi))
                {
                    conn.Open();
                    string q1 = "select * from Siswa";
                    using (SqlDataAdapter da = new SqlDataAdapter(q1, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DataDgv.DataSource = dt;
                    }

                    int total = 0;
                    int jumlahCewek = 0;
                    int jumlahCowok = 0;
                    string q2 = "select JenisKelamin from Siswa";
                    using (SqlDataReader dr = new SqlCommand(q2, conn).ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string jenis = dr["JenisKelamin"].ToString();
                            if (jenis == "L")
                            {
                                jumlahCowok++;
                            }
                            else if (jenis == "P")
                            {
                                jumlahCewek++;
                            }

                            total = jumlahCowok + jumlahCewek;
                        }
                    }
                    TotalLbl.Text = "Total : " + total.ToString();
                    SiswaLbl.Text = "Siswa : " + jumlahCowok.ToString();
                    SiswiLbl.Text = "Siswi : " + jumlahCewek.ToString();

                    if (DataDgv.SelectedRows.Count == 0)
                    {
                        EditBtn.Enabled = false;
                        DeleteBtn.Enabled = false;

                    }
                    else
                    {
                        EditBtn.Enabled = true;
                        DeleteBtn.Enabled = true;

                    }

                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void DataDgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
                if (DataDgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih data yang ingin diedit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    if (DataDgv.Rows.Count > 0)
                    {
                        var row = DataDgv.SelectedRows[0];

                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        string nisn = row.Cells["nisn"].Value.ToString();
                        string nama = row.Cells["nama"].Value.ToString();
                        string tempat = row.Cells["tempat"].Value.ToString();
                        DateTime lahir = Convert.ToDateTime(row.Cells["tanggal"].Value);
                        string kelamin = row.Cells["jenis"].Value.ToString();
                        string alamat = row.Cells["alamat"].Value.ToString();
                        string nomor = row.Cells["nomor"].Value.ToString();
                        string email = row.Cells["email"].Value.ToString();
                        int masuk = Convert.ToInt32(row.Cells["masuk"].Value);
                        int status = Convert.ToInt32(row.Cells["status"].Value);
                        string create = row.Cells["create"].Value.ToString();

                        EditDataFrm editDataFrmcs = new EditDataFrm(id, nisn, nama, tempat, lahir, kelamin, alamat, nomor, email, masuk, status, create);
                        editDataFrmcs.ShowDialog();
                    }
                }
            }
            else if (e.Control && e.KeyCode == Keys.Back)
            {
                if (DataDgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih data yang ingin dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    if (DataDgv.Rows.Count > 0)
                    {
                        if (MessageBox.Show("Anda yakin ingin menghapus data ini?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {

                            int id = Convert.ToInt32(DataDgv.SelectedRows[0].Cells["id"].Value);
                            using (SqlConnection conn = new SqlConnection(koneksi))
                            {
                                conn.Open();
                                string q1 = "delete from Siswa where SiswaID = " + id + "";
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                        }
                        else
                        {
                            return;
                        }


                    }
                }
            }
            else if (e.Control && e.KeyCode == Keys.T)
            {
                AddDataFrmcs addDataFrmcs = new AddDataFrmcs();
                addDataFrmcs.ShowDialog();
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                SearchTxt.Text = "";
                using (SqlConnection conn = new SqlConnection(koneksi))
                {
                    conn.Open();
                    string q1 = "select * from Siswa";
                    using (SqlDataAdapter da = new SqlDataAdapter(q1, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DataDgv.DataSource = dt;
                    }

                    int total = 0;
                    int jumlahCewek = 0;
                    int jumlahCowok = 0;
                    string q2 = "select JenisKelamin from Siswa";
                    using (SqlDataReader dr = new SqlCommand(q2, conn).ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string jenis = dr["JenisKelamin"].ToString();
                            if (jenis == "L")
                            {
                                jumlahCowok++;
                            }
                            else if (jenis == "P")
                            {
                                jumlahCewek++;
                            }

                            total = jumlahCowok + jumlahCewek;
                        }
                    }
                    TotalLbl.Text = "Total : " + total.ToString();
                    SiswaLbl.Text = "Siswa : " + jumlahCowok.ToString();
                    SiswiLbl.Text = "Siswi : " + jumlahCewek.ToString();

                    if (DataDgv.SelectedRows.Count == 0)
                    {
                        EditBtn.Enabled = false;
                        DeleteBtn.Enabled = false;

                    }
                    else
                    {
                        EditBtn.Enabled = true;
                        DeleteBtn.Enabled = true;

                    }

                }
            }
            else if (e.Control && e.KeyCode == Keys.Tab)
            {
                SearchTxt.Focus();
            }else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void AiBtn_Click(object sender, EventArgs e)
        {
            AIFrm aIFrm = new AIFrm();
            aIFrm.ShowDialog();
        }
    }
}
