using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FactoryDemo.Animals;

namespace FactoryDemo.Gui.Components.ListBoxes
{
	public abstract class GuiListBox : ListBox
	{
		public void UpdateList(List<Animal> list)
		{
			DataSource = null;
			DataSource = list;
		}
	}
}