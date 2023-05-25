using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ
{
    class koneksi
    {
        public static string database = "Data Source=DESKTOP-RDRRV9U;Initial Catalog=FOODXYZ;Integrated Security=True";
        public SqlConnection con = new SqlConnection(database);
        public SqlCommand cmd;
        public SqlDataAdapter adp = new SqlDataAdapter();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        public void select(string query)
        {
            try
            {
                dt.Clear();
                con.Open();
                cmd = new SqlCommand(query, con);
                adp.SelectCommand = cmd;
                adp.Fill(dt);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void cud(string query)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public bool Test()
        {
            try
            {
                con.Open();
                MessageBox.Show("Hebat");
                con.Close();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
