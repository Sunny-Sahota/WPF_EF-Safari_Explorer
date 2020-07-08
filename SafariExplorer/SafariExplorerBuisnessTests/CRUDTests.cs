using System.Data.Common;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using SafariExplorerBuisness;
using SE_CodeModel;

namespace SafariExplorerBuisnessTests
{
	public class CRUDTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void AddAnimalTest()
		{
			//Set-up
			CRUDManager _crudManager = new CRUDManager();
			bool testPassed = false;
			int rowBeforeCount = 0;

			using (var db = new SafariExplorerContext())
			{
				rowBeforeCount = db.Animals.ToList().Count;
			}

			//TestMethodcall
			_crudManager.AddAnimal(
				aName: "Wolf",
				aDiet: "Carnivore",
				aHeight: 1,
				aLifespan: 8,
				aMass: 80,
				aSpeed: 60
			);
			

			//Assert
			using (var db = new SafariExplorerContext())
			{
				int rowAfterCount = db.Animals.ToList().Count;
				if (rowAfterCount != rowBeforeCount) { testPassed = true; }
				Assert.IsTrue(testPassed);
			}

			//Undo Database Changes
			using (var db = new SafariExplorerContext())
			{
				if (testPassed)
				{
					Animal removeAnimal = db.Animals.ToList().Last();
					db.Animals.Remove(removeAnimal);

					AnimalInfo removeAI = db.AnimalsInfo.ToList().Last();
					db.AnimalsInfo.Remove(removeAI);
					db.SaveChanges();
				}
			}

		}
		[TestCase]
		public void UpdateAnimal()
		{
			//Set-up
			CRUDManager _crudManager = new CRUDManager();
			bool testPassed = false;
			int currentID =  0;
			int correctDataCount = 0;

			//Adding original data 		
			//Add place holder animal to generate space in database
			_crudManager.AddAnimal(
				aName: "TestDefault",
				aDiet: "Data",
				aHeight: 1,
				aLifespan: 1,
				aMass: 1,
				aSpeed: 1
			);
			using (var db = new SafariExplorerContext())
			{
				//Get the ID of the test entry data added
				var getIDQuery =
					(from a in db.Animals
					 orderby a.AnimalId descending
					 select a).Take(1);
				foreach (var result in getIDQuery)
				{
					currentID = result.AnimalId;
				}
			}

			//TestMethodCall
			string name = "Wolf"; string diet = "Carnivore"; int height = 1; int lifespan = 8; int mass = 80; int speed = 60;
			_crudManager.UpdateAnimalEntry(
				aID: currentID,
				aNAme: name,
				aDiet: diet,
				aHeight: height,
				aLifespan: lifespan,
				aMass: mass,
				aSpeed: speed
				);

			//Assert
			using (var db = new SafariExplorerContext())
			{
				var getAIQuery = db.AnimalsInfo.Where(ai => ai.AnimalId == currentID).FirstOrDefault();
				var getAQuery = db.Animals.Where(a => a.AnimalId == currentID).FirstOrDefault();

				if (getAQuery.AnimalName == name) { correctDataCount++; }
				if (getAIQuery.Diet == diet) { correctDataCount++; }
				if (getAIQuery.Height == height) { correctDataCount++; }
				if (getAIQuery.Lifespan == lifespan) { correctDataCount++; }
				if (getAIQuery.Mass == mass) { correctDataCount++; }
				if (getAIQuery.Speed == speed) { correctDataCount++; }

				if (correctDataCount == 6)
				{
					testPassed = true;
				}
			}
			Assert.IsTrue(testPassed);

			//Undo changes
			using (var db = new SafariExplorerContext())
			{
				if (testPassed)
				{
					Animal removeAnimal = db.Animals.ToList().Last();
					db.Animals.Remove(removeAnimal);

					AnimalInfo removeAI = db.AnimalsInfo.ToList().Last();
					db.AnimalsInfo.Remove(removeAI);
					db.SaveChanges();
				}
			}
		}

		[Test]
		public void DeleteAnimal()
		{
			//Set-up
			CRUDManager _crudManager = new CRUDManager();
			bool testPassed = false;
			int rowBeforeCount = 0; //Number of rows after addition made
			int currentID = 0;

			_crudManager.AddAnimal(
				aName: "Wolf",
				aDiet: "Carnivore",
				aHeight: 1,
				aLifespan: 8,
				aMass: 80,
				aSpeed: 60
			);

			using (var db = new SafariExplorerContext())
			{
				rowBeforeCount = db.Animals.ToList().Count;
				var getIDQuery =
					(from a in db.Animals
					 orderby a.AnimalId descending
					 select a).Take(1);
				foreach (var result in getIDQuery)
				{
					currentID = result.AnimalId;
				}
			}

			//TestMethodcall
			_crudManager.DeleteAnimal(currentID);


			//Assert
			using (var db = new SafariExplorerContext())
			{
				int rowAfterCount = db.Animals.ToList().Count;
				
				if (rowAfterCount != rowBeforeCount) { testPassed = true; }
				Assert.IsTrue(testPassed);
			}
		}


		[TestCase]
		public void TestRandomNumberGenerator()
		{
			//Unfinished Test Method
			//Set-up
			CRUDManager _crudManager = new CRUDManager();
			PickAnimal animal = new PickAnimal();
			var value = animal.RandomNumberGen();
			int maxNum = 0;
			int minNum = 0;

			using (var db = new SafariExplorerContext())
			{
				var countEntryQuery =
						from a in db.Animals
						select a.AnimalId;
				int numOfRows = countEntryQuery.Count();

				maxNum = numOfRows;
			}

			//Assert
			Assert.IsTrue(value > minNum && value < maxNum);

		}
	}
}