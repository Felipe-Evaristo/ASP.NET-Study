using System;
using NewGame.Lib;

namespace NewGame
{
  class Program
    {
        static void Main(string[] args)
        {
            var game = new NiceGame(  
            new Player2(),
            new Player1()
            );
            game.StartGame( );
        }
    }
    
}

