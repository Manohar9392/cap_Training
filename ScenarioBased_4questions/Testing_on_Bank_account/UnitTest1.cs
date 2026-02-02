using Validation_on_bank_account_testcase;
using NUnit.Framework;

using System;

namespace NUnitDemo.Tests
{
    
    // Marks this class as a NUnit test fixture
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account;

        // Runs before each test method
        [SetUp]
        public void Setup()
        {
            // Initialize bank account with initial balance of 1000
            _account = new BankAccount(1000);
        }

        // ---------------- Deposit Test Cases ----------------

        // Test to verify deposit with valid amount updates balance correctly
        [Test]
        public void Test_Deposit_ValidAmount()
        {
            // Act: deposit a valid amount
            _account.Deposit(500);

            // Assert: balance should be increased
            Assert.That(_account.Balance, Is.EqualTo(1500));
        }

        // Test to verify deposit with negative amount throws exception
        [Test]
        public void Test_Deposit_NegativeAmount()
        {
            // Assert: depositing negative amount should throw exception
            Assert.Throws<ArgumentException>(() =>
            {
                _account.Deposit(-200);
            });
        }

        // ---------------- Withdraw Test Cases ----------------

        // Test to verify withdrawal with valid amount updates balance correctly
        [Test]
        public void Test_Withdraw_ValidAmount()
        {
            // Act: withdraw a valid amount
            _account.Withdraw(300);

            // Assert: balance should be reduced
            Assert.That(_account.Balance, Is.EqualTo(700));
        }

        // Test to verify withdrawal greater than balance throws exception
        [Test]
        public void Test_Withdraw_InsufficientFunds()
        {
            // Assert: withdrawing more than balance should throw exception
            Assert.Throws<InvalidOperationException>(() =>
            {
                _account.Withdraw(2000);
            });
        }
    }
}
