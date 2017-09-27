using System.Windows.Forms;

namespace FactoryDemo.Gui.Factories
{
	public interface IGuiFactory
	{
		Control CreateComponent(string name);
		Form CreateForm();
	}
}