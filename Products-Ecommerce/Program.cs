using System;

namespace Products_Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

class MainClass
        {
            public static void Main(string[] args)
            {
                using System;

class MainClass
            {
                public static void Main(string[] args)
                {
                    Products product1 = new Products();
                    product1.productName = "armut";
                    product1.productExp = "Deveci armudu";
                    product1.productPrice = 9.5;
                    product1.productCount = 750;

                    Products product2 = new Products();
                    product2.productName = "Kivi";
                    product2.productExp = "İthal kivi";
                    product2.productPrice = 13;
                    product2.productCount = 190;

                    Products product3 = new Products();
                    product3.productName = "Kavun";
                    product3.productExp = "Ankara kavunu";
                    product3.productPrice = 18;
                    product3.productCount = 870;

                    Products[] products = new Products[]{product1,product2,product3};

                    for (int i = 0; i < products.Length; i++)
                    {
                        Console.WriteLine(products[i].productName);
                        Console.WriteLine(products[i].productExp);
                        Console.WriteLine(products[i].productPrice);
                        Console.WriteLine(products[i].productCount);
                        Console.WriteLine("-----------------#####-------------------");
                    }


                    int j = 0;

                    while (j < products.Length)
                    {
                        Console.WriteLine(products[j].productName);
                        Console.WriteLine(products[j].productExp);
                        Console.WriteLine(products[j].productPrice);
                        Console.WriteLine(products[j].productCount);
                        Console.WriteLine("-----------------#####-------------------");
                        j++;
                    }

                    foreach (var product in products)
                    {
                        Console.WriteLine(products[j].productName);
                        Console.WriteLine(products[j].productExp);
                        Console.WriteLine(products[j].productPrice);
                        Console.WriteLine(products[j].productCount);
                        Console.WriteLine("-----------------#####-------------------");
                    }

                }
            }
        }
    }

    class Products
    {
        public string productName { get; set; }
        public double productPrice { get; set; }
        public string productExp { get; set; }
        public int productCount { get; set; }
    }
}
    }
}
