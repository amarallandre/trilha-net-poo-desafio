using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "123", modelo: "modelo", imei: "123", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("facebook");


Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "123", modelo: "Modelo", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");