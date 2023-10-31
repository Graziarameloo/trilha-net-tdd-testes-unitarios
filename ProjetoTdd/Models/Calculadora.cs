using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTdd.Models
{

    public class Calculadora
    {
        private List<string> _historico;
        private string _data;

        public Calculadora(string data) 
        { 
            _historico = new List<string>();
            _data = data;
            // ou this._data = data
            //this fala que você quer usar o de fora
        }

        public int Somar (int num1, int num2)
        {
            int resultado = num1 + num2;
            _historico.Insert(0, "Res: " + resultado + " - data: " + _data);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            _historico.Insert(0, "Res: " + (num1 - num2) + " - data: " + _data);
            return num1 - num2;
        }


        public int Multiplicar(int num1, int num2)
        {
            _historico.Insert(0, "Res: " + num1 * num2 + " - data: " + _data) ;
            return num1 * num2;
        }


        public int Dividir(int num1, int num2)
        {
            _historico.Insert(0, "Res: " + num1 / num2 + " - data: " + _data);
            return num1 / num2;
        }


        public List<string> Historico()
        {
            List<string> resultado;
            _historico.RemoveRange(2, _historico.Count - 3);
            return _historico;
        }
    }
}
