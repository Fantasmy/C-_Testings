﻿using System;
using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTest
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //arrange 
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act 
            account.Debit(debitAmount);

            // assert 
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }



        [TestMethod]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // arrange 
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act 
            account.Debit(debitAmount);

            // assert is handled by ExpectedException }  

        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsMoreThanZero_ShouldThrowArgumentOutOfRange()
        {

            // arrange 
            double beginningBalance = 11.99;
            double debitAmount = 100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act 
            account.Debit(debitAmount);

            // assert is handled by ExpectedException }  

        }
    }
}
