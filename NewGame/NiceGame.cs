using System;
using NewGame.Interface;

namespace NewGame
{
    public class NiceGame
    {
        private readonly IPlayer _Player1;

        private readonly IPlayer _Player2;
          
        public NiceGame(IPlayer Player1, IPlayer Player2){
            _Player1 = Player1;
            _Player2 = Player2;
        }
        public void StartGame(){
            System.Console.Write(_Player1.Dead());
            System.Console.Write(_Player2.Run());
            System.Console.Write(_Player1.Join());
        }
    }
    
        

}