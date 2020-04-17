using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "teste chuta \n";
        }

        public string Corre()
        {
            return "Teste Corre \n";
        }

        public string Passe()
        {
            return "Teste Passe \n";
        }
    }
}