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
			using (var db = new SafariExplorerContext())
			{
				var minIDQuery =
					(from animal in db.Animals
					 orderby animal.AnimalId ascending
					 select animal).Take(1);
				foreach (var r in minIDQuery)
				{
					minNum = r.AnimalId;
				}

				var maxIDQuery =
					(from animal in db.Animals
					 orderby animal.AnimalId descending
					 select animal).Take(1);
				foreach (var r in maxIDQuery)
				{
					maxNum = r.AnimalId;
				}

			}
			Random rand = new Random();
			int num = rand.Next(minValue: minNum, maxValue: maxNum);
			return num;
		}

	}

	public class CRUDManager
	{
		public Animal SelectedAnimal { get; set; }

		public void UpdateAnimal()
		{
			using (var db = new SafariExplorerContext()) 
			{
				//string Name = " ";
				//SelectedAnimal =
				//	from animal in db.Animals
				//	join aInfo in db.AnimalsInfo on animal.AnimalId equals aInfo.AnimalId
				//	group aInfo by animal into g
				//	select g;
					
			}
				

		}
	}
}
