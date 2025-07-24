using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321098765", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Uber");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone("123456789", "iPhone 13", "123456789012345", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("OLX");

