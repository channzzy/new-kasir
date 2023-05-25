using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.gudang
{
    public partial class GudangNavigation : Form
    {
        koneksi con = new koneksi();
        DataTable dt = new DataTable();
        string userid, tipeuser, nama;

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

        private void GudangNavigation_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void GudangNavigation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.E)
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



        public GudangNavigation(String userid, String tipeuser, String nama)
        {
            InitializeComponent();
            this.userid = userid;
            this.tipeuser = tipeuser;
            this.nama = nama;
            InititateRefresh();
        }
        public void InititateRefresh()
        {
            Txt_ID.Enabled = false;
            lblID.Enabled = false;
            Txt_Kode.Clear();
            Txt_Name.Clear();
            Txt_Jumlah.Clear();
            Txt_Harga.Clear();
            cmbx_satuan.SelectedIndex = -1;
            Btn_Hapus.Enabled = false;
            Btn_Edit.Enabled = false;
            viewDG();
            addCB();
        }

        private void cmbx_satuan_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Txt_Harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(Txt_Harga, "Hanya boleh angka");
            }
        }

        private void Txt_Jumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(Txt_Jumlah, "Hanya boleh angka");
            }
        }

        private void Btn_Tambah_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(Txt_Name.Text) || "".Equals(Txt_Harga.Text) || "".Equals(Txt_Jumlah.Text) || "".Equals(Txt_Kode.Text) || "".Equals(cmbx_satuan.Text))
                {
                    MessageBox.Show("Harap mengisi semua data");
                }
                else
                {
                    con.cud("insert into tbl_barang(kode_barang,nama_barang,expired_date,jumlah_barang,satuan,harga_satuan) values('" + Txt_Kode.Text + "','" + Txt_Name.Text + "','" + dtpicker.Value.ToString("yyyy-MM-dd") + "','" + Txt_Jumlah.Text + "','" + cmbx_satuan.Text + "','" + Txt_Harga.Text + "')");
                    MessageBox.Show("Data berhasil ditambahkan");
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

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result)
            {
                try
                {
                    if ("".Equals(Txt_Name.Text) || "".Equals(Txt_Harga.Text) || "".Equals(Txt_Jumlah.Text) || "".Equals(Txt_Kode.Text) || "".Equals(cmbx_satuan.Text))
                    {
                        MessageBox.Show("Harap mengisi semua data");
                    }
                    else
                    {
                        con.cud("update tbl_barang set kode_barang='" + Txt_Kode.Text + "',nama_barang='" + Txt_Name.Text + "',expired_date='" + dtpicker.Value.ToString("yyyy-MM-dd") + "',jumlah_barang='" + Txt_Jumlah.Text + "',satuan='" + cmbx_satuan.Text + "',harga_satuan='" + Txt_Harga.Text + "' where id_barang='" + Txt_ID.Text + "'");
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
                    if ("".Equals(Txt_Name.Text) || "".Equals(Txt_Harga.Text) || "".Equals(Txt_Jumlah.Text) || "".Equals(Txt_Kode.Text) || "".Equals(cmbx_satuan.Text))
                    {
                        MessageBox.Show("Harap mengisi semua data");
                    }
                    else
                    {
                        con.cud("delete tbl_barang where id_barang='" + Txt_ID.Text + "'");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Txt_ID.Text = row.Cells[0].Value.ToString();
                Txt_Kode.Text = row.Cells[1].Value.ToString();
                Txt_Name.Text = row.Cells[2].Value.ToString();
                dtpicker.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                Txt_Jumlah.Text = row.Cells[4].Value.ToString();
                cmbx_satuan.Text = row.Cells[5].Value.ToString();
                Txt_Harga.Text = row.Cells[6].Value.ToString();
            }
            Btn_Hapus.Enabled = true;
            Btn_Edit.Enabled = true;
            Btn_Tambah.Enabled = false;
        }

        private void cmbx_satuan_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        public void addCB()
        {
            cmbx_satuan.Items.Clear();
            cmbx_satuan.Refresh();

            cmbx_satuan.Items.Add("Cup");
            cmbx_satuan.Items.Add("Porsi");
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void Txt_Harga_TextChanged(object sender, EventArgs e)
        {

        }

        public void viewDG()
        {
            dt.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource = dt;
            con.select("select * from tbl_barang");
            con.adp.Fill(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "ID Barang";
            dataGridView1.Columns[1].HeaderText = "Kode Barang";
            dataGridView1.Columns[2].HeaderText = "Nama Barang";
            dataGridView1.Columns[3].HeaderText = "Expired Date";
            dataGridView1.Columns[4].HeaderText = "Jumlah Barang";
            dataGridView1.Columns[5].HeaderText = "Satuan";
            dataGridView1.Columns[6].HeaderText = "Harga Satuan";
           
        }
        private void searchData()
        {
            dt.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource = dt;
            con.select("select * from tbl_barang where kode_barang like '" + Txt_Search.Text + "%' or nama_barang like '" + Txt_Search.Text + "%' or jumlah_barang like '" + Txt_Search.Text + "%' or satuan like '" + Txt_Search.Text + "%' or harga_satuan like '" + Txt_Search.Text + "%'");
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
    }
}
