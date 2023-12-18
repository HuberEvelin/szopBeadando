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
    public partial class UjRajzForm : Form
    {
        public UjRajzForm(Felhasznalo aktualis, BejelentkezesForm l)
        {
            InitializeComponent();
            this.aktualisFelhasznalo = aktualis;
            this.loginForm = l;
        }

        Felhasznalo aktualisFelhasznalo;
        BejelentkezesForm loginForm;
        RestClient galeriaKliens = new RestClient("http://localhost/szerver2/galeria.php");

        private void mentesButton_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest();
            request.AddParameter("current_user_name", aktualisFelhasznalo.Felhasznalonev);
            request.AddParameter("current_user_password", aktualisFelhasznalo.Jelszo);
            request.AddParameter("new_drawing_name", rajzNeve.Text);
            request.AddParameter("new_drawing", rajz.Text);
            try
            {
                RestResponse response = galeriaKliens.Post(request);
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a rajz mentése során!");
            }
        }

        private void visszaButton_Click(object sender, EventArgs e)
        {
            PostaladaForm postaladaForm = new PostaladaForm(aktualisFelhasznalo, loginForm);
            postaladaForm.Show();
            this.Hide();
        }
    }
}
