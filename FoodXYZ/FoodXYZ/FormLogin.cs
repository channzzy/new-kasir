using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ
{
    public partial class FormLogin : Form
    {
        koneksi con = new koneksi();
        DataTable dt = new DataTable();
        string userid, tipeuser, nama,telepon;
        public FormLogin()
        {
            InitializeComponent();
            this.userid = userid;
            this.tipeuser = tipeuser;
            this.nama = nama;
            this.telepon = telepon;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            
            
            if ("".Equals(Txt_Username.Text) || "".Equals(Txt_Password.Text))
            {
                MessageBox.Show("Harap Masukan Akun Anda");
            }else
            {
                con.select("select * from tbl_user where username='" + Txt_Username.Text + "' and password='" + Txt_Password.Text + "'");
                con.adp.Fill(dt);
                if(dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Akun Yang Anda Salah");
                }else
                {
                    foreach(DataRow dtr in dt.Rows)
                    {
                        userid = dtr[0].ToString();
                        tipeuser = dtr[1].ToString();
                        nama = dtr[2].ToString();
                        telepon = dtr[4].ToString();
                    }

                    con.cud("insert into tbl_log(aktivitas,waktu,id_user) values('Login','"+DateTime.Now.ToString("yyyy-MM-dd")+"','"+userid+"')");

                    if(tipeuser == "Admin")
                    {
                        admin.LogActivity la = new admin.LogActivity(userid, tipeuser, nama);
                        this.Hide();
                        la.ShowDialog();
                        this.Close();
                    }
                    else if (tipeuser == "Gudang")
                    {
                        gudang.GudangNavigation gn = new gudang.GudangNavigation(userid, tipeuser, nama);
                        this.Hide();
                        gn.ShowDialog();
                        this.Close();
                    }
                    else if (tipeuser == "Kasir")
                    {
                        kasir.KasirNavigation kn = new kasir.KasirNavigation(userid, tipeuser, nama,telepon);
                        this.Hide();
                        kn.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ada sesuatu yang salah");
                    }
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Txt_Username.Text = "Gudang";
            Txt_Password.Text = "Gudang";
        }
        
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Txt_Username.Text = "Kasir";
            Txt_Password.Text = "Kasir";
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Txt_Username.Text = "Admin";
            Txt_Password.Text = "Admin";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control == true && e.KeyCode == Keys.L)
            {
                Btn_Login.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.R)
            {
                Btn_Reset.PerformClick();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Txt_Username.Clear();
            Txt_Password.Clear();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
