using DesafioPOO.Models;

Console.WriteLine("Smartphone Nókia");
Smartphone nokia = new Nokia(numero: "+5511999999999", modelo: "Modelo Lumia 1100", imei: "1111111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Asphalt 9");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "+5511988888888", modelo: "Modelo 15 PRO", imei: "22222222222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Call of Duty");

