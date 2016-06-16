using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// http://stackoverflow.com/questions/4362111/how-do-i-show-a-console-output-window-in-a-forms-application
using System.Runtime.InteropServices;

using SoftwareDesignPatterns.CreationalPatterns.FactoryMethod.metanit.com.Example1;

namespace SoftwareDesignPatterns.WinFormsApp
{
    public partial class Form1 : Form
    {
        // http://stackoverflow.com/questions/4362111/how-do-i-show-a-console-output-window-in-a-forms-application
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        public Form1()
        {
            InitializeComponent();
            AllocConsole(); // http://stackoverflow.com/questions/4362111/how-do-i-show-a-console-output-window-in-a-forms-application
        }

        private void TestCreationalPatternsFactoryMethod_button_Click(object sender, EventArgs e)
        {
            List<House> allHouses = new List<House>();

            HouseBuilder houseBuilder = new WoodenHouseBuilder("OOO WoodIsBest");

            House h1 = houseBuilder.Create();
            allHouses.Add(h1);

            // меняем застройщика:
            houseBuilder = new PanelHouseBuilder("Private Panels");
            allHouses.Add(houseBuilder.Create()); 

            foreach (var house in allHouses)
            {
                Console.WriteLine(house.HouseType);
            }
        }
    }
}
