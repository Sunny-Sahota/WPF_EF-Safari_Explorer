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
		
		public MainWindow()
		{
			InitializeComponent();
			Application.Current.MainWindow = this;
			
		}

		private void BtnStartSafari_Click(object sender, RoutedEventArgs e)
		{
			_mainFrame.Navigate(new HomePage());
		}

		private void BtnStartQuiz_Click(object sender, RoutedEventArgs e)
		{
			_mainFrame.Navigate(new SafariQuiz());
		}

		private void BtnClickOpenJournal(object sender, RoutedEventArgs e)
		{
			_mainFrame.Navigate(new JournalPage());
		}
	}
}
