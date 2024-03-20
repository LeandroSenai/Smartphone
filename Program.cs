using DesafioPOO.Models;


    Nokia nokia = new Nokia();
    nokia.Numero = "1199999999";
    nokia.Modelo = "X20";
    nokia.IMEI = "123456789012345";
    nokia.Memoria = 128;

    // Instalando um aplicativo no Nokia
    nokia.InstalarAplicativo("Whatsapp");

    // Criando um objeto Iphone
    Iphone iphone = new Iphone();
    iphone.Numero = "1298765432";
    iphone.Modelo = "13 Pro Max";
    iphone.IMEI = "987654321098765";
    iphone.Memoria = 256;

    // Instalando um aplicativo no Iphone
    iphone.InstalarAplicativo("Instagram");
