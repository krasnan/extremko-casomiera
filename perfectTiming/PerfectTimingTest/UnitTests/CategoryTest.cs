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
        perfecttimingEntities _context;

        [TestMethod]
        public void CategoryAdd()
        {

            _context = new perfecttimingEntities();
            CategoryController ctrl = new CategoryController(ref _context);
            Category c = new Category
            {
                name = "Women",
                description = "Women Category"
            };

            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
        }

        [TestMethod]
        public void CategoryAddEmpty()
        {
            CategoryController ctrl = new CategoryController(ref _context);
            Category c = new Category
            {
                name = "",
                description = "Women Category"
            };
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);
        }

        public void CategoryAddSameName()
        {
            CategoryController ctrl = new CategoryController(ref _context);
            Category c = new Category
            {
                name = "EQname",
                description = "EQdescription1"
            };

            Category c1 = new Category
            {
                name = "EQname",
                description = "EQdescription1"
            };

            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c1).Status);
        }



        [TestMethod]
        public void CategoryUpdate()
        {
            CategoryController ctrl = new CategoryController(ref _context);
            Category old = new Category
            {
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
            Assert.AreEqual(nnew.name, ctrl.Categories[ctrl.Categories.Count - 1].name);
        }

        [TestMethod]
        public void CategoryUpdateSameName()
        {
            CategoryController ctrl = new CategoryController(ref _context);

            Category c1 = new Category { name = "SameName", description = "void" };
            Category c2 = new Category { name = "SimilarName", description = "void" };

            ctrl.Add(c1);
            ctrl.Add(c2);

            // Dve kategorie z rovnakym menom nemozu existovat
            c2.name = "SameName";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Update(c2).Status);

        }

        [TestMethod]
        public void CategoryRemoveSimple()
        {
            CategoryController ctrl = new CategoryController(ref _context);
            Category c = new Category { name = "Example", description = "void" };

            ctrl.Add(c);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(c).Status);
        }
    }
}
