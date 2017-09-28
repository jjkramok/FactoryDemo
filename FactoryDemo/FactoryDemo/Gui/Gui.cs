using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using FactoryDemo.Animals;
using FactoryDemo.Factories;
using FactoryDemo.Gui.Components.Buttons;
using FactoryDemo.Gui.Components.ListBoxes;
using FactoryDemo.Gui.Components.RadioButtons;
using FactoryDemo.Gui.Components.TextBoxes;
using FactoryDemo.Gui.Factories;

namespace FactoryDemo.Gui
{
	public class Gui
	{
		private IGuiFactory _guiFactory;

		public Form Window;
		public GuiButton ButtonAddAnimal;
		public GuiTextBox TextBoxName;
		public GroupBox GroupBoxSpecies;
		public GroupBox GroupBoxType;
		public GuiRadioButton RadioButtonTypeSciFi;
		public GuiRadioButton RadioButtonTypeEarth;
		public GuiRadioButton RadioButtonSpeciesCat;
		public GuiRadioButton RadioButtonSpeciesDog;
		public GuiRadioButton RadioButtonSpeciesSeaUrchin;
		public GuiListBox ListBoxAnimals;

		private List<Animal> _animals;

		public Gui(string style)
		{
			_animals = new List<Animal>();

			_guiFactory = GuiFactoryFactory.CreateGuiFactory(style);
			Window = _guiFactory.CreateForm();
			Window.Size = new Size(500, Window.Size.Height);

			RadioButtonTypeSciFi = (GuiRadioButton) _guiFactory.CreateComponent("RADIOBUTTON");
			RadioButtonTypeSciFi.Text = "Sci-fi";
			RadioButtonTypeSciFi.Location = new Point(10, 10);
			RadioButtonTypeSciFi.Size = new Size(80, 20);
			RadioButtonTypeSciFi.Checked = true;

			RadioButtonTypeEarth = (GuiRadioButton) _guiFactory.CreateComponent("RADIOBUTTON");
			RadioButtonTypeEarth.Text = "Earth";
			RadioButtonTypeEarth.Location = new Point(10, 30);
			RadioButtonTypeEarth.Size = new Size(80, 20);

			GroupBoxType = new GroupBox();
			GroupBoxType.Size = new Size(100, 60);
			GroupBoxType.Location = new Point(10, 10);
			GroupBoxType.Controls.Add(RadioButtonTypeSciFi);
			GroupBoxType.Controls.Add(RadioButtonTypeEarth);

			RadioButtonSpeciesCat = (GuiRadioButton) _guiFactory.CreateComponent("RADIOBUTTON");
			RadioButtonSpeciesCat.Text = "Cat";
			RadioButtonSpeciesCat.Location = new Point(10, 10);
			RadioButtonSpeciesCat.Size = new Size(80, 20);
			RadioButtonSpeciesCat.Checked = true;

			RadioButtonSpeciesDog = (GuiRadioButton) _guiFactory.CreateComponent("RADIOBUTTON");
			RadioButtonSpeciesDog.Text = "Dog";
			RadioButtonSpeciesDog.Location = new Point(10, 30);
			RadioButtonSpeciesDog.Size = new Size(80, 20);

			RadioButtonSpeciesSeaUrchin = (GuiRadioButton) _guiFactory.CreateComponent("RADIOBUTTON");
			RadioButtonSpeciesSeaUrchin.Text = "Sea urchin";
			RadioButtonSpeciesSeaUrchin.Location = new Point(10, 50);
			RadioButtonSpeciesSeaUrchin.Size = new Size(80, 20);

			GroupBoxSpecies = new GroupBox();
			GroupBoxSpecies.Size = new Size(100, 80);
			GroupBoxSpecies.Location = new Point(10, 80);
			GroupBoxSpecies.Controls.Add(RadioButtonSpeciesCat);
			GroupBoxSpecies.Controls.Add(RadioButtonSpeciesDog);
			GroupBoxSpecies.Controls.Add(RadioButtonSpeciesSeaUrchin);

			TextBoxName = (GuiTextBox) _guiFactory.CreateComponent("TEXTBOX");
			TextBoxName.Location = new Point(10, 170);

			ButtonAddAnimal = (GuiButton) _guiFactory.CreateComponent("BUTTON");
			ButtonAddAnimal.Location = new Point(10, 200);
			ButtonAddAnimal.Text = "Add animal";
			ButtonAddAnimal.Click += HandleAddAnimal;

			ListBoxAnimals = (GuiListBox) _guiFactory.CreateComponent("LISTBOX");
			ListBoxAnimals.Location = new Point(120, 10);
			ListBoxAnimals.Size = new Size(350, 200);

			Window.Controls.Add(GroupBoxType);
			Window.Controls.Add(GroupBoxSpecies);
			Window.Controls.Add(TextBoxName);
			Window.Controls.Add(ButtonAddAnimal);
			Window.Controls.Add(ListBoxAnimals);

			Window.Show();
		}

		private void HandleAddAnimal(object s, EventArgs e)
		{
			string name = TextBoxName.Text;

			IAnimalFactory animalFactory;
			if (RadioButtonTypeEarth.Checked) animalFactory = new EarthAnimalFactory();
			else if (RadioButtonTypeSciFi.Checked) animalFactory = new SciFiAnimalFactory();
			else return;

			Animal animal;
			if (RadioButtonSpeciesCat.Checked) animal = animalFactory.CreateCat(name, 0, "");
			else if (RadioButtonSpeciesDog.Checked) animal = animalFactory.CreateDog(name, 0, "");
			else if (RadioButtonSpeciesSeaUrchin.Checked) animal = animalFactory.CreateSeaUrchin(name, 0, "");
			else return;

			_animals.Add(animal);
			ListBoxAnimals.UpdateList(_animals);
		}
	}
}