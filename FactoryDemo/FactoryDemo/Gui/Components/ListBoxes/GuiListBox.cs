using System.Collections.Generic;
using System.Windows.Forms;

namespace FactoryDemo.Gui.Components.ListBoxes
{
	public abstract class GuiListBox : ListBox
	{
		private List<string> _listItems;

		protected GuiListBox()
		{
			_listItems = new List<string>();
			DataSource = _listItems;
		}

		public void AddToList(string value)
		{
			_listItems.Add(value);

			DataSource = null;
			DataSource = _listItems;
		}

		public void RemoveSelectedFromList()
		{
			_listItems.RemoveAt(SelectedIndex);
		}
	}
}