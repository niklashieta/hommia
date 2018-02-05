using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08teht2
{
    public interface ITransaction
    {
        string ShowTransaction { get; set; }
        float GetAmount{get; set;}
    }
    class PaidWithCash : ITransaction
    {
        public string ShowTransaction { get; set; }
       
        public float GetAmount { get; set; }
    }
}
