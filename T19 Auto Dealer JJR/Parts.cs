using System;
using System.Collections.Generic;
using System.Text;

namespace T19_Auto_Dealer_JJR
{
    class Parts
    {

        // Declare variables
        private bool m_blnDelivery;
        private int m_intQuantityParts;

        // Constructor
        public Parts ( bool DeliveryValue, int QuantityPartsValue )
        {
            Delivery = DeliveryValue;               // invoke property
            QuantityParts = QuantityPartsValue;
        }// end constructor

        // property Delivery
        public bool Delivery
        {
            get
            {
                return m_blnDelivery;
            }
            set
            {
                m_blnDelivery = value;
            }
        }// end property Delivery

        // property Quantity
        public int QuantityParts
        {
            get
            {
                return m_intQuantityParts;
            }
            set
            {
                if ( value > 0 )
                    m_intQuantityParts = value;
                else
                    m_intQuantityParts = 1; // set invalid input to 1
            }
        }// end property QuantityParts

        // property PartsPrice
        public decimal PartsPrice
        {
            get
            {
                decimal decPartsPrice = 0;
                // Multiply quantity to base total to obtain Subtotal
                decPartsPrice = 50M * m_intQuantityParts;

                if(m_blnDelivery == true)
                    decPartsPrice += 15.50M;

                return decPartsPrice;

            }
        }// end property PartsPrice
            
    } // end class Parts
}
