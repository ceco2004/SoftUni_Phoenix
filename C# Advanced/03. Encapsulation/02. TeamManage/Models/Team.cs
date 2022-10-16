using _01._SortByNameAndAge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02._TeamManage.Models
{
    public class Team
    {
        private const string nameErrMsg = "Name cannot contain less than 3 symbols!";

        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public string Name { get => name; private set => name = CheckName(value); }
        public List<Person> FirstTeam { get => firstTeam; }
        public List<Person> ReserveTeam { get => reserveTeam;}

        public Team(string name)
        {
            Name = CheckName(name);
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public void AddPlayer(Person player)
        {
            if(player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }

        private string CheckName(string name)
        {
            if(name.Length < 3)
            {
                throw new ArgumentException(nameErrMsg);
            }

            return name;
        }

        public override string ToString()
        {
            string msg = $"First team have {firstTeam.Count} players.";
            msg += $"\nReserved team have {reserveTeam.Count} players.";
            return msg;
        }
    }
}
