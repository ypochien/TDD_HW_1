using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_HW_1
{
    [TestClass]
    public class SheetTest
    {
        [TestMethod]
        public void Test_取3筆_Cost欄位_總和()
        {
            //arrange
            var field = "Cost";
            var subgroup = 3;
            var expected = new[] { 6, 15, 24, 21 };

            IDaoSheet daoStub = new IDaoSheetStub(); //注入假資料
            var target = new Sheet(daoStub); //先透過ctor 處理 di
            
            //act
            var actual = target.SumByFieldAndSubgroup(field, subgroup);
            
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}