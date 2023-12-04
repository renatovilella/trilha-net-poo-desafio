namespace DesafioPOO.Models
{
    // Inherit from the Smartphone class
    public class Iphone : Smartphone
    {
        // Constructor for the Iphone class
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Additional initialization for iPhone specific properties, if needed
        }

        // Override the abstract method from the base class
        public override void InstalarAplicativo(string nomeApp)
        {
            // Implement the installation logic specific to iPhone
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }

        // Additional methods or properties specific to the iPhone class can be added here
    }
}
