using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Classes
{
    class FaceSheetTable
    {
        private float mdBP;
        private float mdMeals;
        private float mdOver;
        private float mdNDiff;
        private float mdHolPay;
        private float mdTrans;
        private float mdSomething;
        private float mdLessWT;
        private float mdSubtotal;
        private float mdNoPax;
        private float mdTotal;

        private float hcBP;
        private float hcMeals;
        private float hcOver;
        private float hcNDiff;
        private float hcHolPay;
        private float hcTrans;
        private float hcSomething;
        private float hcLessWT;
        private float hcSubtotal;
        private float hcNoPax;
        private float hcTotal;

        public FaceSheetTable()
        {


        }

        public void setMDFields(float bp, float meals, float over, float nd, float hp, float trans, float smthing,
            float lwt, float sbtotal, float npax, float total)
        {
            //lagay pa ng error checking or baka sa gui na rin yun.
            mdBP = bp;
            mdHolPay = hp;
            mdMeals = meals;
            mdOver = over;
            mdNDiff = nd;
            mdTrans = trans;
            mdSomething = smthing;
            mdLessWT = lwt;
            mdSubtotal = sbtotal;
            mdNoPax = npax;
            mdTotal = total;
        }
        public void setHCFields(float bp, float meals, float over, float nd, float hp, float trans, float smthing,
            float lwt, float sbtotal, float npax, float total)
        {
            hcBP = bp;
            hcHolPay = hp;
            hcMeals = meals;
            hcOver = over;
            hcNDiff = nd;
            hcTrans = trans;
            hcSomething = smthing;
            hcLessWT = lwt;
            hcSubtotal = sbtotal;
            hcNoPax = npax;
            hcTotal = total;
        }
    }
}
