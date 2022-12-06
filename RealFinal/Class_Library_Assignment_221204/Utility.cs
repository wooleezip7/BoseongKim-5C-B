using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Assignment
{
    public class Utility
    {
        public Utility()
        {

        }

        public static void Bubble_CompareTo<Student>(Student[] students) where Student : IComparable<Student>
        {
            for (int x = 0; x < students.Length; x++)
            {
                for (int y = 0; y < students.Length - 1; y++)
                {
                    if (students[y].CompareTo(students[y + 1]) > 0)
                    {
                        Student temp = students[y + 1];
                        students[y + 1] = students[y];
                        students[y] = temp;
                    }
                }
            }
            Console.WriteLine("Pass!");
        }

        public static Student[] Bubble_ASC(Student[] students)
        {
            Student nTemp;
            int nCount = 0;
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - 1; j++)
                {
                    if (students[j].StudentId > students[j + 1].StudentId)
                    {
                        nTemp = students[j + 1];
                        students[j + 1] = students[j];
                        students[j] = nTemp;
                    }
                    nCount++;
                }
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
            return students;

        }
        public static Student[] Bubble_DESC(Student[] students)
        {
            Student nTemp;
            int nCount = 0;
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - 1; j++)
                {
                    if (students[j].StudentId < students[j + 1].StudentId)
                    {
                        nTemp = students[j + 1];
                        students[j + 1] = students[j];
                        students[j] = nTemp;
                    }
                    nCount++;
                }
            }


            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
            return students;
        }

        public static int TestBinarySearch(Student[] students)
        {
            Array.Sort(students);
            // Console.WriteLine("Enter Binary Search Element");
            // int searchItem = int.Parse(Console.ReadLine());
            int searchItem = 1;
            int start = 0;
            int end = students.Length - 1;
            bool isFound = false;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (searchItem.Equals(students[mid].StudentId))
                {
                    isFound = true;
                    Console.WriteLine($"Result is {students[mid]}");
                    return mid;
                }
                else if (searchItem < students[mid].StudentId)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }

            }

            if (isFound == false)
            {
                Console.WriteLine("Falied!");
                // Console.WriteLine($"{searchItem} is not found");
            }
            return -1;

        }
        public static void TestSequentialSearch(Student[] students)
        {
            // Console.WriteLine("Enter Sequential Search Element");
            int inputId = 1;
            bool isFound = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (inputId == students[i].StudentId)
                {
                    Console.WriteLine("Search Student Id found at index : " + i);
                    // Console.WriteLine("Found!");
                    isFound = true;
                    break;
                }
            }
            if (isFound == false)
            {
                // Console.WriteLine("Search Student Id not Found");
                Console.WriteLine("Fail!");
            }
        }
        public static int BinarySearch(Student[] students)
        {
            Console.WriteLine("Enter Binary Search Element");
            int searchItem = int.Parse(Console.ReadLine());

            int start = 0;
            int end = students.Length - 1;
            bool isFound = false;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (searchItem.Equals(students[mid].StudentId))
                {
                    isFound = true;
                    Console.WriteLine($"Result is {students[mid]}");
                    return mid;
                }
                else if (searchItem < students[mid].StudentId)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }

            }

            if (isFound == false)
            {
                Console.WriteLine($"{searchItem} is not found");
            }
            return -1;

        }
        public static void SequentialSearch(Student[] students)
        {
            Console.WriteLine("Enter Sequential Search Element");
            int inputId = int.Parse(Console.ReadLine());
            bool isFound = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (inputId == students[i].StudentId)
                {
                    Console.WriteLine("Search Student Id found at index : " + i);
                    isFound = true;
                    break;
                }
            }
            if (isFound == false)
            {
                Console.WriteLine("Search Student Id not Found");
            }
        }

    }
}
