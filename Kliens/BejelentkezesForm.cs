using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;


namespace BeadandoV3.Kliens
{
    public partial class BejelentkezesForm : Form
    {
        public BejelentkezesForm()
        {
            InitializeComponent();
        }

        RestClient loginKliens = new RestClient("http://localhost/szerver2/bejelentkezes.php");

        private void BejelentkezesButton_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest();
            string felhTartalom = felhasznalonev.Text;
            string jelszTartalom = jelszoTextbox.Text;

            request.AddParameter("username", felhTartalom);
            request.AddParameter("password", jelszTartalom);
            
            try
            {
                RestResponse response = loginKliens.Get(request);
                LoginValasz res = loginKliens.Deserialize<LoginValasz>(response).Data;

                Felhasznalo u = new Felhasznalo()
                {
                    Id = res.Id,
                    Felhasznalonev = felhTartalom,
                    Jelszo = jelszTartalom,
                };
                PostaladaForm postalada = new PostaladaForm(u, this);
                postalada.Show();
                this.Hide();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a bejelentkezés során!");
            }
        }

        private void RegisztracioButton_Click(object sender, EventArgs e)
        {
            RegisztracioForm regisztracioForm = new RegisztracioForm();
            regisztracioForm.Show();
            this.Hide();
        }
    }
}
