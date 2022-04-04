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
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string cs = "Data source=DESKTOP-P78IF02\\SQLEXPRESS; initial catalog=Skupstinskooni; integrated security=true";
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(cs);
        }


        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection veza = new SqlConnection(cs);
            veza.Open();
            DataTable Stranka = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Stranka", veza);
            SqlCommand naredba = new SqlCommand("select predsednik from Stranka where naziv ='" + textBox6.Text, veza);

            textBox1.Text = (naredba.ExecuteNonQuery()).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(cs);
            DataTable Poslanik = new DataTable();
            DataTable Auto = new DataTable();
            veza.Open();
            SqlDataAdapter adapter_1 = new SqlDataAdapter("select * from Auto", veza);
            adapter_1.Fill(Auto);
            SqlDataAdapter adapter_2 = new SqlDataAdapter("select * from Poslanik", veza);
            adapter_2.Fill(Poslanik);
            SqlCommand naredba_1 = new SqlCommand("select id_poslanika  from Poslanik  join Auto on Poslanik.id_auta= Auto.id where diploma = 'ne'", veza);
            

            int id= naredba_1.ExecuteNonQuery();
            
            textBox2.Text = Poslanik.Rows[id]["ime"].toString();
            textBox3.Text = Poslanik.Rows[id]["prezime"].toString();
            textBox4.Text = Auto.Rows[id]["marka"].toString();
            textBox5.Text = Auto.Rows[id]["model"].toString();
        }
    }
}
