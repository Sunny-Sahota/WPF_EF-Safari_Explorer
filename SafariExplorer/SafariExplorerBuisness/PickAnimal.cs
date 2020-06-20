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
			//Catch null
			int minNum = 0, maxNum = 0;
			try
			{
				using (var db = new SafariExplorerContext())
				{
					//var minIDQuery =
					//	(from animal in db.Animals
					//	 orderby animal.AnimalId ascending
					//	 select animal).Take(1);
					//foreach (var r in minIDQuery)
					//{
					//	minNum = r.AnimalId;
					//}

					//var maxIDQuery =
					//	(from animal in db.Animals
					//	 orderby animal.AnimalId descending
					//	 select animal).Take(1);
					//foreach (var r in maxIDQuery)
					//{
					//	maxNum = r.AnimalId;
					//}
					var countEntryQuery =
						from a in db.Animals
						select a.AnimalId;
					int numOfRows = countEntryQuery.Count();

					maxNum = numOfRows;
				}
			}
			catch (Exception e)
			{
				throw new Exception("Random number Generator failed. Check Queries");
			}
					
			Random rand = new Random();
			int num = rand.Next(minValue: minNum, maxValue: maxNum);
			return num;
		}
	}

	
}
