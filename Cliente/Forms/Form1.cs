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

namespace Cliente
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public int ID;
        public string NickName;
        public Form1(string nickName, int ID)
        {
            InitializeComponent();
            this.ID = ID;
            this.NickName = nickName;
        }

        private async void btn_ejecutar_Click(object sender, EventArgs e)
        {
            //string dinero = this.txt_titulo.Text;
            var values = new Dictionary<string, string>
            {
                {"NCofre", this.txt_nCofre.Text },
                {"Dinero", "2" },
                {"IdUsuario", ID.ToString() }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://localhost:44326/api/NFT", content);
            var responseJson = await response.Content.ReadAsStringAsync();
            ImagenesNft classImagen = JsonConvert.DeserializeObject<ImagenesNft>(responseJson);
            this.txt_id.Text = classImagen.Id.ToString();
            this.txt_titulo.Text = classImagen.Nombre;
            MemoryStream ms = new MemoryStream(classImagen.Img);
            this.pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
        }

    }
}
