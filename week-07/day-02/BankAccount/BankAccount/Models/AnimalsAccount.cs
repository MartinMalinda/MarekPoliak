using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.Models
{
    public class AnimalsAccount
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }
        public string Moral { get; set; }

        public AnimalsAccount(string moral, string name,int balance,string animalType, bool isKing)
        {
            Moral = moral;
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
        }
    }
}
