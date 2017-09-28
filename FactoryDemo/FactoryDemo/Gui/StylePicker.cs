using System;
using System.Drawing;
using System.Windows.Forms;
using FactoryDemo.Gui.Factories;

namespace FactoryDemo.Gui
{
	public class StylePicker : Form
	{
		private Button _buttonStyleSimple;
		private Button _buttonStyleDark;

		public StylePicker()
		{
			_buttonStyleSimple = new Button();
			_buttonStyleDark = new Button();

			_buttonStyleSimple.Click += (x, y) => { new Gui(GuiFactoryFactory.Styles.Simple); };
			_buttonStyleDark.Click += (x, y) => { new Gui(GuiFactoryFactory.Styles.Dark); };

			_buttonStyleSimple.Location = new Point(50, 100);
			_buttonStyleDark.Location = new Point(150, 100);

			_buttonStyleSimple.Size = new Size(100, 50);
			_buttonStyleDark.Size = new Size(100, 50);

			_buttonStyleSimple.Text = "Simple";
			_buttonStyleDark.Text = "Dark";

			Controls.Add(_buttonStyleSimple);
			Controls.Add(_buttonStyleDark);
		}
	}
}