using System.Windows.Forms;
using FactoryDemo.Gui.Components.Buttons;
using FactoryDemo.Gui.Components.ListBoxes;
using FactoryDemo.Gui.Components.RadioButtons;
using FactoryDemo.Gui.Components.TextBoxes;

namespace FactoryDemo.Gui.Factories
{
	public class SimpleGuiFactory : IGuiFactory
	{
		public Control CreateComponent(string name)
		{
			switch (name)
			{
				case "BUTTON": return new SimpleGuiButton();
				case "TEXTBOX": return new SimpleGuiTextBox();
				case "LISTBOX": return new SimpleGuiListBox();
				case "RADIOBUTTON": return new SimpleGuiRadioButton();
				default: return null;
			}
		}

		public Form CreateForm()
		{
			return new Form();
		}
	}
}