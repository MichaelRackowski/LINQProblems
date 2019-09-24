using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problem_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem number 1
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //var wordsWithTh = words.Where(w => w.Contains("th"));
            //foreach (var word in wordsWithTh)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.ReadLine();


            //problem number 2
            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //var singleName = names.Select(n => n).Distinct();
            //foreach (var name in singleName)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //problem number 2
            //List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            //var studentGrades = new List<int>();
            //double classAverage = 0;

            //foreach (var grade in classGrades)
            //{
            //    studentGrades = grade.Split(',').Select(g => int.Parse(g)).ToList();
            //    var gradeValue = studentGrades.Where(s => s != studentGrades.Min()).Average();
            //    classAverage += gradeValue;
            //}
            //Console.WriteLine(classAverage / classGrades.Count);
            //Console.ReadLine();



            string str = "Terrill";
            char[] characterArray = str.ToUpper().ToArray();
            Array.Sort(characterArray);

            str = new string(characterArray);
            var frequencyOfCharacters =
                from x in str.ToArray()
                group x by x into y
                select y;
            var result = "";

            foreach (var character in frequencyOfCharacters)
            {
                result += character.Key + "" + character.Count();
            }
            Console.WriteLine(result);
            Console.ReadLine();
            





        }
    }
}
