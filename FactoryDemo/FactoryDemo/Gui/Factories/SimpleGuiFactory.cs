using System;
using System.Windows.Forms;
using FactoryDemo.Gui.Components.Buttons;
using FactoryDemo.Gui.Components.ListBoxes;
using FactoryDemo.Gui.Components.RadioButtons;
using FactoryDemo.Gui.Components.TextBoxes;
using FactoryDemo.Gui.Components;

namespace FactoryDemo.Gui.Factories
{
	public class SimpleGuiFactory : IGuiFactory
	{
		public Control CreateComponent(string name)
		{
			switch (name)
			{
				case ComponentNames.Button: return new SimpleGuiButton();
				case ComponentNames.TextBox: return new SimpleGuiTextBox();
				case ComponentNames.ListBox: return new SimpleGuiListBox();
				case ComponentNames.RadioButton: return new SimpleGuiRadioButton();
				default: return null;
			}
		}

		public Form CreateForm()
		{
			return new Form();
		}
	}
}