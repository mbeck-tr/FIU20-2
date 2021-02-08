using System;

namespace CallByValueReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            ausgeben(a, b);

            a = b;
            ausgeben(a, b);

            a++;
            ausgeben(a, b);

            MyClass myClass = new MyClass();
            myClass.x = 10;
            myClass.y = 20;
            ausgeben(myClass);

            myClass.x = myClass.y;
            ausgeben(myClass);

            myClass.x++;
            ausgeben(myClass);//x:21 //y:20

            MyClass myClass2 = new MyClass();
            myClass2 = myClass;
            ausgeben(myClass2); //x:21 //y:20

            myClass2.x++;
            ausgeben(myClass2); //x:22 //y:20

            ausgeben(myClass); //x:22 //y:20
            myClass.x++;

            ausgeben(myClass);  //x:23 //y:20
            ausgeben(myClass2); //x:23 //y:20

            int zahl = 100;
            myClass.CallbyValue(zahl);
            Console.WriteLine("Call by Value: " + zahl);    //zahl: 100

            myClass.CallbyReference(ref zahl);
            Console.WriteLine("Call by Reference: " + zahl); //zahl: 101
        }

        static void ausgeben(int a, int b)
        {
            Console.WriteLine($"a: {a}\t\tb: {b}\n\n");
        }

        static void ausgeben(MyClass obj)
        {
            Console.WriteLine($"x: {obj.x}\t\ty: {obj.y}\n\n");
        }

        class MyClass
        {
            public int x;
            public int y;

            public void CallbyValue(int zahl)
            {
                zahl++;
            }

            public void CallbyReference(ref int zahl)
            {
                zahl++;
            }
        }
    }
}
