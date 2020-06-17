using NUnit.Framework;
using SafariExplorerBuisness;

namespace SafariExplorerBuisnessTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase]
		public void TestRandomNumberGenerator()
		{
			PickAnimal animal = new PickAnimal();
			var value = animal.RandomNumberGen();
			
			Assert.IsTrue(value >= 63 && value <= 68);
			//Assert.AreEqual(expected: 10, actual: value); // just to see the output
		}
		
	}
}