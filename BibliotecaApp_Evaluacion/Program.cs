namespace BibliotecaApp_Evaluacion_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sistema de Gestión de Biblioteca - UNAB");



            //Listado de Autores y Libros
            List<Autor> autores = new List<Autor>
            {
                new Autor
                {
                    Id = 1,
                    Nombre = "Gabriela García",
                    Nacionalidad = "Colombiana"
                },
                new Autor
                {
                    Id = 2,
                    Nombre = "Elisa Allende",
                    Nacionalidad = "Chilena"
                },

                new Autor
                {
                    Id = 3,
                    Nombre = "Mario Llosa",
                    Nacionalidad = "Peruana"
                },

                new Autor
                {
                    Id = 4,
                    Nombre = "Juli Wuling",
                    Nacionalidad = "Británica"
                },

                new Autor
                {
                    Id = 5,
                    Nombre = "Stiven Monge",
                    Nacionalidad = "Estadounidense"
                },

                new Autor
                {
                    Id = 6,
                    Nombre = "Jorge Luis Borges",
                    Nacionalidad = "Argentino"
                },

                new Autor
                {
                    Id = 7,
                    Nombre = "Isabel Allende",
                    Nacionalidad = "Chilena"
                }
            };

            //Listado de Libros

            List<Libro> libros = new List<Libro>
            {
                new Libro
                {
                    Id = 1,
                    Codigo = "L001",
                    Titulo = "Magia en el Tiempo",
                    Genero = "Realismo Mágico",
                    PrecioAlquiler = 5,
                    CopiasDisponibles = 3,
                    Estado = true,
                    AutorId = 1
                },

                new Libro
                {
                    Id = 2,
                    Codigo = "L002",
                    Titulo = "La Casa de los Zorros",
                    Genero = "Drama",
                    PrecioAlquiler = 4,
                    CopiasDisponibles = 2,
                    Estado = true,
                    AutorId = 2
                },

                new Libro
                {
                    Id = 3,
                    Codigo = "L003",
                    Titulo = "La Ciudad y los Gatos",
                    Genero = "Novela",
                    PrecioAlquiler = 6,
                    CopiasDisponibles = 1,
                    Estado = true,
                    AutorId = 3
                },

                new Libro
                {
                    Id = 4,
                    Codigo = "L004",
                    Titulo = "Aventuras de los Elfos",
                    Genero = "Fantasía",
                    PrecioAlquiler = 7,
                    CopiasDisponibles = 0,
                    Estado = false,
                    AutorId = 4
                },

                new Libro
                {
                    Id = 5,
                    Codigo = "L005",
                    Titulo = "El Misterio del Bosque",
                    Genero = "Terror",
                    PrecioAlquiler = 8,
                    CopiasDisponibles = 5,
                    Estado = true,
                    AutorId = 5
                },

                new Libro
                {
                    Id = 6,
                    Codigo = "L006",
                    Titulo = "El Viaje de los Sueños",
                    Genero = "Aventura",
                    PrecioAlquiler = 9,
                    CopiasDisponibles = 2,
                    Estado = true,
                    AutorId = 1
                },

                new Libro
                {
                    Id = 7,
                    Codigo = "L007",
                    Titulo = "El Secreto de la Luna",
                    Genero = "Misterio",
                    PrecioAlquiler = 10,
                    CopiasDisponibles = 0,
                    Estado = false,
                    AutorId = 2
                },

            };

            Console.WriteLine($"\nLos libros disponibles son:");

            decimal totalDisponibles = 0;

            Console.WriteLine($"{"Codigo",-6} | {"Titulo",-22} | {"Genero",-15} | {"Precio",7} | {"Copias",6}");
            Console.WriteLine(new string('-', 70));

            var disponibles = libros.Where(p => p.Estado && p.CopiasDisponibles > 0);

            foreach (var libro in disponibles)
            {
                Console.WriteLine($"{libro.Codigo,-6} | {libro.Titulo,-22} | {libro.Genero,-15} | {libro.PrecioAlquiler,7:F2} | {libro.CopiasDisponibles,6}");
                totalDisponibles += libro.PrecioAlquiler * libro.CopiasDisponibles;
            }

            Console.WriteLine($"{new string(' ', 50)}TOTAL: ${totalDisponibles:F2}");



            //Libros y Autores

            Console.WriteLine("\nReporte de Libros Disponibles:");
            Console.WriteLine($"{"Codigo",-6} | {"Titulo",-22} | {"Genero",-15} | {"Precio",7} | {"Copias",6}");
            Console.WriteLine(new string('-', 65));

            foreach (var libro in libros)
            {
                Console.WriteLine($"{libro.Codigo,-6} | {libro.Titulo,-22} | {libro.Genero,-15} | {libro.PrecioAlquiler,7:F2} | {libro.CopiasDisponibles,6}");
            }


            ////Consultas LINQ con Query Syntax y Joins
            

            var librosDisponibles = from p in libros
                                    where p.Estado == true && p.CopiasDisponibles > 0
                                    orderby p.PrecioAlquiler ascending
                                    select p;
            Console.WriteLine($"\nLos libros disponibles son: ");
            foreach (var p in librosDisponibles)
            {

                Console.WriteLine($"{p.Codigo} | {p.Titulo} - ${p.PrecioAlquiler}");

            }


         

            //Ejercicio 2: Relación entre Colecciones (Join)
            var joinrelacion = from p in libros
                               join c in autores on p.AutorId equals c.Id
                               orderby p.AutorId
                               select new
                               {
                                   p.Titulo,
                                   AutorNombre = c.Nombre,
                                   p.Genero
                               };

            Console.WriteLine($"\nLos libros son: ");
            foreach (var p in joinrelacion)
            {
                Console.WriteLine($"{p.Titulo} | {p.AutorNombre} | {p.Genero}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();








            Console.ReadKey();
        }
    }

}







