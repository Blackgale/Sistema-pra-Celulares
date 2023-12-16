using DesafioPOO.Models;

Console.WriteLine("Celular Nokia: ");
Smartphone nokia = new Nokia(numero:"123456", modelo:"Mdelo 01", imei:"111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Aparelho Iphone: ");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo 02", imei: "222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");