using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servidor.Entidades
{
    public class Cofre
    {
        public int NCofre { get; set; } //El número del cofre porque depende del precio comprara un cofre con más probabilidad de ser legendario.
        public int Dinero { get; set; } //Dinero que vale el cofre.
        public int IdUsuario { get; set; } //Nombre de la persona
    }
}