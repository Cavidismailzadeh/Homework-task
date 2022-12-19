



using ClassWork;


//DateTime date = DateTime.Now.AddDays(1);
//float price = 100;

//CheckStatus(date, price);


//static Order[] PriceStatus() 
//{
//    Order order1 = new();
//    order1.Date = new DateTime(2022, 12, 20);
//    order1.Price = 150;

//    Order order2 = new();
//    order2.Date = new DateTime(2022, 10, 20);
//    order2.Price = 100;

//    Order order3 = new();
//    order3.Date = new DateTime(2022, 10, 15);
//    order3.Price = 250;

//    Order order4 = new();
//    order4.Date = new DateTime(2022, 09, 12);
//    order4.Price = 10;

//    Order order5 = new();
//    order5.Date = new DateTime(2022, 08, 16); 
//    order5.Price = 500;

//    Order order6 = new();
//    order6.Date = new DateTime(2022, 11, 25);
//    order6.Price = 15;

//    Order[] orders = { order1, order2, order3, order4, order5, };
//    return orders;
//}


//static void CheckStatus(DateTime Date , float price )
//{
//    var orders = PriceStatus();
//    foreach (var order in orders)
//    {
//        if (price<order.Price && DateTime.Now.AddDays(1) > order.Date)
//        {
//            Console.WriteLine($"{order.Date}  {order.Price} " );
//        }
//    }
//}






CheckDataByMarried(30);


static Person[] FullDataPerson()
{
    Person person1 = new Person();
    person1.Name = "Shaiq";
    person1.Surname = "Kazimov";
    person1.Age = 25;
    person1.Married = true;


    Person person2 = new Person();
    person2.Name = "Konul";
    person2.Surname = "Memmedov";
    person2.Age = 24;
    person2.Married = true;


    Person person3 = new Person();
    person3.Name = "Ferid";
    person3.Surname = "Abbasov";
    person3.Age = 19;
    person3.Married = false;


    Person person4 = new Person();
    person4.Name = "Alakbar";
    person4.Surname = "Huseynov";
    person4.Age = 23;
    person4.Married = false;


    Person person5 = new Person();
    person5.Name = "Cavid";
    person5.Surname = "Beshirov";
    person5.Age = 29;
    person5.Married = true;

    Person[] persons = { person1, person2, person3, person4, person5 };
    return persons;
}




static void CheckDataByMarried(int age)
{
    int count = 0;
    var result = FullDataPerson();
    foreach (var item in result)
    {
        if (item.Age> age && item.Married)
        {
            count++;
        }
        
    }
    Console.WriteLine(count);
}