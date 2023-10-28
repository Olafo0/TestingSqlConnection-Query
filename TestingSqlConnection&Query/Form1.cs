using System.Data.SqlClient;

namespace TestingSqlConnection_Query
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DESKTOP-DNB9KRF;Initial Catalog=CustomerUsers;Integrated Security=True;";
        SqlConnection cnn;
        SqlCommand command;



        public Form1()
        {
            InitializeComponent();
        }

        // Opening the database
        private void OpnCnBT_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Database has been opned");

        }


        // Running a queryt
        private void RunQuery_Click(object sender, EventArgs e)
        {
            SqlDataReader dataReader;
            String queryString, Output = "";

            queryString = "SELECT * FROM CustomerTB";

            command = new SqlCommand(queryString, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {

                Output = Output + dataReader.GetValue(0);
            }
            MessageBox.Show(Output);
            command.Dispose();
            cnn.Close();
        }

        // Inserting new items to a table
        private void InsertBTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            String Query = "";

            Query = "Insert into CustomerTB(FirstName,LastName,Age,Gender) values('Liyla','Klinq',19,'F')";

            command = new SqlCommand(Query, cnn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();

        }

        // Insert into the database 
    }
}