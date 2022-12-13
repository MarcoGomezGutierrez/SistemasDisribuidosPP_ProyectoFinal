using Cliente.Forms;
using Cliente.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Login : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Login()
        {
            InitializeComponent();
        }
       
        private async void btn_register_Click(object sender, EventArgs e)
        {
            string nickName = this.txt_nickName.Text;
            string password = Encrypt.Encriptar(this.txt_password.Text);
            var values = new Dictionary<string, string>
            {
                {"LogIn",  "0"},
                {"NickName", nickName },
                {"Password", password }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://localhost:44326/api/Usuario", content);
            var responseJson = await response.Content.ReadAsStringAsync();
        }

        private void btn_moverBotonesRegistrar_Click(object sender, EventArgs e)
        {
            this.btn_login.Visible = false;
            this.btn_moverBotonesRegistrar.Visible = false;
            this.btn_register.Visible = true;
            this.btn_atras.Visible = true;
            this.lbl_titulo.Text = "Register";
            this.lbl_titulo.Left = 140;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.btn_login.Visible = true;
            this.btn_moverBotonesRegistrar.Visible = true;
            this.btn_register.Visible = false;
            this.btn_atras.Visible = false;
            this.lbl_titulo.Text = "Login";
            this.lbl_titulo.Left = 156;
        }

        private void checkBox_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_mostrar.Checked)
            {
                this.txt_password.UseSystemPasswordChar = true;
            } else
            {
                this.txt_password.UseSystemPasswordChar = false;
            }
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string nickName = this.txt_nickName.Text;
            string password = this.txt_password.Text;
            if (nickName.Length > 0 && password.Length > 0)
            {
                var values = new Dictionary<string, string>
                {
                    {"LogIn",  "1"},
                    {"NickName", nickName },
                    {"Password", password }
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync("https://localhost:44326/api/Usuario", content);
                var responseJson = await response.Content.ReadAsStringAsync();
                UsuarioResponse usuarioResponse = JsonConvert.DeserializeObject<UsuarioResponse>(responseJson);
                string contraseñaDesencriptada = Encrypt.Desencriptar(usuarioResponse.Password);
                if (password == contraseñaDesencriptada) //Coincide la contraseña -> Enviar a Form1
                {
                    Program.login.Hide();
                    Client client = new Client(usuarioResponse.NickName, usuarioResponse.ID);
                    client.Show();
                } else //No coincide -> Me quedo y muestro error de que no coincide
                {
                    this.lbl_error.Text = "Usuario o Contraseña incorrectos";
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.panel_central.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
