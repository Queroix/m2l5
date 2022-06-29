using RoboFight.model;

namespace RoboFight

{
    public class PartidaBatalha
    {
        public static void batalhar(Robo A, Robo B, int limite)
        {

            A.Status = (int)helpers.Status.Ligado;
            B.Status = (int)helpers.Status.Ligado;
            for (int i = 0; i < limite && A.PontosVida > 0 && B.PontosVida > 0; i++)
            {
                System.Console.WriteLine(PartidaBatalha.placar(A, B, i+1));

                System.Console.WriteLine("---------------------------------------------------------------");
                A.causarDano(B);

                if (B.PontosVida > 0)
                {
                    B.causarDano(A);
                }

                System.Console.WriteLine("================================================================");
            }

            if (A.PontosVida == B.PontosVida)
            {
                System.Console.WriteLine("Empate!");
            }
            else if (A.PontosVida > 0)
            {
                System.Console.WriteLine("Vitoria de " + A.Nome);
            }
            else
            {
                System.Console.WriteLine("Vitoria de " + B.Nome);
            }


        }

        public static string placar(Robo A, Robo B, int i)
        {
            return "Round "+i+"\nRobo " + A.Nome + " está com " + A.PontosVida + " pontos de vida.\nRobo " + B.Nome + " está com " + B.PontosVida + " pontos de vida.";
        }
    }
}