using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Fun_eg
    {
        static int[] GetNumbers()
        {
            int[] numbers = { 10, 20, 30, 40 };
            return numbers;
        }
        public static void Start()
        {
            int[] result = GetNumbers();
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }

            string[] resString = GetNames();
            foreach (string str in resString)
            {
                Console.WriteLine($"{str}");
            }
            static string[] GetNames()
            {
                return new string[] { "java", "php", "ASP" };
            }

            int[] arr = { 10, 2, 4, 5, 6, 7, 8, 9 };
            printarr(arr);
            static void printarr(int[] arr)
            {
                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
            }

            int[,] mat = GetMatrix();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            static int[,] GetMatrix()
            {
                int[,] result =
                {
                    {1,2,3},
                    {4,5,6},
                    {7,8,9}
                };
                return result;
            }

            Person[] resultPerson = GetPeople();
            foreach (Person p in resultPerson)
            {
                Console.WriteLine($"name:{p.Name},Age:{p.Age}");
            }
        }
            class Person{
                public string Name;
                public int Age;
            }
        static Person[] GetPeople() {
            Person[] people = new Person[2];
            people[0] = new Person { Name = "abhi", Age = 25 };
            people[1] = new Person { Name = "abhin", Age = 25 };
            return people;
        }
        }
    }

