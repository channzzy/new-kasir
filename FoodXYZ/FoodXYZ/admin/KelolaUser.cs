using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.admin
{

    public partial class KelolaUser : Form
    {
        koneksi con = new koneksi();
        DataTable dt = new DataTable();
        string userid, tipeuser, nama;

        private void Btn_KelolaLaporan_Click(object sender, EventArgs e)
        {
            admin.KelolaLaporan kl = new admin.KelolaLaporan(userid, tipeuser, nama);
            this.Hide();
            kl.ShowDialog();
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result)
            {
                FormLogin fl = new FormLogin();
                this.Hide();
                con.cud("update tbl_log set aktivitas='Logout',waktu='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where id_user='" + userid + "'");
                MessageBox.Show("Anda berhasil logout");
                fl.ShowDialog();
                this.Close();
            }
        }

        private void KelolaUser_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void KelolaUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.U)
            {
                Btn_KelolaUser.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.L)
            {
                Btn_KelolaLaporan.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.E)
            {
                Btn_Edit.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.T)
            {
                Btn_Tambah.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.H)
            {
                Btn_Hapus.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.P)
            {
                Btn_Logout.PerformClick();
            }
        }

        private void Btn_KelolaUser_Click(object sender, EventArgs e)
        {
            admin.KelolaUser ku = new admin.KelolaUser(userid, tipeuser, nama);
            this.Hide();
            ku.ShowDialog();
            this.Close();
        }

        public KelolaUser(String userid, String tipeuser, String nama)
        {
            InitializeComponent();
            this.userid = userid;
            this.tipeuser = tipeuser;
            this.nama = nama;
            InititateRefresh();
        }

        private void Btn_Tambah_Click(object sender, EventArgs e)
        {
            try
            {
                if("".Equals(Txt_Name.Text) || "".Equals(Txt_Password.Text) || "".Equals(Txt_Username.Text) || "".Equals(Txt_Telpon.Text) || "".Equals(Txt_Alamat.Text) || "".Equals(cmbx_tipe.Text))
                {
                    MessageBox.Show("Harap mengisi semua data");
                }else
                {
                    con.cud("insert into tbl_user(tipe_user,nama,alamat,telpon,username,password) values('" + cmbx_tipe.Text + "','" + Txt_Name.Text + "','" + Txt_Alamat.Text + "','" + Txt_Telpon.Text + "','" + Txt_Username.Text + "','" + Txt_Password.Text + "')");
                    MessageBox.Show("Data berhasil ditambahkan");
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                InititateRefresh();
            }
        }

        public void InititateRefresh()
        {
            Txt_ID.Enabled = false;
            lblID.Enabled = false;
            Txt_Username.Clear();
            Txt_Name.Clear();
            Txt_Alamat.Clear();
            Txt_Password.Clear();
            Txt_Telpon.Clear();
            cmbx_tipe.SelectedIndex = -1;
            Btn_Hapus.Enabled = false;
            Btn_Edit.Enabled = false;
            viewDG();
            addCB();
        }
        private void searchData()
        {
            dt.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource = dt;
            con.select("select * from tbl_user where tipe_user like '" +Txt_Search.Text+ "%' or nama like '" + Txt_Search.Text + "%' or telpon like '" + Txt_Search.Text + "%' or alamat like '" + Txt_Search.Text + "%'");
            con.adp.Fill(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "ID User";
            dataGridView1.Columns[1].HeaderText = "Tipe User";
            dataGridView1.Columns[2].HeaderText = "Nama User";
            dataGridView1.Columns[3].HeaderText = "Alamat";
            dataGridView1.Columns[4].HeaderText = "Telpon";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }
        private void Txt_Telpon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(Txt_Telpon, "Hanya boleh angka");
            }
        }

        private void cmbx_tipe_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Txt_ID.Text = row.Cells[0].Value.ToString();
                cmbx_tipe.Text = row.Cells[1].Value.ToString();
                Txt_Name.Text = row.Cells[2].Value.ToString();
                Txt_Alamat.Text = row.Cells[3].Value.ToString();
                Txt_Telpon.Text = row.Cells[4].Value.ToString();
                Txt_Username.Text = row.Cells[5].Value.ToString();
                Txt_Password.Text = row.Cells[6].Value.ToString();
            }
            Btn_Hapus.Enabled = true;
            Btn_Edit.Enabled = true;
            Btn_Tambah.Enabled = false;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DialogResult.Yes == result)
            {
                try
                {
                    if ("".Equals(Txt_Name.Text) || "".Equals(Txt_Password.Text) || "".Equals(Txt_Username.Text) || "".Equals(Txt_Telpon.Text) || "".Equals(Txt_Alamat.Text) || "".Equals(cmbx_tipe.Text))
                    {
                        MessageBox.Show("Harap mengisi semua data");
                    }
                    else
                    {
                        con.cud("update tbl_user set tipe_user='" + cmbx_tipe.Text + "',nama='" + Txt_Name.Text + "',alamat='" + Txt_Alamat.Text + "',telpon='" + Txt_Telpon.Text + "',username='" + Txt_Username.Text + "',password='" + Txt_Password.Text + "' where id_user='" + Txt_ID.Text + "'");
                        MessageBox.Show("Data berhasil diedit");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    InititateRefresh();
                }
            }
        }

        private void Btn_Hapus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result)
            {
                try
                {
                    if ("".Equals(Txt_Name.Text) || "".Equals(Txt_Password.Text) || "".Equals(Txt_Username.Text) || "".Equals(Txt_Telpon.Text) || "".Equals(Txt_Alamat.Text) || "".Equals(cmbx_tipe.Text))
                    {
                        MessageBox.Show("Harap mengisi semua data");
                    }
                    else
                    {
                        con.cud("delete tbl_user where id_user='" + Txt_ID.Text + "'");
                        MessageBox.Show("Data berhasil dihapus");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    InititateRefresh();
                }
            }
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        public void viewDG()
        {
            dt.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource = dt;
            con.select("select * from tbl_user where not tipe_user='Admin'");
            con.adp.Fill(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "ID User";
            dataGridView1.Columns[1].HeaderText = "Tipe User";
            dataGridView1.Columns[2].HeaderText = "Nama User";
            dataGridView1.Columns[3].HeaderText = "Alamat";
            dataGridView1.Columns[4].HeaderText = "Telpon";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }
        public void addCB() {
            cmbx_tipe.Items.Clear();
            cmbx_tipe.Refresh();

            cmbx_tipe.Items.Add("Gudang");
            cmbx_tipe.Items.Add("Kasir");
        }
    }
}
