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

namespace ESL.App
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			using (var s = new System.Speech.Synthesis.SpeechSynthesizer())
			{
				s.SetOutputToDefaultAudioDevice();
				s.Speak("Welcome to E S L universe.");
				s.Speak("all english learning tools for anyone who speaks english as a second language in a single package.");
			}
		}
	}
}
