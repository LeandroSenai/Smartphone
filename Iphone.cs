namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public override void Ligar()
        {
            Console.WriteLine("Ligando o Iphone...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Tocando! Chamada recebida no Iphone...");
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} no Iphone...");
        }
    }
}