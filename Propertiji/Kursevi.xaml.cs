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
using System.Windows.Shapes;

namespace Propertiji
{
	/// <summary>
	/// Interaction logic for Kursevi.xaml
	/// </summary>
	public partial class Kursevi : Window
	{
		private Kurs Kurs { get; set; } = new();
		private ObservableCollection<Kurs> ListaKursevi;


		public Kursevi(ObservableCollection<Kurs> kursevi)
		{
			InitializeComponent();
			DataContext = Kurs;
			ListaKursevi = kursevi;
		}

		private void Otkazi(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void Unos(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(Kurs.Naziv) ||
				string.IsNullOrWhiteSpace(Kurs.Naziv))
				MessageBox.Show("Unesi bre nesto");
			else
			{
				/*for (int indeks = 0; indeks < ListaKursevi.Count; indeks++)
				{
					if (ListaKursevi[indeks].Naziv == Kurs.Naziv)
					{
						MessageBox.Show("Duplikat!");
						return;
					}
				}

				foreach(Kurs k in ListaKursevi)
				{
					if (k.Naziv == Kurs.Naziv)
					{
						MessageBox.Show("Duplikat!");
						return;
					}
				}*/

				if (ListaKursevi.Where(k => k.Naziv.ToLower() == Kurs.Naziv.ToLower()).Any())
				{
					MessageBox.Show("Duplikat!");
					return;
				}
				ListaKursevi.Add(Kurs);

				Close();
			}
		}
	}
}
