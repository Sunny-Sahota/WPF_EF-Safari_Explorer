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
using System.Windows.Shapes;
using SafariExplorerBuisness;

namespace SafariExplorerWPF
{
	/// <summary>
	/// Interaction logic for AddAnimalWindow.xaml
	/// </summary>
	public partial class AddAnimalWindow : Window
	{
		CRUDManager _crudManager = new CRUDManager();
		public AddAnimalWindow()
		{
			InitializeComponent();
		}

		private void BtnAddNew_Click(object sender, RoutedEventArgs e)
		{
			_crudManager.AddAnimal(
				aName: TxtName.Text,
				aDiet: TxtDiet.Text,
				aHeight: Int32.Parse(TxtHeight.Text),
				aLifespan: Int32.Parse(TxtLifespan.Text),
				aMass: Int32.Parse(TxtMass.Text),
				aSpeed: Int32.Parse(TxtSpeed.Text)
				);
		}
	}
}
