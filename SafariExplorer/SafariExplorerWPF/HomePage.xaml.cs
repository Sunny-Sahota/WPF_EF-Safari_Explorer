using System;
using System.Collections.Generic;
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
using SafariExplorerBuisness;

namespace SafariExplorerWPF
{
	/// <summary>
	/// Interaction logic for HomePage.xaml
	/// </summary>
	public partial class HomePage : Page
	{
		private CRUDManager _crudManager = new CRUDManager();
		public HomePage()
		{
			InitializeComponent();
			PopulateTextBoxs();
		}
		private void PopulateTextBoxs()
		{
			_crudManager.GetRandAnimal();
			if (_crudManager.RandomSelectedAnimal != null && _crudManager.RandomSelectedAnimalInfo != null)
			{
				TextBoxAName.Text = _crudManager.RandomSelectedAnimal.AnimalName;
				TextBoxADiet.Text = _crudManager.RandomSelectedAnimalInfo.Diet;
				TextBoxAHeight.Text = _crudManager.RandomSelectedAnimalInfo.Height.ToString();
				TextBoxALifespan.Text = _crudManager.RandomSelectedAnimalInfo.Lifespan.ToString();
				TextBoxAMass.Text = _crudManager.RandomSelectedAnimalInfo.Mass.ToString();
				TextBoxASpeed.Text = _crudManager.RandomSelectedAnimalInfo.Speed.ToString();
			}
		}

		private void BtnClickHomePage(object sender, RoutedEventArgs e)
		{
			//var newWin = new MainWindow();
			//newWin.Show();
			if (this.NavigationService.CanGoBack)
			{
				this.NavigationService.GoBack();
			}
		}
	}
}
