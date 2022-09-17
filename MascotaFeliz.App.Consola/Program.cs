using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {

        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddDueno();
            AddVeterinario();
            AddMascota();
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "miguel",
                Apellidos = "san juan",
                Direccion = "san juan",
                Telefono = "123456891",
                Correo = "elquees@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Juan carlos",
                Apellidos = "martinez",
                Direccion = "escallon vills",
                Telefono = "3124586576",
                TarjetaProfesional = "1256645635"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
         private static void AddMascota()
        {
            var mascota = new Mascota
            {
                
                Nombre = "roky",
                Color = "gris",
                Especie = "gato",
                Raza = "Angola"
                
            };
            _repoMascota.AddMascota(mascota);
        }
=======
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("BLACPINK In Your Area!");

            //AddDueno();
            //AddVeterinario();
            //AddMascota();
            //AddHistoria();
            
        }
        
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Suga",
                Apellidos = "Min",
                Direccion = "Calle 125",
                Telefono = "1234567891",
                TarjetaProfesional = "1235462"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //id = "1212",
                Nombre = "Haruka",
                Color = "Amarillo",
                Especie = "Canino",
                Raza = "Criolla"
            };
            _repoMascota.AddMascota(mascota);
        }
        
        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(2020, 01, 01),
                
            };
            _repoHistoria.AddHistoria(historia);
        }

      

    }
}
