using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Store onlineStore = new Store();
        //исполняется тело главной программы
        MainMenu(onlineStore);
        //функция срабатывает при выборе входа для администратора
    }
    static void LoginPasswordCheck(Store onlineStore)
    {
        Console.WriteLine("");
        Console.WriteLine("Введите логин:");
        string login = Console.ReadLine();
        Console.WriteLine("Введите пароль:");
        string password = Console.ReadLine();
        if (login != "135" && password != "135")
        {
            Console.WriteLine("");
            Console.WriteLine("===== В доступе отказано: неверный логин или пароль =====");
            MainMenu(onlineStore);
        }
        else
        {
            Admin(onlineStore);
        }
    }

    static void Admin(Store onlineStore)
    {
        Store x = onlineStore;
        Console.WriteLine("");
        Console.WriteLine("====== Доступ разрешен ======");
        while (true)
        {
            Console.WriteLine("");
            onlineStore.ShowCatalog();
            Console.WriteLine("");
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1. Добавить товар в каталог");
            Console.WriteLine("2. Удалить товар из каталога");
            Console.WriteLine("3. Выйти из режима администратора");
            Console.WriteLine("");
            Console.WriteLine("Выберите номер действия, которое хотите совершить");
            int numAction = Convert.ToInt32(Console.ReadLine());
            switch (numAction)
            {
                case 1:
                    bool isNotNull = true;
                    Console.WriteLine("");
                    do
                    {
                        try
                        {
                            Console.WriteLine("Введите название товара");
                            string name = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Введите цену товара");
                            int price = Convert.ToInt32(Console.ReadLine());
                            onlineStore.AddProduct(name, price);
                            if (name != "" & price != 0)
                            {
                                isNotNull = true;
                            }
                            else isNotNull = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("======================================================");
                            Console.WriteLine("ОШИБКА: Вы ничего не ввели, либо ввели неверный формат");
                            Console.WriteLine("======================================================");
                        }

                    } while (isNotNull != true);
                    break;
                case 2:
                    bool isInRange = true;
                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Введите номер товара, который нужно удалить");
                        //на случай, если человек введет не число, выбрасываем сообщения вместо сбоя программы
                        try
                        {
                            int num = Convert.ToInt32(Console.ReadLine());

                            if (num == 0 || num > onlineStore.products.Count())
                            {
                                isInRange = false;
                                Console.WriteLine("");
                                Console.WriteLine("===================================");
                                Console.WriteLine("ОШИБКА: Неверно указан номер товара");
                                Console.WriteLine("===================================");
                            }
                            else isInRange = true;
                            if (isInRange == true)
                            {
                                onlineStore.DeleteProduct(num);
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("===================================");
                            Console.WriteLine("ОШИБКА: Неверно указан номер товара");
                            Console.WriteLine("===================================");
                        }
                    } while (isInRange != true);

                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("===== Вы вышли из режима администратора =====");
                    MainMenu(onlineStore);
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("=======================================================");
                    Console.WriteLine("Вы ничего не выбрали. Выберите номер действия из списка");
                    Console.WriteLine("=======================================================");
                    break;
            }
        }
    }

    static void RequestAddToBacket(Store onlineStore)
    {
        while (true)
        {
            bool isYes = true;
            do
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Хотите добавить продукт в корзину? Введите \"да\" или \"нет\"");
                    string agreement = Convert.ToString(Console.ReadLine());
                    if (agreement.ToLower() == "да")
                    {
                        isYes = true;
                    }
                    else if (agreement.ToLower() == "нет")
                    {
                        ShowBucketAndOrder(onlineStore);
                    }
                    else isYes = false;

                    if (isYes == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Введите номер продукта, который желаете добавить в корзину");
                        int choise = Convert.ToInt32(Console.ReadLine());
                        onlineStore.AddToBacket(choise);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("");
                    Console.WriteLine("=====================");
                    Console.WriteLine("Ошибка: неверный ввод");
                    Console.WriteLine("=====================");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("");
                    Console.WriteLine("=====================");
                    Console.WriteLine("Ошибка: неверный ввод");
                    Console.WriteLine("=====================");
                }
            } while (isYes != true);
        }
    }
    static void ShowBucketAndOrder(Store onlineStore)
    {
        Console.WriteLine("");
        Console.WriteLine("Хотите посмотреть корзину?");
        string agreement2 = Convert.ToString(Console.ReadLine());
        if (agreement2.ToLower() == "да")
        {
            if (!onlineStore.basket.Any())
            {
                Console.WriteLine("");
                Console.WriteLine("=== Ваша корзина и так пуста ===");
                MainMenu(onlineStore);
            }
            else
            {
                onlineStore.ShowBacket();
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Хотите оформить заказ?");
        string agreement3 = Convert.ToString(Console.ReadLine());
        if (agreement3.ToLower() == "да")
        {
            onlineStore.CreateOrder();
            MainMenu(onlineStore);
        }
        else
        {
            MainMenu(onlineStore);
        }
        if (agreement2.ToLower() == "нет" & agreement3.ToLower() == "нет")
        {
            MainMenu(onlineStore);
        }
    }

    //тело программы вынесено в функцию специально, чтобы вставить исполнение главной программы
    //в случае неудачного входа для администратора
    static void MainMenu(Store onlineStore)
    {
        while (true)
        {
            //создаем конкретные продукты
            Console.WriteLine("");
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1. Показать каталог продуктов");
            Console.WriteLine("2. Вход для администратора");
            Console.WriteLine("3. Очистить корзину");
            Console.WriteLine("4. Выйти");
            Console.WriteLine("Выберите номер действия, которое хотите совершить");
            string numAction = Console.ReadLine();
            bool isRight;

            do
            {
                if (numAction != "1" || numAction != "2" || numAction != "3")
                {
                    isRight = false;
                }
                else isRight = true;
                switch (numAction)
                {
                    case "1":
                        onlineStore.ShowCatalog();
                        RequestAddToBacket(onlineStore);
                        break;
                    case "2":
                        LoginPasswordCheck(onlineStore);
                        break;
                    case "3":
                        if (!onlineStore.basket.Any())
                        {
                            Console.WriteLine("");
                            Console.WriteLine("=== Ваша корзина и так пуста ===");
                            MainMenu(onlineStore);
                        }
                        else
                        {
                            onlineStore.ClearBasket();
                            Console.WriteLine("");
                            Console.WriteLine("=== Корзина очищена ===");
                            MainMenu(onlineStore);
                        }
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("Вы ничего не выбрали. Выберите номер действия из списка");
                        Console.WriteLine("=======================================================");
                        break;
                }
                if (isRight == false)
                {
                    string numAction2 = Console.ReadLine();
                    numAction = numAction2;
                }
            } while (isRight == false);
        }
    }
}
