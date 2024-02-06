using RandomNameGeneratorLibrary;
using Xunit;
namespace Hæveautomaten.tests
{
	public class BankTests
	{
	
		private Bank bank = new Bank("test bank", new Account("Tom Larsens lønkonto"));


		[Fact]
		public void AddEmployee_ShouldAddEmployeeBelow100Id()
		{
			var p = new PersonNameGenerator();
			Account newAccount = new Account(p.GenerateRandomFirstAndLastName());
			bank.AddEmployee(newAccount, true);

			Assert.True(bank.GetAccounts(1).Contains(newAccount));
		}
		[Fact]
		public void AddEmployee_ShouldAddAccountAbove100Id()
		{
			var p = new PersonNameGenerator();
			Account newAccount = new Account(p.GenerateRandomFirstAndLastName());
			bank.AddEmployee(newAccount, false);

			Assert.True(bank.GetAccounts(1).Contains(newAccount));
        }

	}
}
