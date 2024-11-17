using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Bank
{
   public  class Person
    {
        public int nameAccount {  get; set; }
        public string adress {  get; set; }
        private decimal balance {  get; set; }
       
    }
}
