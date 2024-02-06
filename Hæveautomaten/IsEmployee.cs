
namespace Hæveautomaten.IsEmployee
{
	public static class IsEmployee
	{
		public static bool IsBankEmployee(int id)
		{
			if (id <= 100)
			{
				return true;
			}
			return false;
		}
	}
}
