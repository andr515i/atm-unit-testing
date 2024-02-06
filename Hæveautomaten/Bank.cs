using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hæveautomaten
{
	public class Bank
	{

		public string _bankName { get; }
		private List<Account> _accounts = new List<Account>();

        public Bank(string bankName, Account ownerAccount)
        {
               _bankName = bankName;
        }
    }
}
