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

namespace PrototypesCSharp
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        public Form TryGetFormByName(string frmName)
        {
            var formType = Assembly.GetExecutingAssembly().GetTypes()
                .Where(a => a.BaseType == typeof(Form) && a.Name == frmName)
                .FirstOrDefault();

            if (formType == null)
            {// If there is no form with the given frmName
                return null;
            }

            Form frm = (Form)Activator.CreateInstance(formType);

            frm.TopLevel = false;
            frm.TopMost = true;

            return frm;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                //toolStripMenuItem name like "toolStripMenuItem{form class}" -> "toolStripMenuItemAssemblyVersion"
                String formName = e.ClickedItem.Name.Split(new[] { "toolStripMenuItem" }, StringSplitOptions.None)[1];

                Form frm = TryGetFormByName(formName);

                panel1.Controls.Add(frm);

                frm.Height = panel1.Height;
                frm.Width = panel1.Width;

                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
