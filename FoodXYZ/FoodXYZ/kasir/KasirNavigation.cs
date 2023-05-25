using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;

namespace FoodXYZ.kasir
{
    public partial class KasirNavigation : Form
    {
        koneksi con = new koneksi();
        string userid, tipeuser, nama,telepon;
        int totalakhir, kembalian = 0;
        string idtransaksi;
        public KasirNavigation(String userid, String tipeuser, String nama,String telepon)
        {
            InitializeComponent();
            this.userid = userid;
            this.tipeuser = tipeuser;
            this.nama = nama;
            this.telepon = telepon;
            InitiateRefresh();
            addMetode();
            Btn_Print.Enabled = false;
            lblname.Text = telepon;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmbx_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbx_menu1.SelectedIndex != -1)
            {
                Txt_Harga.Text = (cmbx_menu1.SelectedItem as dynamic).Harga;
                Btn_Tambah.Enabled = true;
            }
            else
            {
                Txt_Harga.Text = "";
            }
        }

        private void Txt_Qty_TextChanged(object sender, EventArgs e)
        {
            hitungtotal();
        }

        private void Btn_Tambah_Click(object sender, EventArgs e)
        {
            var barang = (cmbx_menu1.SelectedItem as dynamic);
            int newID = (dataGridView1.Rows.Count + 1);
            string idtrx = "TR" + newID.ToString().PadLeft(3, '0');

            dataGridView1.Rows.Add(idtrx, barang.Value, barang.Kode, barang.Nama, barang.Harga, Txt_Qty.Text, Txt_Total.Text,cmbx_metode.Text,lblname.Text,Txt_NomerHP.Text);

            totalakhir += int.Parse(Txt_Total.Text);
            lbltotal.Text = totalakhir.ToString();
        }

        private void Btn_Bayar_Click(object sender, EventArgs e)
        {
            int bayar = int.Parse(Txt_Bayar.Text.ToString());
            int total = int.Parse(lbltotal.Text.ToString());

            if(bayar < total)
            {
                MessageBox.Show("Uang Anda Kurang");
            }else
            {
                MessageBox.Show("Pembayaran Berhasil");
                kembalian = bayar - total;
                lblkembalian.Text = kembalian.ToString();
                Btn_Save.Enabled = true;
            }
        }

        public void addMetode()
        {
            cmbx_metode.Items.Clear();
            cmbx_metode.Refresh();

            cmbx_metode.Items.Add("Tunai");
            cmbx_metode.Items.Add("Voucher");
        }


        public async void sendNotif(String nomor,String message)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // URL endpoint dari API yang ingin Anda hit
                    string apiURL = "http://notif.arkatech.id/send";

                    // Membuat data JSON yang akan dikirim dalam permintaan POST
                    string jsonBody = "{\"group\":\"pplg\",\"to\":\"" + nomor + "\",\"message\":\"" + message + "\"}";
                    Console.WriteLine("test" + jsonBody);
                    // Mengatur tipe media sebagai application/json
                    var content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");

                    // Menambahkan header Authorization
                    client.DefaultRequestHeaders.Add("Authorization", "brodkesin.notif");

                    // Mengirim permintaan POST ke API dan mendapatkan respon
                    HttpResponseMessage response = await client.PostAsync(apiURL, content);

