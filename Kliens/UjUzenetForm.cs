using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeadandoV3.Kliens
{
    public partial class UjUzenetForm : Form
    {
        public UjUzenetForm(Felhasznalo aktualis, BejelentkezesForm l)
        {
            InitializeComponent();
            this.aktualisFelhasznalo = aktualis;
            bejelentkezoForm = l;
        }

        Felhasznalo aktualisFelhasznalo;
        BejelentkezesForm bejelentkezoForm;
        RestClient postaKliens = new RestClient("http://localhost/szerver2/posta.php");
        RestClient galeriaKliens = new RestClient("http://localhost/szerver2/galeria.php");

        private async void UjUzenetForm_Load(object sender, EventArgs e)
        {
            var galeriaAdatok = await GaleriaAdatokLekerese();

            legorduloMenu.DataSource = galeriaAdatok;
            legorduloMenu.DisplayMember = "RajzNev";

            if (galeriaAdatok.Count > 0)
            {
                legorduloMenu.SelectedIndex = 0;
            }

            RajzInfo elsoRajz = galeriaAdatok.FirstOrDefault();
            if (elsoRajz != null)
            {
                kepTextbox.Text = elsoRajz.Rajz;
            }
        }

        private async Task<List<RajzInfo>> GaleriaAdatokLekerese()
        {
            RestRequest request = new RestRequest();
            request.AddParameter("current_user_name", aktualisFelhasznalo.Felhasznalonev);
            request.AddParameter("current_user_password", aktualisFelhasznalo.Jelszo);
            try
            {
                RestResponse response = galeriaKliens.Get(request);
                List<RajzInfo> galeriaAdatok = galeriaKliens.Deserialize<List<RajzInfo>>(response).Data;
                return galeriaAdatok;
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a galéria adatainak lekérdezése során!");
                return null;
            }
        }

        private void kuldesButton_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest();
            request.AddParameter("current_user_name", aktualisFelhasznalo.Felhasznalonev);
            request.AddParameter("current_user_password", aktualisFelhasznalo.Jelszo);
            request.AddParameter("other_user_name", cimzett.Text);
            RajzInfo kivalasztottRajz = legorduloMenu.SelectedItem as RajzInfo;
            request.AddParameter("message_id", kivalasztottRajz.Id);
            try
            {
                RestResponse response = postaKliens.Post(request);
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba az üzenet küldése során!");
            }
        }

        private void visszaButton_Click(object sender, EventArgs e)
        {
            PostaladaForm postaladaForm = new PostaladaForm(aktualisFelhasznalo, bejelentkezoForm);
            postaladaForm.Show();
            this.Hide();
        }

        private void legorduloMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            RajzInfo kivalasztottRajz = (RajzInfo)legorduloMenu.SelectedItem;
            kepTextbox.Text = kivalasztottRajz.Rajz ?? string.Empty;
        }
    }
}
