namespace Clases1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Instancia de la clase = objeto
            Animal perro = new Animal();
            Animal avestruz = new Animal();

            perro.Nombre = "Canis Lupus familiaris";
            perro.EstaExtinto = true;
            perro.aniosPromedio = 10.5;
            perro.Reino = "Animal";
            perro.EsMamifero = true;

            avestruz.Nombre = "Struthio camelus";
            avestruz.EstaExtinto = false;
            avestruz.aniosPromedio = 40.0;
            avestruz.Reino = "Aves";

            Console.WriteLine(perro.MostrarInformacion());
            Console.WriteLine(avestruz.MostrarInformacion());
        }
    }

    public class Animal
    {
        public string Nombre;
        public bool EstaExtinto;
        public double aniosPromedio;
        public string Reino;
        public bool EsMamifero, EsTerrestre;
        public int NumOjos;
        public int NumPatas;
        public bool pelo;
        public bool volar;
    }

    public void Dormir()
    {

    }

    public void Comer()
    {

    }

    public string MostrarInformacion()
    {
        string datos = "Nombre" + Nombre "*\n";
        datos += "Está extinto"´+ EstaExtinto "*\n";
        datos += "Anios promedio" + aniosPromedio "*\n";
        return datos;
    }
}