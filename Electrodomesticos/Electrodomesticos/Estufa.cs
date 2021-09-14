using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
   public class Estufa
    {
        //atributos
        //1
        private string _marca;

        public string GetMarca()
        {
            return _marca;
        }
        public void SetMarca(string valor)
        {
            _marca = valor;
        }
        //2
        private string _modelo;

        public string GetModelo()
        {
            return _modelo;
        }
        public void SetModelo(string valor)
        {
            _modelo = valor;
        }
        //3
        private int _precio;

        public int GetPrecio()
        {
            return _precio;
        }
        public void SetPrecio(int valor)
        {
            _precio = valor;
        }

        //Metodos
        public void Tamaño()
        {
            Console.WriteLine("La estufa es bastante pequeña");

        }
        public void Procedencia()
        {
            Console.WriteLine("La estufa fue hecho en China");
        }
        public void Color()
        {
            Console.WriteLine("El color es gris opaco...");
        }
    }
}
