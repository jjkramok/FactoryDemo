using System.Collections.Generic;
using System.Windows.Forms;
using FactoryDemo.Animals;
using FactoryDemo.Gui;

namespace FactoryDemo
{
    public class Client
    {
        private StylePicker _stylePicker;
        
        public Client()
        {   
            _stylePicker = new StylePicker();
            
            Application.Run(_stylePicker);
        }
    }
}