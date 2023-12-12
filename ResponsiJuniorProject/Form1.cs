using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ResponsiJuniorProject
{
    public partial class Form1 : Form
    {
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi";

        public Form1()
        {
            InitializeComponent();
            PopulateCBDept();
        }

        private void PopulateCBDept()
        {
            string query = "SELECT nama_dep FROM departemen";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nama_dep = reader.GetString(0);
                            cbDept.Items.Add(nama_dep);
                        }
                    }
                }
                conn.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string deptQuery = "SELECT id_dep FROM departemen WHERE nama_dep = @nama_dep";
                    int id_dep;
                    using (var deptCmd = new NpgsqlCommand(deptQuery, conn))
                    {
                        deptCmd.Parameters.AddWithValue("@nama_dep", cbDept.SelectedItem.ToString());
                        id_dep = (int)deptCmd.ExecuteScalar();
                    }

                    string insertSql = "INSERT INTO karyawan (nama, id_dep) VALUES (@nama, @id_dep)";
                    using (var cmd = new NpgsqlCommand(insertSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", tbKaryawan.Text);
                        cmd.Parameters.AddWithValue("@id_dep", id_dep);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data karyawan telah berhasil disimpan.");
                        }
                        else
                        {
                            MessageBox.Show("Gagal menyimpan data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

    }
}
