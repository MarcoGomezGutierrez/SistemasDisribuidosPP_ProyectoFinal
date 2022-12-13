using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Servidor.Entidades
{
    public class ImagenNft
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public byte[] Img { get; set; }
    }
}