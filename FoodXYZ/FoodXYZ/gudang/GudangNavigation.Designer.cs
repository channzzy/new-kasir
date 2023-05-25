namespace FoodXYZ.gudang
{
    partial class GudangNavigation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GudangNavigation));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txt_Harga = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_Kode = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_Tambah = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Jumlah = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_Hapus = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbx_satuan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Btn_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 473);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(757, 242);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Txt_Harga
            // 
            this.Txt_Harga.BorderRadius = 10;
            this.Txt_Harga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Harga.DefaultText = "";
            this.Txt_Harga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Harga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Harga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Harga.DisabledState.Parent = this.Txt_Harga;
            this.Txt_Harga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Harga.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Txt_Harga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Harga.FocusedState.Parent = this.Txt_Harga;
            this.Txt_Harga.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Txt_Harga.ForeColor = System.Drawing.Color.Black;
            this.Txt_Harga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Harga.HoverState.Parent = this.Txt_Harga;
            this.Txt_Harga.Location = new System.Drawing.Point(651, 282);
            this.Txt_Harga.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Txt_Harga.Name = "Txt_Harga";
            this.Txt_Harga.PasswordChar = '\0';
            this.Txt_Harga.PlaceholderText = "";
            this.Txt_Harga.SelectedText = "";
            this.Txt_Harga.ShadowDecoration.Parent = this.Txt_Harga;
            this.Txt_Harga.Size = new System.Drawing.Size(300, 60);
            this.Txt_Harga.TabIndex = 26;
            this.Txt_Harga.TextChanged += new System.EventHandler(this.Txt_Harga_TextChanged);
            this.Txt_Harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Harga_KeyPress);
            // 
            // Txt_Kode
            // 
            this.Txt_Kode.BorderRadius = 10;
            this.Txt_Kode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Kode.DefaultText = "";
            this.Txt_Kode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Kode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Kode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Kode.DisabledState.Parent = this.Txt_Kode;
            this.Txt_Kode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Kode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Txt_Kode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Kode.FocusedState.Parent = this.Txt_Kode;
            this.Txt_Kode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Txt_Kode.ForeColor = System.Drawing.Color.Black;
            this.Txt_Kode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Kode.HoverState.Parent = this.Txt_Kode;
            this.Txt_Kode.Location = new System.Drawing.Point(277, 74);
            this.Txt_Kode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Txt_Kode.Name = "Txt_Kode";
            this.Txt_Kode.PasswordChar = '\0';
            this.Txt_Kode.PlaceholderText = "";
            this.Txt_Kode.SelectedText = "";
            this.Txt_Kode.ShadowDecoration.Parent = this.Txt_Kode;
            this.Txt_Kode.Size = new System.Drawing.Size(300, 60);
            this.Txt_Kode.TabIndex = 30;
            // 
            // Btn_Tambah
            // 
            this.Btn_Tambah.BorderRadius = 10;
            this.Btn_Tambah.CheckedState.Parent = this.Btn_Tambah;
            this.Btn_Tambah.CustomImages.Parent = this.Btn_Tambah;
            this.Btn_Tambah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Tambah.ForeColor = System.Drawing.Color.White;
            this.Btn_Tambah.HoverState.Parent = this.Btn_Tambah;
            this.Btn_Tambah.Location = new System.Drawing.Point(277, 351);
            this.Btn_Tambah.Name = "Btn_Tambah";
            this.Btn_Tambah.ShadowDecoration.Parent = this.Btn_Tambah;
            this.Btn_Tambah.Size = new System.Drawing.Size(175, 58);
            this.Btn_Tambah.TabIndex = 16;
            this.Btn_Tambah.Text = "Tambah";
            this.Btn_Tambah.Click += new System.EventHandler(this.Btn_Tambah_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(646, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Harga Per Satuan";
            // 
            // Txt_Jumlah
            // 
            this.Txt_Jumlah.BorderRadius = 10;
            this.Txt_Jumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Jumlah.DefaultText = "";
            this.Txt_Jumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Jumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Jumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Jumlah.DisabledState.Parent = this.Txt_Jumlah;
            this.Txt_Jumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Jumlah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Txt_Jumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Jumlah.FocusedState.Parent = this.Txt_Jumlah;
            this.Txt_Jumlah.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Txt_Jumlah.ForeColor = System.Drawing.Color.Black;
            this.Txt_Jumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Jumlah.HoverState.Parent = this.Txt_Jumlah;
            this.Txt_Jumlah.Location = new System.Drawing.Point(651, 74);
            this.Txt_Jumlah.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Txt_Jumlah.Name = "Txt_Jumlah";
            this.Txt_Jumlah.PasswordChar = '\0';
            this.Txt_Jumlah.PlaceholderText = "";
            this.Txt_Jumlah.SelectedText = "";
            this.Txt_Jumlah.ShadowDecoration.Parent = this.Txt_Jumlah;
            this.Txt_Jumlah.Size = new System.Drawing.Size(300, 60);
            this.Txt_Jumlah.TabIndex = 29;
            this.Txt_Jumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Jumlah_KeyPress);
            // 
            // Btn_Hapus
            // 
            this.Btn_Hapus.BorderRadius = 10;
            this.Btn_Hapus.CheckedState.Parent = this.Btn_Hapus;
            this.Btn_Hapus.CustomImages.Parent = this.Btn_Hapus;
            this.Btn_Hapus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Hapus.ForeColor = System.Drawing.Color.White;
            this.Btn_Hapus.HoverState.Parent = this.Btn_Hapus;
            this.Btn_Hapus.Location = new System.Drawing.Point(639, 351);
            this.Btn_Hapus.Name = "Btn_Hapus";
            this.Btn_Hapus.ShadowDecoration.Parent = this.Btn_Hapus;
            this.Btn_Hapus.Size = new System.Drawing.Size(175, 58);
            this.Btn_Hapus.TabIndex = 14;
            this.Btn_Hapus.Text = "Hapus";
            this.Btn_Hapus.Click += new System.EventHandler(this.Btn_Hapus_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BorderRadius = 10;
            this.Btn_Edit.CheckedState.Parent = this.Btn_Edit;
            this.Btn_Edit.CustomImages.Parent = this.Btn_Edit;
            this.Btn_Edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit.ForeColor = System.Drawing.Color.White;
            this.Btn_Edit.HoverState.Parent = this.Btn_Edit;
            this.Btn_Edit.Location = new System.Drawing.Point(458, 351);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.ShadowDecoration.Parent = this.Btn_Edit;
            this.Btn_Edit.Size = new System.Drawing.Size(175, 58);
            this.Btn_Edit.TabIndex = 15;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(272, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kode Barang";
            // 
            // Txt_Search
            // 
            this.Txt_Search.BorderRadius = 10;
            this.Txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Search.DefaultText = "";
            this.Txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Search.DisabledState.Parent = this.Txt_Search;
            this.Txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Search.FocusedState.Parent = this.Txt_Search;
            this.Txt_Search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Txt_Search.ForeColor = System.Drawing.Color.Black;
            this.Txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Search.HoverState.Parent = this.Txt_Search;
            this.Txt_Search.Location = new System.Drawing.Point(277, 418);
            this.Txt_Search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.PasswordChar = '\0';
            this.Txt_Search.PlaceholderText = "Cari User";
            this.Txt_Search.SelectedText = "";
            this.Txt_Search.ShadowDecoration.Parent = this.Txt_Search;
            this.Txt_Search.Size = new System.Drawing.Size(300, 46);
            this.Txt_Search.TabIndex = 28;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // Txt_ID
            // 
            this.Txt_ID.BorderRadius = 10;
            this.Txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_ID.DefaultText = "";
            this.Txt_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_ID.DisabledState.Parent = this.Txt_ID;
            this.Txt_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_ID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Txt_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_ID.FocusedState.Parent = this.Txt_ID;
            this.Txt_ID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Txt_ID.ForeColor = System.Drawing.Color.Black;
            this.Txt_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_ID.HoverState.Parent = this.Txt_ID;
            this.Txt_ID.Location = new System.Drawing.Point(301, 548);
            this.Txt_ID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.PasswordChar = '\0';
            this.Txt_ID.PlaceholderText = "";
            this.Txt_ID.SelectedText = "";
            this.Txt_ID.ShadowDecoration.Parent = this.Txt_ID;
            this.Txt_ID.Size = new System.Drawing.Size(300, 60);
            this.Txt_ID.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(646, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Jumlah Barang";
            // 
            // Txt_Name
            // 
            this.Txt_Name.BorderRadius = 10;
            this.Txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Name.DefaultText = "";
            this.Txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Name.DisabledState.Parent = this.Txt_Name;
            this.Txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Txt_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Name.FocusedState.Parent = this.Txt_Name;
            this.Txt_Name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Txt_Name.ForeColor = System.Drawing.Color.Black;
            this.Txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Name.HoverState.Parent = this.Txt_Name;
            this.Txt_Name.Location = new System.Drawing.Point(277, 180);
            this.Txt_Name.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.PasswordChar = '\0';
            this.Txt_Name.PlaceholderText = "";
            this.Txt_Name.SelectedText = "";
            this.Txt_Name.ShadowDecoration.Parent = this.Txt_Name;
            this.Txt_Name.Size = new System.Drawing.Size(300, 60);
            this.Txt_Name.TabIndex = 31;
            // 
            // cmbx_satuan
            // 
            this.cmbx_satuan.BackColor = System.Drawing.Color.Transparent;
            this.cmbx_satuan.BorderRadius = 10;
            this.cmbx_satuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbx_satuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_satuan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbx_satuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbx_satuan.FocusedState.Parent = this.cmbx_satuan;
            this.cmbx_satuan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_satuan.ForeColor = System.Drawing.Color.Black;
            this.cmbx_satuan.HoverState.Parent = this.cmbx_satuan;
            this.cmbx_satuan.ItemHeight = 30;
            this.cmbx_satuan.ItemsAppearance.Parent = this.cmbx_satuan;
            this.cmbx_satuan.Location = new System.Drawing.Point(651, 191);
            this.cmbx_satuan.Name = "cmbx_satuan";
            this.cmbx_satuan.ShadowDecoration.Parent = this.cmbx_satuan;
            this.cmbx_satuan.Size = new System.Drawing.Size(300, 36);
            this.cmbx_satuan.TabIndex = 25;
            this.cmbx_satuan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbx_satuan_KeyDown);
            this.cmbx_satuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbx_satuan_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(272, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(646, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Satuan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(578, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kelola Barang";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(-11, 51);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(271, 264);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.BorderRadius = 10;
            this.Btn_Logout.CheckedState.Parent = this.Btn_Logout;
            this.Btn_Logout.CustomImages.Parent = this.Btn_Logout;
            this.Btn_Logout.FillColor = System.Drawing.Color.Red;
            this.Btn_Logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Logout.ForeColor = System.Drawing.Color.White;
            this.Btn_Logout.HoverState.Parent = this.Btn_Logout;
            this.Btn_Logout.Location = new System.Drawing.Point(18, 670);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.ShadowDecoration.Parent = this.Btn_Logout;
            this.Btn_Logout.Size = new System.Drawing.Size(217, 58);
            this.Btn_Logout.TabIndex = 5;
            this.Btn_Logout.Text = "Logout";
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(296, 517);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(99, 25);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "Telepon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gudang Navigation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(272, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Expired Date";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.Btn_Logout);
            this.guna2Panel1.Location = new System.Drawing.Point(-3, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(258, 740);
            this.guna2Panel1.TabIndex = 13;
            // 
            // dtpicker
            // 
            this.dtpicker.BorderRadius = 10;
            this.dtpicker.CheckedState.Parent = this.dtpicker;
            this.dtpicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker.HoverState.Parent = this.dtpicker;
            this.dtpicker.Location = new System.Drawing.Point(277, 287);
            this.dtpicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.ShadowDecoration.Parent = this.dtpicker;
            this.dtpicker.Size = new System.Drawing.Size(300, 58);
            this.dtpicker.TabIndex = 34;
            this.dtpicker.Value = new System.DateTime(2023, 5, 25, 0, 0, 0, 0);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // GudangNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1085, 740);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_Harga);
            this.Controls.Add(this.Txt_Kode);
            this.Controls.Add(this.Btn_Tambah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_Jumlah);
            this.Controls.Add(this.Btn_Hapus);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.cmbx_satuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GudangNavigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GudangNavigation";
            this.Load += new System.EventHandler(this.GudangNavigation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GudangNavigation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Harga;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Kode;
        private Guna.UI2.WinForms.Guna2Button Btn_Tambah;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Jumlah;
        private Guna.UI2.WinForms.Guna2Button Btn_Hapus;
        private Guna.UI2.WinForms.Guna2Button Btn_Edit;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Search;
        private Guna.UI2.WinForms.Guna2TextBox Txt_ID;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Name;
        private Guna.UI2.WinForms.Guna2ComboBox cmbx_satuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button Btn_Logout;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpicker;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}