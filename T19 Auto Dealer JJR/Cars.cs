using System;
using System.Collections.Generic;
using System.Text;

namespace T19_Auto_Dealer_JJR
{
    class Cars
    {
        // Declare and initialize variables
        private string m_strModel;
        private string m_strColor;
        private bool m_blnAutomatic;    // TRANSMISSION
        private bool m_blnLeather;      // SEATS
        private bool m_blnAC;           // ADDITIONAL SPECS
        private bool m_blnCruise;
        private bool m_blnGPS;
        private bool m_blnStereo;
        private int m_intQuantity;      // QUANTITY

        public Cars ( string ModelValue, string ColorValue,
            bool AutomaticValue, bool LeatherValue,
            bool ACValue, bool CruiseValue, bool GPSValue,
            bool StereoValue, int QuantityValue )
        {
            Model = ModelValue;             // invoke Property
            Color = ColorValue;
            Automatic = AutomaticValue;
            Leather = LeatherValue;
            GPS = GPSValue;
            AC = ACValue;
            Cruise = CruiseValue;
            Stereo = StereoValue;
            Quantity = QuantityValue;
        } // end constructor

        // property Model
        public string Model
        {
            get
            {
                return m_strModel;
            }
            set
            {
                m_strModel = value;
            }
        }// end property Color

        // property Color
        public string Color
        {
            get
            {
                return m_strColor;
            }
            set
            {
                m_strColor = value;
            }
        }// end property Color

        // property Automatic
        public bool Automatic
        {
            get
            {
                return m_blnAutomatic;
            }
            set
            {
                m_blnAutomatic = value;
            }
        }// end property Automatic

        // property Leather
        public bool Leather
        {
            get
            {
                return m_blnLeather;
            }
            set
            {
                m_blnLeather = value;
            }
        }// end property Leather

        // property AC
        public bool AC
        {
            get
            {
                return m_blnAC;
            }
            set
            {
                m_blnAC = value;
            }
        }// end property Automatic

        // property Cruise
        public bool Cruise
        {
            get
            {
                return m_blnCruise;
            }
            set
            {
                m_blnCruise = value;
            }
        }// end property Automatic

        // property GPS
        public bool GPS
        {
            get
            {
                return m_blnGPS;
            }
            set
            {
                m_blnGPS = value;
            }
        }// end property GPS

        // property Stereo
        public bool Stereo
        {
            get
            {
                return m_blnStereo;
            }
            set
            {
                m_blnStereo = value;
            }
        }// end property Stereo

        // property Quantity
        public int Quantity
        {
            get
            {
                return m_intQuantity;
            }
            set
            {
                if ( value > 0 )
                    m_intQuantity = value;
                else
                    m_intQuantity = 1; // set invalid input to 1
            }
        }// end property Quantity

        public decimal CarSubtotal
        {
            get
            {
                // Declare Total variable
                decimal decCarSubtotal = 0;
                // Multiply quantity to base total to obtain Subtotal
                decCarSubtotal = 20000M * m_intQuantity;

                // Add Checked components to Subtotal using if structure
                if ( m_blnAutomatic == true )              // Auto Trans cost $800.00
                    decCarSubtotal += 800M;
                if ( m_blnLeather == true )
                    decCarSubtotal += 750M;
                if ( m_blnAC == true )
                    decCarSubtotal += 500M;
                if ( m_blnCruise == true )
                    decCarSubtotal += 375.47M;
                if ( m_blnGPS == true )
                    decCarSubtotal += 1500M;
                if ( m_blnStereo == true )
                    decCarSubtotal += 800.67M;

                return decCarSubtotal;

            }

        }// end property Car Subtotal
    }
}
