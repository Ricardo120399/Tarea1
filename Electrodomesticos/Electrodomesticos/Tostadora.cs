using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
   public class Tostadora
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
            Console.WriteLine("La tostadora es bastante pequeña");
            
        }
        public  void Procedencia()
        {
            Console.WriteLine("La tostadora fue hecho en China");
        }
        public  void Ricardo()
        {
            string Nombre = "Ricardo";
            int Edad = 22;
            string Sector = "Zona Colonial";
            Console.WriteLine(Nombre);
            Console.WriteLine(Edad);
            Console.WriteLine(Sector);
        }
    }
}
