using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero: "123456", modelo:  "Modelo 1", imei:  "1111111",memoria:  64 );
Console.WriteLine(nokia.ToString());
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");
Console.WriteLine("\n");

Smartphone iphone = new Nokia(numero: "76543", modelo:  "Modelo 2", imei:  "444444",memoria:  128 );
Console.WriteLine(iphone.ToString());
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Discord");




