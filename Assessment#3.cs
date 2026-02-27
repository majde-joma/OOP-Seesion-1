using System;
using System.Collections.Generic;

namespace Proiect_3
{
    class TaskItem
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string description)
        {
            Description = description;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{Description} - {(IsCompleted ? "✅ Completed" : "⏳ Pending")}";
        }
    }

    class ToDoList
    {
        private List<TaskItem> tasks = new List<TaskItem>();

        public void AddTask(string description)
        {
            tasks.Add(new TaskItem(description));
            Console.WriteLine("Task added successfully!");
        }

        public void ViewTasks()
        {
            // التحقق إذا كانت القائمة فارغة عند العرض
            if (tasks.Count == 0)
            {
                Console.WriteLine("\n⚠️ You don’t have any tasks.");
                return;
            }

            Console.WriteLine("\n📋 Your Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        public void MarkAsCompleted(int index)
        {
            // 1. التحقق أولاً إذا كانت القائمة فارغة
            if (tasks.Count == 0)
            {
                Console.WriteLine("\n⚠️ You don’t have any tasks.");
                return;
            }

            // 2. التحقق من صحة الرقم المدخل (Index)
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index].IsCompleted = true;
                Console.WriteLine("Task marked as completed!");
            }
            else
            {
                Console.WriteLine($"\n❌ There is no task with index = {index + 1}.");
            }
        }

        public void RemoveTask(int index)
        {
            // 1. التحقق أولاً إذا كانت القائمة فارغة
            if (tasks.Count == 0)
            {
                Console.WriteLine("\n⚠️ You don’t have any tasks.");
                return;
            }

            // 2. التحقق من صحة الرقم المدخل (Index)
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                Console.WriteLine("Task removed successfully!");
            }
            else
            {
                Console.WriteLine($"\n❌ There is no task with index = {index + 1}.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoList list = new ToDoList();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n📌 TO-DO LIST APP");
                Console.WriteLine("1 Add Task\n2 View Tasks\n3 Mark Completed\n4 Remove Task\n5 Exit");
                Console.Write("Option: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Write("Description: ");
                    list.AddTask(Console.ReadLine());
                }
                else if (input == "2")
                {
                    list.ViewTasks();
                }
                else if (input == "3")
                {
                    Console.Write("Task Number: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        list.MarkAsCompleted(num - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
                else if (input == "4")
                {
                    Console.Write("Task Number: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        list.RemoveTask(num - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
                else if (input == "5")
                {
                    running = false;
                }
            }
        }
    }
}