                    // Memastikan respon berhasil (kode status 200 OK)
                    response.EnsureSuccessStatusCode();
                    // Membaca respon sebagai string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Tampilkan respon
                    Console.WriteLine("re:" + responseBody);
                }
                catch (Exception ex)
                {
                    // Tangani kesalahan jika terjadi
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            String no = DateTime.Now.ToString("yyyyMMddHHmmss");
            String nama = Txt_Nama.Text;
            DataTable dt = new DataTable();
            con.cud("insert into tbl_transaksi(no_transaksi,tgl_transaksi,total_bayar,id_user) values('" +no+ "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + Txt_Total.Text.ToString() + "','" + userid + "')");

            con.select("select max(id_transaksi) as t from tbl_transaksi");
            con.adp.Fill(dt);
            foreach(DataRow dtr in dt.Rows){
                idtransaksi = dtr[0].ToString();
            }

            Console.WriteLine("test" + idtransaksi);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                con.cud("insert into tbl_transaksidetail(id_transaksi,id_barang,qty,harga_satuan,subtotal,pembayaran,nomer_hp) values('" + idtransaksi + "','" + row.Cells[1].Value.ToString() + "','" + row.Cells[5].Value.ToString() + "','" + row.Cells[4].Value.ToString() + "','" + row.Cells[6].Value.ToString() + "','" + row.Cells[7].Value.ToString() + "','" + row.Cells[9].Value.ToString() +"')");
                
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                String message = "*Ada orderan baru nih*\\n" +
                    "No Trx: " + no + "\\n"+
                    "A/n : " + nama + "\\n\\n" +
                    "Pesanan:\\n" +
                    row.Cells[3].Value.ToString()+" x "+row.Cells[5].Value.ToString()+" porsi";
                sendNotif(lblname.Text.ToString(), message);
                String messageKonsumen = "*EXPO JABAR MASAGI XI RPL 1*\\n" +
                    "Terima kasih telah melakukan transaksi pembelian distand kami <3\\n" +
                    "No Trx : " + no + "\\n\\n" +
                    "Total Pesanan Anda:"+lbltotal.Text.ToString()+"\\n" +
                    "Jumlah Uang Anda:"+Txt_Bayar.Text.ToString()+"\\n"+
                    "Kembalian Anda:"+lblkembalian.Text.ToString()+"\\n"+
                    row.Cells[3].Value.ToString() + " x " + row.Cells[5].Value.ToString() + " porsi\\n\\n"+
                    "*Mampir Kesini Yu Ke Instagram Kami: @semestaverse_*";
                sendNotif(Txt_NomerHP.Text.ToString(), messageKonsumen);
                con.cud("update tbl_barang set jumlah_barang=jumlah_barang-" + row.Cells[5].Value.ToString() + " where id_barang='"+row.Cells[1].Value.ToString()+"'");
            }
            MessageBox.Show("Data Berhasil Disimpan");
            Btn_Print.Enabled = true;
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

        private void KasirNavigation_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void KasirNavigation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.R)
            {
                Btn_Reset.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.T)
            {
                Btn_Tambah.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.S)
            {
                Btn_Save.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.U)
            {
                Btn_Logout.PerformClick();
            }
        }

        private void Txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(Txt_Qty, "Hanya boleh angka");
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            kasir.KasirNavigation kn = new kasir.KasirNavigation(userid, tipeuser, nama, telepon);
            this.Hide();
            kn.ShowDialog();
            this.Close();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            FormReport fr = new FormReport();
            fr.ShowDialog();
        }

        private void cmbx_menu_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Txt_Bayar_TextChanged(object sender, EventArgs e)
        {
            if(Txt_Bayar.Text != "")
            {
                int bayar = int.Parse(Txt_Bayar.Text.ToString());
                int total = int.Parse(lbltotal.Text.ToString());
                    //MessageBox.Show("Pembayaran Berhasil");
                    kembalian = bayar - total;
                    lblkembalian.Text = kembalian.ToString();
                    Btn_Save.Enabled = true;
            }
            else
            {
                lblkembalian.Text = 0.ToString();
            }
        }

        private void cmbx_menu_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Btn_Print_Click_1(object sender, EventArgs e)
        {
            FormReport fr = new FormReport();
            fr.ShowDialog();
        }

        private void test_TextChanged(object sender, EventArgs e)
        {

        }

        public void InitiateRefresh()
        {
            Btn_Tambah.Enabled = false;
            Btn_Save.Enabled = false;
            Txt_Total.Enabled = false;
            Txt_Harga.Enabled = false;
            loadCB();
        }
        public void loadCB()
        {
            cmbx_menu1.DisplayMember = "Text";
            cmbx_menu1.ValueMember = "Value";
            DataTable cb = new DataTable();
            con.select("select id_barang,kode_barang,nama_barang,harga_satuan from tbl_barang");
            con.adp.Fill(cb);

            foreach(DataRow dtr in cb.Rows)
            {
                cmbx_menu1.Items.Add(new
                {
                    Value = dtr[0].ToString(),
                    Text = dtr[1].ToString() + " - " + dtr[2].ToString(),
                    Kode = dtr[1].ToString(),
                    Nama = dtr[2].ToString(),
                    Harga = dtr[3].ToString()
                });
            }
            hitungtotal();
        }
        public void hitungtotal()
        {
            int harga = 0;
            if (cmbx_menu1.SelectedIndex != -1)
            {
                harga = int.Parse(Txt_Harga.Text.ToString());
            }
            int qty = 0;
            if (Txt_Qty.Text != "")
            {
                qty = int.Parse(Txt_Qty.Text.ToString());
            }
            int total;
            total = harga * qty;
            Txt_Total.Text = total.ToString();
        }
    }
}
