using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //product p1 = new product { code = 1, name = "Pen", price = 20 };

            //ArrayList list = new ArrayList();
            //list.Add(p1);

            ////or
            //ArrayList list2 = new ArrayList();
            //{
            //    new product { code = 2, name = "pencile", price = 10 };
            //};

            ////or
            //ArrayList list3 = new ArrayList();
            //list3.Add(new product { code = 3, name = "pen", price = 30 });

            ////foreach (product p in list)
            ////{
            ////    Console.WriteLine($"{p.code} , {p.name} ,{p.price}");
            ////}

            
            //Book book = new Book { price=500,bookname="History",author="NECRT"};
            //ArrayList list5 = new ArrayList();
            //list5.Add(book);

            //foreach (Book b in list5)
            //{
            //    Console.WriteLine($"{b.bookname} , {b.author} , {b.price}");


            //}


            List<int> list = new List<int>();
            

            list.Add(10);
            list.Add(20);
            list.Add(30);

       
            list.Remove(10);

            list.Insert(0, 10);
            list.Reverse();

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }


            List<string> list2 = new List<string>();
            list2.Add("Ram");
            list2.Add("gaurav");

            list2.Remove("Ram");

            list2.Insert(0, "Shankar");
            list2.Reverse();

           
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            List<product> prod = new List<product>();
            prod.Add(new product { code = 1, name = "Nokia", price = 10000 });
            prod.Add(new product { code = 2, name="samsung", price=15000});
            prod.Add(new product { code = 3, name = "Oppo", price = 20000 });

            prod.RemoveAt(2);
            prod.Insert(2, new product { code=3,name="Oppo",price=20000 });

            foreach (product item in prod)
            {
                Console.WriteLine($"{item.code} {item.name} {item.price}");
            }
                
                
              Stack<int> ints = new Stack<int>();
            ints.Push(25);
            ints.Push(30);
            ints.Push(35);
            ints.Push(40);

            ints.Pop();
            Console.WriteLine($"{ints.Peek()}");

            foreach (int stk in ints)
            {
                Console.WriteLine( stk );
            }
            
            Stack<product> products = new Stack<product>();
            products.Push(new product { code = 101, name = "AC", price = 30000 });
            products.Push(new product { code = 102, name = "Laptop", price = 45000 });
            products.Push(new product { code = 103, name = "Mobile", price = 20000 });

            products.Pop();
           


            foreach (product item in products)
            {
                Console.WriteLine($"{item.code} {item.name} {item.price}");
            }
                
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(18);
            qu.Enqueue(10);
            qu.Enqueue(95);
            qu.Enqueue(10);

            qu.Dequeue();
            Console.WriteLine(qu.Peek());


            foreach (int num in qu)
            {
                Console.WriteLine(num);
            }

            Queue<product> prod1 = new Queue<product>();
            prod1.Enqueue(new product { code = 201, name = "Table", price = 5000 });
            prod1.Enqueue(new product { code = 202, name = "Chair", price = 1000 });
            prod1.Enqueue(new product { code = 203, name = "fan", price = 1200 });

            foreach (product item in prod1)
            {
                Console.WriteLine($"{item.code} {item.name} {item.price}");
            }
        }
    }
}
