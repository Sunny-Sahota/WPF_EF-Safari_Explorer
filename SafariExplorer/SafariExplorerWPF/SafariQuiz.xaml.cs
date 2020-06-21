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
	/// Interaction logic for SafariQuiz.xaml
	/// </summary>
	public partial class SafariQuiz : Page
	{
		//The code in this class is a placeholder, only for demonstration purposes
		//Next sprint to implement a db table and refactor this code.

		private int Counter = 0; 
		private int scoreCount = 0;

		public SafariQuiz()
		{
			InitializeComponent();
			TxtBoxQuestions.Text = "Tarantulas transform their prey into a liquid smoothie and drink it with their straw-like mouth."; ;

		}

		private void BtnAnswerClicked(object sender, RoutedEventArgs e)
		{
			Counter++;

			if (Counter == 1)
			{
				PopulateTxtBoxQuestions1("True");		
			}
			if (Counter == 2)
			{
				PopulateTxtBoxQuestions2("True");
			}
			if (Counter == 3)
			{
				PopulateTextBoxQuestions3("False");
				Counter++;
			}
			if (Counter == 4)
			{			
				TextScore.Text = $"Final Score: {scoreCount}";
			}
		}
		private void PopulateTxtBoxQuestions1(string answer)
		{
			if (answer == "True")
			{
				scoreCount++;
			}
			TxtBoxQuestions.Text = "Female praying mantis can sometimes eat their husband.";

		}

		private void PopulateTxtBoxQuestions2(string answer)
		{
			TxtBoxQuestions.Text = "Koalas are bears.";
			if (answer == "True")
			{
				scoreCount++;
			}

		}
		private void PopulateTextBoxQuestions3(string answer)
		{
			TxtBoxQuestions.Text = "End of Quiz";
			if (answer == "False")
			{
				scoreCount++;
			}
		}


		private void BtnClick_Back(object sender, RoutedEventArgs e)
		{
			_SafariQuiz.Navigate(new MainWindow());
		}
	}
	
}
