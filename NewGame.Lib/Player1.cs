using NewGame.Interface;

namespace NewGame.Lib
{
     public class Player1 : iPlayer

    {
        

        public string Join(){
            return "Felipe join the game\n";
        }
 
        public string Dead() {
            return "Felipe dead\n";
        }

        public string Run() {
            return "Felipe ran\n";
        }

    }
}