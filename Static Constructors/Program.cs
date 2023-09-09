using System;

//ref link:https://www.youtube.com/watch?v=95Sg5y77x4k&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=48
//static - shared(VB) - means shares data, has its onw static memory area besides the stack and heap

// App Domain - additional knowledge

class Cow
{
    //static int numInstances;
    //static int numInstances = new Random().Next(20);
    //public static int numInstances = new Random().Next(20);
    //static int whatever = numInstances + 5;
    public static int numInstances;
    static int whatever;
    
    int id;
    public Cow()
    {
        id = ++numInstances;
    }
    
    static Cow()        //static constructor
    {
        numInstances = new Random().Next(20);
        whatever = numInstances + 5;
    }
}

//class Dog
//{
//    static int numInstances;
//    //public static int numInstances;
//    int id;
//    public Dog()
//    {
//        id = ++numInstances;
//    }
//}

class MainClass
{
    static void Main()
    {
        Goo();

        //Cow.numInstances = 123;

        //Cow.numInstances += 213152;
        //Cow betsy = new Cow();
        //Cow georgy = new Cow();
        //Dog tax = new Dog();
    }
    static void Goo()
    {
        Cow.numInstances = 100;
        Cow betsy = new Cow();
        Cow georgy = new Cow();
    }
}