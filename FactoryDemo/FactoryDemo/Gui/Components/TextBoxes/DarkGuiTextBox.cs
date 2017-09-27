using System.Drawing;
using System.Windows.Forms;

namespace FactoryDemo.Gui.Components.TextBoxes
{
	public class DarkGuiTextBox : GuiTextBox
	{
		public DarkGuiTextBox()
		{
			BackColor = Color.Black;
			ForeColor = Color.MintCream;
			BorderStyle = BorderStyle.FixedSingle;
		}
	}
}