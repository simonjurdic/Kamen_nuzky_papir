using System;
using System.Collections.Generic;
using System.Text;

namespace Kamen_nuzky_papir
{
    public class Player
    {
        Random random = new Random();

        public int Money { get; internal set; }

        public Player(int money)
        {
            Money = money;

        }

        public PlayerStats GetStarted()
        {
            int value = random.Next(0, 3);
            return (PlayerStats)value;
        }

        public void Win()
        {
            Money++;
        }

        public void Lose()
        {
            Money--;
        }
    }

    public enum PlayerStats
    {
        Kámen,
        Nůžky,
        Papír,
    }

}
