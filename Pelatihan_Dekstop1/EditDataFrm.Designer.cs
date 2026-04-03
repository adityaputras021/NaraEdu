using System.Windows.Forms;

namespace NaraEdu
{
    partial class EditDataFrm : Form
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
            this.NisnTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NamaTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.TempatTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.StatusCmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AlamatTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.NomorTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.LahirDtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.kelaminCmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SimpanBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.FormPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.InfoGbx = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CreateLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.MasukTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.FormPnl.SuspendLayout();
            this.InfoGbx.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NisnTxt
            // 
            this.NisnTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NisnTxt.BorderRadius = 20;
            this.NisnTxt.BorderThickness = 2;
            this.NisnTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NisnTxt.DefaultText = "";
            this.NisnTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NisnTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NisnTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NisnTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NisnTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NisnTxt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NisnTxt.ForeColor = System.Drawing.Color.Black;
            this.NisnTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NisnTxt.Location = new System.Drawing.Point(12, 172);
            this.NisnTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NisnTxt.Name = "NisnTxt";
            this.NisnTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.NisnTxt.PlaceholderText = "NISN";
            this.NisnTxt.SelectedText = "";
            this.NisnTxt.Size = new System.Drawing.Size(342, 78);
            this.NisnTxt.TabIndex = 0;
            this.NisnTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NisnTxt_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(172, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 127);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit Siswa";
            // 
            // NamaTxt
            // 
            this.NamaTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NamaTxt.BorderRadius = 20;
            this.NamaTxt.BorderThickness = 2;
            this.NamaTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamaTxt.DefaultText = "";
            this.NamaTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NamaTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NamaTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NamaTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NamaTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NamaTxt.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.NamaTxt.ForeColor = System.Drawing.Color.Black;
            this.NamaTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NamaTxt.Location = new System.Drawing.Point(12, 263);
            this.NamaTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NamaTxt.Name = "NamaTxt";
            this.NamaTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.NamaTxt.PlaceholderText = "Nama Lengkap";
            this.NamaTxt.SelectedText = "";
            this.NamaTxt.Size = new System.Drawing.Size(342, 78);
            this.NamaTxt.TabIndex = 2;
            this.NamaTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NamaTxt_KeyDown);
            // 
            // TempatTxt
            // 
            this.TempatTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TempatTxt.BorderRadius = 20;
            this.TempatTxt.BorderThickness = 2;
            this.TempatTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TempatTxt.DefaultText = "";
            this.TempatTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TempatTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TempatTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TempatTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TempatTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TempatTxt.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.TempatTxt.ForeColor = System.Drawing.Color.Black;
            this.TempatTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TempatTxt.Location = new System.Drawing.Point(12, 354);
            this.TempatTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TempatTxt.Name = "TempatTxt";
            this.TempatTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TempatTxt.PlaceholderText = "Tempat Lahir ";
            this.TempatTxt.SelectedText = "";
            this.TempatTxt.Size = new System.Drawing.Size(342, 78);
            this.TempatTxt.TabIndex = 4;
            this.TempatTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TempatTxt_KeyDown);
            // 
            // StatusCmb
            // 
            this.StatusCmb.BackColor = System.Drawing.Color.Transparent;
            this.StatusCmb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.StatusCmb.BorderRadius = 15;
            this.StatusCmb.BorderThickness = 2;
            this.StatusCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusCmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusCmb.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.StatusCmb.ForeColor = System.Drawing.Color.Black;
            this.StatusCmb.ItemHeight = 30;
            this.StatusCmb.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif"});
            this.StatusCmb.Location = new System.Drawing.Point(12, 580);
            this.StatusCmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusCmb.Name = "StatusCmb";
            this.StatusCmb.Size = new System.Drawing.Size(340, 36);
            this.StatusCmb.TabIndex = 8;
            this.StatusCmb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatusCmb_KeyDown);
            // 
            // AlamatTxt
            // 
            this.AlamatTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AlamatTxt.BorderRadius = 20;
            this.AlamatTxt.BorderThickness = 2;
            this.AlamatTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AlamatTxt.DefaultText = "";
            this.AlamatTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AlamatTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AlamatTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AlamatTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AlamatTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AlamatTxt.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.AlamatTxt.ForeColor = System.Drawing.Color.Black;
            this.AlamatTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AlamatTxt.Location = new System.Drawing.Point(363, 172);
            this.AlamatTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AlamatTxt.Name = "AlamatTxt";
            this.AlamatTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.AlamatTxt.PlaceholderText = "Alamat";
            this.AlamatTxt.SelectedText = "";
            this.AlamatTxt.Size = new System.Drawing.Size(342, 78);
            this.AlamatTxt.TabIndex = 1;
            this.AlamatTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AlamatTxt_KeyDown);
            // 
            // NomorTxt
            // 
            this.NomorTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NomorTxt.BorderRadius = 20;
            this.NomorTxt.BorderThickness = 2;
            this.NomorTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NomorTxt.DefaultText = "";
            this.NomorTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NomorTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NomorTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomorTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomorTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NomorTxt.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.NomorTxt.ForeColor = System.Drawing.Color.Black;
            this.NomorTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NomorTxt.Location = new System.Drawing.Point(363, 354);
            this.NomorTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NomorTxt.Name = "NomorTxt";
            this.NomorTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.NomorTxt.PlaceholderText = "Nomor HP";
            this.NomorTxt.SelectedText = "";
            this.NomorTxt.Size = new System.Drawing.Size(342, 78);
            this.NomorTxt.TabIndex = 5;
            this.NomorTxt.TextChanged += new System.EventHandler(this.NomorTxt_TextChanged);
            this.NomorTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NomorTxt_KeyDown);
            // 
            // EmailTxt
            // 
            this.EmailTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.EmailTxt.BorderRadius = 20;
            this.EmailTxt.BorderThickness = 2;
            this.EmailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxt.DefaultText = "";
            this.EmailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxt.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.EmailTxt.ForeColor = System.Drawing.Color.Black;
            this.EmailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxt.Location = new System.Drawing.Point(363, 263);
            this.EmailTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.EmailTxt.PlaceholderText = "Email";
            this.EmailTxt.SelectedText = "";
            this.EmailTxt.Size = new System.Drawing.Size(342, 78);
            this.EmailTxt.TabIndex = 3;
            this.EmailTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmailTxt_KeyDown);
            // 
            // LahirDtp
            // 
            this.LahirDtp.BorderRadius = 15;
            this.LahirDtp.Checked = true;
            this.LahirDtp.FillColor = System.Drawing.Color.Blue;
            this.LahirDtp.Font = new System.Drawing.Font("Poppins", 9F);
            this.LahirDtp.ForeColor = System.Drawing.Color.White;
            this.LahirDtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.LahirDtp.Location = new System.Drawing.Point(363, 482);
            this.LahirDtp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LahirDtp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.LahirDtp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.LahirDtp.Name = "LahirDtp";
            this.LahirDtp.Size = new System.Drawing.Size(342, 55);
            this.LahirDtp.TabIndex = 7;
            this.LahirDtp.Value = new System.DateTime(2026, 3, 23, 9, 34, 40, 814);
            this.LahirDtp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LahirDtp_KeyDown);
            // 
            // kelaminCmb
            // 
            this.kelaminCmb.BackColor = System.Drawing.Color.Transparent;
            this.kelaminCmb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kelaminCmb.BorderRadius = 15;
            this.kelaminCmb.BorderThickness = 2;
            this.kelaminCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.kelaminCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kelaminCmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kelaminCmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kelaminCmb.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.kelaminCmb.ForeColor = System.Drawing.Color.Black;
            this.kelaminCmb.ItemHeight = 30;
            this.kelaminCmb.Items.AddRange(new object[] {
            "Laki - Laki",
            "Perempuan"});
            this.kelaminCmb.Location = new System.Drawing.Point(12, 482);
            this.kelaminCmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kelaminCmb.Name = "kelaminCmb";
            this.kelaminCmb.Size = new System.Drawing.Size(340, 36);
            this.kelaminCmb.TabIndex = 6;
            this.kelaminCmb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kelaminCmb_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 443);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 542);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Status";
            // 
            // SimpanBtn
            // 
            this.SimpanBtn.Animated = true;
            this.SimpanBtn.BorderRadius = 20;
            this.SimpanBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SimpanBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SimpanBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SimpanBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SimpanBtn.FillColor = System.Drawing.Color.Blue;
            this.SimpanBtn.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SimpanBtn.ForeColor = System.Drawing.Color.White;
            this.SimpanBtn.Image = global::NaraEdu.Properties.Resources.save;
            this.SimpanBtn.Location = new System.Drawing.Point(18, 9);
            this.SimpanBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SimpanBtn.Name = "SimpanBtn";
            this.SimpanBtn.Size = new System.Drawing.Size(270, 69);
            this.SimpanBtn.TabIndex = 10;
            this.SimpanBtn.Text = "Simpan";
            this.SimpanBtn.Click += new System.EventHandler(this.SimpanBtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::NaraEdu.Properties.Resources.exit;
            this.guna2Button1.Location = new System.Drawing.Point(462, 9);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(270, 69);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Cancel";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.Controls.Add(this.SimpanBtn);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Location = new System.Drawing.Point(18, 656);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(745, 88);
            this.guna2Panel1.TabIndex = 21;
            // 
            // FormPnl
            // 
            this.FormPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormPnl.AutoScroll = true;
            this.FormPnl.Controls.Add(this.InfoGbx);
            this.FormPnl.Controls.Add(this.MasukTxt);
            this.FormPnl.Controls.Add(this.label4);
            this.FormPnl.Controls.Add(this.LahirDtp);
            this.FormPnl.Controls.Add(this.label3);
            this.FormPnl.Controls.Add(this.NisnTxt);
            this.FormPnl.Controls.Add(this.label2);
            this.FormPnl.Controls.Add(this.NamaTxt);
            this.FormPnl.Controls.Add(this.kelaminCmb);
            this.FormPnl.Controls.Add(this.TempatTxt);
            this.FormPnl.Controls.Add(this.StatusCmb);
            this.FormPnl.Controls.Add(this.AlamatTxt);
            this.FormPnl.Controls.Add(this.EmailTxt);
            this.FormPnl.Controls.Add(this.NomorTxt);
            this.FormPnl.Location = new System.Drawing.Point(18, 127);
            this.FormPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FormPnl.Name = "FormPnl";
            this.FormPnl.Size = new System.Drawing.Size(745, 518);
            this.FormPnl.TabIndex = 22;
            // 
            // InfoGbx
            // 
            this.InfoGbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoGbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.InfoGbx.Controls.Add(this.CreateLbl);
            this.InfoGbx.Controls.Add(this.IdLbl);
            this.InfoGbx.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.InfoGbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InfoGbx.ForeColor = System.Drawing.Color.White;
            this.InfoGbx.Location = new System.Drawing.Point(18, 22);
            this.InfoGbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InfoGbx.Name = "InfoGbx";
            this.InfoGbx.Size = new System.Drawing.Size(682, 134);
            this.InfoGbx.TabIndex = 24;
            this.InfoGbx.Text = "Informasi Data";
            // 
            // CreateLbl
            // 
            this.CreateLbl.AutoSize = true;
            this.CreateLbl.ForeColor = System.Drawing.Color.Black;
            this.CreateLbl.Location = new System.Drawing.Point(225, 89);
            this.CreateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateLbl.Name = "CreateLbl";
            this.CreateLbl.Size = new System.Drawing.Size(181, 25);
            this.CreateLbl.TabIndex = 1;
            this.CreateLbl.Text = "Tanggal Pembuatan : ";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.ForeColor = System.Drawing.Color.Black;
            this.IdLbl.Location = new System.Drawing.Point(16, 89);
            this.IdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(79, 25);
            this.IdLbl.TabIndex = 0;
            this.IdLbl.Text = "ID Siswa";
            // 
            // MasukTxt
            // 
            this.MasukTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MasukTxt.BorderRadius = 20;
            this.MasukTxt.BorderThickness = 2;
            this.MasukTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MasukTxt.DefaultText = "";
            this.MasukTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MasukTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MasukTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MasukTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MasukTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MasukTxt.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.MasukTxt.ForeColor = System.Drawing.Color.Black;
            this.MasukTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MasukTxt.Location = new System.Drawing.Point(363, 557);
            this.MasukTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MasukTxt.Name = "MasukTxt";
            this.MasukTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.MasukTxt.PlaceholderText = "Tahun Masuk";
            this.MasukTxt.SelectedText = "";
            this.MasukTxt.Size = new System.Drawing.Size(342, 78);
            this.MasukTxt.TabIndex = 9;
            this.MasukTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MasukTxt_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 443);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tanggal Lahir";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Blue;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.FormPnl);
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(777, 752);
            this.guna2Panel2.TabIndex = 23;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // EditDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 752);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditDataFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDataFrmcs";
            this.Load += new System.EventHandler(this.EditDataFrm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.FormPnl.ResumeLayout(false);
            this.FormPnl.PerformLayout();
            this.InfoGbx.ResumeLayout(false);
            this.InfoGbx.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox NisnTxt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox NamaTxt;
        private Guna.UI2.WinForms.Guna2TextBox TempatTxt;
        private Guna.UI2.WinForms.Guna2ComboBox StatusCmb;
        private Guna.UI2.WinForms.Guna2TextBox AlamatTxt;
        private Guna.UI2.WinForms.Guna2TextBox NomorTxt;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxt;
        private Guna.UI2.WinForms.Guna2DateTimePicker LahirDtp;
        private Guna.UI2.WinForms.Guna2ComboBox kelaminCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button SimpanBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel FormPnl;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox MasukTxt;
        private Guna.UI2.WinForms.Guna2GroupBox InfoGbx;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label CreateLbl;
    }
}