using System.Linq.Expressions;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphone Nokia:");
 Smartphone nokia = new  Nokia(numero:"12343", modelo: "Modelo 1", imei: "1111111111111", memoria: 64);
 nokia.Ligar();
 nokia.InstalarAplicativo("Whatsapp");

 System.Console.WriteLine("\n");

 System.Console.WriteLine("Smartphone Iphone"); 
  Smartphone iphone = new  Iphone(numero:"112312", modelo: "Modelo 2", imei: "222222222", memoria: 128);
  iphone.ReceberLigacao();
  iphone.InstalarAplicativo("Telegram");

