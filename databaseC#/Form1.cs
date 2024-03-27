using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace databaseC_
{
    public partial class Form1 : Form
    {
        koneksi koneksi=new koneksi();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            koneksi.bukaKoneksi();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            koneksi.tutupKoneksi();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            string kode =txtKode.Text;
            koneksi.bukaKoneksi();
            try
            {
                string query = "SELECT Email FROM Customers WHERE CustomerID=@code";
                SqlCommand con = new SqlCommand(query,koneksi.con);
                con.Parameters.AddWithValue("@code", kode);
                SqlDataReader dr = con.ExecuteReader();

                if(dr.Read()) 
                { 
                string nama = dr[0].ToString();
                    MessageBox.Show(nama);
                }
                else
                {
                    MessageBox.Show("data kosong");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            koneksi.tutupKoneksi();
        }
    }
}
