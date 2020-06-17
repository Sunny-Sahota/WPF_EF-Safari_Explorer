using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

	public partial class MainWindow : Window
	{
		private CRUDManager _crudManager = new CRUDManager();
		public MainWindow()
		{
			InitializeComponent();
			PopulateTextBoxs();
		}

		private void PopulateTextBoxs()
		{
			_crudManager.UpdateAnimal();
			if (_crudManager.SelectedAnimal != null && _crudManager.SelectedAnimalInfo != null)
			{
				TextBoxAName.Text = _crudManager.SelectedAnimal.AnimalName;
				TextBoxADiet.Text = _crudManager.SelectedAnimalInfo.Diet;
				TextBoxAHeight.Text = _crudManager.SelectedAnimalInfo.Height.ToString();
				TextBoxALifespan.Text = _crudManager.SelectedAnimalInfo.Lifespan.ToString();
				TextBoxAMass.Text = _crudManager.SelectedAnimalInfo.Mass.ToString();
				TextBoxASpeed.Text = _crudManager.SelectedAnimalInfo.Speed.ToString();
			}
		}
	}
}
