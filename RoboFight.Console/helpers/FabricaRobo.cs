using RoboFight.model;
namespace RoboFight.helpers
{
    public  class FabricaRobo
    {
        public static Robo CreateRobo(string nome, int tipo){
            Robo robo;

            if(tipo == 1){
                robo = new RoboBatalhaLeve(nome);
            } else {

                robo = new RoboBatalhaPesado(nome);
            }

            return robo;
        }
    }
}