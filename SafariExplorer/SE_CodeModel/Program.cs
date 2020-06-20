using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SE_CodeModel
{
	public class Program
	{
		public static void Main(string[] args)
		{
			using (var db = new SafariExplorerContext())
			{
				//var countEntryQuery =
				//	from a in db.Animals
				//	select a.AnimalId;
				//int numOfRows = countEntryQuery.Count();

				//Random rand = new Random();
				//int num = rand.Next(0, numOfRows);
				//Console.WriteLine(num);


				//int count = 1;
				//string name = ""; 
				//var query = db.Animals;
				//foreach (var r in query)
				//{
				//	count++;
				//	if (count == num) 
				//	{
				//		name = r.AnimalName;
				//	}						
				//}
				//int count2 = 1;
				//int animalsID = 0;
				//var query2 = db.AnimalsInfo;
				//foreach (var res in query2)
				//{
				//	count2++;
				//	if (count2 == num)
				//	{
				//		animalsID = res.AnimalId;

				//	}
				//}
				//Console.WriteLine(name);
				//Console.WriteLine(animalsID);

				//var animalquery = db.Animals.Where(a => a.AnimalName == name).FirstOrDefault();


				db.Add(new Animal { AnimalName = "Test" });

				var query = db.Animals.OrderBy(a => a.AnimalId).FirstOrDefault();

				query.AnimalInfos.Add(new AnimalInfo
				{
					//AnimalId = aID,
					Diet = "he",
					Height = 1,
					Lifespan = 2,
					Mass = 3,
					Speed = 4
				});

				db.SaveChanges();



			}
				
		}
	}
}
