﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace SE_CodeModel
{
	public class SafariExplorerContext : DbContext
	{
		public DbSet<Animal> Animals { get; set; }
		public DbSet<AnimalInfo> AnimalsInfo { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=SafariExplorer;");
	}

	public class Animal 
	{
		public int AnimalId { get; set; }

		public string AnimalName { get; set; }

		public List<AnimalInfo> AnimalInfos { get; } = new List<AnimalInfo>();
	}

	public class AnimalInfo
	{
		public int AnimalInfoId { get; set; }
	
		public int Size { get; set; }

		public int Weight { get; set; }

		public int AnimalId { get; set; }

		public Animal Animal { get; set; }
	}
}