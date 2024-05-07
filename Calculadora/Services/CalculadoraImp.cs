using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public List<string> listaHistorico;

        public CalculadoraImp()
        {
            listaHistorico = new List<string>();
        }
        public int somar(int val1, int val2)
        {
            int resultado = val1 + val2;
            listaHistorico.Insert(0, "Resultado: " + resultado);
            return resultado;
        

        }
        public int subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            listaHistorico.Insert(0, "Resultado: " + resultado);
            return resultado;

        }
        public int multiplicar(int val1, int val2)
        {
            int resultado = val1*val2;
            listaHistorico.Insert(0, "Resultado: " + resultado);
            return resultado;

        }
        public int dividir(int val1, int val2)
        {
            int resultado = val1 / val2;  
            listaHistorico.Insert(0, "Resultado: " + resultado);  
            return resultado;

        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}