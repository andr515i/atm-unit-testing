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

		public List<Account> GetAccounts(int id)
		{
			if (IsEmployee.IsEmployee.IsBankEmployee(id))
			{
				return _accounts;
			}
			else throw new UnauthorizedAccessException("access denied. only bank employess are allowed");
		}



		public Bank(string bankName, Account ownerAccount)
		{
			_bankName = bankName;
			_accounts.Add(ownerAccount);
		}


		public void AddEmployee(Account accountToAdd, bool isEmployee)
		{
			if (!isEmployee)
			{
				accountToAdd.Id = _accounts.Count() + 100;
				_accounts.Add(accountToAdd);
			}
			else
			{
				if (_accounts.Count <= 100)
				{
					_accounts.Add(accountToAdd);
				}
				else
				{

					throw new IndexOutOfRangeException();
				}
			}


		}
	}
}
