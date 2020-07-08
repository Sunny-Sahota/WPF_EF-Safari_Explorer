using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using SafariExplorerBuisness;
using SE_CodeModel;

namespace SafariExplorerWPF
{
	/// <summary>
	/// Interaction logic for JournalPage.xaml
	/// </summary>
	public partial class JournalPage : Page
	{
		

		CRUDManager _crudManager = new CRUDManager();
		public JournalPage()
		{
			InitializeComponent();
			PopulateListBox();
			
		}

		private void BtnClick_OpenAddWindow(object sender, RoutedEventArgs e)
		{
			AddAnimalWindow win = new AddAnimalWindow();
			win.Show();
		}
		private void PopulateListBox()
		{
			ListBoxAnimals.ItemsSource = _crudManager.RetrieveAllAnimalInfo();
		}
		private void PopulateAnimalFields()
		{
			if (_crudManager.SelectedAnimal != null || _crudManager.SelectedAnimalInfo != null)
			{
				TextBoxID.Text = _crudManager.SelectedAnimalInfo.AnimalId.ToString();
				TextBoxName.Text = _crudManager.SelectedAnimal.AnimalName;
				TextBoxDiet.Text = _crudManager.SelectedAnimalInfo.Diet;
				TextBoxHeight.Text = _crudManager.SelectedAnimalInfo.Height.ToString();
				TextBoxLifespan.Text = _crudManager.SelectedAnimalInfo.Lifespan.ToString();
				TextBoxMass.Text = _crudManager.SelectedAnimalInfo.Mass.ToString();
				TextBoxSpeed.Text = _crudManager.SelectedAnimalInfo.Speed.ToString();
			}
		}

		
		private void ListBoxAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (ListBoxAnimals.SelectedItem != null)
			{
				_crudManager.SetSelectedAnimalInfo(ListBoxAnimals.SelectedItem);

				_crudManager.SetSelectedAnimal();

				PopulateAnimalFields();
			}
		}

		private void BtnUpdate_Click(object sender, RoutedEventArgs e)
		{
			int id = Int32.Parse(TextBoxID.Text);
			int h = Int32.Parse(TextBoxHeight.Text);
			int l = Int32.Parse(TextBoxLifespan.Text);
			int m = Int32.Parse(TextBoxMass.Text);
			int s = Int32.Parse(TextBoxSpeed.Text);
			_crudManager.UpdateAnimalEntry(aID:id,aNAme:TextBoxName.Text, aDiet: TextBoxDiet.Text, aHeight:h, aLifespan:l, aMass:m, aSpeed:s);
			//Populate list
			ListBoxAnimals.ItemsSource = null;
			PopulateListBox();
			//Populate text boxes
			ListBoxAnimals.SelectedItem = _crudManager.SelectedAnimalInfo;
			PopulateAnimalFields();
		}

		private void BtnClickRefresh(object sender, RoutedEventArgs e)
		{
			PopulateListBox();
		}

		private void BtnClickDelete(object sender, RoutedEventArgs e)
		{		
			_crudManager.DeleteAnimal(aId:Int32.Parse(TextBoxID.Text));

			ListBoxAnimals.ItemsSource = null; //Clears list box
			PopulateListBox(); //Updates 
		}

		private void BtnClick_Back(object sender, RoutedEventArgs e)
		{
			_journalPage.Navigate(new MenuPage());
		}
	}
}
