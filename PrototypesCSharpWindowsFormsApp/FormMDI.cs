using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PrototypesCSharpWindowsFormsApp
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        public Form TryGetFormByName(string frmName, bool closeAll = false)
        {
            //Close All
            if (closeAll)
            {
                if (panelMDI.Controls.Count > 0)
                {
                    panelMDI.Controls.RemoveAt(0);
                }
            }

            var formType = Assembly.GetExecutingAssembly().GetTypes()
                .Where(a => a.BaseType == typeof(Form) && a.Name == frmName)
                .FirstOrDefault();

            if (formType == null)
            {//if no form
                return null;
            }

            Form frm = (Form)Activator.CreateInstance(formType);

            //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.acceptbutton?view=net-5.0

            frm.AutoSize = true;
            frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frm.Height = panelMDI.Height;
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.Width = panelMDI.Width;

            frm.Show();

            panelMDI.Controls.Add(frm);

            frm.WindowState = FormWindowState.Maximized;

            return frm;
        }

        private void FormMDI_SizeChanged(object sender, EventArgs e)
        {
            foreach (Form frm in panelMDI.Controls)
            {
                frm.MinimumSize = panelMDI.Size;
                frm.MaximumSize = panelMDI.Size;

                frm.WindowState = this.WindowState;
            }
        }

        //on menu click
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                String formName = e.ClickedItem.Name.Split(new[] { "toolStripMenuItem" }, StringSplitOptions.None)[1];

                Form frm = TryGetFormByName(formName);
                //Form frm = TryGetFormByName(formName, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}