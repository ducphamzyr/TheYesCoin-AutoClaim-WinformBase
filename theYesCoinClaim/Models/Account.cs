using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace theYesCoinClaim.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string AmountCoin { get; set; }
        public string Token { get; set; }
    }
}
