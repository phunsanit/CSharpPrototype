
namespace PrototypesCSharp
{
    partial class FormMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFormAssemblyVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFormTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMDI = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFormAssemblyVersion,
            this.toolStripMenuItemFormTasks});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItemFormAssemblyVersion
            // 
            this.toolStripMenuItemFormAssemblyVersion.Name = "toolStripMenuItemFormAssemblyVersion";
            this.toolStripMenuItemFormAssemblyVersion.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItemFormAssemblyVersion.Text = "Assembly Version";
            // 
            // toolStripMenuItemFormTasks
            // 
            this.toolStripMenuItemFormTasks.Name = "toolStripMenuItemFormTasks";
            this.toolStripMenuItemFormTasks.Size = new System.Drawing.Size(46, 22);
            this.toolStripMenuItemFormTasks.Text = "Tasks";
            // 
            // panelMDI
            // 
            this.panelMDI.AutoSize = true;
            this.panelMDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMDI.Location = new System.Drawing.Point(0, 24);
            this.panelMDI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMDI.Name = "panelMDI";
            this.panelMDI.Size = new System.Drawing.Size(560, 246);
            this.panelMDI.TabIndex = 1;
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.panelMDI);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMDI";
            this.Text = "Multiple-Document Interface (MDI) Applications";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFormAssemblyVersion;
        private System.Windows.Forms.Panel panelMDI;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFormTasks;
    }
}