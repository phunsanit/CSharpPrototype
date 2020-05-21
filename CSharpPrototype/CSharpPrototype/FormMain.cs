using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSharpPrototype
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            AssemblyName thisAssemName = this.GetType().Assembly.GetName();

            this.Text = thisAssemName.Name + " Version " + thisAssemName.Version;
        }

    }
}
