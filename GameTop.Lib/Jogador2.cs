using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Maratona está chutando";
        }

        public string Corre()
        {
            return "Maratona está Correndo";
        }

        public string Passe()
        {
            return "Maratona está Passando";
        }
    }
}