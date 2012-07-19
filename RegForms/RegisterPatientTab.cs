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
        //holders for birthdate fields
        private DateTime birthdate;
        //holders for address fields
        private string addline;
        private UInt16 stnumber;
        private string region;
        private string city;
        //holders for contact number fields
        private string contactlabel;
        private UInt16 contactnumber;
        
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

        }

        //save inputs to respective classes
        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write("Finish Button Clicked\n");
            if (tabControl1.SelectedIndex == PATIENT_TAB)
            {
                //Patient Tab
                //get all the values in the fields & perform error checking

                    desig = pdesigCoB.SelectedText;
                    fname = pfnameIn.Text;
                    sname = psnameIn.Text;
                    mname = pmnameIn.Text;
                //replace error checking with regular expressions.
                    if (fname.Equals("First Name"))
                    {
                        Console.WriteLine("Enter Valid First Name");
                    }
                    else if (fname.Length == 0)
                    {
                        Console.Out.WriteLine("First Name Field is Empty");
                    }
  
                    if (mname.Equals("Middle Name"))
                    {
                        Console.WriteLine("Enter Valid Middle Name");
                    }
                    else if (mname.Length == 0)
                    {
                        Console.Out.WriteLine("Middle Name Field is Empty");
                    }
                    
                    if (sname.Equals("Surname"))
                    {
                        Console.WriteLine("Enter Valid Surname");
                    }
                    else if (fname.Length == 0)
                    {
                        Console.Out.WriteLine("Surname Field is Empty");
                    }

                //Get data from DateTime Picker
                    birthdate = pbdayPick.Value;
                               
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
                    Console.WriteLine("Street #: "+err.Message);
                }

                //get contact number details
                contactlabel = pcontypeCoB.SelectedText;
                try
                {
                    contactnumber = UInt16.Parse(pconNumIn.Text);
                }
                catch(Exception err)
                {
                    Console.WriteLine("Contact Number: "+err.Message);
                   
                }
                //get email
                email = pemailIn.Text;

                //add fields to Patient Object
                patient.setName(desig,fname,mname,sname);
                patient.setBday(birthdate);
                patient.setGender(gender);
                patient.setNationality(nationality);
                patient.setReligion(religion);
                patient.setCivilStatus(civstat);
                patient.setEducAttainment(educattain);
                patient.setEmail(email);
        
            }
            else if (tabControl1.SelectedIndex == CLIENT_TAB)
            {

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

        private void pconAddButton_Click(object sender, EventArgs e)
        {

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
            if (primaryCB.Checked == true)
            {
                primaryIn.Enabled = false;
            }
            else
            {
                primaryIn.Enabled = true;
            }
        }




    }
}
