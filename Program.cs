using DesafioPOO.Models;

// Implementado!

Smartphone iphone = new Iphone(numero: "9389", modelo: "15 PRO", imei: "9999", memoria: 128);
Smartphone nokia = new Nokia(numero: "7456", modelo: "3200", imei: "1111", memoria: 64);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("VSCode");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Visual Studio");