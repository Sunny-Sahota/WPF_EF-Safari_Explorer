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

namespace SafariExplorerWPF
{
	/// <summary>
	/// Interaction logic for MenuPage.xaml
	/// </summary>
	public partial class MenuPage : Page
	{
		public MenuPage()
		{
			InitializeComponent();
		}
		private void BtnStartSafari_Click(object sender, RoutedEventArgs e)
		{
			_menuFrame.Navigate(new HomePage());
		}

		private void BtnStartQuiz_Click(object sender, RoutedEventArgs e)
		{
			_menuFrame.Navigate(new SafariQuiz());
		}

		private void BtnClickOpenJournal(object sender, RoutedEventArgs e)
		{
			_menuFrame.Navigate(new JournalPage());
		}
	}
}
