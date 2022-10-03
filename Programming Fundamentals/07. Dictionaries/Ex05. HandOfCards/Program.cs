using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05._HandOfCards
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> playerWithCards = new Dictionary<string, List<string>>();
            while (input != "JOKER")
            {
                string[] nameCards = input.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = nameCards[0];

                string[] cards = nameCards[1].Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
              
                AddPlayerAndCards(name, cards);


                input = Console.ReadLine();
            }

            foreach(var player in playerWithCards)
            {
                Console.WriteLine($"{player.Key}: {CalculatePoints(player.Value)}");
            }

            int CalculatePoints(List<string> cards)
            {
                int score = 0;
                foreach(var card in cards)
                {
                    string c1 = card.Trim();
                    string valueCard = c1.Remove(c1.Length - 1, 1);
                    
                    string typeCard = string.Empty;

                    if(c1.Length == 2)
                    {
                       typeCard =  c1.Remove(0, 1);
                    }
                    else if(c1.Length == 3)
                    {
                        typeCard = c1.Remove(0, 2);
                    }

                    int value = 0;

                    if(int.TryParse(valueCard, out value) == false)
                    {
                        switch (valueCard)
                        {
                            case "J": value = 11; break;
                            case "Q": value = 12; break;
                            case "K": value = 13; break;
                            case "A": value = 14; break;
                        }
                    }
                   
                    int type = 0;
                    switch (typeCard)
                    {
                        case "S": type = 4; break;
                        case "H": type = 3; break;
                        case "D": type = 2; break;
                        case "C": type = 1; break;
                    }

                    score += value * type;
                }

                return score;
            }

            void AddPlayerAndCards(string name, string[] cards)
            {
                if(playerWithCards.ContainsKey(name) == false)
                {
                    playerWithCards[name] = new List<string>();
                }

                foreach(var card in cards)
                {
                    if(playerWithCards[name].Contains(card) == false)
                    {
                        playerWithCards[name].Add(card);
                    }
                }
            }
        }

    }
}
