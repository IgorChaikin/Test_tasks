using System;
using System.Linq;
using System.Collections.Generic;
using Igor_Chaikin_test_tasks_1_3.Entities;
using System.Text.Json;
using System.IO;

namespace Igor_Chaikin_test_tasks_1_3
{
    class Program
    {
        // method of console application which writes every Vehicle type name to the console, sorted alphabetically.
        static void PrintSortedTypes(IEnumerable<Type> types) {
            IEnumerable<string> sortedNames = types
                .Select(type => type.Name)
                .OrderBy(name => name);
            foreach (string name in sortedNames) {
                Console.WriteLine(name);
            }
        }

        // method which can search for types by specifying part of the name
        static IEnumerable<Type> FindBySubstring(IEnumerable<Type> types, string namePart)
        {
            IEnumerable<Type> filtredTypes = types
                .Where(type => type.Name.ToLower().Contains(namePart.ToLower()));
            return filtredTypes;
        }

        // method which can write all instances returned from InstanceService.GetInstances() to disk
        static void WriteInstancesToDisk(IEnumerable<object> instances, string folderPath)
        {
            foreach (object instance in instances) {
                string serializedInstance = JsonSerializer.Serialize(instance);
                // create unique filename for save instance to disk
                string fileName = $"{instance.GetType().Name}_{instance.GetHashCode()}";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                File.WriteAllText($"{folderPath}/{fileName}.json", serializedInstance);
            }
        }

        static void Main(string[] args)
        {
            // get Vehicle class instances
            InstanceService<Vehicle> instanceService = new InstanceService<Vehicle>();
            IEnumerable<Vehicle> vehicleInstances = instanceService.GetInstances();

            // get types for testing console application methods that work with types
            IEnumerable<Type> vehicleTypes = vehicleInstances.Select(instance => instance.GetType());

            // test task 3.1
            PrintSortedTypes(vehicleTypes);
            Console.WriteLine();

            // test task 3.2
            // output: ["Bicycle", "Motorbike"]
            IEnumerable<Type> test_1 = FindBySubstring(vehicleTypes, "bi");
            foreach (Type searchResultElement in test_1) {
                Console.WriteLine(searchResultElement.Name);
            }
            Console.WriteLine();

            // output: ["Truck"]
            IEnumerable<Type> test_2 = FindBySubstring(vehicleTypes, "uc");
            foreach (Type searchResultElement in test_2)
            {
                Console.WriteLine(searchResultElement.Name);
            }
            Console.WriteLine();

            // output: []
            IEnumerable<Type> test_3 = FindBySubstring(vehicleTypes, "boat");
            foreach (Type searchResultElement in test_3)
            {
                Console.WriteLine(searchResultElement.Name);
            }
            Console.WriteLine();

            // test task 3.3
            // path to folder: "[PATH_TO_PROJECT_FOLDER]/outputs"
            WriteInstancesToDisk(vehicleInstances, "../../../outputs");
        }
    }
}
