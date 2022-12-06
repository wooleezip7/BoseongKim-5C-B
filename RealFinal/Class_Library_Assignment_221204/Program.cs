using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_Library_Assignment
{
    public class Program
    {
        static Student[] students = {
            new Student("Yoon", "wooleezip3@gmail.com", "0475887427", "math", "12/12", 3),
            new Student("PARK", "wooleezip4@gmail.com", "0475887423", "english", "12/12", 1),
            new Student("Lee", "wooleezip5@gmail.com", "0475887425", "spanish", "12/12", 4),
            new Student("MIN", "wooleezip6@gmail.com", "0475887421", "Science", "12/12", 2),
            new Student("Seong", "wooleezip7@gmail.com", "0475887427", "math", "12/12", 10)
        };
        static Student s1 = new Student("Boseong", "wooleezip7@gmail.com", "0475887427", "math", "12/12", 1);
        static Student s2 = new Student("Boseong", "wooleezip7@gmail.com", "0475887427", "math", "12/12", 1);

        static Student n1 = new Student("Lee", "Lee@gmail.com", "11", "math", "12/12", 1);
        static Student n2 = new Student("Park", "Park@gmail.com", "22", "math", "12/12", 2);
        static Student n3 = new Student("Yoon", "Yoon@gmail.com", "33", "math", "12/12", 3);
        static Student n4 = new Student("Dale", "Dale@gmail.com", "44", "math", "12/12", 4);
        static Student n5 = new Student("N", "N@gmail.com", "55", "math", "12/12", 5);

        public static void RunSequentialSearch()
        {
            Utility.TestSequentialSearch(students);
        }

        public static Student[] RunBubbleSortDESC()
        {
            
            Student[] resultDESC = Utility.Bubble_DESC(students);
            return resultDESC;
        }

        public static Student[] RunBubbleSortASC()
        {
            Student[] resultASC = Utility.Bubble_ASC(students);
            return resultASC;
        }

        public static void RunBubbleSortWithCompareTo() 
        {
            Utility.Bubble_CompareTo(students);
        }

        public static void RunBinarySearch()
        {
            Utility.TestBinarySearch(students);
        }


        // Doubly linked list

        // Traverse Display students
        // Not soleved Console.WriteLine("Traverse Display students");
        static DoublyLinkedList<Student> nStudents = new DoublyLinkedList<Student>();

        public static void RunDoublyNodeAddFirst()
        {
            Console.WriteLine("Double Linked List \n");
            // Add First
            nStudents.AddFirst(n1);
            nStudents.AddFirst(n2);
            nStudents.AddFirst(n4);
            Console.WriteLine("n1 , n2 , n4 Added first node");

            foreach (Student n in nStudents)
            {
                Console.WriteLine("Name: " + n.Name + " " + "Email: " + n.Email + " " + "TelNum: " + n.Tel_Num + "Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "StudentID" + n.StudentId);
            }
        }

        public static void RunDoublyNodeContains()
        {
            // Find function 
            Console.WriteLine("use find function \n");
            Console.WriteLine(" n3 found in the list : " + nStudents.Contains(n3));
            Console.WriteLine(" n4 found in the list : " + nStudents.Contains(n4));
        }


        public static void RunDoublyNodeAddLast()
        {
            // Add Last
            nStudents.AddLast(n3);
            nStudents.AddLast(n5);
            Console.WriteLine("nStudents n3 nad n5 is LAST ADDED: \n");
            foreach (Student n in nStudents)
            {
                Console.WriteLine("Name: " + n.Name + " " + "Email: " + n.Email + " " + "TelNum: " + n.Tel_Num + "Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "StudentID" + n.StudentId);
            }
        }

        public static void RunDoublyNodeDeleteFirst()
        {
            // Delete Function // First
            Console.WriteLine("Delete First Student from the list");
            nStudents.RemoveFirst();
            foreach (Student n in nStudents)
            {
                Console.WriteLine("Name: " + n.Name + " " + "Email: " + n.Email + " " + "TelNum: " + n.Tel_Num + "Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "StudentID" + n.StudentId);
            }
        }

        public static void RunDoublyNodeDeleteLast()
        {
            // Delete Function // Last
            Console.WriteLine("Delete Last Student from the list");
            nStudents.RemoveLast();
            foreach (Student n in nStudents)
            {
                Console.WriteLine("Name: " + n.Name + " " + "Email: " + n.Email + " " + "TelNum: " + n.Tel_Num + "Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "StudentID" + n.StudentId);
            }
        }

        static SingleLinkedList<Student> sStudents = new SingleLinkedList<Student>();
        // Tset Single Linked List
        static Student si1 = new Student("Lee", "Lee@gmail.com", "11", "math", "12/12", 1);
        static Student si2 = new Student("Park", "Park@gmail.com", "22", "math", "12/12", 2);
        static Student si3 = new Student("Yoon", "Yoon@gmail.com", "33", "math", "12/12", 3);
        static Student si4 = new Student("Dale", "Dale@gmail.com", "44", "math", "12/12", 4);
        static Student si5 = new Student("N", "N@gmail.com", "55", "math", "12/12", 5);

        public static void RunSingleNodeAddFirst()
        {
            // Add First
            Console.WriteLine("Test Single Linked List \n");
            sStudents.AddFirst(si1);
            sStudents.AddFirst(si2);
            sStudents.AddFirst(si4);
            //nStudents.GetEnumerator();
            Console.WriteLine("Enumerate through the list and display each of the Student node values \n");

            foreach (Student n in sStudents)
            {
                Console.WriteLine("Name: " + n.Name + " " + "Email: " + n.Email + " " + "TelNum: " + n.Tel_Num + "Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "StudentID" + n.StudentId);
            }

        }

        public static void RunSingleNodeAddLast()
        { // Add Last
            sStudents.AddLast(si3);
            sStudents.AddLast(si5);
            Console.WriteLine("sStudents si3 and si5 is LAST ADDED: \n");
            foreach (Student n in sStudents)
            {
                Console.WriteLine("Name: " + n.Name + " " + "Email: " + n.Email + " " + "TelNum: " + n.Tel_Num + "Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "StudentID" + n.StudentId);
            }
        }

        public static void RunSingleNodeContains()
        {
            Console.WriteLine(" si 1 Contain True or False");
            Console.WriteLine(sStudents.Contains(s1));
        }

        public static void RunSingleNodeDeleteFirst()
        {
            Console.WriteLine("Remove first line of the list");
            sStudents.RemoveFirst();
            foreach (Student n in sStudents)
            {
                Console.WriteLine("Name: " + n.Name + " " + "Email: " + n.Email + " " + "TelNum: " + n.Tel_Num + "Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "StudentID" + n.StudentId);
            }
        }

        public static void RunSingleNodeDeleteLast()
        {
            Console.WriteLine("Remove last line of the list");
            sStudents.RemoveLast();
            foreach (Student n in sStudents)
            {
                Console.WriteLine("Name: " + n.Name + " " + "Email: " + n.Email + " " + "TelNum: " + n.Tel_Num + "Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "StudentID" + n.StudentId);
            }
        }




        public static void Main(string[] args)
        {

            for (int i = 0; i < students.Length; i++) // Printing all studentArray 
            {
                Console.WriteLine(students[i] + " ");
            }

            // Sequential Search for Program.CS
            // Sequential Search
            Console.WriteLine("\n Sequential Search");
            Utility.SequentialSearch(students);

            // Sequential Search for NUnit
            Console.WriteLine("\n Sequential Search for NUnit");
            RunSequentialSearch();
            Console.WriteLine("\n");

            //Bubble Sort DESC
            Console.WriteLine("Bubble Sort in descending");
            Student[] resultDESC = RunBubbleSortDESC();


            //Bubble Sort ASC
            Console.WriteLine("Bubble Sort in ascending");
            Student[] resultASC = RunBubbleSortASC();

            //Binary Search for Program.cs
            Console.WriteLine("\n Binary Search");
            Utility.BinarySearch(Utility.Bubble_ASC(students));
            // Binary Search for NUnit
            Console.WriteLine("\n Binary Search for NUnit");
            RunBinarySearch();

            Console.WriteLine("\n");

            // Doubly Node Add First
            RunDoublyNodeAddFirst();

            // Doubly Node Add Last
            RunDoublyNodeAddLast();

            Console.WriteLine("\n");

            // Doubly Node Contains
            RunDoublyNodeContains();

            Console.WriteLine("\n");

            // Doubly Node Delete First
            RunDoublyNodeDeleteFirst();

            // Doubly Node Delete Last
            RunDoublyNodeDeleteLast();

            Console.WriteLine("\n\n");


            // Single Node Add First
            RunSingleNodeAddFirst();

            // Single Node Add Last
            RunSingleNodeAddLast();

            Console.WriteLine("\n");

            // Single Node Contains
            RunSingleNodeContains();

            Console.WriteLine("\n");

            // Single Node Delete First
            RunSingleNodeDeleteFirst();

            // Single Node Delete Last
            RunSingleNodeDeleteLast();
            
            Console.WriteLine("\n\n");

            
            BinaryTree binaryTree = new BinaryTree();
            // BinarySearch Tree
            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(3);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);

            Node node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(7);
            binaryTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
