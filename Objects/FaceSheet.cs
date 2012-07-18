﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class FaceSheet
    {
        private Physician physician;
        private Client client;
        private Patient patient;
        private bool[] casMan, homVac;
        private bool carTra, ambWel, senRes;

        public FaceSheet()
        {
            physician = new Physician();
            client = new Client();
            patient = new Patient();
            casMan = new bool[4];
            homVac = new bool[4];
            carTra = new bool();
            ambWel = new bool();
            senRes = new bool();
        }

        public void setFS(Physician phy, Client cli, Patient pat, bool[] cm, bool[] hv, bool ct, bool aw, bool sr)
        {
            physician = phy;
            client = cli;
            patient = pat;
            casMan = cm;
            homVac = hv;
            carTra = ct;
            ambWel = aw;
            senRes = sr;

        }

    }
}