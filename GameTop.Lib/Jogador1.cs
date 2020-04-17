using GameTop.Interface;

namespace GameTop.Lib
{
     public class Jogador1 : IJogador
    {
        public readonly string Nome;

        public Jogador1()
        {
            //this.Nome = nome;
        }
        public string Chuta()
        {
            return $"{Nome} está chutando ";
        }

        public string Corre()
        {
            return $"{Nome} está correndo ";
        }
        
        public string Passe()
        {
            return $"{Nome} está passando ";
        }
    }
}