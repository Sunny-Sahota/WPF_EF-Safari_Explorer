﻿using System;
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

		private int _currentID = 0;

		public void GetRandAnimal()
		{
			PickAnimal animal = new PickAnimal();
			var animalNum = animal.RandomNumberGen();
			
			using (var db = new SafariExplorerContext())
			{
				int count = 0;
				string name = "";
				var queryAnimals = db.Animals;
				foreach (var result in queryAnimals)
				{
					count++;
					if (count == animalNum)
					{
						name = result.AnimalName;						
					}
				}
				int count2 = 0;
				int animalsID = 0;//may remove, use global instead
				var queryAnimalInfo = db.AnimalsInfo;
				foreach (var result in queryAnimalInfo)
				{
					count2++;
					if (count2 == animalNum)
					{
						animalsID = result.AnimalId;
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

				var queryLatestEntry =
					(from a in db.Animals
					orderby a.AnimalId descending
					select a).Take(1);
				foreach (var result in queryLatestEntry) 
				{
					_currentID = result.AnimalId;
				}

				db.Add(new AnimalInfo
				{
					AnimalId = _currentID,
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


		public void SetSelectedAnimalInfo(object selectedItem)
		{
			SelectedAnimalInfo = (AnimalInfo)selectedItem;
			_currentID = SelectedAnimalInfo.AnimalId;
		}

		public void SetSelectedAnimal()
		{
			using (var db = new SafariExplorerContext())
			{
				SelectedAnimal = db.Animals.Where(a => a.AnimalId == _currentID).FirstOrDefault();
			}
		}
	
	}
}
