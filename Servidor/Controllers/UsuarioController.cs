using Servidor.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servidor.Controllers
{
    public class UsuarioController : ApiController
    {
        static string ConexionSql = "server= " + SqlServer.Url + " ; database= CartasDB ; integrated security= true";
        SqlConnection conexion = new SqlConnection(ConexionSql);
        // GET: api/Usuario
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Usuario/5
        public string Get(int id) //Si pregunta por el ID devuelve un objeto con las veces que esta repetido y su foto
        {
            return "value";
        }

        // POST: api/Usuario
        public UsuarioResponse Post([FromBody]Usuario value) //Método utilizado para registrar un Usuario (Register si es value.LogIn = 0) o Log-In (si value.LogIn = 1)
        {
            if (value.LogIn==1)
            {
                return GetUsuarioResponse(value.NickName);
            } else
            {
                conexion.Open();
                string sql = $"exec CrearUsuario '{value.NickName}', '{value.Password}', 0";//Procedure que guarda un unico Usuario con Nick Name (no se puede repetir) y su password
                SqlCommand command = new SqlCommand(sql, conexion);
                command.ExecuteNonQuery();
                conexion.Close();
                return new UsuarioResponse();
            }
        }

        // PUT: api/Usuario/5
        public string Put(int id, [FromBody]UsuarioImagenesRepetidas value) //id = ID Usuario, value = ID Imagen // Devuelve el número de veces que se repite la carta del usuario.
        {
            conexion.Open();
            string sql = $"select COUNT(*) as repetidos from Cartas where UsuarioID = '{id}' and ImagenID = '{value.ImagenID}'";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            SqlDataReader registro = cmd.ExecuteReader();
            string repetido = "0";
            if (registro.Read())
            {
                repetido = registro["repetidos"].ToString();
            }
            else
            {
                repetido = "0";
            }
            conexion.Close();
            return repetido;
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }

        public UsuarioResponse GetUsuarioResponse(string nickName) //Método para validar si el usuario ha introducido un Nick Name que existe y una contraseña correcta
        {
            conexion.Open();
            string sql = $"select * from Usuarios where NickName='{nickName}'";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            SqlDataReader registro = cmd.ExecuteReader();
            string password = string.Empty;
            int id = 0;
            if (registro.Read())
            {
                password = registro["Encrypt_Password"].ToString();
                id = int.Parse(registro["ID"].ToString());
            }
            else
            {
                password = "No hay registros";
                id = 0;
            }
            conexion.Close();
            return new UsuarioResponse()
            {
                ID = id,
                NickName = nickName,
                Password = password
            };
        }
    }
}
