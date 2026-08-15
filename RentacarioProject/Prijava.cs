using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentacarioProject
{
    public partial class Prijava : Form
    {
        private string connectionString =
        "Server=31.147.206.65;" +
        "Database=PI2526_lseremet22_DB;" +
        "User Id=PI2526_lseremet22;" +
        "Password=7*sW1R}.&7K)B-.);";

        private Employee employee;

        public Prijava()
        {
            InitializeComponent();
        }

        private void Prijava_Load(object sender, EventArgs e)
        {

        }

        private void gumbPrijava_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // skuplja vrijednosti iz textboxova
                String username = useranameBox.Text;
                String password = passwordBox.Text;

                // select upit
                string query = "select * from zaposlenici where korisnickoime=@username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //stvara objekt employee sa podacima iz baze prema korisnickom imenu
                            employee = new Employee(
                                reader["korisnickoime"].ToString(),
                                reader["lozinka"].ToString(),
                                Convert.ToInt32(reader["pozicija"])
                            );
                        }
                    }
                    if (employee.getPassword() == password)
                    {
                        Homepage homepage = new Homepage(employee, 840, 620);
                        homepage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
                    }
                }
            }
        }
    }
}
