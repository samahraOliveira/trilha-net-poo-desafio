using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarphone Nokia:");
Smartphone nokia = new Nokia(numero:"1010",modelo:"xxx",Imei:"1515", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smarphone Iphone:");
Smartphone iphone = new Iphone(numero:"2020",modelo:"zzz",Imei:"3030", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");