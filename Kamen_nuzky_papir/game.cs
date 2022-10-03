using System;
using System.Collections.Generic;
using System.Text;
using System. Timers;

namespace Kamen_nuzky_papir
{
    class game
    {
        private Timer timer;

        public Player Player1 { get;  }

        public Player Player2 { get;  }

        public game (int money)
        {
            Player1 = new Player(money);
            Player2 = new Player(money);
            timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
           

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var p1 = Player1.GetStarted();
            var p2 = Player2.GetStarted();
            if (p1!=p2)
            {
                if (p1 == PlayerStats.Kámen)
                {
                    if (p2 == PlayerStats.Nůžky)
                    {
                        Player1.Win();
                        Player2.Lose();
                    }
                    else
                    {
                        Player1.Lose();
                        Player2.Win();
                    }
                }
                else if (p1 == PlayerStats.Nůžky)
                {
                    if (p2 == PlayerStats.Papír)
                    {
                        Player1.Win();
                        Player2.Lose();
                    }
                    else
                    {
                        Player1.Lose();
                        Player2.Win();
                    }
                }
                else if (p1 == PlayerStats.Papír)
                {
                    if (p2 == PlayerStats.Kámen)
                    {
                        Player1.Win();
                        Player2.Lose();
                    }
                    else
                    {
                        Player1.Lose();
                        Player2.Win();
                    }
                }
            }
            
                    
        }
    }
}
