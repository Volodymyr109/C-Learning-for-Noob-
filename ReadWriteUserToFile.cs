using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteToFile
{
    class Program
    {
        public static string DBFilePath { get; set; }

        static void Main(string[] args)
        {
            string fileDBName = "UsersDatabaseProgram.txt";
            string fileFolderPath = @"D:\ReadWriteUserToFile";
            DBFilePath = Path.Combine(fileFolderPath, fileDBName);

            if (!File.Exists(DBFilePath))
            {
                Directory.CreateDirectory(fileFolderPath); // Create the directory if it doesn't exist
                File.Create(DBFilePath).Close();
            }

            bool isWork = true;

            string allCommands = "\nPress 0 to Output all Users \nPress 1 to Add a new User \nPress 2 to Delete a User with ID \nPress 3 to Exit \n_________________________________________";

            while (isWork)
            {
                Console.WriteLine(allCommands);

                string inputCommandStr = Console.ReadLine();

                int inputCommand = 0;

                try
                {
                    inputCommand = int.Parse(inputCommandStr);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Command not exists");
                }

                switch (inputCommand)
                {
                    case 0:
                        {
                            var allUsers = ReadAllFromDB();
                            if (allUsers.Count == 0) Console.WriteLine("No Users found");
                            foreach (var user in allUsers) Console.WriteLine(user);
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Add Name: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("Add Surname: ");
                            string surname = Console.ReadLine();

                            Console.WriteLine("Add Email: ");
                            string email = Console.ReadLine();

                            Console.WriteLine("Add City: ");
                            string city = Console.ReadLine();

                            Console.WriteLine("Add Address: ");
                            string address = Console.ReadLine();

                            User newUser = new User(0, name, surname, email, city, address);
                            SaveToDB(newUser);

                            Console.WriteLine("User Saved to Database!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter User ID to Delete: ");

                            string idStr = Console.ReadLine();

                            int id = GetIntFromString(idStr);

                            if (id == 0)
                            {
                                Console.WriteLine("Id does not exist");
                            }
                            else
                            {
                                bool result = DeleteFromDB(id);

                                if (result)
                                {
                                    Console.WriteLine("User Deleted!");
                                }
                                else
                                {
                                    Console.WriteLine("Deleting Error");
                                }
                            }

                            break;
                        }
                    case 3:
                        {
                            isWork = false;
                            Console.WriteLine("Bye! Break!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Command doesn't exist, try again!");
                            break;
                        }
                }
            }
        }

        static int GetIntFromString(string inputStr)
        {
            int input = 0;
            try
            {
                input = int.Parse(inputStr);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Command not exists");
            }
            return input;
        }

        static void SaveToDB(User user)
        {
            List<User> allCurrentUsers = ReadAllFromDB();

            int lastId = allCurrentUsers.Count == 0 ? 0 : allCurrentUsers.Last().Id;

            user.SetNewId(lastId + 1);

            allCurrentUsers.Add(user);

            string serializedUsers = JsonConvert.SerializeObject(allCurrentUsers);

            File.WriteAllText(DBFilePath, serializedUsers);
        }

        static void SaveToDB(List<User> users)
        {

            string serializedUsers = JsonConvert.SerializeObject(users);

            File.WriteAllText(DBFilePath, serializedUsers);
        }

        static bool DeleteFromDB(int id)
        {
            List<User> allCurrentUsers = ReadAllFromDB();

            User userForDetelion = allCurrentUsers.FirstOrDefault(x => x.Id == id);

            bool result = false;

            if (userForDetelion != null)
            {
                allCurrentUsers.Remove(userForDetelion);
                SaveToDB(allCurrentUsers);
                result = true;
            }
            return result;
        }

        static List<User> ReadAllFromDB()
        {
            string json = File.ReadAllText(DBFilePath);

            List<User> currentUsers = JsonConvert.DeserializeObject<List<User>>(json);

            return currentUsers ?? new List<User>();
        }
    }

    class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        public string City { get; private set; }
        public string Address { get; private set; }

        public User(int id, string name, string surname, string email, string city, string address)
        {
            Id = id; 
            Name = name;
            Surname = surname;
            Email = email;
            City = city;
            Address = address;
        }

        public void SetNewId(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Surname} {Email} {City} {Address}";
        }
    }
}
