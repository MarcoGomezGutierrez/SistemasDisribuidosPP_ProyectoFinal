using Servidor.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace Servidor.Controllers
{
    public class NFTController : ApiController
    {
        private int numNFTs = 18; //En total hay 18 IDs
        private int gruposNFTs = 6; //Grupos de Cartas compuestas por 3 cartas cada grupo
        static string ConexionSql = "server= " + SqlServer.Url + " ; database= CartasDB ; integrated security= true";
        SqlConnection conexion = new SqlConnection(ConexionSql);
        // GET: api/NFT
        public string Get()
        {
            return "value";
        }

        // GET: api/NFT/5
        public byte[] Get(int id) //Obtener una imagen por su ID de Imagen
        {
            return ObtenerImagenBytes(id);
        }

        // POST: api/NFT
        public ImagenNft Post([FromBody]Cofre value)
        {
            SumarDineroDB(value.Dinero); //Sumamos dinero a la base de datos

            int id = AbrirCofre(value.NCofre);
            GuardarCartaDB(value.IdUsuario, id);
            return new ImagenNft()
            {
                Id = id,
                Nombre = ObtenerNombreImagen(id),
                Img = ObtenerImagenBytes(id)
            };
        }

        // PUT: api/NFT/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/NFT/5
        public void Delete(int id)
        {
        }

        private void SumarDineroDB(int value)
        {
            string query = "exec Almacenar_Dinero " + value; //Hemos creado un procedure en la base de datos que nos almacena el dinero que ingresamos,
                                                             //la cantidad que teniamos en nuestro monedero anteriormente y la suma del precio anterior más lo que ingresamos
            conexion.Open();
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        private string ObtenerNombreImagen(int id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select Titulo from Imagenes where id=" + id, conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds, "titulo");
            string titulo = "";
            try
            {
                DataRow dr = ds.Tables["titulo"].Rows[0];
                titulo = (string)dr["Titulo"];
            }
            catch { }
            conexion.Close();
            return titulo.ToString();
        }

        private byte[] ObtenerImagenBytes(int id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select Imagen from Imagenes where id=" + id, conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds, "img");
            byte[] datos = new byte[0];
            try
            {
                DataRow dr = ds.Tables["img"].Rows[0];
                datos = (byte[])dr["Imagen"];
            }
            catch { }
            conexion.Close();
            return datos;
        }

        private void GuardarCartaDB(int idUsuario, int idCarta)
        {
            string query = "exec GuardarCartaUsuario " + idUsuario + ", " + idCarta;

            conexion.Open();
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        private int AbrirCofre(int NCofre)
        {
            Random rand = new Random();
            int num = rand.Next(1, 1000);
            int categoria = 0;
            if (NCofre == 1)
            {
                categoria = CofreNormal(num);
            } else if (NCofre == 2)
            {
                categoria = CofreRaro(num);
            } else
            {
                categoria = CofreLegendario(num);
            }
            int clase = rand.Next(1, gruposNFTs + 1);

            return (clase * 3) - categoria; // Hay 5 clases que multiplicado por 3 da el ID maximo de la clase y restado de la categoria nos da el ID
                                            // (ID(MAX) - 0) -> Legendario
                                            // (ID(MAX) - 1) -> Raro
                                            // (ID(MAX) - 2) -> Normal
        }

        private int CofreNormal(int value) 
        {
            if (value <= 700) //Carta Normal (70 %)
            {
                return 2;
            } else if (value > 700 && value <= 980) //Carta Rara (28 %)
            {
                return 1;
            }
            else //Carta Legendaria (2 %)
            {
                return 0;
            }
        }

        private int CofreRaro(int value)
        {
            if (value <= 500) //Carta Normal (50 %)
            {
                return 2;
            }
            else if (value > 500 && value <= 950) //Carta Rara (45 %)
            {
                return 1;
            }
            else //Carta Legendaria (5 %)
            {
                return 0;
            }
        }

        private int CofreLegendario(int value)
        {
            if (value <= 400) //Carta Normal (40 %)
            {
                return 2;
            }
            else if (value > 400 && value <= 850) //Carta Rara (45 %)
            {
                return 1;
            }
            else //Carta Legendaria (15 %)
            {
                return 0;
            }
        }
    }

}
