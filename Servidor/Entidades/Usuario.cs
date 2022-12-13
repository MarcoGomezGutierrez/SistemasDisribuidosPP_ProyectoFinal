using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servidor.Entidades
{
    public class Usuario
    {
        public int LogIn { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
    }
}