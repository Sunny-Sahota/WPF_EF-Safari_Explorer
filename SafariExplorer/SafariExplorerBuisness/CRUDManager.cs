using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SE_CodeModel;

namespace SafariExplorerBuisness
{
	public class CRUDManager
	{
		public Animal SelectedAnimal { get; set; }
		public AnimalInfo SelectedAnimalInfo { get; set; }

		public void UpdateAnimal()
		{
			PickAnimal animal = new PickAnimal();
			var animalID = animal.RandomNumberGen();
			
			using (var db = new SafariExplorerContext())
			{
				SelectedAnimalInfo = db.AnimalsInfo.Where(a => a.AnimalId == animalID).FirstOrDefault();
				var sa =
					from a in db.Animals
					where a.AnimalId == animalID
					select a;
				SelectedAnimal = sa.FirstOrDefault();
				
			}
		}
		
	}
}
