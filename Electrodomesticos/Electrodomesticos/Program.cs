using System;

namespace Electrodomesticos
{
    class Program
    {
      static void Main(string[] args)
        {
            Tostadora tostadora = new Tostadora();
            tostadora.Ricardo();
            Console.WriteLine("----------------------------------------");
            tostadora.Tamaño();
            tostadora.Procedencia();
            tostadora.SetMarca("Toshiba");
            Console.WriteLine(tostadora.GetMarca());
            Console.WriteLine("----------------------------------------");
            Radio radio = new Radio();
            radio.Color();
            radio.Procedencia();
            radio.Tamaño();
            Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}
