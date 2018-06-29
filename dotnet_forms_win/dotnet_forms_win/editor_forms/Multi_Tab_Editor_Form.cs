using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_forms
{ 
    public partial class Multi_Tab_Editor_Form : Base_Form
    {
        protected int current_panel { get; set; }
        protected int number_panels { get; set; }

        // protected Dictionary<int,> // I don't want to set up a complicated data structure to handle multiple tabs.

        public Multi_Tab_Editor_Form()
        {
            InitializeComponent();

            this.tabControl1.Width = this.panel1.Width;
            this.tabControl1.Height = this.panel1.Height;
            this.Resize += multi_tab_resize_handle;
            this.editToolStripMenuItem.DropDownItems.Add("New Tab");
            this.editToolStripMenuItem.DropDownItems.Add("Remove Tab");
        }

        protected void multi_tab_click_handle(object Sender, EventArgs e)
        {

        }

        protected void multi_tab_double_click_handle(object Sender, EventArgs e)
        {

        }

        protected void multi_tab_add_handle(object Sender,EventArgs e)
        {
            this.tabControl1.TabPages.Add("New Tab");// add a new tab page.
        }

        protected void multi_tab_remove_handle(object Sender, EventArgs e)
        {
            /*foreach( var a in new ArgIterator(e))
            {

            }*/
        }

        protected void multi_tab_resize_handle(object Sender, EventArgs e)
        {
            this.tabControl1.Height = this.panel1.Height;
            this.tabControl1.Width = this.panel1.Width;
        }

    }

}
