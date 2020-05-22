using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public List<Order> Orders { get; set; }
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int vendorId)
    {
      return _instances[vendorId -1];
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}