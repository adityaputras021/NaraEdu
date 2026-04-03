using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace NaraEdu
{
    public partial class AIFrm : Form
    {
        private static readonly HttpClient client = new HttpClient();

        string schemaTabel = @"CREATE TABLE Siswa (
		SiswaID INT IDENTITY(1,1) PRIMARY KEY, 
		NISN CHAR(10) NOT NULL UNIQUE,
		NamaLengkap NVARCHAR(100) NOT NULL,   
		TempatLahir NVARCHAR(50),
		TanggalLahir DATE,
		JenisKelamin CHAR(1) CHECK (JenisKelamin IN ('L', 'P')),
		Alamat NVARCHAR(MAX),  
		NomorHP VARCHAR(15),
		Email VARCHAR(100) UNIQUE,
		TahunMasuk INT,
		IsAktif BIT DEFAULT 1,     
		CreatedAt DATETIME DEFAULT GETDATE(), 
		UpdatedAt DATETIME DEFAULT GETDATE()
	);";

        string koneksi = "Data Source=DESKTOP-L27N0PB\\SQLEXPRESS01;Initial Catalog=smkti2026;Integrated Security=True;TrustServerCertificate=True";

        string aturan = @"[STRICT RULES]
1. MANDATORY: ALWAYS start the query with 'SELECT * FROM Siswa'.
2. PROHIBITED: Do NOT list individual column names.
3. NO EXPLANATION: Output only the SQL string.
4. SCOPE: If the question is not about students, output 'INVALID'.
5. CONSTRAINT: Every result must return ALL columns.";

        public AIFrm()
        {
            InitializeComponent();
        }

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            string userInput = SearchTxt.Text;

            if (string.IsNullOrWhiteSpace(userInput))
            {
                guna2PictureBox1.Image = Properties.Resources.Gemini_Generated_Image_umju2eumju2eumju;
                ResponseLbl.Text = "Tidak apa apa, silahkan tanya ke Nara";
                guna2CustomGradientPanel1.Width = ResponseLbl.Text.Length * 8;
                DialogResult resss = MessageBox.Show("Silakan masukkan perintah.", "Input Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (resss == DialogResult.OK)
                {
                    using (SqlConnection conn2 = new SqlConnection(koneksi))
                    {
                        conn2.Open();
                        string q1 = "select * from Siswa";
                        using (SqlDataAdapter da2 = new SqlDataAdapter(q1, conn2))
                        {
                            DataTable dt2 = new DataTable();
                            da2.Fill(dt2);
                            DataDgv.DataSource = dt2;
                        }
                    }
                }
                return;
            }

            try
            {
                guna2PictureBox1.Image = Properties.Resources.Gemini_Generated_Image_v9kncxv9kncxv9kn;
                ResponseLbl.Text = "Sabar yaa, Nara masih kerjain...";
                guna2CustomGradientPanel1.Width = ResponseLbl.Text.Length * 8;

                SearchBtn.Enabled = false;
                SearchTxt.Enabled = false;
                DataDgv.DataSource = null;

                var payload = new
                {
                    model = "llama3.2:1b",
                    prompt = $@"Database Table:
{schemaTabel}

Rules:
{aturan}

User: {userInput}
SQL: SELECT",
                    stream = false
                };

                string jsonPayload = JsonConvert.SerializeObject(payload);
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://localhost:11434/api/generate", content);
                response.EnsureSuccessStatusCode();

                string responseString = await response.Content.ReadAsStringAsync();
                dynamic json = JsonConvert.DeserializeObject(responseString);
                string res = json.response;
                string result = res.Trim();

                string[] kataTerlarang = { "DELETE", "DROP", "TRUNCATE", "UPDATE", "INSERT", "ALTER", "CREATE" };
                bool terdeteksiBahaya = false;

                foreach (string kata in kataTerlarang)
                {
                    if (userInput.ToUpper().Contains(kata) || result.ToUpper().Contains(kata))
                    {
                        guna2PictureBox1.Image = Properties.Resources.Gemini_Generated_Image_h759jfh759jfh759;
                        ResponseLbl.Text = "Hei! No no yaa, Nara ga boleh lakuin itu";
                        guna2CustomGradientPanel1.Width = ResponseLbl.Text.Length * 8;
                        terdeteksiBahaya = true;
                        DialogResult resss = MessageBox.Show($"Sistem Keamanan: Perintah '{kata}' dilarang!", "Peringatan Keamanan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        if (resss == DialogResult.OK)
                        {
                            using (SqlConnection conn2 = new SqlConnection(koneksi))
                            {
                                conn2.Open();
                                string q1 = "select * from Siswa";
                                using (SqlDataAdapter da2 = new SqlDataAdapter(q1, conn2))
                                {
                                    DataTable dt2 = new DataTable();
                                    da2.Fill(dt2);
                                    DataDgv.DataSource = dt2;
                                }
                            }
                        }
                        break;
                    }
                }

                string cleanSql = "SELECT * FROM Siswa";

                if (!terdeteksiBahaya)
                {
                    int wherePos = result.ToUpper().IndexOf("WHERE");
                    if (wherePos >= 0)
                    {
                        string filter = result.Substring(wherePos + 5).Trim();

                        filter = filter.Replace("`", "").Replace("*", "").Replace(";", "").Trim();

                        if (!string.IsNullOrEmpty(filter))
                        {
                            cleanSql += " WHERE " + filter;
                        }
                    }
                }

                

                
                else if (!result.ToUpper().Contains("SELECT") && result.Length > 2)
                {
                    string simpleFilter = result.Replace("*", "").Replace(";", "").Trim();
                    cleanSql += " WHERE " + simpleFilter;
                }

                cleanSql = cleanSql.Replace("Siswa *", "Siswa").Trim();

                guna2PictureBox1.Image = Properties.Resources.Gemini_Generated_Image_5qsh7c5qsh7c5qsh;
                ResponseLbl.Text = "Nara sudah selesai, maafin Nara yaa kalo responnya ga sesuai, kamu bisa ulangi lagi kok!";
                guna2CustomGradientPanel1.Width = ResponseLbl.Text.Length * 7;

                using (SqlConnection conn = new SqlConnection(koneksi))
                {
                    await conn.OpenAsync();
                    using (SqlDataAdapter da = new SqlDataAdapter(cleanSql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DataDgv.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            guna2PictureBox1.Image = Properties.Resources.Gemini_Generated_Image_9ipheo9ipheo9iph;
                            ResponseLbl.Text = "Maaf yaa, Nara ga nemu data yang kamu minta";
                            guna2CustomGradientPanel1.Width = ResponseLbl.Text.Length * 8;

                            DialogResult resss = MessageBox.Show("Data tidak ditemukan.", "Hasil Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (resss == DialogResult.OK)
                            {
                                using (SqlConnection conn2 = new SqlConnection(koneksi))
                                {
                                    conn2.Open();
                                    string q1 = "select * from Siswa";
                                    using (SqlDataAdapter da2 = new SqlDataAdapter(q1, conn2))
                                    {
                                        DataTable dt2 = new DataTable();
                                        da2.Fill(dt2);
                                        DataDgv.DataSource = dt2;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                DialogResult resss = MessageBox.Show("Kesalahan Query SQL: \n" + sqlEx.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                guna2PictureBox1.Image = Properties.Resources.Gemini_Generated_Image_9ipheo9ipheo9iph;
                ResponseLbl.Text = "Maaf yaa, SQL Nara Error";
                guna2CustomGradientPanel1.Width = ResponseLbl.Text.Length * 8;
                if (resss == DialogResult.OK)
                {
                    using (SqlConnection conn2 = new SqlConnection(koneksi))
                    {
                        conn2.Open();
                        string q1 = "select * from Siswa";
                        using (SqlDataAdapter da2 = new SqlDataAdapter(q1, conn2))
                        {
                            DataTable dt2 = new DataTable();
                            da2.Fill(dt2);
                            DataDgv.DataSource = dt2;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult resss = MessageBox.Show("Kesalahan Sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                guna2PictureBox1.Image = Properties.Resources.Gemini_Generated_Image_9ipheo9ipheo9iph;
                ResponseLbl.Text = "Maafin Nara, ada yang error";
                guna2CustomGradientPanel1.Width = ResponseLbl.Text.Length * 8;
                if (resss == DialogResult.OK)
                {
                    using (SqlConnection conn2 = new SqlConnection(koneksi))
                    {
                        conn2.Open();
                        string q1 = "select * from Siswa";
                        using (SqlDataAdapter da2 = new SqlDataAdapter(q1, conn2))
                        {
                            DataTable dt2 = new DataTable();
                            da2.Fill(dt2);
                            DataDgv.DataSource = dt2;
                        }
                    }
                }

            }
            finally
            {
                SearchBtn.Enabled = true;
                SearchTxt.Enabled = true;
                SearchTxt.Focus();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AIFrm_Load(object sender, EventArgs e)
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
            }
            guna2PictureBox1.Image = Properties.Resources.Gemini_Generated_Image_umju2eumju2eumju;
            ResponseLbl.Text = "Hallo, apakah ada yang bisa Nara bantu?";
            guna2CustomGradientPanel1.Width =  ResponseLbl.Text.Length * 8;
            MessageBox.Show("Nara masih belajar, maafin Nara ya kalo responnya gak sesuai, kamu bisa ulangin kok!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
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
                }
                guna2PictureBox1.Image = Properties.Resources.Gemini_Generated_Image_umju2eumju2eumju;
                SearchTxt.Text = "";
                ResponseLbl.Text = "Hallo, apakah ada yang bisa Nara bantu?";
                guna2CustomGradientPanel1.Width = ResponseLbl.Text.Length * 8;
            }
        }
    }
}