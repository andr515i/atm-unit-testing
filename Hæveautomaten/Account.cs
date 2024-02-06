using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hæveautomaten
{
	public class Account
	{
		private int _id;

		public int Id { get { return _id; } set { if(IsBankEmployee()) _id = value } }

		public string AccountName { get; set; }


		private short _pinCode;

		public short PinCode
		{
			get { if (IsBankEmployee()) return _pinCode; return 1234; }
			set { if (IsBankEmployee()) _pinCode = value; }
		}


		public Account(short pinCode, string accountName)
		{
			AccountName = accountName;
			PinCode = pinCode;

			

		}

		private bool IsBankEmployee()
		{
			if (Id <= 100)
			{
				return true;
			}
			return false;
		}

		/// <summary>
		/// x is the currency that which the user currently has. y is the amount we subtract from the account.
		/// </summary>
		/// <param name="x">curent balance</param>
		/// <param name="y"></param>
		/// <returns></returns>
		public decimal SubtractTransaction(decimal x, decimal y)
		{
			if (x < 0 || y < 0) return x;
			return x - y;
		}
		/// <summary>
		/// x is the currency that which the user currently has. y is the amount we add to the account.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public decimal AddTransaction(decimal x, decimal y)
		{
			return x + y;
		}
	}
}
