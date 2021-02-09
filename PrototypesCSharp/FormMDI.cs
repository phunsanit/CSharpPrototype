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
            if (panelMDI.Controls.Count > 0)
            {
                panelMDI.Controls.RemoveAt(0);
            }

            var formType = Assembly.GetExecutingAssembly().GetTypes()
                .Where(a => a.BaseType == typeof(Form) && a.Name == frmName)
                .FirstOrDefault();

            if (formType == null)
            {// If there is no form with the given frmName
                return null;
            }

            Form frm = (Form)Activator.CreateInstance(formType);

            //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.acceptbutton?view=net-5.0

            frm.AutoSize = true;
            frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frm.Height = panelMDI.Height;
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.WindowState = FormWindowState.Maximized;
            frm.Width = panelMDI.Width;

            frm.Show();

            return frm;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                String formName = e.ClickedItem.Name.Split(new[] { "toolStripMenuItem" }, StringSplitOptions.None)[1];

                Form frm = TryGetFormByName(formName);

                panelMDI.Controls.Add(frm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
