using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextZuBinärConverter.Tests
{
	[TestClass]
	public class MainWindowTests
	{
		[TestMethod]
		public void Konvertiere_MitEinemIAlsText_Liefert01001001()
		{
			// Arrange
			string erwarteterText = "01001001";
			string inputText = "I";

			var sut = new MainWindow();
			sut.ObereTextbox.Text = inputText;

			// Act
			sut.Konvertiere();

			// Assert
			Assert.AreEqual(erwarteterText, sut.UntereTextbox.Text);
		}

		[TestMethod]
		public void Konvertiere_MitEinemWort_SollteWortInBinärLiefern()
		{
			// Arrange
			string inputText = "Hallo";
			string erwarteterText = "01001000 01100001 01101100 01101100 01101111";

			var sut = new MainWindow();
			sut.ObereTextbox.Text = inputText;

			// Act
			sut.Konvertiere();

			// Assert
			Assert.AreEqual(erwarteterText, sut.UntereTextbox.Text);
		}

	}
}
