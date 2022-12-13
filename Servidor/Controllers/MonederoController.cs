using Servidor.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servidor.Controllers
{
    public class MonederoController : ApiController
    {
        static string ConexionSql = "server= " + SqlServer.Url + " ; database= CartasDB ; integrated security= true";
        SqlConnection conexion = new SqlConnection(ConexionSql);
        // GET: api/Monedero
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Monedero/5
        public int Get(int id) //Método que te devuelve el dinero que tiene el Usuario por su ID unica en la Base de Datos
        {
            conexion.Open();
            string sql = $"select Dinero from Usuarios where ID=" + id;
            SqlCommand command = new SqlCommand(sql, conexion);
            SqlDataReader registro = command.ExecuteReader();
            int Monedero = 0;
            if (registro.Read())
            {
                Monedero = int.Parse(registro["Dinero"].ToString());
            }
            else
            {
                Monedero = -1;
            }
            conexion.Close();
            return Monedero;
        }

        // POST: api/Monedero
        public int Post([FromBody] MonederoUsuario value) //Actualiza el precio del usuario siempre que no sea negativo y te devuelve el Monedero del usuario Actual
        {
            conexion.Open();
            string sql = $"exec ActualizarPrecio '{value.ID}', '{value.Precio}'";//Procedure que guarda un unico Usuario con Nick Name (no se puede repetir) y su password
            SqlCommand command = new SqlCommand(sql, conexion);
            SqlDataReader registro = command.ExecuteReader();
            int Monedero = 0;
            if (registro.Read())
            {
                Monedero = int.Parse(registro["Dinero"].ToString());
            } else
            {
                Monedero = -1;
            }
            conexion.Close();
            return Monedero;
        }

        // PUT: api/Monedero/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Monedero/5
        public void Delete(int id)
        {
        }
    }
}
