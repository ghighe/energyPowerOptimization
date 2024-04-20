
using System.Collections.Generic;


namespace energyPowerOptimization.Products
{
   public class Product
    {
        public string name { get; set; }
        public int powerConsumption { get; set; }
    }

    public static class ItemManager
    {
        public static List<Product> GetHomeProducts()
        {
            return new List<Product>()
            {
                new Product() { name = "Aer Conditionat", powerConsumption = 1000 },
                new Product() { name = "Uscator de haine", powerConsumption = 3000 },
                new Product() { name = "Fier de calcat", powerConsumption = 2400 },
                new Product() { name = "Masina spalat vase", powerConsumption = 1600 },
                new Product() { name = "CeainicElectric", powerConsumption = 2000 },
                new Product() { name = "Ventilator", powerConsumption = 70 },
                new Product() { name = "Cuptor Electric", powerConsumption = 2000 },
                new Product() { name = "Cuptor microunde", powerConsumption = 800 },
                new Product() { name = "Calculator Desktop", powerConsumption = 100 },
                new Product() { name = "Laptop", powerConsumption = 50 },
                new Product() { name = "Frigider", powerConsumption = 200 },
                new Product() { name = "Televizor", powerConsumption = 70 },
                new Product() { name = "Aspirator", powerConsumption = 800 },
                new Product() { name = "Prajitor Paine", powerConsumption = 1000 },
                new Product() { name = "Masina de spalat", powerConsumption = 1500 },
                new Product() { name = "Boiler Electric", powerConsumption = 2000 }
            };
        }
    }

 

}

    //define our list of homeProducts

   
