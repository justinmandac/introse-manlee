using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace introseHHC.RegForms
{
    public partial class CGAForm : Form
    {
        public CGAForm()
        {
            InitializeComponent();
            this.tabPage1.Text = "Patient Information";
            this.tabPage2.Text = "Geriatric Depression Scale";
     
            this.tabPage3.Text = "Mini-Mental Status Examination";
            this.tabPage4.Text = "Mini-Nutritional Assessment";
            this.tabPage5.Text = "Caregiver Assessment";
        }

        private void CGAForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
