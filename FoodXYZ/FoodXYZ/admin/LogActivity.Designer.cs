namespace FoodXYZ.admin
{
    partial class LogActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogActivity));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Btn_KelolaUser = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_KelolaLaporan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dtpicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Btn_Filter = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.Btn_KelolaUser);
            this.guna2Panel1.Controls.Add(this.Btn_Logout);
            this.guna2Panel1.Controls.Add(this.Btn_KelolaLaporan);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(258, 740);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Admin Navigation";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(-2, 47);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(271, 264);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Btn_KelolaUser
            // 
            this.Btn_KelolaUser.BorderRadius = 10;
            this.Btn_KelolaUser.CheckedState.Parent = this.Btn_KelolaUser;
            this.Btn_KelolaUser.CustomImages.Parent = this.Btn_KelolaUser;
            this.Btn_KelolaUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_KelolaUser.ForeColor = System.Drawing.Color.White;
            this.Btn_KelolaUser.HoverState.Parent = this.Btn_KelolaUser;
            this.Btn_KelolaUser.Location = new System.Drawing.Point(18, 329);
            this.Btn_KelolaUser.Name = "Btn_KelolaUser";
            this.Btn_KelolaUser.ShadowDecoration.Parent = this.Btn_KelolaUser;
            this.Btn_KelolaUser.Size = new System.Drawing.Size(217, 58);
            this.Btn_KelolaUser.TabIndex = 7;
            this.Btn_KelolaUser.Text = "Kelola User";
            this.Btn_KelolaUser.Click += new System.EventHandler(this.Btn_KelolaUser_Click);
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
            // Btn_KelolaLaporan
            // 
            this.Btn_KelolaLaporan.BorderRadius = 10;
            this.Btn_KelolaLaporan.CheckedState.Parent = this.Btn_KelolaLaporan;
            this.Btn_KelolaLaporan.CustomImages.Parent = this.Btn_KelolaLaporan;
            this.Btn_KelolaLaporan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_KelolaLaporan.ForeColor = System.Drawing.Color.White;
            this.Btn_KelolaLaporan.HoverState.Parent = this.Btn_KelolaLaporan;
            this.Btn_KelolaLaporan.Location = new System.Drawing.Point(18, 397);
            this.Btn_KelolaLaporan.Name = "Btn_KelolaLaporan";
            this.Btn_KelolaLaporan.ShadowDecoration.Parent = this.Btn_KelolaLaporan;
            this.Btn_KelolaLaporan.Size = new System.Drawing.Size(217, 58);
            this.Btn_KelolaLaporan.TabIndex = 6;
            this.Btn_KelolaLaporan.Text = "Kelola Laporan";
            this.Btn_KelolaLaporan.Click += new System.EventHandler(this.Btn_KelolaLaporan_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(617, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Log Activity";
            // 
            // dtpicker
            // 
            this.dtpicker.BorderRadius = 10;
            this.dtpicker.CheckedState.Parent = this.dtpicker;
            this.dtpicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker.HoverState.Parent = this.dtpicker;
            this.dtpicker.Location = new System.Drawing.Point(300, 64);
            this.dtpicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.ShadowDecoration.Parent = this.dtpicker;
            this.dtpicker.Size = new System.Drawing.Size(275, 58);
            this.dtpicker.TabIndex = 9;
            this.dtpicker.Value = new System.DateTime(2023, 5, 25, 0, 0, 0, 0);
            // 
            // Btn_Filter
            // 
            this.Btn_Filter.BorderRadius = 10;
            this.Btn_Filter.CheckedState.Parent = this.Btn_Filter;
            this.Btn_Filter.CustomImages.Parent = this.Btn_Filter;
            this.Btn_Filter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Filter.ForeColor = System.Drawing.Color.White;
            this.Btn_Filter.HoverState.Parent = this.Btn_Filter;
            this.Btn_Filter.Location = new System.Drawing.Point(581, 64);
            this.Btn_Filter.Name = "Btn_Filter";
            this.Btn_Filter.ShadowDecoration.Parent = this.Btn_Filter;
            this.Btn_Filter.Size = new System.Drawing.Size(147, 58);
            this.Btn_Filter.TabIndex = 7;
            this.Btn_Filter.Text = "Filter";
            this.Btn_Filter.Click += new System.EventHandler(this.Btn_Filter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(300, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(744, 588);
            this.dataGridView1.TabIndex = 10;
            // 
            // LogActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1085, 740);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Filter);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogActivity";
            this.Load += new System.EventHandler(this.LogActivity_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogActivity_KeyDown);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button Btn_KelolaUser;
        private Guna.UI2.WinForms.Guna2Button Btn_Logout;
        private Guna.UI2.WinForms.Guna2Button Btn_KelolaLaporan;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button Btn_Filter;
    }
}