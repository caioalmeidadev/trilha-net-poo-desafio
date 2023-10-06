using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


var Nokia3220 = new Nokia("92929292");
Nokia3220.Memoria = 32;
Nokia3220.IMEI = "123456765432";
Nokia3220.Modelo = "3220";

var iPhone15 = new Iphone("93331515");
iPhone15.Memoria = 128;
iPhone15.IMEI = "1234567654";
iPhone15.Modelo = "iPhone15";

iPhone15.Ligar();
Nokia3220.ReceberLigacao();

Nokia3220.Ligar();
iPhone15.ReceberLigacao();

Nokia3220.InstalarAplicativo("Instagram");
iPhone15.InstalarAplicativo("iPhone15");




