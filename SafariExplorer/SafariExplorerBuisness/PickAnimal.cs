using System;
using SE_CodeModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SafariExplorerBuisness
{
	public class PickAnimal
	{
		public PickAnimal() { }
	
		public int RandomNumberGen()
		{
			int minNum = 0, maxNum = 0;
			try
			{
				using (var db = new SafariExplorerContext())
				{
					var countEntryQuery =
						from a in db.Animals
						select a.AnimalId;
					int numOfRows = countEntryQuery.Count();

					maxNum = numOfRows;
				}
			}
			catch (Exception)
			{
				throw new Exception("Random number Generator failed. Check Queries");
			}				
			Random rand = new Random();
			int num = rand.Next(minValue: minNum, maxValue: maxNum);
			return num;
		}
	}

	
}
