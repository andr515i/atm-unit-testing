using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hæveautomaten.tests
{
	public class BankTests
	{
	
		private Bank bank = new Bank("test bank", new Account(
			pinCode: 9100, "test bank", "Tom Larsens lønkonto"));

		public void AddEmployee_ShouldAddEmployeeBelow100Id()
		{
			bank.AddEmployee(new Account())
		}

	}
}
