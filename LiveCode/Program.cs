namespace LiveCode
{
    using System;
    using System.Collections.Generic;

    using Animals;
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loop
            // 3 animals diff type feed with diff foods 
            //Linked list task Pesho skip moves (positive negative)
            //Calories
            var dog = new Dog();
            var foods = new List<string>();

            dog.Foods = foods;
        }

        public static void LinkedList()
        {
            var linkedList = new Node<string>("Ivan");
            var node1 = new Node<string>("Pesho");
            var node2 = new Node<string>("Stamat");
            var node3 = new Node<string>("Strahil");
            var node4 = new Node<string>("Petkan");
            var node5 = new Node<string>("Dragoi");
            var node6 = new Node<string>("Kiril");

            linkedList.Add(node1);
            node1.AddPrevious(linkedList);
            node1.Add(node2);
            node2.AddPrevious(node1);
            node2.Add(node3);
            node3.AddPrevious(node2);
            node3.Add(node4);
            node4.AddPrevious(node3);
            node4.Add(node5);
            node5.AddPrevious(node4);
            node5.Add(node6);
            node6.AddPrevious(node5);


            Console.WriteLine(linkedList.Find("Kiril"));
            Console.WriteLine();
            Console.WriteLine(linkedList.Traverse());
            Console.WriteLine();
            Console.WriteLine(node3.TraverseBackwards(2));

        }
    }
}
