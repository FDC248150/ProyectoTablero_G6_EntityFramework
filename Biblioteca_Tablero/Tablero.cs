﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca_Tablero
{
    public class Tablero
    {
        public Tablero(Usuario usuario)
        {
            IDTablero = 0;
            Tareas = new List<Tarea>();
            Usuario = usuario;
        }
        //Para indicar que la PK es ID
        [Key]
        //Para que la ID sea autoincrementable
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDTablero { get; set; }


        public virtual List<Tarea> Tareas { get; set; }

        //La llave FK se define con el nombre de la PK de la clase Usuario
        [ForeignKey("IDUsuario")]
        //Objeto virtual, Tablero tiene un Usuario
        public virtual Usuario Usuario { get; set; }

    }
}
