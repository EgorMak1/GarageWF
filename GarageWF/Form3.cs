using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GarageWF
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //// ДОБАВЛЕИНЕ КЛИЕНТА... СДЕЛАТЬ МЕТОД!!!
        {
            string sqlExpressionToClient = "INSERT INTO Client (Name) VALUES (@Name)";
            string sqlExpressionToCar = "INSERT INTO Car (ClientID, ServiceID, RegistrationNumber, CarBrand) VALUES (@ClientId, @ServiceID, @RegistrationNumber, @CarBrand)";
            string sqlExpressionFromClient = "SELECT MAX(ClientID) AS ClientID FROM Client";
            
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TKLBKO0;Initial Catalog=garage;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand connectToClient = new SqlCommand(sqlExpressionToClient, connection);
                connectToClient.Parameters.AddWithValue("@Name", textBox1.Text);
              
                SqlCommand connectToCar = new SqlCommand(sqlExpressionToCar, connection);
                connectToCar.Parameters.AddWithValue("@CarBrand", textBox2.Text);
                connectToCar.Parameters.AddWithValue("@RegistrationNumber", textBox3.Text);
                connectToCar.Parameters.AddWithValue("@ServiceID", textBox4.Text);
                

                SqlCommand connectFromClient = new SqlCommand(sqlExpressionFromClient, connection);
                using(SqlDataReader reader = connectFromClient.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       int z = Convert.ToInt32(reader[0]);
                       connectToCar.Parameters.Add("@ClientID", SqlDbType.Int).Value = z+1;
                    }
                }  
                connectToClient.ExecuteNonQuery();
                connectToCar.ExecuteNonQuery();
                //connectFromClient.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)////ПОИСК МАШИНЫ ПО ClientID  
        {
            int carID;
            string clientName = textBox5.Text;
            string sqlExpressionFromClient = $"SELECT (ClientID) FROM Client WHERE (Name) IN ('{clientName}')";


            carID = takeCarIdFromTable(sqlExpressionFromClient);
            string sqlExpressionFromCar = $"SELECT (CarID), (ServiceID), (RegistrationNumber), (CarBrand) FROM (garage) WHERE (ClientID) = ('{carID}')";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TKLBKO0;Initial Catalog=garage;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand connectFromCar = new SqlCommand(sqlExpressionFromCar, connection);
                SqlDataReader reader = connectFromCar.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow((IDataRecord)reader);
                }
                reader.Close();
            }


        }

        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            MessageBox.Show((String.Format("{0}", dataRecord[0])));
        }

        public int takeCarIdFromTable(string sqlExpressionFromClient)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TKLBKO0;Initial Catalog=garage;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand connectFromClient = new SqlCommand(sqlExpressionFromClient, connection);
                SqlDataReader reader = connectFromClient.ExecuteReader();


                while (reader.Read())
                {
                    int carId = Convert.ToInt32(reader[0]);
                    MessageBox.Show(carId.ToString());
                    return Convert.ToInt32(reader[0]);
                    
                }

                connection.Close();
                return 0;
            }
           
        }
    }
}
