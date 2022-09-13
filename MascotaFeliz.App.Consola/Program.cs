using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddDueno();
            AddVeterinario();
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
    }
}
