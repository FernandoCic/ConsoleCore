using GameTop.Interface;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly IJogador _jogadorA;

        private readonly IJogador _jogadorB;
        public JogoFoda(IJogador jogadorA, IJogador jogadorB)
        {
            this._jogadorA = jogadorA;
            this._jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Passe());

            System.Console.Write("\n PRÓXIMO JOGADOR \n");

            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passe());
        }
    }
}