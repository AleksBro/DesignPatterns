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

using SoftwareDesignPatterns.CreationalPatterns.FactoryMethod.MetanitCom.Example;
using SoftwareDesignPatterns.CreationalPatterns.Builder;
using SoftwareDesignPatterns.CreationalPatterns.Builder.WikipediaOrg;

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

            // http://stackoverflow.com/questions/4362111/how-do-i-show-a-console-output-window-in-a-forms-application
            AllocConsole();
        }

        private void TestCreationalPatternsFactoryMethod_button_Click(object sender, EventArgs e)
        {
            CreationalPatterns.FactoryMethod.MetanitCom.Example.UsingExample example = new CreationalPatterns.FactoryMethod.MetanitCom.Example.UsingExample();
        }

        private void TestCreationalPatternsBuilderWikipediaExample_button_Click(object sender, EventArgs e)
        {
            CreationalPatterns.Builder.WikipediaOrg.UsingExample example = new CreationalPatterns.Builder.WikipediaOrg.UsingExample();
        }

        private void TestBehavioralPatternsChainOfResponsibility_button_Click(object sender, EventArgs e)
        {
            BehavioralPatterns.ChainOfResponsibility.WikipediaOrg.UsingExample example = new BehavioralPatterns.ChainOfResponsibility.WikipediaOrg.UsingExample();
        }

        private void TestCreationalPatternsBuilderMetanitExample_button_Click(object sender, EventArgs e)
        {
            CreationalPatterns.Builder.MetanitCom.Example.UsingExample example = new CreationalPatterns.Builder.MetanitCom.Example.UsingExample();
        }
    }
}
