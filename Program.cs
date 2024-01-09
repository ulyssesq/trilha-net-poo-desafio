using DesafioPOO.Models;

Console.WriteLine("Instanciando um Nokia");
Smartphone nokia = new Nokia("23456789", "Galaxy S23", "223452234522345", 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("Instanciando um Iphone");
Smartphone iphone = new Iphone("12345678", "15 Pro", "123451234512345", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
