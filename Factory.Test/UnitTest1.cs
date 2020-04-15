using System;
using FactoryDesign;
using Xunit;

namespace Factory.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           var fact = new MoneyBackFactory(50000, 0);
            CreditCard card = fact.GetCreditCard();
            //string expected1 = card.CardType;
            //int expected2 = card.CreditLimit;
            //int expected3 = card.AnnualCharge;
            //string actual1 = "MoneyBack";
            //int actual2 = 50000;
            //int actual3 = 0;

            //Assert  
            Assert.Equal(card.CardType, "MoneyBack");
            Assert.Equal(card.CreditLimit, 50000);
            Assert.Equal(card.AnnualCharge, 0);
        }

        [Fact]
        public void Test2()
        {
            TitaniumFactory fact;
             fact = new TitaniumFactory(100000, 500);
            CreditCard card = fact.GetCreditCard();
            //string expected1 = card.CardType;
            //int expected2 = card.CreditLimit;
            //int expected3 = card.AnnualCharge;
            //string actual1 = "MoneyBack";
            //int actual2 = 50000;
            //int actual3 = 0;

            //Assert  
            Assert.Equal(card.CardType, "Titanium");
            Assert.Equal(card.CreditLimit, 100000);
            Assert.Equal(card.AnnualCharge, 500);
        }

        [Fact]
        public void Test3()
        {
            PlatinumFactory fact;
            fact = new PlatinumFactory(500000,1000);
            CreditCard card = fact.GetCreditCard();
            //string expected1 = card.CardType;
            //int expected2 = card.CreditLimit;
            //int expected3 = card.AnnualCharge;
            //string actual1 = "MoneyBack";
            //int actual2 = 50000;
            //int actual3 = 0;

            //Assert  
            Assert.Equal(card.CardType, "Platinum");
            Assert.Equal(card.CreditLimit, 500000);
            Assert.Equal(card.AnnualCharge, 1000);
        }

        }
    }
