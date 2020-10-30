using System;
using NewGame.Interface;

namespace NewGame
{
    public class NiceGame
    {
        private readonly iPlayer _Player1;

        private readonly iPlayer _Player2;
          
        public NiceGame(iPlayer Player1, iPlayer Player2){
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