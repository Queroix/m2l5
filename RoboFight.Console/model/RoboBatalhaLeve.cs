using RoboFight.model;

namespace RoboFight
{
    public class RoboBatalhaLeve : Robo
    {
        public RoboBatalhaLeve(string nome)
        {
            Nome = nome;
            PontosVida = 100;
            Status = (int)helpers.Status.Desligado;
        }

        public override void causarDano(Robo oponente)
        {
            Random random = new Random();            
            int valorDano = random.Next(1, 10);

            if (Status == (int)helpers.Status.Ligado)
            {
                Console.WriteLine(Nome + " causou " + valorDano + " de dano ao " + oponente.Nome);
                oponente.reduzirPontosVida(valorDano);
            }
        }
    }
}