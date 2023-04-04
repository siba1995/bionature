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

namespace NatureBioMarkt
{
    public partial class Rechnungs : Form
    {
        private SqlConnection dataconnect = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alarab\Desktop\nature\NatureBioMarkt\NatureBioMarkt.mdf;Integrated Security=True;Connect Timeout=30");
        public Rechnungs()
        {
            InitializeComponent();
            show();
        }

        private void Rechnungs_Load(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        //  when i an element to show and i do not want to write this code everytime 
        private void show()
        {
            dataconnect.Open();
            string query = "select * from Rechnung";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, dataconnect);
            var dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            // this hier to show my db table
            dataGrid.DataSource = dataset.Tables[0];
            dataGrid.Columns[0].Visible=false;
            dataconnect.Close();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1_emp.Text = dataGrid.SelectedRows[0].Cells[1].Value.ToString();
            textBox1_preis.Text = dataGrid.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = dataGrid.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void showquery (string query)
        {
            dataconnect.Open();
            SqlCommand sqlCommand = new SqlCommand(query, dataconnect);
            sqlCommand.ExecuteNonQuery();
            dataconnect.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string query = $"insert into Rechnung values ('{textBox1_emp.Text}','{comboBox1.Text}','{textBox1_preis.Text}')";
            show();
            showquery(query);
            show();
        }

        private void textBox1_emp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
