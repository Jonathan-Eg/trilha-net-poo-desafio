using DesafioPOO.Models;
Console.WriteLine("\n Nokia");
Smartphone nokia = new Nokia(numero: "123", modelo: "modelo A", imei: "1111111", memoria: 128);
Console.WriteLine("\n");
nokia.Ligar();
Console.WriteLine("\n");
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n\n");

Console.WriteLine("\n Iphone");
Smartphone iphone = new Iphone(numero: "456", modelo: "modelo B", imei: "2222222", memoria: 256);
Console.WriteLine("\n");
nokia.Ligar();
Console.WriteLine("\n");
nokia.InstalarAplicativo("Telegram");
