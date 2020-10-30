using NewGame.Interface;

namespace NewGame.Lib
{
    public class Player2 : iPlayer
    {
        public string Dead()
        {
            return "Dark213 dead \n";
        }

        public string Join()
        {
            return "Dark213 join the game \n";
        }

        public string Run()
        {
            return "Dark213 ran \n";
        }
    }
}