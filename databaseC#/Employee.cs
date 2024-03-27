using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace databaseC_
{
    class Employee
    {
        public string CustomerID;
        public string firstName;
        public string lastName;
        public string Email;

        koneksi koneksi = new koneksi();
        public void Create()
        {
            try
                {
                    koneksi.bukaKoneksi();
                    string query = "INSERT INTO dbo.Customers (CustomerID, FirstName, LastName, Email) VALUES (@CustomerID, @FirstName, @LastName, @Email)";
                    using (SqlCommand command = new SqlCommand(query, koneksi.con))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", Email);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil dimasukkan");
                        }
                        else
                        {
                            MessageBox.Show("Data gagal dimasukkan");
                        }
                    }

                }
    catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }

        public DataSet Read()
        {
            DataSet ds = new DataSet();     
            try 
            {
                string query = "SELECT * FROM dbo.Customers"; // Perubahan disini
                SqlCommand command = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds, "Customers");
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ds;
        }

        public void Update() 
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "UPDATE dbo.Customers SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, koneksi.con))
                {
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", Email);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil diperbarui");
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diperbarui");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }

        public void Delete()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "DELETE FROM dbo.Customers WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, koneksi.con))
                {
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus");
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan atau gagal dihapus");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }
    }
}
