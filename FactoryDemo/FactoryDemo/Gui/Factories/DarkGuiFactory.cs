using System.Drawing;
using System.Windows.Forms;
using FactoryDemo.Gui.Components.Buttons;
using FactoryDemo.Gui.Components.ListBoxes;
using FactoryDemo.Gui.Components.TextBoxes;

namespace FactoryDemo.Gui.Factories
{
	public class DarkGuiFactory : IGuiFactory
	{
		public Control CreateComponent(string name)
		{
			switch (name)
			{
				case "BUTTON": return new DarkGuiButton();
				case "TEXTBOX": return new DarkGuiTextBox();
				case "LISTBOX": return new DarkGuiListBox();
				default: return null;
			}
		}

		public Form CreateForm()
		{
			return new Form() {BackColor = Color.FromArgb(255, 100, 100, 100)};
		}
	}
}