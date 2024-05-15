using System;

namespace GestionVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de gestión de vehículos\n");

            Automovil automovil = new Automovil("Toyota", "Corolla", 2020, 4, "Gasolina");
            MostrarInformacionVehiculo(automovil);

            Camion camion = new Camion("Volvo", "FH16", 2021, 40, "Remolque Tipo A");
            MostrarInformacionVehiculo(camion);

            Bicicleta bicicleta = new Bicicleta("BMX", "Modelo X", 2023, 5);
            MostrarInformacionVehiculo(bicicleta);
        }

        static void MostrarInformacionVehiculo(Vehiculo vehiculo)
        {
            Console.WriteLine("Información del vehículo:");
            vehiculo.MostrarInformacion();
            Console.WriteLine();
        }
    }

    class Vehiculo
    {
        private string marca;
        private string modelo;
        private int año;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Año
        {
            get { return año; }
            set { año = value; }
        }

        public Vehiculo(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}\nModelo: {Modelo}\nAño: {Año}");
        }
    }

    class Automovil : Vehiculo
    {
        private int numeroPuertas;
        private string tipoCombustible;

        public int NumeroPuertas
        {
            get { return numeroPuertas; }
            set { numeroPuertas = value; }
        }

        public string TipoCombustible
        {
            get { return tipoCombustible; }
            set { tipoCombustible = value; }
        }

        public Automovil(string marca, string modelo, int año, int numeroPuertas, string tipoCombustible)
            : base(marca, modelo, año)
        {
            NumeroPuertas = numeroPuertas;
            TipoCombustible = tipoCombustible;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Tipo: Automóvil\nNúmero de Puertas: {NumeroPuertas}\nTipo de Combustible: {TipoCombustible}");
        }
    }

    class Camion : Vehiculo
    {
        private double capacidadCarga;
        private string tipoRemolque;

        public double CapacidadCarga
        {
            get { return capacidadCarga; }
            set { capacidadCarga = value; }
        }

        public string TipoRemolque
        {
            get { return tipoRemolque; }
            set { tipoRemolque = value; }
        }

        public Camion(string marca, string modelo, int año, double capacidadCarga, string tipoRemolque)
            : base(marca, modelo, año)
        {
            CapacidadCarga = capacidadCarga;
            TipoRemolque = tipoRemolque;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Tipo: Camión\nCapacidad de carga (toneladas): {CapacidadCarga}\nTipo de Remolque: {TipoRemolque}");
        }
    }

    class Bicicleta : Vehiculo
    {
        private int numeroMarchas;

        public int NumeroMarchas
        {
            get { return numeroMarchas; }
            set { numeroMarchas = value; }
        }

        public Bicicleta(string marca, string modelo, int año, int numeroMarchas)
            : base(marca, modelo, año)
        {
            NumeroMarchas = numeroMarchas;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Tipo: Bicicleta\nNúmero de Marchas: {NumeroMarchas}");
        }
    }
}
