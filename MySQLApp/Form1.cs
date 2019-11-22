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
    //LÉtező adatok módosítása, olyan rendező törlése ne legyen lehetséges akinek van filmje
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=filmdb;Uid=root;Pwd=;");
            conn.Open();
            filmekListBox.Enabled = false;
            tbCim.Enabled = false;
            tbHossz.Enabled = false;
            dtFilm.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            button1.Enabled = false;
            RendezoListazas();
            FilmListazas();
        }

        void RendezoListazas()
        {
            rendezoListBox.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, nev, szulDatum, szarmazas FROM rendezok ORDER BY nev";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var szulDatum = reader.GetDateTime("szulDatum");
                    var szarmazas = reader.GetString("szarmazas");
                   rendezoListBox.Items.Add(new Rendezo(id,nev, szulDatum, szarmazas));
                }
            }
        }
        void FilmListazas()
        {
            filmekListBox.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, cim, kiadas, hossz, rendezok_id from filmek";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var cim = reader.GetString("cim");
                    var kiadas = reader.GetDateTime("kiadas");
                    var hossz = reader.GetInt32("hossz");
                    var rendezok_id = reader.GetInt32("rendezok_id");
                    filmekListBox.Items.Add(new Film(id, cim, kiadas, hossz, rendezok_id));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void filmListaRendezo()
        {
            filmekListBox.Enabled = true;
            tbCim.Enabled = true;
            tbHossz.Enabled = true;
            dtFilm.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            button1.Enabled = true;
            filmekListBox.Items.Clear();
            var rendezo = (Rendezo)rendezoListBox.SelectedItem;
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, cim, kiadas, hossz, rendezok_id from filmek WHERE rendezok_id = @rendezok_id";
            cmd.Parameters.AddWithValue("@rendezok_id", rendezo.Id);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var cim = reader.GetString("cim");
                    var kiadas = reader.GetDateTime("kiadas");
                    var hossz = reader.GetInt32("hossz");
                    var rendezok_id = reader.GetInt32("rendezok_id");
                    filmekListBox.Items.Add(new Film(id, cim, kiadas, hossz, rendezok_id));
                }
            }
        }
        private void rendezoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmekListBox.Enabled = true;
            tbCim.Enabled = true;
            tbHossz.Enabled = true;
            dtFilm.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            button1.Enabled = true;
            filmekListBox.Items.Clear();
            var rendezo = (Rendezo)rendezoListBox.SelectedItem;
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, cim, kiadas, hossz, rendezok_id from filmek WHERE rendezok_id = @rendezok_id";
            cmd.Parameters.AddWithValue("@rendezok_id", rendezo.Id);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var cim = reader.GetString("cim");
                    var kiadas = reader.GetDateTime("kiadas");
                    var hossz = reader.GetInt32("hossz");
                    var rendezok_id = reader.GetInt32("rendezok_id");
                    filmekListBox.Items.Add(new Film(id, cim, kiadas, hossz, rendezok_id));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbNev.Text) && !String.IsNullOrWhiteSpace(tbSzarmazas.Text))
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO rendezok (nev, szulDatum, szarmazas) VALUES (@nev, @szulDatum, @szarmazas)";
                cmd.Parameters.AddWithValue("@nev", tbNev.Text);
                cmd.Parameters.AddWithValue("@szulDatum", dtSzulDatum.Value);
                cmd.Parameters.AddWithValue("@szarmazas", tbSzarmazas.Text);

                cmd.ExecuteNonQuery();
                RendezoListazas();
            }
            else
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
            }

        }

        private void btnRendezoDelete_Click(object sender, EventArgs e)
        {
            if (filmekListBox.Items.Count > 0)
            {
                MessageBox.Show("Nem törölhet olyan rendezőt, akinek van filmje.");
            }
            else
            {
                if (rendezoListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Nincs rendezo kivalasztva!");
                    return;
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM rendezok WHERE id = @id";
                var rendezo = (Rendezo)rendezoListBox.SelectedItem;
                cmd.Parameters.AddWithValue("@id", rendezo.Id);
                cmd.ExecuteNonQuery();
                RendezoListazas();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbCim.Text) && !String.IsNullOrWhiteSpace(tbHossz.Text) && rendezoListBox.SelectedIndex != -1)
            {
                var rendezo = (Rendezo)rendezoListBox.SelectedItem;
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO filmek (cim, kiadas, hossz, rendezok_id) VALUES (@cim, @kiadas, @hossz, @rendezok_id)";
                cmd.Parameters.AddWithValue("@cim", tbCim.Text);
                cmd.Parameters.AddWithValue("@kiadas", dtFilm.Value);
                cmd.Parameters.AddWithValue("@hossz", tbHossz.Text);
                cmd.Parameters.AddWithValue("@rendezok_id", rendezo.Id);

                cmd.ExecuteNonQuery();
                filmListaRendezo();
            }
            else
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
            }
        }
        Form2 formUpdate = new Form2();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            formUpdate.Show();
        }
    }
}
