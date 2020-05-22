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
  }
}