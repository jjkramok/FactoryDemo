using System;

namespace FactoryDemo.Gui.Factories
{
	public class GuiFactoryFactory
	{
		public static IGuiFactory CreateGuiFactory(string style)
		{
			switch (style)
			{
				case Styles.Simple:
					return new SimpleGuiFactory();
				case Styles.Dark:
					return new DarkGuiFactory();
				default: throw new ArgumentException("Unkown style");
			}
		}

		public static class Styles
		{
			public const string Simple = "SIMPLE";
			public const string Dark = "DARK";
		}
	}
}