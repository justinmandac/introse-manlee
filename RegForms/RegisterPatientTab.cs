using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using introseHHC.Objects;

namespace introseHHC.RegForms
{
    public partial class RegisterPatientTab : Form
    {
        private const byte PATIENT_TAB = 0;
        private const byte CLIENT_TAB =  1;
        private const byte REQUIREMENTS_TAB = 2;
        private const byte DETAILS_TAB = 3;

        private Patient patient;
        private Client  client;
        private FaceSheet fsheet;
        private Person s;

        private string fname;
        private string sname;
        private string mname;
        private char gender;
        private string nationality;
        private char civstat;
        private string educattain;
        private string email;
        private Address address;

        public RegisterPatientTab()
        {
            InitializeComponent();

            this.tabPage1.Text = "Register Patient";
            this.tabPage2.Text = "Register Client";
            this.tabPage3.Text = "Requirements";
            this.tabPage4.Text = "Details";

            patient = new Patient();
            client  = new Client();
            fsheet  = new FaceSheet();
            address = new Address();
            

        }

        private void caseMgmtCB_CheckedChanged(object sender, EventArgs e)
        {
            if (caseMgmtCB.Checked == false)
            {
                caseMgmtBox.Enabled = false;
            }
            else
            {
                caseMgmtBox.Enabled = true;
            }
        }

        private void hvacCB_CheckedChanged(object sender, EventArgs e)
        {
            if (hvacCB.Checked == false)
            {
                hvacCoB.Enabled = false;
            }
            else
            {
                hvacCoB.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }
        
        //save inputs to respective classes
        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == PATIENT_TAB)
            {
                //Patient Tab
          
            }
            else if (tabControl1.SelectedIndex == CLIENT_TAB)
            {
                //Client Tab
            }
            else if (tabControl1.SelectedIndex == REQUIREMENTS_TAB)
            {
                //Requirements tab
            }
            else if (tabControl1.SelectedIndex == DETAILS_TAB)
            {
                //Details tab
            }
        }

        private void pcityIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterPatientTab_Load(object sender, EventArgs e)
        {

        }




    }
}
