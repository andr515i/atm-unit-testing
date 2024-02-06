using System;
using System.Security.Cryptography;

namespace Hæveautomaten
{
	public class Account
	{
		private int _id;

		public int Id { get { return _id; } set { if (!IsEmployee.IsEmployee.IsBankEmployee(Id)) return; _id = value; } }

		public string AccountName { get; set; }


		private string _pinCode;

		public string PinCode
		{
			get { if (IsEmployee.IsEmployee.IsBankEmployee(Id)) return _pinCode; return "error"; }
			set { if (IsEmployee.IsEmployee.IsBankEmployee(Id)) _pinCode = value; }
		}


		public Account( string accountName)
		{
			AccountName = accountName;
			PinCode = GenerateRandomPin();


		}


		private string GenerateRandomPin()
		{

			byte[] randomBytes = new byte[2];

			
			using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
			{
				rng.GetBytes(randomBytes);
			}

			int randomNumber = BitConverter.ToInt16(randomBytes, 0);

			int pin = Math.Abs(randomNumber % 10000);

			string formattedPin = pin.ToString("D4");

			return formattedPin;

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
