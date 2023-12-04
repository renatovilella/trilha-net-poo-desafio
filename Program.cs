using DesafioPOO.Models;
using System;

class Program
{
    static void Main()
    {
        // Test Nokia
        Nokia nokiaPhone = new Nokia("123456789", "Nokia Model", "IMEI123", 64);
        TestSmartphone(nokiaPhone, "Nokia App");

        // Test iPhone
        Iphone iphone = new Iphone("987654321", "iPhone Model", "IMEI456", 128);
        TestSmartphone(iphone, "iPhone App");

        Console.ReadLine();
    }

    static void TestSmartphone(Smartphone phone, string appName)
    {
        // Test common methods
        phone.Ligar();
        phone.ReceberLigacao();

        // Test the overridden method
        phone.InstalarAplicativo(appName);
    }
}

// TODO: Realizar os testes com as classes Nokia e Iphone