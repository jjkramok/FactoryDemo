using System.Drawing;
using System.Windows.Forms;

namespace FactoryDemo.Gui.Components.ListBoxes
{
	public class DarkGuiListBox : GuiListBox
	{
		public DarkGuiListBox()
		{
			BackColor = Color.Black;
			ForeColor = Color.MintCream;
			BorderStyle = BorderStyle.FixedSingle;
		}
	}
}