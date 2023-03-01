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
    public partial class products : Form
    {//vebendung mit dem Datenbank
        //1 ich habe ein variable  von SQlconnection // in die klammer ich habe die Source gefügt aber das ist nicht genug die sind noch nicht verbindet
        private SqlConnection databaseconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alarab\Documents\NatureBioMarkt.mdf;Integrated Security=True;Connect Timeout=30");
        private int lastselectedprodkey;
        public products()
        {
            InitializeComponent();
            Showproduct();
            clearall();

        }
        // ich habe eine method geschrieben damit: wenn ich jedes mal ein neues product hinfügen dann ich muss den cod noch mal schreiben
        private void  Showproduct(){
            // ein verbendung 
            databaseconnection.Open(); // wir offnen die daten verbendung
            // zwischen open and close wir wolten die elemente sehen so wir schreiben ein query die wir unsesre elemente aus unsere datenbank bekommen
            string query = "select * from Product";
            // wir brauchen unsere query ausführen so erstellen wir die data sqladabter die führt der query in unsesre databaseconnection es ist kofigürirt aber nicht gestarted
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseconnection);
            // ich habe den query ausqeführt und jetzt die ergebniss die ich bekomme Product packe ich rein in
            var dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            //die quelle ist unsere datatset  die steht auf unsrere einziges Tabelle (Product)
            productsDGV.DataSource = dataset.Tables[0];
            productsDGV.Columns[0].Visible = false;

            databaseconnection.Close();// es ist wichtig nach dem offen das wir die wieder schliessen
        }

        private void products_Load(object sender, EventArgs e)
        {
          
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {  // damit ich die neue produkte speichern
          if(  textBox_ProductName.Text=="" 
             ||textBox_ProduktMarke.Text==""
             || textBox_ProductPrice.Text=="" 
             || comboBox_ProduktCategorie.Text =="")
            {
                MessageBox.Show("Bitte fülle alle Werte aus");
                return;
            }
            string productName = textBox_ProductName.Text;
            string productMarke = textBox_ProduktMarke.Text;
            string productKategorie = comboBox_ProduktCategorie.Text;
            string produktprice = textBox_ProductPrice.Text; // wir wollen von der text box als float geben deswegen benutzen wir parse
                                                             // nachdem ich die elemente hin fügen dann brauche ich die sehen kann die sind gesprichert aber ich sehe diein die tabelle nicht
            string query = string.Format("insert into Product values('{0}','{1}','{2}','{3}')", productName, productMarke, productKategorie, produktprice);
            executequery(query);
            // save product name in database
            Showproduct();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (lastselectedprodkey == 0)
            {
                MessageBox.Show("bitte wähle zuerst ein produkt aus");
                return;
            }
            

            string query = string.Format("edit Product set '{0}','{1}','{2}','{3}' where Id={4}",textBox_ProductName.Text, textBox_ProduktMarke.Text, comboBox_ProduktCategorie.Text, textBox_ProductPrice.Text, lastselectedprodkey);


            executequery(query);
            
            Showproduct();
        }

        private void btnProductDelet_Click(object sender, EventArgs e)
        {
            if (lastselectedprodkey == 0)
            {
                MessageBox.Show("bitte wähle zuerst ein produkt aus");
                return;
            }
            string query = string.Format("delete from Product where Id={0};", lastselectedprodkey);

            executequery(query);
            clearall();
            Showproduct();
        }
        private void clearall()
        {
            textBox_ProductName.Text = "";
            textBox_ProduktMarke.Text = "";
            comboBox_ProduktCategorie.Text = "";
            comboBox_ProduktCategorie.SelectedItem = null;
            textBox_ProductPrice.Text = "";

        }
        private void executequery(string query)
        {
            // ich erstelle ein neu Query
            //damit ich die info oben hier einbinden dan verwinde ich die string formel
           // string query = string.Format("insert into Product values('{0}','{1}','{2}','{3}')", productName, productMarke, productKategorie, produktprice);
            // Ausführen
            //1 query erstellen
            //2 daten in query einfügern
            //3 query executien
            //4 was wichtig mit datenbank verbinden aufbauen bevor query haben
            databaseconnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseconnection);
            sqlCommand.ExecuteNonQuery();
            
            databaseconnection.Close();
        }

        private void productsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { // ich will die liste update
         // 1 damit ich sehe was habe ich gewählt und steht in die felder rein dann : selectedrows das was ich ausgewält und [0 beduted das erste ausgewählt habe]
         // cells [1 steht für name] value weil der typ von value object ist deswegen verwende tostring
            textBox_ProductName.Text = productsDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBox_ProduktMarke.Text = productsDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboBox_ProduktCategorie.Text = productsDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBox_ProductPrice.Text = productsDGV.SelectedRows[0].Cells[4].Value.ToString();
            lastselectedprodkey =(int) productsDGV.SelectedRows[0].Cells[0].Value;
            Console.WriteLine(lastselectedprodkey);
        }
    }
}
