using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLApp
{
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        public Form2()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=filmdb;Uid=root;Pwd=;");
            conn.Open();
            cbFilmRendezo.Items.Add("Rendezők");
            cbFilmRendezo.Items.Add("Filmek");
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void cbFilmRendezo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilmRendezo.SelectedItem.Equals("Rendezők"))
            {
                MessageBox.Show("Rendezők");
            }
            if (cbFilmRendezo.SelectedItem.Equals("Filmek"))
            {
                MessageBox.Show("Filmek");
            }
        }
    }
}
