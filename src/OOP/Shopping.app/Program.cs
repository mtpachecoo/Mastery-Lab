Product p1 = new Product("Iphone 17", 10000, Category.Electronics );
Product p2 = new Product("Boné Lacoste", 350, Category.Clothing );
Product p3 = new Product("BigTasty", 49, Category.Food);

Cart c1 = new Cart();
c1.AddProduct(p1);
c1.AddProduct(p2);
c1.AddProduct(p3);

System.Console.Write("O carrinho contem os seguintes items: " + c1);
System.Console.WriteLine("O valor total do carrinho é " + c1.TotalPrice);
