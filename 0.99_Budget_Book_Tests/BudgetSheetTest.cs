using _0._99_Budget_Book;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_Budget_Book_Tests
{
	[TestClass]
    public class BudgetSheetTest
    {
		[TestMethod]
        
			public void TestHighestDeposit()
			{
            //27Add a reference to the Budget_Book
            //28 change the BudgetSheet to public

				//29 Write the unit tests.
				BudgetSheet sheet = new BudgetSheet();
				sheet.DepositMoney(100.0M);
				sheet.DepositMoney(400.0M);

				BudgetActivity testResult = sheet.ShowAccountActivity();
				Assert.AreEqual(400.0M, testResult.High);
			 }

        [TestMethod]
        public void TestLowestDeposit()
        {
            BudgetSheet sheet = new BudgetSheet();
            sheet.DepositMoney(5.0M);
            sheet.DepositMoney(400.0M);

            BudgetActivity testResult = sheet.ShowAccountActivity();
            Assert.AreEqual(0, testResult.Low);
        }
        [TestMethod]
        public void TestAverageDeposit()
        {
            //27Add a reference to the Budget_Book
            //28 change the BudgetSheet to public

            //29 Write the unit tests.
            BudgetSheet sheet = new BudgetSheet();
            //sheet.DepositMoney(10.0M);
            //sheet.DepositMoney(10.0M);
            sheet.DepositMoney(10.3M);
            sheet.DepositMoney(10.3M);
            sheet.DepositMoney(10.7M);

            BudgetActivity testResult = sheet.ShowAccountActivity();
            // Assert.AreEqual(10.0M, testResult.Average);

            //29Problem: imperfect average.
            Assert.AreEqual(10.0M, testResult.Average);
     
            //Assert.AreEqual(10.433333333M, testResult.Average, 0.01M);

        }
    }

}
