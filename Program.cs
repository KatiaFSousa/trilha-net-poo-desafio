using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "86598", modelo: "Model1", imei: "111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "67890", modelo: "Model2", imei: "99999", memoria: 240);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("youtube");