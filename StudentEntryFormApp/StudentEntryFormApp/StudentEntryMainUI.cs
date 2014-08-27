using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryFormApp
{
    public partial class studentEntryMainWindow : Form
    {
        public studentEntryMainWindow()
        {
            InitializeComponent();
        }

        private void departmentEntryButton_Click(object sender, EventArgs e)
        {
            DepartmentEntryUI aDepartmentEntryUi = new DepartmentEntryUI();
            aDepartmentEntryUi.Show();
        }
    }
}
