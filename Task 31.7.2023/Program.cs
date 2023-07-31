//                        CLASSWORK(Casting)

// boxing- unboxing

//int num = 5;

//object t = num;

////num = 1000;

//Console.WriteLine(t);

////Console.WriteLine(num);

//int j = (int)t;

// upcasting-downcasting

//////////////////////////////////////////////////////////////////////

using Task_31._7._2023;

//Animal animal1 = new Animal();

//Fish fish1 = new Fish();

// Animal animal3 = fish1;

//Animal animal2 = new Fish();

//Fish fish3 = (Fish) animal2;

//Book book = new Book();

//object[] animals = {book, 1,"Salam", animal1, fish1, animal3, animal2, fish3};

//foreach ( var item in animals)
//{
//   Animal animal = item as Animal;
//    if (animal != null)
//    {
//        animal.Name = "canavar";
//        Console.WriteLine(animal.Name);
//    }


//if (item is Animal a)
//{
//    a.Name = "Tulku";
//    Console.WriteLine(a.Name);
//}

//    //if ( item is Animal)
//    //{
//    //    ((Animal)item).Name = "Tulku";
//    //    Console.WriteLine(((Animal)item).Name);
//    //}

//}

////////////////////////////////////////////////////////////////////////

//byte num1 = 5;

////int num2 = num1;

//byte num2 = (byte)num1;

//byte age = 50;
//int age2 = age;

//int num1 = 200;

//byte num2 =(byte)num1;

//Console.WriteLine(num2);


/////////////////////////////////////////////////////////////////////////////

//Test();
//static void Test(int? a = 5)
//{
//    if (a != null)
//    {
//        Test2((int)a);
//    }



//}


//static void Test2(int m)
//{

//}




//

//                                    GENERICS




//IntList intList = new IntList();

//intList.Add(5);
//intList.Add(15);

//var result = intList.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}




//StringList stringList = new StringList();
//stringList.Add("Salam");
//stringList.Add("Salamlar");

//var res = stringList.GetAll();
//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}



//DataList<int> datas = new DataList<int>();

//datas.Add(1);   
//datas.Add(2);
//datas.Add(3);
//datas.Add(4);

//var result = datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}





//DataList<string> words = new DataList<string>();

//words.Add("salam");
//words.Add("salam1");
//words.Add("salam2");

//var list = words.GetAll();
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}





//DataList<bool> statues = new DataList<bool>();

//statues.Add(true);
//statues.Add(false);


//var listBool = statues.GetAll();
//foreach (var item in listBool)
//{
//    Console.WriteLine(item);
//}



//DataList<Book> books = new DataList<Book>();

//books.Add(new Book { Id = 1, Name = "Xosrov ve Shirin"});

//books.Add(new Book { Id = 2, Name = "Isgendername" });

//var result = books.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}



//Repository<string> data1 = new Repository<string>();
//Repository<Book> data2 = new Repository<Book>();
//Repository<int> data3 = new Repository<int>();


Repository<Bird, Animal> animal = new Repository<Bird, Animal>();



