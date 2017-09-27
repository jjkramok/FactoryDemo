using System;
using System.Drawing;
using System.Windows.Forms;

namespace FactoryDemo.Gui
{
	public class StylePicker
	{
		private Form _form;
		private Button _buttonStyleSimple;
		private Button _buttonStyleDark;

		public StylePicker()
		{
			_form = new Form();
			_buttonStyleSimple = new Button();
			_buttonStyleDark = new Button();

			_buttonStyleSimple.Click += (x, y) => { new Gui("SIMPLE"); };
			_buttonStyleDark.Click += (x, y) => { new Gui("DARK"); };
			
			_buttonStyleSimple.Location=new Point(50,100);
			_buttonStyleDark.Location=new Point(150,100);
			
			_buttonStyleSimple.Size = new Size(100,50);
			_buttonStyleDark.Size = new Size(100,50);

			_buttonStyleSimple.Text = "Simple";
			_buttonStyleDark.Text = "Dark";
			
			_form.Controls.Add(_buttonStyleSimple);
			_form.Controls.Add(_buttonStyleDark);

			Application.Run(_form);
		}
	}
}