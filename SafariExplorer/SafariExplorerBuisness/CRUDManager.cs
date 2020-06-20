using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SE_CodeModel;
using Microsoft.EntityFrameworkCore;

namespace SafariExplorerBuisness
{
	public class CRUDManager
	{
		public Animal RandomSelectedAnimal { get; set; }
		public AnimalInfo RandomSelectedAnimalInfo { get; set; }
		public Animal SelectedAnimal { get; set; }
		public AnimalInfo SelectedAnimalInfo { get; set; }

		public int CurrentID = 0;


		public void GetRandAnimal()
		{
			PickAnimal animal = new PickAnimal();
			var animalNum = animal.RandomNumberGen();
			
			using (var db = new SafariExplorerContext())
			{
				int count = 1;
				string name = "";
				var query = db.Animals;
				foreach (var r in query)
				{
					count++;
					if (count == animalNum)
					{
						name = r.AnimalName;
						
					}
				}
				int count2 = 1;
				int animalsID = 0;
				var query2 = db.AnimalsInfo;
				foreach (var res in query2)
				{
					count2++;
					if (count2 == animalNum)
					{
						animalsID = res.AnimalId;

					}
				}

				RandomSelectedAnimal = db.Animals.Where(a => a.AnimalName == name).FirstOrDefault();
				RandomSelectedAnimalInfo = db.AnimalsInfo.Where(ai => ai.AnimalId == animalsID).FirstOrDefault(); 
				
			}
		}

		public void AddAnimal(string aName, string aDiet, int aHeight, int aLifespan, int aMass, int aSpeed)
		{
			using (var db = new SafariExplorerContext())
			{

				db.Add(new Animal { AnimalName = aName });
				db.SaveChanges();

				var q =
					(from a in db.Animals
					orderby a.AnimalId descending
					select a).Take(1);
				foreach (var r in q) 
				{
					CurrentID = r.AnimalId;
				}

				var getAnimalInfo = db.AnimalsInfo.Where(a => a.AnimalId == CurrentID).FirstOrDefault();

				//var query = db.Animals.OrderBy(a => a.AnimalId).FirstOrDefault();

				//var query2 =
				//	from a in db.Animals
				//	orderby a.AnimalId descending
				//	select a;

				//int localID = query2.AnimalId;

				db.Add(new AnimalInfo
				{
					AnimalId = CurrentID,
					Diet = aDiet,
					Height = aHeight,
					Lifespan = aLifespan,
					Mass = aMass,
					Speed = aSpeed
				});
				
				db.SaveChanges();
			}
		}

		public List<AnimalInfo> RetrieveAllAnimalInfo()
		{
			using (var db = new SafariExplorerContext())
			{
				return db.AnimalsInfo.ToList();
			}
		}

		public void UpdateAnimalEntry(int aID, string aNAme, string aDiet, int aHeight, int aLifespan, int aMass, int aSpeed)
		{
			using (var db = new SafariExplorerContext())
			{
				
				SelectedAnimalInfo = db.AnimalsInfo.Where(ai => ai.AnimalId == aID).FirstOrDefault();
				SelectedAnimal = db.Animals.Where(a => a.AnimalId == aID).FirstOrDefault();


				SelectedAnimal.AnimalName = aNAme;
				SelectedAnimalInfo.AnimalId = aID;
				SelectedAnimalInfo.Diet = aDiet;
				SelectedAnimalInfo.Height = aHeight;
				SelectedAnimalInfo.Lifespan = aLifespan;
				SelectedAnimalInfo.Mass = aMass;
				SelectedAnimalInfo.Speed = aSpeed;
				db.SaveChanges();
			}
		}

		
		public void SetSelectedAnimalInfo(object selectedItem)
		{
			SelectedAnimalInfo = (AnimalInfo)selectedItem;
			CurrentID = SelectedAnimalInfo.AnimalId;
		}

		public void SetSelectedAnimal()
		{
			//I want to set an animal based upon the animalInfo Selected 
			//SelectedAnimal = (Animal)selectedItem;
			using (var db = new SafariExplorerContext())
			{
				SelectedAnimal = db.Animals.Where(a => a.AnimalId == CurrentID).FirstOrDefault();
			}
		}

		public void DeleteAnimal(int aId)
		{
			using (var db = new SafariExplorerContext())
			{
				var queryAnimal = db.Animals.Where(a => a.AnimalId == aId).FirstOrDefault();
				var queryAnimalInfo = db.AnimalsInfo.Where(a => a.AnimalId == aId).FirstOrDefault();
				
				db.Remove(queryAnimal);
				db.Remove(queryAnimalInfo);
				db.SaveChanges();
			}
		}
	}
}
