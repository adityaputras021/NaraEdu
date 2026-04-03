using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaraEdu
{
    public partial class AddDataFrmcs : Form
    {
        string koneksi = "Data Source=DESKTOP-L27N0PB\\SQLEXPRESS01;Initial Catalog=smkti2026;Integrated Security=True;TrustServerCertificate=True";

        public AddDataFrmcs()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SimpanBtn_Click(object sender, EventArgs e)
        {

            try
            {

                if(NisnTxt.Text == "" || NamaTxt.Text == "" || TempatTxt.Text == "" || AlamatTxt.Text == "" || EmailTxt.Text == "" || kelaminCmb.Text == "" || StatusCmb.Text == "" || NomorTxt.Text == "" || MasukTxt.Text == "")
                {
                    MessageBox.Show("Semua field harus diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string kelamin = "";

                    if (kelaminCmb.Text == "Laki - Laki")
                    {
                        kelamin = "L";
                    }
                    else if (kelaminCmb.Text == "Perempuan")
                    {
                        kelamin = "P";
                    }
                    int status = 1;

                    if (StatusCmb.Text == "Aktif")
                    {
                        status = 1;
                    }
                    else if (StatusCmb.Text == "Tidak Aktif")
                    {
                        status = 0;
                    }


                    if (!long.TryParse(NisnTxt.Text, out long nisn) && NisnTxt.Text == "")
                    {
                        MessageBox.Show("NISN harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!long.TryParse(NomorTxt.Text, out long nomor) && NomorTxt.Text == "")
                    {
                        MessageBox.Show("Nomor harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!int.TryParse(MasukTxt.Text, out int masuk) && MasukTxt.Text == "")
                    {
                        MessageBox.Show("Tahun masuk harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (NisnTxt.TextLength != 10)
                    {
                        MessageBox.Show("NISN harus 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (NomorTxt.TextLength != 15)
                    {
                        MessageBox.Show("Nomor HP harus 15 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        using (SqlConnection conn = new SqlConnection(koneksi))
                        {
                            conn.Open();
                            string q1 = "insert into Siswa (NISN,NamaLengkap,TempatLahir,TanggalLahir,JenisKelamin,Alamat,NomorHP,Email,TahunMasuk,IsAktif,CreatedAt,UpdatedAt) values ('" + nisn + "', '" + NamaTxt.Text + "', '" + TempatTxt.Text + "','" + LahirDtp.Value.ToString("yyyy-MM-dd") + "', '" + kelamin + "', '" + AlamatTxt.Text + "'," + nomor + ",'" + EmailTxt.Text + "', " + masuk + ", " + status + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                            using (SqlCommand cmd = new SqlCommand(q1, conn))
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Data Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }

                        }
                    }
                }
                


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        

        private void AddDataFrmcs_Load(object sender, EventArgs e)
        {

        }

        private void MasukTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDataFrmcs_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void NisnTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                try
                {

                    if (NisnTxt.Text == "" || NamaTxt.Text == "" || TempatTxt.Text == "" || AlamatTxt.Text == "" || EmailTxt.Text == "" || kelaminCmb.Text == "" || StatusCmb.Text == "" || NomorTxt.Text == "" || MasukTxt.Text == "")
                    {
                        MessageBox.Show("Semua field harus diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string kelamin = "";

                        if (kelaminCmb.Text == "Laki - Laki")
                        {
                            kelamin = "L";
                        }
                        else if (kelaminCmb.Text == "Perempuan")
                        {
                            kelamin = "P";
                        }
                        int status = 1;

                        if (StatusCmb.Text == "Aktif")
                        {
                            status = 1;
                        }
                        else if (StatusCmb.Text == "Tidak Aktif")
                        {
                            status = 0;
                        }


                        if (!long.TryParse(NisnTxt.Text, out long nisn) && NisnTxt.Text == "")
                        {
                            MessageBox.Show("NISN harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!long.TryParse(NomorTxt.Text, out long nomor) && NomorTxt.Text == "")
                        {
                            MessageBox.Show("Nomor harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!int.TryParse(MasukTxt.Text, out int masuk) && MasukTxt.Text == "")
                        {
                            MessageBox.Show("Tahun masuk harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NisnTxt.TextLength != 10)
                        {
                            MessageBox.Show("NISN harus 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NomorTxt.TextLength != 15)
                        {
                            MessageBox.Show("Nomor HP harus 15 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(koneksi))
                            {
                                conn.Open();
                                string q1 = "insert into Siswa (NISN,NamaLengkap,TempatLahir,TanggalLahir,JenisKelamin,Alamat,NomorHP,Email,TahunMasuk,IsAktif,CreatedAt,UpdatedAt) values ('" + nisn + "', '" + NamaTxt.Text + "', '" + TempatTxt.Text + "','" + LahirDtp.Value.ToString("yyyy-MM-dd") + "', '" + kelamin + "', '" + AlamatTxt.Text + "'," + nomor + ",'" + EmailTxt.Text + "', " + masuk + ", " + status + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void AlamatTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                try
                {

                    if (NisnTxt.Text == "" || NamaTxt.Text == "" || TempatTxt.Text == "" || AlamatTxt.Text == "" || EmailTxt.Text == "" || kelaminCmb.Text == "" || StatusCmb.Text == "" || NomorTxt.Text == "" || MasukTxt.Text == "")
                    {
                        MessageBox.Show("Semua field harus diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string kelamin = "";

                        if (kelaminCmb.Text == "Laki - Laki")
                        {
                            kelamin = "L";
                        }
                        else if (kelaminCmb.Text == "Perempuan")
                        {
                            kelamin = "P";
                        }
                        int status = 1;

                        if (StatusCmb.Text == "Aktif")
                        {
                            status = 1;
                        }
                        else if (StatusCmb.Text == "Tidak Aktif")
                        {
                            status = 0;
                        }


                        if (!long.TryParse(NisnTxt.Text, out long nisn) && NisnTxt.Text == "")
                        {
                            MessageBox.Show("NISN harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!long.TryParse(NomorTxt.Text, out long nomor) && NomorTxt.Text == "")
                        {
                            MessageBox.Show("Nomor harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!int.TryParse(MasukTxt.Text, out int masuk) && MasukTxt.Text == "")
                        {
                            MessageBox.Show("Tahun masuk harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NisnTxt.TextLength != 10)
                        {
                            MessageBox.Show("NISN harus 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NomorTxt.TextLength != 15)
                        {
                            MessageBox.Show("Nomor HP harus 15 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(koneksi))
                            {
                                conn.Open();
                                string q1 = "insert into Siswa (NISN,NamaLengkap,TempatLahir,TanggalLahir,JenisKelamin,Alamat,NomorHP,Email,TahunMasuk,IsAktif,CreatedAt,UpdatedAt) values ('" + nisn + "', '" + NamaTxt.Text + "', '" + TempatTxt.Text + "','" + LahirDtp.Value.ToString("yyyy-MM-dd") + "', '" + kelamin + "', '" + AlamatTxt.Text + "'," + nomor + ",'" + EmailTxt.Text + "', " + masuk + ", " + status + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void NamaTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                try
                {

                    if (NisnTxt.Text == "" || NamaTxt.Text == "" || TempatTxt.Text == "" || AlamatTxt.Text == "" || EmailTxt.Text == "" || kelaminCmb.Text == "" || StatusCmb.Text == "" || NomorTxt.Text == "" || MasukTxt.Text == "")
                    {
                        MessageBox.Show("Semua field harus diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string kelamin = "";

                        if (kelaminCmb.Text == "Laki - Laki")
                        {
                            kelamin = "L";
                        }
                        else if (kelaminCmb.Text == "Perempuan")
                        {
                            kelamin = "P";
                        }
                        int status = 1;

                        if (StatusCmb.Text == "Aktif")
                        {
                            status = 1;
                        }
                        else if (StatusCmb.Text == "Tidak Aktif")
                        {
                            status = 0;
                        }


                        if (!long.TryParse(NisnTxt.Text, out long nisn) && NisnTxt.Text == "")
                        {
                            MessageBox.Show("NISN harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!long.TryParse(NomorTxt.Text, out long nomor) && NomorTxt.Text == "")
                        {
                            MessageBox.Show("Nomor harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!int.TryParse(MasukTxt.Text, out int masuk) && MasukTxt.Text == "")
                        {
                            MessageBox.Show("Tahun masuk harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NisnTxt.TextLength != 10)
                        {
                            MessageBox.Show("NISN harus 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NomorTxt.TextLength != 15)
                        {
                            MessageBox.Show("Nomor HP harus 15 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(koneksi))
                            {
                                conn.Open();
                                string q1 = "insert into Siswa (NISN,NamaLengkap,TempatLahir,TanggalLahir,JenisKelamin,Alamat,NomorHP,Email,TahunMasuk,IsAktif,CreatedAt,UpdatedAt) values ('" + nisn + "', '" + NamaTxt.Text + "', '" + TempatTxt.Text + "','" + LahirDtp.Value.ToString("yyyy-MM-dd") + "', '" + kelamin + "', '" + AlamatTxt.Text + "'," + nomor + ",'" + EmailTxt.Text + "', " + masuk + ", " + status + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void EmailTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                try
                {

                    if (NisnTxt.Text == "" || NamaTxt.Text == "" || TempatTxt.Text == "" || AlamatTxt.Text == "" || EmailTxt.Text == "" || kelaminCmb.Text == "" || StatusCmb.Text == "" || NomorTxt.Text == "" || MasukTxt.Text == "")
                    {
                        MessageBox.Show("Semua field harus diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string kelamin = "";

                        if (kelaminCmb.Text == "Laki - Laki")
                        {
                            kelamin = "L";
                        }
                        else if (kelaminCmb.Text == "Perempuan")
                        {
                            kelamin = "P";
                        }
                        int status = 1;

                        if (StatusCmb.Text == "Aktif")
                        {
                            status = 1;
                        }
                        else if (StatusCmb.Text == "Tidak Aktif")
                        {
                            status = 0;
                        }


                        if (!long.TryParse(NisnTxt.Text, out long nisn) && NisnTxt.Text == "")
                        {
                            MessageBox.Show("NISN harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!long.TryParse(NomorTxt.Text, out long nomor) && NomorTxt.Text == "")
                        {
                            MessageBox.Show("Nomor harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!int.TryParse(MasukTxt.Text, out int masuk) && MasukTxt.Text == "")
                        {
                            MessageBox.Show("Tahun masuk harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NisnTxt.TextLength != 10)
                        {
                            MessageBox.Show("NISN harus 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NomorTxt.TextLength != 15)
                        {
                            MessageBox.Show("Nomor HP harus 15 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(koneksi))
                            {
                                conn.Open();
                                string q1 = "insert into Siswa (NISN,NamaLengkap,TempatLahir,TanggalLahir,JenisKelamin,Alamat,NomorHP,Email,TahunMasuk,IsAktif,CreatedAt,UpdatedAt) values ('" + nisn + "', '" + NamaTxt.Text + "', '" + TempatTxt.Text + "','" + LahirDtp.Value.ToString("yyyy-MM-dd") + "', '" + kelamin + "', '" + AlamatTxt.Text + "'," + nomor + ",'" + EmailTxt.Text + "', " + masuk + ", " + status + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void TempatTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                try
                {

                    if (NisnTxt.Text == "" || NamaTxt.Text == "" || TempatTxt.Text == "" || AlamatTxt.Text == "" || EmailTxt.Text == "" || kelaminCmb.Text == "" || StatusCmb.Text == "" || NomorTxt.Text == "" || MasukTxt.Text == "")
                    {
                        MessageBox.Show("Semua field harus diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string kelamin = "";

                        if (kelaminCmb.Text == "Laki - Laki")
                        {
                            kelamin = "L";
                        }
                        else if (kelaminCmb.Text == "Perempuan")
                        {
                            kelamin = "P";
                        }
                        int status = 1;

                        if (StatusCmb.Text == "Aktif")
                        {
                            status = 1;
                        }
                        else if (StatusCmb.Text == "Tidak Aktif")
                        {
                            status = 0;
                        }


                        if (!long.TryParse(NisnTxt.Text, out long nisn) && NisnTxt.Text == "")
                        {
                            MessageBox.Show("NISN harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!long.TryParse(NomorTxt.Text, out long nomor) && NomorTxt.Text == "")
                        {
                            MessageBox.Show("Nomor harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!int.TryParse(MasukTxt.Text, out int masuk) && MasukTxt.Text == "")
                        {
                            MessageBox.Show("Tahun masuk harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NisnTxt.TextLength != 10)
                        {
                            MessageBox.Show("NISN harus 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NomorTxt.TextLength != 15)
                        {
                            MessageBox.Show("Nomor HP harus 15 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(koneksi))
                            {
                                conn.Open();
                                string q1 = "insert into Siswa (NISN,NamaLengkap,TempatLahir,TanggalLahir,JenisKelamin,Alamat,NomorHP,Email,TahunMasuk,IsAktif,CreatedAt,UpdatedAt) values ('" + nisn + "', '" + NamaTxt.Text + "', '" + TempatTxt.Text + "','" + LahirDtp.Value.ToString("yyyy-MM-dd") + "', '" + kelamin + "', '" + AlamatTxt.Text + "'," + nomor + ",'" + EmailTxt.Text + "', " + masuk + ", " + status + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void NomorTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                try
                {

                    if (NisnTxt.Text == "" || NamaTxt.Text == "" || TempatTxt.Text == "" || AlamatTxt.Text == "" || EmailTxt.Text == "" || kelaminCmb.Text == "" || StatusCmb.Text == "" || NomorTxt.Text == "" || MasukTxt.Text == "")
                    {
                        MessageBox.Show("Semua field harus diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string kelamin = "";

                        if (kelaminCmb.Text == "Laki - Laki")
                        {
                            kelamin = "L";
                        }
                        else if (kelaminCmb.Text == "Perempuan")
                        {
                            kelamin = "P";
                        }
                        int status = 1;

                        if (StatusCmb.Text == "Aktif")
                        {
                            status = 1;
                        }
                        else if (StatusCmb.Text == "Tidak Aktif")
                        {
                            status = 0;
                        }


                        if (!long.TryParse(NisnTxt.Text, out long nisn) && NisnTxt.Text == "")
                        {
                            MessageBox.Show("NISN harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!long.TryParse(NomorTxt.Text, out long nomor) && NomorTxt.Text == "")
                        {
                            MessageBox.Show("Nomor harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!int.TryParse(MasukTxt.Text, out int masuk) && MasukTxt.Text == "")
                        {
                            MessageBox.Show("Tahun masuk harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NisnTxt.TextLength != 10)
                        {
                            MessageBox.Show("NISN harus 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NomorTxt.TextLength != 15)
                        {
                            MessageBox.Show("Nomor HP harus 15 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(koneksi))
                            {
                                conn.Open();
                                string q1 = "insert into Siswa (NISN,NamaLengkap,TempatLahir,TanggalLahir,JenisKelamin,Alamat,NomorHP,Email,TahunMasuk,IsAktif,CreatedAt,UpdatedAt) values ('" + nisn + "', '" + NamaTxt.Text + "', '" + TempatTxt.Text + "','" + LahirDtp.Value.ToString("yyyy-MM-dd") + "', '" + kelamin + "', '" + AlamatTxt.Text + "'," + nomor + ",'" + EmailTxt.Text + "', " + masuk + ", " + status + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void kelaminCmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                try
                {

                    if (NisnTxt.Text == "" || NamaTxt.Text == "" || TempatTxt.Text == "" || AlamatTxt.Text == "" || EmailTxt.Text == "" || kelaminCmb.Text == "" || StatusCmb.Text == "" || NomorTxt.Text == "" || MasukTxt.Text == "")
                    {
                        MessageBox.Show("Semua field harus diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string kelamin = "";

                        if (kelaminCmb.Text == "Laki - Laki")
                        {
                            kelamin = "L";
                        }
                        else if (kelaminCmb.Text == "Perempuan")
                        {
                            kelamin = "P";
                        }
                        int status = 1;

                        if (StatusCmb.Text == "Aktif")
                        {
                            status = 1;
                        }
                        else if (StatusCmb.Text == "Tidak Aktif")
                        {
                            status = 0;
                        }


                        if (!long.TryParse(NisnTxt.Text, out long nisn) && NisnTxt.Text == "")
                        {
                            MessageBox.Show("NISN harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!long.TryParse(NomorTxt.Text, out long nomor) && NomorTxt.Text == "")
                        {
                            MessageBox.Show("Nomor harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!int.TryParse(MasukTxt.Text, out int masuk) && MasukTxt.Text == "")
                        {
                            MessageBox.Show("Tahun masuk harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NisnTxt.TextLength != 10)
                        {
                            MessageBox.Show("NISN harus 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NomorTxt.TextLength != 15)
                        {
                            MessageBox.Show("Nomor HP harus 15 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(koneksi))
                            {
                                conn.Open();
                                string q1 = "insert into Siswa (NISN,NamaLengkap,TempatLahir,TanggalLahir,JenisKelamin,Alamat,NomorHP,Email,TahunMasuk,IsAktif,CreatedAt,UpdatedAt) values ('" + nisn + "', '" + NamaTxt.Text + "', '" + TempatTxt.Text + "','" + LahirDtp.Value.ToString("yyyy-MM-dd") + "', '" + kelamin + "', '" + AlamatTxt.Text + "'," + nomor + ",'" + EmailTxt.Text + "', " + masuk + ", " + status + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void LahirDtp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                try
                {

                    if (NisnTxt.Text == "" || NamaTxt.Text == "" || TempatTxt.Text == "" || AlamatTxt.Text == "" || EmailTxt.Text == "" || kelaminCmb.Text == "" || StatusCmb.Text == "" || NomorTxt.Text == "" || MasukTxt.Text == "")
                    {
                        MessageBox.Show("Semua field harus diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string kelamin = "";

                        if (kelaminCmb.Text == "Laki - Laki")
                        {
                            kelamin = "L";
                        }
                        else if (kelaminCmb.Text == "Perempuan")
                        {
                            kelamin = "P";
                        }
                        int status = 1;

                        if (StatusCmb.Text == "Aktif")
                        {
                            status = 1;
                        }
                        else if (StatusCmb.Text == "Tidak Aktif")
                        {
                            status = 0;
                        }


                        if (!long.TryParse(NisnTxt.Text, out long nisn) && NisnTxt.Text == "")
                        {
                            MessageBox.Show("NISN harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!long.TryParse(NomorTxt.Text, out long nomor) && NomorTxt.Text == "")
                        {
                            MessageBox.Show("Nomor harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!int.TryParse(MasukTxt.Text, out int masuk) && MasukTxt.Text == "")
                        {
                            MessageBox.Show("Tahun masuk harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NisnTxt.TextLength != 10)
                        {
                            MessageBox.Show("NISN harus 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NomorTxt.TextLength != 15)
                        {
                            MessageBox.Show("Nomor HP harus 15 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(koneksi))
                            {
                                conn.Open();
                                string q1 = "insert into Siswa (NISN,NamaLengkap,TempatLahir,TanggalLahir,JenisKelamin,Alamat,NomorHP,Email,TahunMasuk,IsAktif,CreatedAt,UpdatedAt) values ('" + nisn + "', '" + NamaTxt.Text + "', '" + TempatTxt.Text + "','" + LahirDtp.Value.ToString("yyyy-MM-dd") + "', '" + kelamin + "', '" + AlamatTxt.Text + "'," + nomor + ",'" + EmailTxt.Text + "', " + masuk + ", " + status + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void StatusCmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                try
                {

                    if (NisnTxt.Text == "" || NamaTxt.Text == "" || TempatTxt.Text == "" || AlamatTxt.Text == "" || EmailTxt.Text == "" || kelaminCmb.Text == "" || StatusCmb.Text == "" || NomorTxt.Text == "" || MasukTxt.Text == "")
                    {
                        MessageBox.Show("Semua field harus diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string kelamin = "";

                        if (kelaminCmb.Text == "Laki - Laki")
                        {
                            kelamin = "L";
                        }
                        else if (kelaminCmb.Text == "Perempuan")
                        {
                            kelamin = "P";
                        }
                        int status = 1;

                        if (StatusCmb.Text == "Aktif")
                        {
                            status = 1;
                        }
                        else if (StatusCmb.Text == "Tidak Aktif")
                        {
                            status = 0;
                        }


                        if (!long.TryParse(NisnTxt.Text, out long nisn) && NisnTxt.Text == "")
                        {
                            MessageBox.Show("NISN harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!long.TryParse(NomorTxt.Text, out long nomor) && NomorTxt.Text == "")
                        {
                            MessageBox.Show("Nomor harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!int.TryParse(MasukTxt.Text, out int masuk) && MasukTxt.Text == "")
                        {
                            MessageBox.Show("Tahun masuk harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NisnTxt.TextLength != 10)
                        {
                            MessageBox.Show("NISN harus 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NomorTxt.TextLength != 15)
                        {
                            MessageBox.Show("Nomor HP harus 15 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(koneksi))
                            {
                                conn.Open();
                                string q1 = "insert into Siswa (NISN,NamaLengkap,TempatLahir,TanggalLahir,JenisKelamin,Alamat,NomorHP,Email,TahunMasuk,IsAktif,CreatedAt,UpdatedAt) values ('" + nisn + "', '" + NamaTxt.Text + "', '" + TempatTxt.Text + "','" + LahirDtp.Value.ToString("yyyy-MM-dd") + "', '" + kelamin + "', '" + AlamatTxt.Text + "'," + nomor + ",'" + EmailTxt.Text + "', " + masuk + ", " + status + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void MasukTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                try
                {

                    if (NisnTxt.Text == "" || NamaTxt.Text == "" || TempatTxt.Text == "" || AlamatTxt.Text == "" || EmailTxt.Text == "" || kelaminCmb.Text == "" || StatusCmb.Text == "" || NomorTxt.Text == "" || MasukTxt.Text == "")
                    {
                        MessageBox.Show("Semua field harus diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string kelamin = "";

                        if (kelaminCmb.Text == "Laki - Laki")
                        {
                            kelamin = "L";
                        }
                        else if (kelaminCmb.Text == "Perempuan")
                        {
                            kelamin = "P";
                        }
                        int status = 1;

                        if (StatusCmb.Text == "Aktif")
                        {
                            status = 1;
                        }
                        else if (StatusCmb.Text == "Tidak Aktif")
                        {
                            status = 0;
                        }


                        if (!long.TryParse(NisnTxt.Text, out long nisn) && NisnTxt.Text == "")
                        {
                            MessageBox.Show("NISN harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!long.TryParse(NomorTxt.Text, out long nomor) && NomorTxt.Text == "")
                        {
                            MessageBox.Show("Nomor harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!int.TryParse(MasukTxt.Text, out int masuk) && MasukTxt.Text == "")
                        {
                            MessageBox.Show("Tahun masuk harus berupa angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NisnTxt.TextLength != 10)
                        {
                            MessageBox.Show("NISN harus 10 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (NomorTxt.TextLength != 15)
                        {
                            MessageBox.Show("Nomor HP harus 15 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(koneksi))
                            {
                                conn.Open();
                                string q1 = "insert into Siswa (NISN,NamaLengkap,TempatLahir,TanggalLahir,JenisKelamin,Alamat,NomorHP,Email,TahunMasuk,IsAktif,CreatedAt,UpdatedAt) values ('" + nisn + "', '" + NamaTxt.Text + "', '" + TempatTxt.Text + "','" + LahirDtp.Value.ToString("yyyy-MM-dd") + "', '" + kelamin + "', '" + AlamatTxt.Text + "'," + nomor + ",'" + EmailTxt.Text + "', " + masuk + ", " + status + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
