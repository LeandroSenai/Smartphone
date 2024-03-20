namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public override void Ligar()
        {
            Console.WriteLine("Ligando o Nokia...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Tocando! Chamada recebida no Nokia...");
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} no Nokia...");
        }
    }

}