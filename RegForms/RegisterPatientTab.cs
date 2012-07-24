using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using introseHHC.Objects;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace introseHHC.RegForms
{
    public partial class RegisterPatientTab : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private string server;
        private string database;
        private string user;
        private string password;

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
        private UInt16 homeNum;
        private UInt16 workNum;
        private UInt16 mobNum;
        private UInt16 otherNum;
        
        public RegisterPatientTab()
        {
            InitializeComponent();

            this.tabPage1.Text = "Register Patient";
            this.tabPage2.Text = "Register Client";
            this.tabPage3.Text = "Requirements";
            this.tabPage4.Text = "Details";

            patient = new Patient();
            client = new Client();
            fsheet = new FaceSheet();

            server = "localhost";
            user = "root";
            database = "hhc-db";
            password = "root";

            string connString = "SERVER=" + server + ";" + "DATABASE=" +
                                database + ";" + "UID=" + user + ";" + 
                                "PASSWORD=" + password + ";";

            conn = new MySqlConnection(connString);
                     
          }


        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        private int checkName(string s, string f, string m)
        {
            

            return 0;
        }


        private void displayStuff(Patient p)
        {

            Console.WriteLine("Name: "+patient.getName().getFullName());
            Console.WriteLine("Birthdate: "+patient.getBDay().ToShortDateString());
            Console.WriteLine("Gender: "+patient.getGender());
            Console.WriteLine("Nationality: "+patient.getNationality());
            Console.WriteLine("Religion: "+patient.getReligion());
            Console.WriteLine("Civil Status: "+patient.getCivilStatus());
            Console.WriteLine("Educational Attainment: "+patient.getEducAttainment());

       

        }
        //save inputs to respective classes
        private void finishButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == PATIENT_TAB)
            {   
                
        
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
        //runs when the Add button for Contact information is clicked.

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

        private void acceptButton_Click(object sender, EventArgs e)
        {
           
        }

        private void RegisterPatientTab_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseConnection())
                Console.WriteLine("SQL Connection Closed");

        }

        private void pNextButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;

            //Patient Tab
            //get all the values in the fields & perform error checking
            //commands below execute only when the Patient Information Tab is selected.

            desig = pdesigCoB.Text;
            fname = pfnameIn.Text;
            sname = psnameIn.Text;
            mname = pmnameIn.Text;

            checkName(fname, sname, mname); //replace error checking with regular expressions.
            birthdate = pbdayPick.Value;             //Get data from DateTime Picker

            //following fields must not be blank
            gender = pgenCoB.Text;
            nationality = pnatIn.Text;
            religion = prelIn.Text;
            civstat = pcivStatCoB.Text;
            educattain = pedattCoB.Text;

            //fields for address. must not be blank!
            addline = paddlineIn.Text;
            city = pcityIn.Text;
            region = pregIn.Text;

            try
            {
                stnumber = UInt16.Parse(pstnoIn.Text);
            }
            catch (FormatException err)
            {
                Console.WriteLine("Street #: " + err.Message);
            }
            catch (OverflowException of)
            {
                Console.WriteLine("Street #: " + of.Message);
            }

            try
            {
                workNum = UInt16.Parse(pWorkIn.Text);
                homeNum = UInt16.Parse(pHomeIn.Text);
                mobNum = UInt16.Parse(pMobileIn.Text);
                otherNum = UInt16.Parse(pOtherIn.Text);
            }
            catch (Exception err)
            {
            }
               


            //get email
            //needs regex based error checking
            email = pemailIn.Text;

            //add fields to Patient Object
            patient.setName(desig, fname, mname, sname);
            patient.setBday(birthdate);
            patient.setGender(gender);
            patient.setNationality(nationality);
            patient.setReligion(religion);
            patient.setCivilStatus(civstat);
            patient.setEducAttainment(educattain);
            patient.setEmail(email);
            patient.setAddress(stnumber, addline, city, region);
            patient.setNumbers(homeNum,workNum,mobNum,otherNum);
            
            //displayStuff(patient);

            //open connection to database
            if (OpenConnection())
            {
               

                
                
            }
            else
            {

            }

            //move to next tab
            
        }
        private void cNextButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
        }
        private void rNextButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == PATIENT_TAB)
            {

            }
        }


 


    }
}
