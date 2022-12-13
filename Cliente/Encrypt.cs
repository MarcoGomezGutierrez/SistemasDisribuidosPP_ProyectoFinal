using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Encrypt
    {
        public static string Encriptar(string text)
        {
            string resultado = string.Empty;
            byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(text);
            resultado = Convert.ToBase64String(encriptar);
            return resultado;
        }

        public static string Desencriptar(string text)
        {
            string resultado = string.Empty;
            try
            {
                byte[] desencriptar = Convert.FromBase64String(text);
                resultado = System.Text.Encoding.Unicode.GetString(desencriptar);
            } catch {}
            return resultado;
        }
    }
}
