using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using FactoryDemo.Gui.Components.Buttons;
using FactoryDemo.Gui.Components.ListBoxes;
using FactoryDemo.Gui.Components.TextBoxes;
using FactoryDemo.Gui.Factories;

namespace FactoryDemo.Gui
{
	public class Gui
	{
		private IGuiFactory _guiFactory;

		private Form _form;
		private GuiButton _button;
		private GuiTextBox _textBox;
		private GuiListBox _listBox;

		public Gui(string style)
		{
			switch (style)
			{
				case "SIMPLE":
					_guiFactory = new SimpleGuiFactory();
					break;
				case "DARK":
					_guiFactory = new DarkGuiFactory();
					break;
				default: throw new ArgumentException("Unkown style");
			}

			_form = _guiFactory.CreateForm();
			_button = (GuiButton) _guiFactory.CreateComponent("BUTTON");
			_textBox = (GuiTextBox) _guiFactory.CreateComponent("TEXTBOX");
			_listBox = (GuiListBox) _guiFactory.CreateComponent("LISTBOX");

			_button.Text = "Placeholder";
			_button.Location = new Point(50, 50);
			_button.Click += (sender, args) =>
			{
				if (_textBox.Text.Length > 0)
				{
					_listBox.AddToList(_textBox.Text);
					_textBox.Text = "";
				}
			};

			_textBox.Location = new Point(50, 100);

			_listBox.Location = new Point(50, 150);

			_form.Controls.Add(_button);
			_form.Controls.Add(_textBox);
			_form.Controls.Add(_listBox);

			_form.Show();
		}
	}
}