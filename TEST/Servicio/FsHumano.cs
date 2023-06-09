using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEST.Contexto;
using TEST.Entidades.Humano;
using TEST.Modelo.Humano;

namespace TEST.Servicio
{
    public class FsHumano
    {

        private readonly ApplicationDbContext _contexto;
        public FsHumano(ApplicationDbContext contexto) {
            _contexto = contexto;
        }


        public List<ModelHumano> ObtenerObjetoHumano() {

            try {
                var humanos = new List<ModelHumano>
                {
                    new ModelHumano { Nombre = "Juan", Edad = 25, Sexo = "Masculino", Altura = 1.75f, Peso = 70.5f },
                    new ModelHumano { Nombre = "María", Edad = 30, Sexo = "Femenino", Altura = 1.60f, Peso = 55.2f },
                    new ModelHumano { Nombre = "Pedro", Edad = 40, Sexo = "Masculino", Altura = 1.80f, Peso = 80.0f },
                    new ModelHumano { Nombre = "Laura", Edad = 28, Sexo = "Femenino", Altura = 1.65f, Peso = 60.7f },
                    new ModelHumano { Nombre = "Carlos", Edad = 35, Sexo = "Masculino", Altura = 1.70f, Peso = 75.3f },
                    new ModelHumano { Nombre = "Ana", Edad = 32, Sexo = "Femenino", Altura = 1.62f, Peso = 58.9f },
                    new ModelHumano { Nombre = "Luis", Edad = 45, Sexo = "Masculino", Altura = 1.78f, Peso = 85.1f },
                    new ModelHumano { Nombre = "Sofía", Edad = 27, Sexo = "Femenino", Altura = 1.63f, Peso = 59.6f },
                    new ModelHumano { Nombre = "Gabriel", Edad = 33, Sexo = "Masculino", Altura = 1.75f, Peso = 72.9f },
                    new ModelHumano { Nombre = "Julia", Edad = 29, Sexo = "Femenino", Altura = 1.68f, Peso = 63.4f }
                };
                return humanos;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public List<HumanoEnty> ObtenerListaHumano()
        {
            try
            {
                var humanos = _contexto.ModelosHumanos.ToList();
                return humanos;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
           
        }
        public HumanoEnty ObtenerHumanoPorId(int id)
        {
            try
            {
                var humanos = _contexto.ModelosHumanos.Where(x=>x.Id == id).ToList().FirstOrDefault();
                return humanos;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
        public HumanoEnty CrearHumano(HumanoEnty humano)
        {
            try
            {
                 _contexto.ModelosHumanos.Add(humano);
                _contexto.SaveChanges();
                return humano;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
        public HumanoEnty ActulizarHumano(HumanoEnty humano, int id)
        {
            try
            {
                var datosHumano = _contexto.ModelosHumanos.Where(x => x.Id == id).FirstOrDefault();
                datosHumano.Nombre = humano.Nombre;
                datosHumano.Edad = humano.Edad;
                datosHumano.Sexo = humano.Sexo;
                datosHumano.Altura = humano.Altura;
                datosHumano.Peso = humano.Peso;
                _contexto.SaveChanges();

                return humano;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
    }
}
