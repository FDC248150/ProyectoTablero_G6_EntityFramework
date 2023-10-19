using Microsoft.EntityFrameworkCore;

namespace Biblioteca_Tablero
{
    public class BD_ProyectoTablero_context : DbContext
    {
        public BD_ProyectoTablero_context(DbContextOptions<BD_ProyectoTablero_context> opciones)
            : base(opciones)
        {

        }

        public DbSet<Tablero> Tableros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//Aca para vincular a nuestros SQL Server, tenemos que agregar cada Server personal // el nombre de la BD podria ser BD_ProyectoTablero
            optionsBuilder.UseSqlServer(@"Server=COMPLETAR_BD_PERSONAL;Database=COMPLETAR_NOMBRE_BD;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        /* Problema Flor en la consola de paquetes NuGet: Your startup project 'ProyectoTablero_G6_EntityFramework'
            doesn't reference Microsoft.EntityFrameworkCore.Design. This package
            is required for the Entity Framework Core Tools to work.
             Ensure your startup project is correct, install the package, and try again.
        
            En espaniol: Su proyecto de inicio 'ProyectoTablero_G6_EntityFramework' 
        no hace referencia a Microsoft.EntityFrameworkCore.Design. Este paquete es 
        necesario para que funcionen las herramientas principales de Entity Framework. 
        Asegúrese de que su proyecto de inicio sea correcto, instale el paquete y vuelva a 
        intentarlo.

         */


        //Este metodo permite que en SQL tenga nombre singular (falta probar)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tablero>().ToTable("Tablero");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Tarea>().ToTable("Tarea");
        }

       

    }
}