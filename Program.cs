using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphne Nokia:");
Smartphone nokia = new Nokia(numero: "1233456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whattsap");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphne iphone:");
Smartphone iphone = new Iphone(numero: "05506069", modelo: "Modelo 2", imei: "99999999999", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");