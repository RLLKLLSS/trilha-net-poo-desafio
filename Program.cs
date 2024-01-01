using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("231313","modelo1","sdfdsf545665",128);
iphone.Ligar();
iphone.InstalarAplicativo("Linkedin");
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("231313","modelo1","sdfdsf545665",128);
nokia.Ligar();
nokia.InstalarAplicativo("Signal");