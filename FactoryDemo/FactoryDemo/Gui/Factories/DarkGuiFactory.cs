using System.Drawing;
using System.Windows.Forms;
using FactoryDemo.Gui.Components.Buttons;
using FactoryDemo.Gui.Components.ListBoxes;
using FactoryDemo.Gui.Components.RadioButtons;
using FactoryDemo.Gui.Components.TextBoxes;
using FactoryDemo.Gui.Components;

namespace FactoryDemo.Gui.Factories
{
	public class DarkGuiFactory : IGuiFactory
	{
		public Control CreateComponent(string name)
		{
			switch (name)
			{
				case ComponentNames.Button: return new DarkGuiButton();
				case ComponentNames.TextBox: return new DarkGuiTextBox();
				case ComponentNames.ListBox: return new DarkGuiListBox();
				case ComponentNames.RadioButton: return new DarkGuiRadioButton();
				default: return null;
			}
		}

		public Form CreateForm()
		{
			return new Form() {BackColor = Color.FromArgb(255, 100, 100, 100)};
		}
	}
}