using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Classes
{
    class FaceSheet
    {

        private uint pID; //patient ID
        private uint cID; // client ID
        private uint phyID; //physician ID for Attending Physician;

        //fields for requirements
        private uint caseMgmt;
        private bool trainMod; //care training module
        private bool ambClin; //ambulatory wellness clinic
        private bool senRes; //senior residential facility
        private uint vaccProg; //home vaccination program
        private string details; //details of requirements
        private string acts; //actions taken
        private FaceSheetTable reqTable; //requirements table
        private DateTime gatherTime;
        private DateTime endorseTime;
        private DateTime effTime;
        private uint surveyVal;




    }
}
