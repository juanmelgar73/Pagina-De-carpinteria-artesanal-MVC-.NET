using CarpinteriaArtesanal.Models;

namespace CarpinteriaArtesanal.Data
{
    public class ListaEmpleados
    {
        public List<Empleado> GetEmpleados()
        {
            return new List<Empleado>
            {
                new Empleado {
                    id = 1, nombre = "Juan", apellido = "Perez", edad = "42 años",
                    experto = "Encastres tradicionales y uniones ocultas", sector = "Armado", activo = true
                },
                new Empleado {
                    id = 2, nombre = "Maria", apellido = "Diaz", edad = "29 años",
                    experto = "Restauración de madera nativa y veteados", sector = "Terminaciones", activo = true
                },
                new Empleado {
                    id = 3, nombre = "Pedro", apellido = "Gomez", edad = "55 años",
                    experto = "Torneado artesanal de patas y columnas", sector = "Mecanizado", activo = false
                },
                new Empleado {
                    id = 4, nombre = "Ana", apellido = "Rodriguez", edad = "34 años",
                    experto = "Diseño de mobiliario escandinavo y planos", sector = "Diseño", activo = true
                },
                new Empleado {
                    id = 5, nombre = "Lucas", apellido = "Martinez", edad = "38 años",
                    experto = "Lustre al poliuretano y lacas marinas", sector = "Terminaciones", activo = true
                },
                new Empleado {
                    id = 6, nombre = "Sofia", apellido = "Lopez", edad = "26 años",
                    experto = "Tallado a mano con gubia en bajorrelieve", sector = "Armado", activo = true
                },
                new Empleado {
                    id = 7, nombre = "Diego", apellido = "Fernandez", edad = "47 años",
                    experto = "Corte de tablones masivos y calibración", sector = "Mecanizado", activo = false
                },
                new Empleado {
                    id = 8, nombre = "Laura", apellido = "Benitez", edad = "31 años",
                    experto = "Estructuras de hierro y estilo industrial", sector = "Armado", activo = true
                },
                new Empleado {
                    id = 9, nombre = "Martin", apellido = "Silva", edad = "40 años",
                    experto = "Tratamientos de quemado estiloc Shugi Ban", sector = "Terminaciones", activo = true
                },
                new Empleado {
                    id = 10, nombre = "Clara", apellido = "Ortega", edad = "28 años",
                    experto = "Maquetación 3D y renderizado de interiores", sector = "Diseño", activo = true
                },
                new Empleado {
                    id = 11, nombre = "Javier", apellido = "Rios", edad = "50 años",
                    experto = "Mantenimiento y afilado de herramientas", sector = "Mecanizado", activo = false
                },
                new Empleado {
                    id = 12, nombre = "Elena", apellido = "Paz", edad = "35 años",
                    experto = "Enchapados finos y marquetería artesanal", sector = "Armado", activo = true
                },
                new Empleado {
                    id = 13, nombre = "Tomas", apellido = "Castro", edad = "24 años",
                    experto = "Lijado fino de pre-entrega y texturas", sector = "Terminaciones", activo = true
                },
                new Empleado {
                    id = 14, nombre = "Florencia", apellido = "Rossi", edad = "33 años",
                    experto = "Selección y control de calidad de maderas", sector = "Mecanizado", activo = true
                },
                new Empleado {
                    id = 15, nombre = "Nicolas", apellido = "Sosa", edad = "39 años",
                    experto = "Colocación de herrajes y guías ocultas", sector = "Armado", activo = true
                }
            };
        }

    }
}
