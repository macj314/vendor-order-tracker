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
      Vendor vendor = new Vendor("testTitle", "testDesc");
      Assert.AreEqual(typeof(Vendor), vendor.GetType());
    }
  }
}