using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseC_
{
    public partial class DataName : Form
    {
        public DataName()
        {
            InitializeComponent();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();

        }

        void LoadData()
        {
            try
            {
                Employee emp = new Employee();
                DataSet ds = emp.Read();
                DataNama.DataSource = ds;
                DataNama.DataMember = "Customers";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ClearData()
        {
            textid.Text = "";
            textFirst.Text = "";
            textLast.Text = "";
            textEmail.Text = "";
            
        }

        private void txtSimpan_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (int.TryParse(textid.Text, out int customerId))
            {
                emp.CustomerID = customerId.ToString();
                emp.firstName = textFirst.Text;
                emp.lastName = textLast.Text;
                emp.Email = textEmail.Text;
                emp.Create();
                LoadData();
                ClearData();
            }
            else
            {
                MessageBox.Show("ID pelanggan harus berupa bilangan bulat.");
            }

        }

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (int.TryParse(textid.Text, out int customerId))
            {
                emp.CustomerID = customerId.ToString();
                emp.firstName = textFirst.Text;
                emp.lastName = textLast.Text;
                emp.Email = textEmail.Text;
                emp.Update();
                LoadData();
                ClearData();
            }
            else
            {
                MessageBox.Show("ID pelanggan harus berupa bilangan bulat.");
            }
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (int.TryParse(textid.Text, out int customerId))
            {
                emp.CustomerID = customerId.ToString();
                emp.Delete();
                LoadData();
                ClearData();
            }
            else
            {
                MessageBox.Show("ID pelanggan harus berupa bilangan bulat.");
            }
        }

        private void DataNama_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < DataNama.RowCount - 1)
            {
                int customerId;
                if (int.TryParse(DataNama.Rows[e.RowIndex].Cells[0].Value.ToString(), out customerId))
                {
                    textid.Text = customerId.ToString();
                }
                textFirst.Text = DataNama.Rows[e.RowIndex].Cells[1].Value.ToString();
                textLast.Text = DataNama.Rows[e.RowIndex].Cells[2].Value.ToString();
                textEmail.Text = DataNama.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
