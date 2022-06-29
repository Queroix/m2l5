using RoboFight.model;

namespace Engine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robo A;
            Robo B;
            System.Console.WriteLine("Digite o nome do primeiro Robo: ");
            var nomeA = Console.ReadLine();

            System.Console.WriteLine("Selecione o tipo do robo\n1- Robo de Batalha Leve\n2- Robo de batalha Pesado");
            int tipoA = int.Parse(Console.ReadLine());

            while (tipoA < 1 && tipoA > 2)
            {
                System.Console.WriteLine("Opção invalida!\nSelecione o tipo do robo\n1- Robo de Batalha Leve\n2- Robo de batalha Pesado");
                tipoA = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Digite o nome do segundo Robo: ");
            var nomeB = Console.ReadLine();

            System.Console.WriteLine("Selecione o tipo do robo\n1- Robo de Batalha Leve\n2- Robo de batalha Pesado");
            int tipoB = int.Parse(Console.ReadLine());

            while (tipoA < 1 && tipoA > 2)
            {
                System.Console.WriteLine("Opção invalida!\nSelecione o tipo do robo\n1- Robo de Batalha Leve\n2- Robo de batalha Pesado");
                tipoB = int.Parse(Console.ReadLine());
            }

            A = RoboFight.helpers.FabricaRobo.CreateRobo(nomeA, tipoA);
            B = RoboFight.helpers.FabricaRobo.CreateRobo(nomeB, tipoB);

            System.Console.WriteLine("Informe a quantidade maxima de rodadas para essa batalha.");
            int limite = int.Parse(Console.ReadLine());

            RoboFight.PartidaBatalha.batalhar(A, B, limite);



        }
    }
}