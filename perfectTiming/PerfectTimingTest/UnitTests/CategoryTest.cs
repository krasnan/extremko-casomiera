using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using perfectTiming.Controller;
using perfectTiming.Model;
using perfectTiming.Helpers;
using System.Collections.Generic;


namespace PerfectTimingTest.UnitTests
{
    
    [TestClass]
    public class CategoryTest
    {
       private perfecttimingEntities _context;
       private CategoryController ctrl;
       const int TEST_EVENT_ID = 209; // ID testovacej Udalosti 
        public CategoryTest()
        {
           this._context = new perfecttimingEntities();
           this.ctrl = new CategoryController(ref _context);
        }

        [TestMethod]
        public void CategoryAddAndRemove()
        {

            Category c = new Category
            {   race_id = TEST_EVENT_ID,
                name = "Abcdefg",
                description = "Abcdefg"
            };

            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(c).Status);
        }

        [TestMethod]
        public void CategoryAddEmpty()
        {
            // Empty race_id
            Category c = new Category
            {
                name = "Abcdefg",
                description = "Women Category"
            };
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);

            // Empty name
            c.name = "";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);


        }
        [TestMethod]
        public void CategoryAddSameName()
        {

            Category c = new Category
            {
                race_id = TEST_EVENT_ID,
                name = "EQname",
                description = "EQdescription1"
            };

            Category c1 = new Category
            {
                race_id = TEST_EVENT_ID,
                name = "EQname",
                description = "EQdescription1"
            };

            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c1).Status);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(c).Status);
        }



        [TestMethod]
        public void CategoryUpdate()
        {

            Category old = new Category
            {
                race_id = TEST_EVENT_ID,
                name = "OldName",
                description = "oldDescription"
            };

            ctrl.Add(old);
            Category nnew = ctrl.Categories[ctrl.Categories.Count - 1];

            // Change name
            nnew.name = "NewName";
           
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Update(nnew).Status);
            Assert.AreEqual(nnew.name, ctrl.Categories[ctrl.Categories.Count - 1].name);

            // Name empty
            old.name = "";

            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Update(old).Status);
            old.race_id = 0;
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Update(old).Status);
            Assert.AreEqual(nnew.name, ctrl.Categories[ctrl.Categories.Count - 1].name);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(nnew).Status);

        }

        [TestMethod]
        public void CategoryUpdateSameName()
        {

            Category c1 = new Category { race_id = TEST_EVENT_ID, name = "SameName", description = "void" };
            Category c2 = new Category { race_id = TEST_EVENT_ID, name = "SimilarName", description = "void" };

            ctrl.Add(c1);
            ctrl.Add(c2);

            // Dve kategorie z rovnakym menom nemozu existovat
            c2.name = "SameName";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Update(c2).Status);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(c1).Status);
            c2.name = "SimilarName";
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(c2).Status);
        }

        [TestMethod]
        public void CategoryRemoveSimple()
        {
            Category c = new Category { race_id = TEST_EVENT_ID, name = "Example", description = "void" };
            ctrl.Add(c);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(c).Status);
        }
    }
}
