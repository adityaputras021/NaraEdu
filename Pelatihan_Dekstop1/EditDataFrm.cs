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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NaraEdu
{
    public partial class EditDataFrm : Form
    {
        string koneksi = "Data Source=DESKTOP-L27N0PB\\SQLEXPRESS01;Initial Catalog=smkti2026;Integrated Security=True;TrustServerCertificate=True";


        int id;
        string nisn1;
        string nama;
        string tempat;
        DateTime lahir;
        string kelamin;
        string alamat;
        string nomor;
        string email;
        int masuk;
        int status;
        string create;
        public EditDataFrm(int id, string nisn, string nama, string tempat, DateTime lahir, string kelamin, string alamat, string nomor, string email, int masuk, int status, string create)
        {
            InitializeComponent();
            this.id = id;
            this.nisn1 = nisn.ToString();
            this.nama = nama;
            this.tempat = tempat;
            this.lahir = lahir;
            this.kelamin = kelamin;
            this.alamat = alamat;
            this.nomor = nomor;
            this.email = email;
            this.masuk = masuk;
            this.status = status;
            this.create = create;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditDataFrm_Load(object sender, EventArgs e)
        {
            NamaTxt.Text = nama;
            NisnTxt.Text = nisn1;
            TempatTxt.Text = tempat;
            LahirDtp.Value = lahir;
            kelaminCmb.Text = kelamin == "L" ? "Laki - Laki" : "Perempuan";
            AlamatTxt.Text = alamat;
            NomorTxt.Text = nomor;
            EmailTxt.Text = email;
            MasukTxt.Text = masuk.ToString();
            StatusCmb.Text = status == 1 ? "Aktif" : "Tidak Aktif";

            IdLbl.Text = "ID Siswa : " + id.ToString();
            CreateLbl.Text = "Tanggal Pembuatan : " + create;

            NisnTxt.Enabled = false;
            kelaminCmb.Enabled = false;
            MasukTxt.Enabled = false;
        }

        private void SimpanBtn_Click(object sender, EventArgs e)
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
                            string q1 = "Update Siswa set NamaLengkap = '" + NamaTxt.Text + "',TempatLahir='" + TempatTxt.Text + "',TanggalLahir='" + LahirDtp.Value.ToString("yyyy-MM-dd") + "',JenisKelamin='" + kelamin + "',Alamat='" + AlamatTxt.Text + "',NomorHP=" + nomor + ",Email='" + EmailTxt.Text + "',TahunMasuk= " + masuk + ",IsAktif=" + status + ",UpdatedAt='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where SiswaID = " + id;
                            using (SqlCommand cmd = new SqlCommand(q1, conn))
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Data Berhasil Diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                string q1 = "Update Siswa set NamaLengkap = '" + NamaTxt.Text + "',TempatLahir='" + TempatTxt.Text + "',TanggalLahir='" + LahirDtp.Value.ToString("yyyy-MM-dd") + "',JenisKelamin='" + kelamin + "',Alamat='" + AlamatTxt.Text + "',NomorHP=" + nomor + ",Email='" + EmailTxt.Text + "',TahunMasuk= " + masuk + ",IsAktif=" + status + ",UpdatedAt='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where SiswaID = " + id;
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                string q1 = "Update Siswa set NamaLengkap = '" + NamaTxt.Text + "',TempatLahir='" + TempatTxt.Text + "',TanggalLahir='" + LahirDtp.Value.ToString("yyyy-MM-dd") + "',JenisKelamin='" + kelamin + "',Alamat='" + AlamatTxt.Text + "',NomorHP=" + nomor + ",Email='" + EmailTxt.Text + "',TahunMasuk= " + masuk + ",IsAktif=" + status + ",UpdatedAt='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where SiswaID = " + id;
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                string q1 = "Update Siswa set NamaLengkap = '" + NamaTxt.Text + "',TempatLahir='" + TempatTxt.Text + "',TanggalLahir='" + LahirDtp.Value.ToString("yyyy-MM-dd") + "',JenisKelamin='" + kelamin + "',Alamat='" + AlamatTxt.Text + "',NomorHP=" + nomor + ",Email='" + EmailTxt.Text + "',TahunMasuk= " + masuk + ",IsAktif=" + status + ",UpdatedAt='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where SiswaID = " + id;
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                string q1 = "Update Siswa set NamaLengkap = '" + NamaTxt.Text + "',TempatLahir='" + TempatTxt.Text + "',TanggalLahir='" + LahirDtp.Value.ToString("yyyy-MM-dd") + "',JenisKelamin='" + kelamin + "',Alamat='" + AlamatTxt.Text + "',NomorHP=" + nomor + ",Email='" + EmailTxt.Text + "',TahunMasuk= " + masuk + ",IsAktif=" + status + ",UpdatedAt='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where SiswaID = " + id;
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                string q1 = "Update Siswa set NamaLengkap = '" + NamaTxt.Text + "',TempatLahir='" + TempatTxt.Text + "',TanggalLahir='" + LahirDtp.Value.ToString("yyyy-MM-dd") + "',JenisKelamin='" + kelamin + "',Alamat='" + AlamatTxt.Text + "',NomorHP=" + nomor + ",Email='" + EmailTxt.Text + "',TahunMasuk= " + masuk + ",IsAktif=" + status + ",UpdatedAt='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where SiswaID = " + id;
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                string q1 = "Update Siswa set NamaLengkap = '" + NamaTxt.Text + "',TempatLahir='" + TempatTxt.Text + "',TanggalLahir='" + LahirDtp.Value.ToString("yyyy-MM-dd") + "',JenisKelamin='" + kelamin + "',Alamat='" + AlamatTxt.Text + "',NomorHP=" + nomor + ",Email='" + EmailTxt.Text + "',TahunMasuk= " + masuk + ",IsAktif=" + status + ",UpdatedAt='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where SiswaID = " + id;
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                string q1 = "Update Siswa set NamaLengkap = '" + NamaTxt.Text + "',TempatLahir='" + TempatTxt.Text + "',TanggalLahir='" + LahirDtp.Value.ToString("yyyy-MM-dd") + "',JenisKelamin='" + kelamin + "',Alamat='" + AlamatTxt.Text + "',NomorHP=" + nomor + ",Email='" + EmailTxt.Text + "',TahunMasuk= " + masuk + ",IsAktif=" + status + ",UpdatedAt='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where SiswaID = " + id;
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                string q1 = "Update Siswa set NamaLengkap = '" + NamaTxt.Text + "',TempatLahir='" + TempatTxt.Text + "',TanggalLahir='" + LahirDtp.Value.ToString("yyyy-MM-dd") + "',JenisKelamin='" + kelamin + "',Alamat='" + AlamatTxt.Text + "',NomorHP=" + nomor + ",Email='" + EmailTxt.Text + "',TahunMasuk= " + masuk + ",IsAktif=" + status + ",UpdatedAt='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where SiswaID = " + id;
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                string q1 = "Update Siswa set NamaLengkap = '" + NamaTxt.Text + "',TempatLahir='" + TempatTxt.Text + "',TanggalLahir='" + LahirDtp.Value.ToString("yyyy-MM-dd") + "',JenisKelamin='" + kelamin + "',Alamat='" + AlamatTxt.Text + "',NomorHP=" + nomor + ",Email='" + EmailTxt.Text + "',TahunMasuk= " + masuk + ",IsAktif=" + status + ",UpdatedAt='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where SiswaID = " + id;
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                string q1 = "Update Siswa set NamaLengkap = '" + NamaTxt.Text + "',TempatLahir='" + TempatTxt.Text + "',TanggalLahir='" + LahirDtp.Value.ToString("yyyy-MM-dd") + "',JenisKelamin='" + kelamin + "',Alamat='" + AlamatTxt.Text + "',NomorHP=" + nomor + ",Email='" + EmailTxt.Text + "',TahunMasuk= " + masuk + ",IsAktif=" + status + ",UpdatedAt='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where SiswaID = " + id;
                                using (SqlCommand cmd = new SqlCommand(q1, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void NomorTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
