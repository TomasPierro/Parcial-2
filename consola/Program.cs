using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesP.Models;
using ClasesP.Repositories;
int opcion;
do
{

    Console.WriteLine("===== plataforma de música =====");
    Console.WriteLine("1.Alta Artista");
    Console.WriteLine("2.Alta Canción");
    Console.WriteLine("3.Ver Canciones");
    Console.WriteLine("4.Mostrar canciones más largas");
    Console.WriteLine("5.Cantidad total de canciones");
    Console.WriteLine("6.Mostrar canciones ordenadas alfabéticamente por título");
    Console.WriteLine("7.Verificar si existen canciones registradas.");
    Console.WriteLine("8.Salir");
    int.TryParse(Console.ReadLine(), out opcion);
    Console.Clear();
    switch (opcion)
    {
        case 1:
            {
             Console.WriteLine("ingrese el nombre del artista:");
                string nombreArtista = Console.ReadLine();
                Artista artista = new Artista { Nombre = nombreArtista };
                GenericRepository<Artista> artistaRepository = new GenericRepository<Artista>();
                artistaRepository.Agregar(artista);
                Console.WriteLine("Artista registrado exitosamente.");
            }
            break;
        case 2:
            {
                Console.WriteLine("ingrese el nombre de la canción:");
                string nombreCancion = Console.ReadLine();
                Console.WriteLine("ingrese la duración de la canción (en minutos):");
                double duracionCancion = double.Parse(Console.ReadLine());
                GenericRepository<Artista> artistaRepository = new GenericRepository<Artista>();
                foreach (var artista in artistaRepository.ObtenerTodos())
                {
                    Console.WriteLine($"ID: {artista.id}, Nombre: {artista.Nombre}");
                }
                Console.WriteLine("Ingrese el ID del artista al que pertenece la canción:");
                int artistaId = int.Parse(Console.ReadLine());
                Cancion cancion = new Cancion { Titulo = nombreCancion, Duracion = duracionCancion, ArtistaId = artistaId };
                GenericRepository<Cancion> cancionRepository = new GenericRepository<Cancion>();
                cancionRepository.Agregar(cancion);
                Console.WriteLine("Canción registrada exitosamente.");

            }
            break;
        case 3:
            {
                GenericRepository<Cancion> cancionrepository = new GenericRepository<Cancion>();
                foreach (var canciones in cancionrepository.ObtenerTodos()) 
                {
                    Console.WriteLine($"Titulo:{canciones.Titulo} ,Duracion:{canciones.Duracion}");  
                }
            }
            break;
        case 4:
            {
                GenericRepository<Cancion> cancionrepository = new GenericRepository<Cancion>();
                foreach (var canciones in cancionrepository.ObtenerTodos())
                {
                    if (canciones.Duracion > 2 )
                    {
                        Console.WriteLine($"Titulo:{canciones.Titulo},Duracion:{canciones.Duracion}");
                    }

                }
            }
            break;
        case 5:
            {
                GenericRepository<Cancion> cancionrepository = new GenericRepository<Cancion>();
                int suma = 0;
                foreach (var canciones in cancionrepository.ObtenerTodos())
                {
                    suma++;       
                }
                Console.WriteLine($"La cantidad de canciones es:{suma}");
            }
            break;
        case 6:
            {
                GenericRepository<Cancion> cancionrepository = new GenericRepository<Cancion>();

                List<Cancion> canciones = cancionrepository.ObtenerTodos();

                repocancion repo = new repocancion();

                List<Cancion> ordenadas = repo.ObtenerOrdenados(canciones);

                foreach (Cancion cancion in ordenadas)
                {
                    Console.WriteLine(cancion.Titulo);
                }

            }
            break;
        case 7:
            {
                GenericRepository<Cancion> cancionrepository = new GenericRepository<Cancion>();
                int suma = 0;
                foreach (var canciones in cancionrepository.ObtenerTodos())
                {
                    suma++;
                    if (suma == 0)
                    { 
                        Console.WriteLine("no hay canciones registradas");
                    }
                    else
                    {
                        Console.WriteLine($"si hay canciones registradas:{suma}");
                    }

                }
            }
            break;
        case 8:
            {
            Console.WriteLine("salir..");
            }
            break;
    }
} while (opcion != 8);