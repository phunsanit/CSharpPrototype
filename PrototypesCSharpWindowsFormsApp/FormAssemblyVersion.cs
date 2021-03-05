using System.Reflection;
using System.Windows.Forms;

namespace PrototypesCSharpWindowsFormsApp
{
    public partial class FormAssemblyVersion : Form
    {
        public FormAssemblyVersion()
        {
            InitializeComponent();

            AssemblyName thisAssemName = this.GetType().Assembly.GetName();

            if (Configurations.environment == "PRODUCTION")
            {
                this.Text = thisAssemName.Name + " Version " + thisAssemName.Version;
            }
            else
            {
                this.Text = thisAssemName.Name + " Version " + thisAssemName.Version + " " + Configurations.environment;
            }
        }

    }
}