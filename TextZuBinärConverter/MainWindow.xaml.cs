using System;
using System.Linq;
using System.Windows;

namespace TextZuBinärConverter
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();
		}

		internal void Konvertiere()
		{
			string wort = this.ObereTextbox.Text;

			string fertigerCode = "";
			foreach (char buchstaben in wort)
			{
				int zahl = buchstaben;
				if(!string.IsNullOrWhiteSpace(fertigerCode))
				{
					fertigerCode = fertigerCode + " " + Convert.ToString(zahl, 2).PadLeft(8, '0');
				}
				else
				{
					fertigerCode = Convert.ToString(zahl, 2).PadLeft(8, '0');
				}
			}

			this.UntereTextbox.Text = fertigerCode;

		}

		private void Konvertiere(object sender, RoutedEventArgs e)
		{
			this.Konvertiere();
		}

		private void Nick_ist_toll_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (this.umwandelCheckbox.IsChecked == true)
			{
				this.Konvertiere();
			}
		}

		private void Zurückwandeln(object sender, RoutedEventArgs e)
		{
			var buchstaben = this.UntereTextbox.Text.Split(' ').ToList().Where(b => !string.IsNullOrWhiteSpace(b));

			string fertigerCode = "";
			foreach (string buchstabe in buchstaben)
			{
				int zahl = Convert.ToInt32(buchstabe, 2);
				char neuerBuchstabe = (char)zahl;
				fertigerCode = fertigerCode + neuerBuchstabe;
			}

			this.ObereTextbox.Text = fertigerCode;
		}
	}
}
