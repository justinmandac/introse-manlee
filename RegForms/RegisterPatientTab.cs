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

        private string desig;
        private string fname;
        private string sname;
        private string mname;
        private string gender;
        private string nationality;
        private string religion;
        private string civstat;
        private string educattain;
        private string email;
        private Address address;
        private Contact contact;
        //holders for birthdate fields
        private UInt16 mm;
        private UInt16 dd; //lol P. Diddy
        private UInt16 yy;
        //holders for address fields
        private string addline;
        private UInt16 stnumber;
        private string region;
        private string city;
        
        
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
            contact = new Contact();
            

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
            {                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }
        
        //save inputs to respective classes
        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == PATIENT_TAB || tabControl1.SelectedIndex == CLIENT_TAB)
            {
                //Patient Tab
                //get all the values in the fields & perform error checking
                desig = pdesigCoB.SelectedText;
                fname = pfnameIn.Text;
                mname = pmnameIn.Text;
                sname = psnameIn.Text;

                //Get data from birthdate fields & check for errors
                try
                {
                    mm = UInt16.Parse(pmonthIn.Text);
                    
                }
                catch (Exception err)
                {

                }
                try
                {
                    dd = UInt16.Parse(pdayIn.Text);
                }
                catch (Exception err)
                {

                }
                try
                {
                    yy = UInt16.Parse(pyearIn.Text);
                }
                catch (Exception err)
                {

                }
                               
                //following fields must not be blank
                gender = pgenCoB.SelectedText;
                nationality = pnatIn.Text;
                religion = prelIn.Text;
                civstat = pcivStatCoB.SelectedText;
                educattain = pedattCoB.SelectedText;
                //fields for address. must not be blank!
                addline = paddlineIn.Text;
                city = pcityIn.Text;
                region = pregIn.Text;

                try
                {
                    stnumber = UInt16.Parse(pstnoIn.Text);
                }
                catch (Exception err)
                {

                }

                if (tabControl1.SelectedIndex == CLIENT_TAB)
                {


                }


                                
                
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
