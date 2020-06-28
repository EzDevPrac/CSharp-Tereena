using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping
{
    class CreditCard
    {
        public int CreditCardNum;
        public string CardHolderName;

        public CreditCard(int cardno, string holdername)
        {
            this.CreditCardNum = cardno;
            this.CardHolderName = holdername;
        }
        public int GetCreditCardNum()
        {
            return CreditCardNum;
        }
        public void SetCreditCardNum(int cardno)
        {
            this.CreditCardNum = cardno;
        }
        public string GetCardHolderName()
        {
            return CardHolderName;
        }
        public void SetCardHolderName(string holdername)
        {
            this.CardHolderName = holdername;
        }
    }
}
