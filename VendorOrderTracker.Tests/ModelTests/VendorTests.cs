using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();      
    }
    
    [TestMethod]
    public void VendorConstructor_CreateInstanceVendor_Object()
    {
      Vendor vendor = new Vendor("testName1", "testDesc1");
      Assert.AreEqual(typeof(Vendor), vendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "testName2";
      Vendor vendor = new Vendor(name, "testDesc2");
      string result = vendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "testName3";
      string description = "testDesc3";
      Vendor vendor = new Vendor(name, description);
      string result = vendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      string name1 = "testName4";
      string description1 = "testDesc4";
      string name2 = "testName5";
      string description2 = "testDesc5";
      Vendor vendor1 = new Vendor(name1, description1);
      Vendor vendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { vendor1, vendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}