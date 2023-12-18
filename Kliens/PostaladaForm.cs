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
    public partial class PostaladaForm : Form
    {
        Felhasznalo aktualisFelhasznalo = new Felhasznalo();
        BejelentkezesForm loginForm;
        RestClient postaKliens = new RestClient("http://localhost/szerver2/posta.php");
        public PostaladaForm(Felhasznalo aktualis, BejelentkezesForm l)
        {
            aktualisFelhasznalo = aktualis;
            loginForm = l;
            InitializeComponent();
            uzenetPanelInic();
            uzenetPanelFrissites(aktualisFelhasznalo);
            
        }
        
        void uzenetPanelInic()
        {
            uzenetekPanel.Columns.Add("idOszlop", "");
            uzenetekPanel.Columns.Add("feladoOszlop", "Feladó");
            uzenetekPanel.Columns.Add("uzenetOszlop", "Üzenet");

            uzenetekPanel.Columns["idOszlop"].Width = 0;
            uzenetekPanel.Columns["feladoOszlop"].Width = 100;
            uzenetekPanel.Columns["uzenetOszlop"].Width = 100;
        }

        

        void uzenetPanelFrissites(Felhasznalo aktualisFelhasznalo)
        {
            RestRequest request = new RestRequest();
            Console.WriteLine(aktualisFelhasznalo.Felhasznalonev);
            request.AddParameter("current_user_name", aktualisFelhasznalo.Felhasznalonev);
            request.AddParameter("current_user_password", aktualisFelhasznalo.Jelszo);
            try
            {
                RestResponse response = postaKliens.Get(request);
                PostaResponse res = postaKliens.Deserialize<PostaResponse>(response).Data;
                uzenetekPanel.Rows.Clear();

                foreach (Uzenet c in res.Tartalom)
                {
                    uzenetekPanel.Rows.Add(c.Id, c.Kuldo_id, c.Uzenet_id);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a táblázat feltöltése során!");
            }
        }

        private void kijelentkezes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ujUzenet_Click(object sender, EventArgs e)
        {
            UjUzenetForm ujUzenetForm = new UjUzenetForm(aktualisFelhasznalo, loginForm);
            ujUzenetForm.Show();
            this.Hide();
        }

        private void ujRajz_Click(object sender, EventArgs e)
        {
            UjRajzForm ujRajzForm = new UjRajzForm(aktualisFelhasznalo, loginForm);
            ujRajzForm.Show();
            this.Hide();
        }

        private void frissitesButton_Click(object sender, EventArgs e)
        {
            uzenetPanelFrissites(aktualisFelhasznalo);
        }

        private void torlesButton_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest();
            request.AddBody(new
            {
                current_user_name = aktualisFelhasznalo.Felhasznalonev,
                current_user_password = aktualisFelhasznalo.Jelszo,
                id = int.Parse(uzenetekPanel.SelectedCells[0].OwningRow.Cells[0].Value.ToString()),
            });
            try
            {
                RestResponse response = postaKliens.Delete(request);
                Valasz res = postaKliens.Deserialize<Valasz>(response).Data;
                uzenetPanelFrissites(aktualisFelhasznalo);
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a törlés során!");
            }
        }
    }
}
