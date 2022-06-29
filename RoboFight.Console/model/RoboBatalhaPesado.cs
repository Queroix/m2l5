using RoboFight.model;

namespace RoboFight
{
    public class RoboBatalhaPesado : Robo
    {
        public RoboBatalhaPesado(string nome)
        {
            Nome = nome;
            PontosVida = 100;
            Status = (int)helpers.Status.Desligado;
        }

        public override void causarDano(Robo oponente)
        {
            Random random = new Random();
            int valorDano = random.Next(5, 20);

            if (Status == (int)helpers.Status.Ligado)
            {
                Console.WriteLine(Nome + " causou " + valorDano + " de dano ao " + oponente.Nome);
                oponente.reduzirPontosVida(valorDano);
                if (valorDano >= 15)
                {
                    Status = (int)helpers.Status.Aguardando;
                    Console.WriteLine(Nome + " superaqueceu apos o ataque.");
                }
            }
            else if (Status == (int)helpers.Status.Aguardando)
            {
                Console.WriteLine(Nome + " esta carregando o ataque.");
                Status = (int)helpers.Status.Ligado;
            }
        }
    }
}