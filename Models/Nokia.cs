namespace DesafioPOO.Models
{
    // Inherit from the Smartphone class
    public class Nokia : Smartphone
    {
        // Constructor for the Nokia class
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Additional initialization for Nokia specific properties, if needed
        }

        // Override the abstract method from the base class
        public override void InstalarAplicativo(string nomeApp)
        {
            // Implement the installation logic specific to Nokia
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
        }

        // Additional methods or properties specific to the Nokia class can be added here
    }
}
