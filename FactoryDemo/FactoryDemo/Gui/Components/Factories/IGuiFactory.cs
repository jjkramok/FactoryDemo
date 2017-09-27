using System.Windows.Forms;

namespace FactoryDemo.Gui.Components.Factories
{
	public interface IGuiFactory
	{
		Control CreateComponent(string name);
		Form CreateForm();
	}
}