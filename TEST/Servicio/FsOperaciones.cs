using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEST.Modelo.Operador;

namespace TEST.Servicio
{
    public class FsOperaciones
    {

        public FsOperaciones() {
        
        }


        public string OperacionesMatematicasPorModelo(ModelOperacion operacion) {

            try {

                int resultado = 0;

                switch (operacion.Operador)
                {
                    case "+":
                        resultado = operacion.Numero1 + operacion.Numero2;
                        break;
                    case "-":
                        resultado = operacion.Numero1 - operacion.Numero2;
                        break;
                    case "*":
                        resultado = operacion.Numero1 * operacion.Numero2;
                        break;
                    case "/":
                        resultado = operacion.Numero1 / operacion.Numero2;
                        break;
                    default:
                        return "Operador inválido";
                }

                return ""+resultado;
            } catch (Exception e) {
                return e.Message; 
            }
        }
        public string OperacionesMatematicasPorPametro(int Numero1, int Numero2, string Operador)
        {
            try
            {
                int resultado = 0;
                switch (Operador)
                {
                    case "+":
                        resultado = Numero1 + Numero2;
                        break;
                    case "-":
                        resultado = Numero1 - Numero2;
                        break;
                    case "*":
                        resultado = Numero1 * Numero2;
                        break;
                    case "/":
                        resultado = Numero1 / Numero2;
                        break;
                    default:
                        return "Operador inválido";
                }

                return "" + resultado;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
