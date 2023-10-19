using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Tablero
{
    public class Tarea
    {
        public Tarea(string descripcion, string titulo, Estado estado)
        {

            IDTarea = IDTarea;
            Titulo = titulo;
            Descripcion = descripcion;
            //esto pidio la profe modificar por una lista de Tarea (de si misma)
            // SubTarea = new List<SubTarea>();
            tareas = new List<Tarea>();
            EstadoTarea = estado;
        }

       

        //Para indicar que la PK es ID
        [Key]
        //Para que la ID sea autoincrementable
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDTarea { get; set; }
        public Estado EstadoTarea { get; set; }
        public string Descripcion { get; set; }
        public string Titulo { get; set; }

        public List<Tarea> tareas { get; set; }



        public void AgregarTarea(Tarea tarea)
        {
            tareas.Add(tarea);
        }

        //Por que no permite devolver un Estado... Solo permite void...
        private void pasoEnteroAEstado(int numero)
        {
            Estado estadoADevolver;
            switch (numero)
            {
                case 1:
                    estadoADevolver = Estado.ANALISIS;
                    break;
                case 2:
                    estadoADevolver = Estado.TO_DO;
                    break;
                case 3:
                    estadoADevolver = Estado.IN_PROGRESS;
                    break;
                default:
                    estadoADevolver = Estado.FINALIZED;
                    break;
            }
        }


        public void EliminarTarea(Tarea tarea)
        {
            tareas.Remove(tarea);
        }
/*
        public void ModificarTarea(string titulo, string descripcion, enum estado)
        {
            if(titulo == null)
            {
                if(descripcion == null)
                {
            //continuar
                }
            }
}*/

    }
}
