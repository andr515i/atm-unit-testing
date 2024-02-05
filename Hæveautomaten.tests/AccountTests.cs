using Hæveautomaten;
using Xunit;
namespace Hæveautomaten.tests
{
	public class AccountTests
	{

		[Theory]
		[InlineData(10, 5, 5)]
		[InlineData(10.5, 5.125, 5.375)]
		public void SubtractTransaction_DecimalsShouldSubtract(decimal x, decimal y, decimal expceted)
		{
			decimal actual = Account.SubtractTransaction(x, y);
		}
	}
}
