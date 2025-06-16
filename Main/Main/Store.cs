using System.Collections.Generic;
using System;

public class Store
{
    //инициализаия списков
    public List<Product> products;
    public List<Product> basket = new List<Product>();
    public List<Order> orders;

    public Store()
    {
        //инициализация списка продуктов (пример инициализации списка + вложение конкретных экземпляров)
        products = new List<Product>
                {
                    new Product("Milk", 13),
                    new Product("Bread", 6),
                    new Product("Eggs", 7),
                    new Product("Cheese", 26),
                    new Product("Wine", 122)
                };
        //инициализация пустых списков для корзины и для фин.заказа
        basket = new List<Product>();
        orders = new List<Order>();
    }

    public void ShowCatalog()
    {
        Console.WriteLine("\tКаталог продуктов:");
        int number = 1;//для нумерации продуктов
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"\t{number}. {products[i].name} {products[i].price}");
            number++;
        }
    }
    public void AddToBacket(int choise)
    {
        basket.Add(products[choise - 1]);
        Console.WriteLine("");
        Console.WriteLine($"Продукт {products[choise - 1].name} добавлен в корзину!");
        Console.WriteLine($"Количество позиций в корзине: {basket.Count}");
    }
    public void AddProduct(string name, int price)
    {
        Product newProduct = new Product(name, price);
        products.Add(newProduct);
        Console.WriteLine("");
        Console.WriteLine($"=== Продукт {newProduct.name} добавлен в каталог ===");
    }
    public void DeleteProduct(int choise)
    {
        products.Remove(products[choise - 1]);
        Console.WriteLine("");
        Console.WriteLine($"=== Продукт под номером {choise} был удален из каталога ===");
    }

    public void ShowBacket()
    {
        Console.WriteLine("\tВаша корзина:");
        int number2 = 1;//для нумерации продуктов
        for (int i = 0; i < basket.Count; i++)
        {
            Console.WriteLine($"\t{number2}. {basket[i].name} {basket[i].price}");
            number2++;
        }
    }
    public void CreateOrder()
    {
        //передать в отдел доставки затем опустошить корзину
        Order order = new Order(basket);
        orders.Add(order);
        //перед очисткой пересчитываем и выводим сумму цены всего в корзине
        decimal orderCost = 0;
        for (int i = 0; i < basket.Count; i++)
        {
            orderCost += basket[i].price;
        }
        Console.WriteLine("");
        Console.WriteLine($"=== Заказ на сумму {orderCost} обработан ===");
        basket.Clear();
    }
    public void ClearBasket()
    {
        basket.Clear();
    }
}