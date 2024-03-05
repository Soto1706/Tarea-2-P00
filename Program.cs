using System;

namespace Tarea_Dos

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.MostrarDatos();

            persona.SetNombre("Carlos");
            Apartamento nuevoApartamento = new Apartamento();
            Puerta nuevaPuerta = new Puerta();
            nuevaPuerta.SetColor("verde");

            nuevoApartamento.SetPuerta(nuevaPuerta);
            persona.SetCasa(nuevoApartamento);

            persona.MostrarDatos();
        }
    }

    class Puerta
    {
        public string Color { get; private set; }

        public Puerta()
        {
            Color = "Café";
        }

        public void SetColor(string nuevoColor)
        {
            Color = nuevoColor;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Soy una Puerta, mi color es {Color}.");
        }
    }

    class Casa
    {
        public int Area { get; private set; }
        public Puerta Puerta { get; private set; }

        public Casa(int area)
        {
            Area = area;
            Puerta = new Puerta();
        }

        public void SetArea(int nuevaArea)
        {
            Area = nuevaArea;
        }

        public void SetPuerta(Puerta nuevaPuerta)
        {
            Puerta = nuevaPuerta;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Soy una Casa, mi área es {Area} m2.");
            Puerta.MostrarDatos();
        }
    }

    class Apartamento : Casa
    {
        public Apartamento() : base(50)
        {
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Soy un Apartamento, mi área es {Area} m2.");
        }
    }

    class Persona
    {
        public string Nombre { get; private set; }
        public Casa Casa { get; private set; }

        public Persona()
        {
            Nombre = "Juan";
            Casa = new Casa(150);
        }

        public Persona(string nombre, Casa casa)
        {
            Nombre = nombre;
            Casa = casa;
        }

        public void SetNombre(string nuevoNombre)
        {
            Nombre = nuevoNombre;
        }

        public void SetCasa(Casa nuevaCasa)
        {
            Casa = nuevaCasa;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Mi nombre es {Nombre}.");
            Casa.MostrarDatos();
        }
    }
}
