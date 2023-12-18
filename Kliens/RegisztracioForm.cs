using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeadandoV3.Kliens
{
    public partial class RegisztracioForm : Form
    {
        public RegisztracioForm()
        {
            InitializeComponent();
        }

        RestClient regisztraciosKliens = new RestClient("http://localhost/szerver2/felhasznalo.php");

        private void bejelentkezesButton_Click(object sender, EventArgs e)
        {
            BejelentkezesForm bejelentkezesForm = new BejelentkezesForm();
            bejelentkezesForm.Show();
            this.Hide();
        }

        private void regisztracioButton_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest();
            request.AddParameter("new_user_name", felhasznalonev.Text);
            request.AddParameter("new_user_password", jelszo.Text);
            try
            {
                RestResponse response = regisztraciosKliens.Post(request);
                Valasz res = regisztraciosKliens.Deserialize<Valasz>(response).Data;
                
                //Átirányítás
                BejelentkezesForm bejelentkezesForm = new BejelentkezesForm();
                bejelentkezesForm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a regisztráció során!");
            }
        }
    }
}
