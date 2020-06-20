using System;
using System.Collections.Generic;
using System.Text;

namespace SE_CodeModel
{
	public partial class AnimalInfo
	{
		public override string ToString()
		{
			//string aName = "";
			//using (var db = new SafariExplorerContext())
			//{
			//	var animalName = db.Animals;
			//	//aName = animalName;
			//}

			return $"{AnimalId} - {Diet} - {Height} - {Lifespan} - {Mass} - {Speed}";
		}
	}
}
