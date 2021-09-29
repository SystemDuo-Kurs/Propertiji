using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Propertiji
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ObservableCollection<Kurs> Kursevi { get; set; } = new();
		public MainWindow()
		{
			InitializeComponent();
			dg.ItemsSource = Kursevi;
		}

		private void Klik(object sender, RoutedEventArgs e)
		{
			Kursevi kurs = new(Kursevi);
			kurs.Owner = this;
			kurs.ShowDialog();
			
		}
	}

	public class Polaznik
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string PrezimeIIme { get => $"{Prezime} {Ime}"; }
	}

	public class Kurs
	{
		public string Naziv { get; set; }
	}
}
