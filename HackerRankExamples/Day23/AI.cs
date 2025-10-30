using HackerRankExamples.Day23;
using System;
using System.Collections.Generic;

namespace HackerRankExamples
{
    internal class AI
    {
        // Method
        public int PickSpot(TicTacToe game)
        {
            List<int> choices = new List<int>(); // De esta forma se crea un List sin valores.
            for (int i = 0; i < 9; i++)
            {
                //If the slot is not  taken, add it as a choice.
                if (game.board[i] == '-')
                {
                    choices.Add(i + 1);
                }
            }
            Random rand = new Random(); // objeto Random
            int choice = choices[Math.Abs(rand.Next() % choices.Count)]; //?
            return choice;
        }
    }
}