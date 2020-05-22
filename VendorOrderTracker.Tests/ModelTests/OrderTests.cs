using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();      
    }
    
    [TestMethod]
    public void OrderConstructor_CreateInstanceOrder_Object()
    {
      Order order = new Order("testTitle1", "testDesc1", 1, 1);
      Assert.AreEqual(typeof(Order), order.GetType());
    }

    [TestMethod]
      public void GetProperties_ReturnOrderProperties_String()
    {
      string title = "testTitle2";
      string description = "testDesc2";
      int price = 2;
      int date = 2;
      Order order = new Order(title, description, price, date);

      string titleResult = order.Title;
      string albumResult = order.Description;
      int yearResult = order.Price;
      int dateResult = order.Date;

      Assert.AreEqual(title, titleResult);
      Assert.AreEqual(description, albumResult);
      Assert.AreEqual(price, yearResult);   
      Assert.AreEqual(date, dateResult); 
    }
  }
}