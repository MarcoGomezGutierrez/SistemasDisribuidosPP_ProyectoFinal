using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Forms
{
    public partial class Client : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public int ID;
        public string NickName;
        public int Monedero;
        public Client(string nickName, int ID)
        {
            InitializeComponent();
            this.ID = ID;
            this.NickName = nickName;
            this.Monedero = 0;
            this.lbl_error.Show();
            OcultarTodo();
        }

        private void OcultarTodo()
        {
            this.btn_tienda.Enabled = true;
            this.btn_buscar.Enabled = true;
            this.btn_verNfts.Enabled = true;
            this.lbl_store.Hide();
            this.lbl_cofreNormal.Hide();
            this.lbl_cofreRaro.Hide();
            this.lbl_cofreLegendario.Hide();
            this.panel_cofreNormal.Hide();
            this.panel_cofreRaro.Hide();
            this.panel_cofreLegendario.Hide();
            this.lbl_dineroNormal.Hide();
            this.lbl_dineroRaro.Hide();
            this.lbl_dineroLegendario.Hide();
            this.btn_comprarCofreNormal.Hide();
            this.btn_comprarCofreRaro.Hide();
            this.btn_comprarCofreLegendario.Hide();
            this.pictureBox.Hide();
            this.lbl_id.Hide();
            this.lbl_nombre.Hide();
            this.lbl_error.Hide();
            this.txt_addFound.Hide();
            this.btn_wallet.Hide();
            this.btn_logOut.Hide();
            this.btn_exit.Hide();
            OcultarPictureBox();
            OcultarLblRepes();
        }

        private void OcultarLblRepes()
        {
            this.lbl_rep1.Hide();
            this.lbl_rep2.Hide();
            this.lbl_rep3.Hide();
            this.lbl_rep4.Hide();
            this.lbl_rep5.Hide();
            this.lbl_rep6.Hide();
            this.lbl_rep7.Hide();
            this.lbl_rep8.Hide();
            this.lbl_rep9.Hide();
            this.lbl_rep10.Hide();
            this.lbl_rep11.Hide();
            this.lbl_rep12.Hide();
            this.lbl_rep13.Hide();
            this.lbl_rep14.Hide();
            this.lbl_rep15.Hide();
            this.lbl_rep16.Hide();
            this.lbl_rep17.Hide();
            this.lbl_rep18.Hide();
        }

        private void MostrarLblRepes()
        {
            this.lbl_rep1.Show();
            this.lbl_rep2.Show();
            this.lbl_rep3.Show();
            this.lbl_rep4.Show();
            this.lbl_rep5.Show();
            this.lbl_rep6.Show();
            this.lbl_rep7.Show();
            this.lbl_rep8.Show();
            this.lbl_rep9.Show();
            this.lbl_rep10.Show();
            this.lbl_rep11.Show();
            this.lbl_rep12.Show();
            this.lbl_rep13.Show();
            this.lbl_rep14.Show();
            this.lbl_rep15.Show();
            this.lbl_rep16.Show();
            this.lbl_rep17.Show();
            this.lbl_rep18.Show();
        }

        private void OcultarPictureBox()
        {
            this.pictureBox1.Hide();
            this.pictureBox2.Hide();
            this.pictureBox3.Hide();
            this.pictureBox4.Hide();
            this.pictureBox5.Hide();
            this.pictureBox6.Hide();
            this.pictureBox7.Hide();
            this.pictureBox8.Hide();
            this.pictureBox9.Hide();
            this.pictureBox10.Hide();
            this.pictureBox11.Hide();
            this.pictureBox12.Hide();
            this.pictureBox13.Hide();
            this.pictureBox14.Hide();
            this.pictureBox15.Hide();
            this.pictureBox16.Hide();
            this.pictureBox17.Hide();
            this.pictureBox18.Hide();
        }

        private void MostrarPictureBox()
        {
            this.pictureBox1.Show();
            this.pictureBox2.Show();
            this.pictureBox3.Show();
            this.pictureBox4.Show();
            this.pictureBox5.Show();
            this.pictureBox6.Show();
            this.pictureBox7.Show();
            this.pictureBox8.Show();
            this.pictureBox9.Show();
            this.pictureBox10.Show();
            this.pictureBox11.Show();
            this.pictureBox12.Show();
            this.pictureBox13.Show();
            this.pictureBox14.Show();
            this.pictureBox15.Show();
            this.pictureBox16.Show();
            this.pictureBox17.Show();
            this.pictureBox18.Show();
        }

        private async void Client_Load(object sender, EventArgs e) //Consulta Get para traer el dinero del monedero
        {
            this.panel_central.BackColor = Color.FromArgb(100, 0, 0, 0);
            var response = await client.GetAsync("https://localhost:44326/api/Monedero/" + ID);
            var responseJson = await response.Content.ReadAsStringAsync();
            Monedero = JsonConvert.DeserializeObject<int>(responseJson);
            this.lbl_monedero.Text = "Wallet: " + Monedero + " €";
        }

        private void btn_tienda_Click(object sender, EventArgs e)
        {
            OcultarTodo();
            this.btn_tienda.Enabled = false;
            this.lbl_store.Show();
            this.lbl_cofreNormal.Show();
            this.lbl_cofreRaro.Show();
            this.lbl_cofreLegendario.Show();
            this.panel_cofreNormal.Show();
            this.panel_cofreRaro.Show();
            this.panel_cofreLegendario.Show();
            this.lbl_dineroNormal.Show();
            this.lbl_dineroRaro.Show();
            this.lbl_dineroLegendario.Show();
            this.btn_comprarCofreNormal.Show();
            this.btn_comprarCofreRaro.Show();
            this.btn_comprarCofreLegendario.Show();
            this.pictureBox.Show();
            this.lbl_id.Show();
            this.lbl_nombre.Show();
            this.lbl_error.Hide();
        }

        private void btn_comprarCofreNormal_Click(object sender, EventArgs e)
        {
            if (Monedero - 2 >= 0) //Comprobar que nunca este negativo
            {
                RestarDineroMonedero(ID.ToString(), "2", "1");
            } else //Si esta negativo lanzo error
            {
                this.pictureBox.Hide();
                this.lbl_error.Show();
            }
        }

        private void btn_comprarCofreRaro_Click(object sender, EventArgs e)
        {
            if (Monedero - 5 >= 0) //Comprobar que nunca este negativo
            {
                RestarDineroMonedero(ID.ToString(), "5" , "2");
            }
            else //Si esta negativo lanzo error
            {
                this.pictureBox.Hide();
                this.lbl_error.Show();
            }
        }

        private void btn_comprarCofreLegendario_Click(object sender, EventArgs e)
        {
            if (Monedero - 10 >= 0) //Comprobar que nunca este negativo
            {
                RestarDineroMonedero(ID.ToString(), "10", "3");
            }
            else //Si esta negativo lanzo error
            {
                this.pictureBox.Hide();
                this.lbl_error.Show();
            }
        }

        private async void RestarDineroMonedero(string id, string precio, string numCofre)
        {
            this.lbl_error.Hide();
            this.pictureBox.Show();
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                {"ID", id },
                {"Precio", "-" + precio }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://localhost:44326/api/Monedero", content);
            var responseJson = await response.Content.ReadAsStringAsync();
            int monedero = JsonConvert.DeserializeObject<int>(responseJson);
            if (monedero != -1)
            {
                Monedero = monedero;
                this.lbl_monedero.Text = "Wallet: " + Monedero + " €";
                AbrirCofre(numCofre, precio);
            } else //Mostrar que no se ha podido comprar
            {
                this.lbl_error.Show();
            }
        }

        private async void AbrirCofre(string numCofre, string dinero)
        {
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                {"NCofre", numCofre },
                {"Dinero", dinero },
                {"IdUsuario", ID.ToString() }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://localhost:44326/api/NFT", content);
            var responseJson = await response.Content.ReadAsStringAsync();
            ImagenesNft classImagen = JsonConvert.DeserializeObject<ImagenesNft>(responseJson);
            this.lbl_id.Text = "ID: " + classImagen.Id.ToString();
            this.lbl_nombre.Text = "Nombre: " + classImagen.Nombre;
            MemoryStream ms = new MemoryStream(classImagen.Img);
            this.pictureBox.Image = System.Drawing.Bitmap.FromStream(ms);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            OcultarTodo();
            this.btn_buscar.Enabled = false;
            MostrarPictureBox();
            MostrarLblRepes();
            RellenarPictureBox();
        }

        private void MenosTamañoLetra()
        {
            this.lbl_rep1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep8.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep9.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep10.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep11.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep12.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep13.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep14.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep15.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep16.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep17.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep18.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void MasTamañoLetra()
        {
            this.lbl_rep1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep8.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep9.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep10.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep12.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep13.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep14.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep15.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep16.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep17.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rep18.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void PonerNombreLbl()
        {
            this.lbl_rep1.Text = "Archer";
            this.lbl_rep2.Text = "Rare Archer";
            this.lbl_rep3.Text = "Legendary Archer";
            this.lbl_rep4.Text = "Thief";
            this.lbl_rep5.Text = "Rare Thief";
            this.lbl_rep6.Text = "Legendary Thief";
            this.lbl_rep7.Text = "Knight";
            this.lbl_rep8.Text = "Rare Knight";
            this.lbl_rep9.Text = "Legendary Knight";
            this.lbl_rep10.Text = "Cleric";
            this.lbl_rep11.Text = "Rare Cleric";
            this.lbl_rep12.Text = "Legendary Cleric";
            this.lbl_rep13.Text = "Mage";
            this.lbl_rep14.Text = "Rare Mage";
            this.lbl_rep15.Text = "Legendary Mage";
            this.lbl_rep16.Text = "Paladin";
            this.lbl_rep17.Text = "Rare Paladin";
            this.lbl_rep18.Text = "Legendary Paladin";
        }

        private void RellenarPictureBox()
        {
            PonerNombreLbl();
            MenosTamañoLetra();
            RellenarUnPictureBox(pictureBox1, "1");
            RellenarUnPictureBox(pictureBox2, "2");
            RellenarUnPictureBox(pictureBox3, "3");
            RellenarUnPictureBox(pictureBox4, "4");
            RellenarUnPictureBox(pictureBox5, "5");
            RellenarUnPictureBox(pictureBox6, "6");
            RellenarUnPictureBox(pictureBox7, "7");
            RellenarUnPictureBox(pictureBox8, "8");
            RellenarUnPictureBox(pictureBox9, "9");
            RellenarUnPictureBox(pictureBox10, "10");
            RellenarUnPictureBox(pictureBox11, "11");
            RellenarUnPictureBox(pictureBox12, "12");
            RellenarUnPictureBox(pictureBox13, "13");
            RellenarUnPictureBox(pictureBox14, "14");
            RellenarUnPictureBox(pictureBox15, "15");
            RellenarUnPictureBox(pictureBox16, "16");
            RellenarUnPictureBox(pictureBox17, "17");
            RellenarUnPictureBox(pictureBox18, "18");
        }

        private async void RellenarUnPictureBox(PictureBox pictureBox, string id)
        {
            var response = await client.GetAsync("https://localhost:44326/api/NFT/" + id);
            var responseJson = await response.Content.ReadAsStringAsync();
            byte[] imagenes = JsonConvert.DeserializeObject<byte[]>(responseJson);
            MemoryStream ms = new MemoryStream(imagenes);
            pictureBox.Image = System.Drawing.Bitmap.FromStream(ms);
        }

        private async void btn_verNfts_Click(object sender, EventArgs e)
        {
            OcultarTodo();
            this.btn_verNfts.Enabled = false;
            MostrarPictureBox();
            MostrarLblRepes();
            MasTamañoLetra();
            int repetido = await ContarRepetidos(ID, 1);
            PintarSiExiste(repetido, pictureBox1, 1, this.lbl_rep1);

            repetido = await ContarRepetidos(ID, 2);
            PintarSiExiste(repetido, pictureBox2, 2, this.lbl_rep2);

            repetido = await ContarRepetidos(ID, 3);
            PintarSiExiste(repetido, pictureBox3, 3, this.lbl_rep3);

            repetido = await ContarRepetidos(ID, 4);
            PintarSiExiste(repetido, pictureBox4, 4, this.lbl_rep4);

            repetido = await ContarRepetidos(ID, 5);
            PintarSiExiste(repetido, pictureBox5, 5, this.lbl_rep5);

            repetido = await ContarRepetidos(ID, 6);
            PintarSiExiste(repetido, pictureBox6, 6, this.lbl_rep6);

            repetido = await ContarRepetidos(ID, 7);
            PintarSiExiste(repetido, pictureBox7, 7, this.lbl_rep7);

            repetido = await ContarRepetidos(ID, 8);
            PintarSiExiste(repetido, pictureBox8, 8, this.lbl_rep8);

            repetido = await ContarRepetidos(ID, 9);
            PintarSiExiste(repetido, pictureBox9, 9, this.lbl_rep9);

            repetido = await ContarRepetidos(ID, 10);
            PintarSiExiste(repetido, pictureBox10, 10, this.lbl_rep10);

            repetido = await ContarRepetidos(ID, 11);
            PintarSiExiste(repetido, pictureBox11, 11, this.lbl_rep11);

            repetido = await ContarRepetidos(ID, 12);
            PintarSiExiste(repetido, pictureBox12, 12, this.lbl_rep12);

            repetido = await ContarRepetidos(ID, 13);
            PintarSiExiste(repetido, pictureBox13, 13, this.lbl_rep13);

            repetido = await ContarRepetidos(ID, 14);
            PintarSiExiste(repetido, pictureBox14, 14, this.lbl_rep14);

            repetido = await ContarRepetidos(ID, 15);
            PintarSiExiste(repetido, pictureBox15, 15, this.lbl_rep15);

            repetido = await ContarRepetidos(ID, 16);
            PintarSiExiste(repetido, pictureBox16, 16, this.lbl_rep16);

            repetido = await ContarRepetidos(ID, 17);
            PintarSiExiste(repetido, pictureBox17, 17, this.lbl_rep17);

            repetido = await ContarRepetidos(ID, 18);
            PintarSiExiste(repetido, pictureBox18, 18, this.lbl_rep18);

        }

        private void PintarSiExiste(int repes, PictureBox pictureBox, int imagenId, Label label)
        {
            if (repes > 0)
            {
                RellenarUnPictureBox(pictureBox, imagenId.ToString());
            } else
            {
                RellenarUnPictureBox(pictureBox, "19");
            }
            label.Text = "Repetido: " + repes;
        }
        private async Task<int> ContarRepetidos(int usuarioId, int imagenId)
        {
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                {"ImagenID", imagenId.ToString() }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PutAsync("https://localhost:44326/api/Usuario/" + usuarioId, content);
            var responseJson = await response.Content.ReadAsStringAsync();
            int repetido = int.Parse(JsonConvert.DeserializeObject<string>(responseJson));
            return repetido;
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            if (this.btn_wallet.Visible)
            {
                this.txt_addFound.Hide();
                this.btn_wallet.Hide();
                this.btn_logOut.Hide();
                this.btn_exit.Hide();
            } else
            {
                this.txt_addFound.Show();
                this.btn_wallet.Show();
                this.btn_logOut.Show();
                this.btn_exit.Show();
            }
            
        }

        private async void btn_wallet_Click(object sender, EventArgs e)
        {
            if (this.txt_addFound.Text.Length > 0)
            {
                Dictionary<string, string> values = new Dictionary<string, string>
                {
                    {"ID", this.ID.ToString() },
                    {"Precio",  this.txt_addFound.Text }
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync("https://localhost:44326/api/Monedero", content);
                var responseJson = await response.Content.ReadAsStringAsync();
                int monedero = JsonConvert.DeserializeObject<int>(responseJson);
                Monedero = monedero;
                this.lbl_monedero.Text = "Wallet: " + Monedero + " €";
            }
        }

        private void txt_addFound_KeyPress(object sender, KeyPressEventArgs e) //Solo meter numeros
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.login.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.login.Close();
        }
    }
}
