using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomNumber.Models
{
    public class Generator
    {
        private readonly Random random = new Random();

        public int ReturnNumber()
        {
            return random.Next(100);
        }
    }
}
