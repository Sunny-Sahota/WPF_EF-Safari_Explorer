using System;
using System.Collections.Generic;
using System.Text;

namespace SE_CodeModel
{
	public partial class AnimalInfo
	{
		public override string ToString()
		{
			return $"{AnimalId} - {Diet} - {Height} - {Lifespan} - {Mass} - {Speed}";
			//return $"ID: {AnimalId} , Diet: {Diet}";
		}
	}
}
