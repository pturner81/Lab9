using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{

    class Program
    {
        static void Main(string[] args)
        {
            //declares object list
            List<Students> students = new List<Students>();
            //instanciates object list
            ObjectProperties(students);

            string ContinueOption = "y";
            while (ContinueOption == "y")
            {
                PrintList(students);

                Console.WriteLine("Type 'learn' to learn about a new student or 'new' to enter an additional student");
                string LearnOrNew = Console.ReadLine();
                LearnOrNew = LearnorNewVal(LearnOrNew);

                if (LearnOrNew == "learn")
                {
                    Console.WriteLine("Which student would you like to learn about?");
                    string WhichStudent = Console.ReadLine();
                    int WhichStudentVal = ValidateInt(WhichStudent);
                    WhichStudentVal = IsOption(WhichStudentVal, students);
                    Console.WriteLine($"What would you like to know about {students[WhichStudentVal - 1].StudentName}: Favorite Food or Hometown?");
                    string FoodOrHome = Console.ReadLine();
                    FoodOrHome = ValidateString(FoodOrHome);
                    FoodOrHome = ValidateFoodHome(FoodOrHome);
                    if (FoodOrHome == "favorite food")
                    {
                        Console.WriteLine($"{students[WhichStudentVal - 1].StudentName}'s {FoodOrHome} is {students[WhichStudentVal - 1].FavoriteFood}");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine($"{students[WhichStudentVal - 1].StudentName}'s {FoodOrHome} is {students[WhichStudentVal - 1].Hometown}");
                        Console.WriteLine(" ");
                    }
                }
                else
                {
                    Students temp = new Students();
                    Console.WriteLine("What is the name of the student you would like to add?");
                    string NewStudent = ValidateString(Console.ReadLine());
                    temp.StudentName = NewStudent;

                    Console.WriteLine($"What is {NewStudent}'s favorite food?");
                    string NewFavFood = ValidateString(Console.ReadLine());
                    temp.FavoriteFood = NewFavFood;

                    Console.WriteLine($"What is {NewStudent}'s Hometown?");
                    string NewHometown = ValidateString(Console.ReadLine());
                    temp.Hometown = NewHometown;

                    students.Add(temp);
                }
                Console.WriteLine("Would you like to view/add another student? Type 'y' for main menu");
                ContinueOption = ValidateString(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Thank you! Press any key to exit");
        }

        private static void ObjectProperties(List<Students> students)
        {
            Students Student1 = new Students();
            Student1.StudentName = "Student1";
            Student1.FavoriteFood = "Food1";
            Student1.Hometown = "Hometown1";
            students.Add(Student1);

            Students Student2 = new Students();
            Student2.StudentName = "Student2";
            Student2.FavoriteFood = "Food2";
            Student2.Hometown = "Hometown2";
            students.Add(Student2);

            Students Student3 = new Students();
            Student3.StudentName = "Student3";
            Student3.FavoriteFood = "Food3";
            Student3.Hometown = "Hometown3";
            students.Add(Student3);

            Students Student4 = new Students();
            Student4.StudentName = "Student4";
            Student4.FavoriteFood = "Food4";
            Student4.Hometown = "Hometown4";
            students.Add(Student4);

            Students Student5 = new Students();
            Student5.StudentName = "Student5";
            Student5.FavoriteFood = "Food5";
            Student5.Hometown = "Hometown5";
            students.Add(Student5);
        }

        public static void PrintList(List<Students> students)
        {
            int x = 1;
            foreach (Students s in students)
            {
                Console.WriteLine($"{x}) {s.StudentName}");
                x = x + 1;
                Console.WriteLine("=================");
            }
        }
        public static string LearnorNewVal(string UserInput2)
        {
            while (UserInput2 != "learn" && UserInput2 != "new")
            {
                Console.WriteLine("That is not an option - Please select a valid option");
                UserInput2 = Console.ReadLine();
                UserInput2 = ValidateString(UserInput2);
            }
            if (UserInput2 == "learn")
            {
                return "learn";
            }
            return "new";
        }
        public static string ValidateString(string UserInput)
        {//Catches Hackers
            try
            {
                UserInput = UserInput.ToLower();
                return (UserInput);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return "0";
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                return "0";
            }
        }
        public static int ValidateInt(string UserInput1)
        {
            try
            {
                int.Parse(UserInput1);
                return (int.Parse(UserInput1));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                return 0;
            }
        }
        public static int IsOption(int validatedInput, List<Students> students)
        {
            while (validatedInput <= 0 || validatedInput >= students.Count + 1)
            {
                Console.WriteLine("That is not an option- Please enter a valid number/option");
                string UserInput = Console.ReadLine();
                validatedInput = ValidateInt(UserInput);
            }
            return validatedInput;


        }
        public static string ValidateFoodHome(string UserInput2)
        {
            while (UserInput2 != "food" && UserInput2 != "favorite food" && UserInput2 != "hometown" && UserInput2 != "home")
            {
                Console.WriteLine("That is not an option - Please select a valid option");
                UserInput2 = Console.ReadLine();
                UserInput2 = ValidateString(UserInput2);
            }
            if (UserInput2 == "food" || UserInput2 == "favorite food")
            {
                return "favorite food";
            }
            return "Hometown";
        }
    }
}
