namespace LiveCode
{
    using System;
    using System.Collections.Generic;

    using Animals;

    public class Program
    {
        static void Main(string[] args)
        {
            AnimalsAndFood();
            LinkedList();
        }

        private static void AnimalsAndFood()
        {
            try
            {
                #region input
                Console.WriteLine("Animals and Food Exercise");
                Console.WriteLine();
                var animals = new List<Animal>()
                {
                    new Dog("Reksi", new List<string>()
                    {
                        "meat",
                        "bones",
                    }),
                    new Monkey("Macaca", new List<string>()
                    {
                        "banana",
                        "seeds",
                    }),
                    new Rabbit("Roger", new List<string>()
                    {
                        "carrot",
                        "cabbage",
                    })
                };

                var foods = new List<Food>()
                { 
                    new Food("banana", 140),
                    new Food("meat", 250),
                    new Food("seeds", 185),
                    new Food("carrot", 60),
                    new Food("cabbage", 72),
                    new Food("bones", 125),
                };
                #endregion

                foreach (var animal in animals)
                {
                    animal.Play();
                    Console.WriteLine($"{animal.Name}:");

                    foreach (var food in foods)
                    {
                        animal.Feed(food);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Animal Statistics:");
                foreach (var animal in animals)
                {
                    Console.WriteLine(animal);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void LinkedList()
        {
            try
            {
                #region input
                var linkedList = new Node<string>("Ivan");
                var node1 = new Node<string>("Pesho");
                var node2 = new Node<string>("Stamat");
                var node3 = new Node<string>("Strahil");
                var node4 = new Node<string>("Petkan");
                var node5 = new Node<string>("Dragoi");
                var node6 = new Node<string>("Kiril");

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
                linkedList.Add(node1);
                #endregion

                Console.WriteLine("Linked List Exercise:");
                Console.WriteLine();
                Console.WriteLine($"Find: {linkedList.Find("Kiril")}");
                Console.WriteLine($"Traverse: {linkedList.Traverse(4)}");
                Console.WriteLine($"Traverse Backwards: {node3.TraverseBackwards(2)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
