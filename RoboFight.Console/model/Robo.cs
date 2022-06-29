namespace RoboFight.model
{
    public abstract class Robo
    {
        private string _nome;
        public string Nome { get { return _nome; } protected set { _nome = value; } }

        private int _pontosVida;
        public int PontosVida { get { return _pontosVida; } protected set { _pontosVida = value; } }

        private int _status;
        public int Status { get { return _status; } set { _status = value; } }

        public bool iniciar()
        {
            Status = (int)helpers.Status.Ligado;
            if (Status == 1) { return true; }
            else { return false; }
        }

        public bool parar()
        {
            Status = (int)helpers.Status.Desligado;
            if (Status == 1) { return true; }
            else { return false; }
        }

        public abstract void causarDano(Robo oponente);

        public void reduzirPontosVida(int danoRecebido)
        {
            if(danoRecebido >= PontosVida){
                PontosVida = 0;
                Status = (int)helpers.Status.Destruido;
            } else {
                PontosVida -= danoRecebido;
            }

        }
    }
}