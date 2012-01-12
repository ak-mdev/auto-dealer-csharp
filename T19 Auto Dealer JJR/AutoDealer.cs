/* PROGRAMMER NAME: JULIO REYES
 * PROGRAM NAME: T19 Auto Dealer JJR
 * PROGRAM PURPOSE: Create and Display an Auto Dealer program 
 * that lets buy cars and parts by using multiple classes and objects */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace T19_Auto_Dealer_JJR
{
    public partial class AutoDealer : Form
    {

        // create string array for model and color
        private string [ ] m_strModel
            = { "Scion TC", "Lotus Elise", "Nissan Skyline Type - R",
            "Cadillac Escalade EXT", "Acura Integra Type-R", "Subaru Impreza" };
        private string [ ] m_strColor
            = { "Sterling Silver", "Bright Crimson", "Cobalt Blue",
            "Nocturne Black", "Saffron Sun", "Dark Sage" };
        
        // create objects
        private Cars[] m_objCars = new Cars[5];  // Cars
        private Parts[] m_objParts = new Parts [8]; // Parts

        // initialize total variables
        decimal m_decCarPrice = 0;
        decimal m_decPartsPrice = 0;

                
        public AutoDealer()
        {
            InitializeComponent();
        }
        private void AutoDealer_Load ( object sender, EventArgs e )
        {
            // Display string arrays in ComboBox
            cboModel.DataSource = m_strModel;
            cboColor.DataSource = m_strColor;

        }


        private void btnBuy_Click ( object sender, EventArgs e )
        {
            
            // Display subtotals for each section \
            if ( txtQuantity.Text == "" || txtPartName.Text == "" )
            {
                ShowPartsTotals();
            }
            if ( txtPartsQuantity.Text == "" )
            {
                ShowCarTotals ( );
            }
            else
            {
                ShowCarTotals ( );
                ShowPartsTotals ( );
            }

            // Declare Grand Total variable
            decimal decGrandTotal = 0;

            // Calculate Grand Total
            decGrandTotal = m_decCarPrice + m_decPartsPrice;

            // Display Grand Total
            lblTotal.Text = String.Format ( "{0:C}", decGrandTotal );
                              

        }// end btnBuy_Click

        private void ShowCarTotals()
        {            
            string strModel;
            string strColor;
            bool blnTransmission;
            bool blnSeats;
            bool blnAC;
            bool blnCruise;
            bool blnGPS;
            bool blnStereo;
            int intQuant;

            // get user input
            strModel = Convert.ToString(cboModel.SelectedItem);
            strColor = Convert.ToString(cboColor.SelectedItem);
            blnTransmission = radAuto.Checked;
            blnSeats = radLeather.Checked;
            blnAC = chkAC.Checked;
            blnCruise = chkCruise.Checked;
            blnGPS = chkGPS.Checked;
            blnStereo = chkStereo.Checked;
            intQuant = Convert.ToInt32(txtQuantity.Text);

            if (intQuant > 10) //limited to 10 cars
            {
                intQuant = 10;
                txtQuantity.Text = "10";
            } // end if

            //create cars objects and get price of cars
            for (int intCount = 0; intCount < intQuant; intCount++)
            {
                m_objCars[intCount] = new Cars(strModel, strColor, blnTransmission, blnSeats,
                    blnAC, blnCruise, blnGPS, blnStereo, intQuant);
                m_decCarPrice += m_objCars[intCount].CarSubtotal;
            }//end for loop

            // Display Result
            lblSubtotal.Text = String.Format("{0:C}", m_decCarPrice);

        } //end method ShowCarTotal

        private void ShowPartsTotals()
        {
            // Declare variables
            bool blnDelivery;
            int intPartsQuantity;

            // get user input
            blnDelivery = radDelivery.Checked;
            intPartsQuantity = Convert.ToInt32(txtPartsQuantity.Text);

            

            //create cake objects and get price of parts
            for (int intCount = 0; intCount < intPartsQuantity; intCount++)
            {
                m_objParts[intCount] = new Parts(blnDelivery, intPartsQuantity);
                m_decPartsPrice += m_objParts[intCount].PartsPrice;
            }//end for loop

            if (intPartsQuantity > 10) //limited to 10 parts
            {
                intPartsQuantity = 10;
                txtPartsQuantity.Text = "10";
            } // end if

            // Display Result
            lblPartsSubtotal.Text = String.Format("{0:C}", m_decPartsPrice);

        } // end method PartsPrice

        
        
    }
}