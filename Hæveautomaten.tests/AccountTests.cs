using Hæveautomaten;
using Xunit;
namespace Hæveautomaten.tests
{
	public class AccountTests
	{
		private Account _account = new Account(2345, "nordea", "defaut konto navn...");

		[Theory]
		[InlineData(10, 5, 5)]
		[InlineData(10.5, 5.125, 5.375)]
		public void SubtractTransaction_DecimalsShouldSubtract(decimal x, decimal y, decimal expceted)
		{
			decimal actual = _account.SubtractTransaction(x, y);

			Assert.Equal(expceted, actual);
		}
		[Theory]
		[InlineData(5,5,10)]
		[InlineData(10.005, 5.8001, 15.8051)]
		public void AddTransaction_DecimalsShouldAdd(decimal x, decimal y, decimal expceted)
		{
			decimal actual = _account.AddTransaction(x, y);

			Assert.Equal(expceted, actual);
		}
	
	}
}
