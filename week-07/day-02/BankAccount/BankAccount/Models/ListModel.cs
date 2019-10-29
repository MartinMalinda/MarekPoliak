using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.Models
{
    public static class ListModel
    {
        public static List<AnimalsAccount> list { get; set; } = new List<AnimalsAccount>()
        {
            new AnimalsAccount("good guy", "simba", 1000, "lion", true),
            new AnimalsAccount("bad guy", "idk", 2543, "idk", false),
            new AnimalsAccount("bad guy", "marek", 543, "pig", false)
        };
    }
}
