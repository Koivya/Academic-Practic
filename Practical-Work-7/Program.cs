using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PracticalWork7
{
    class Program
    {
        public static void Main(string[] args)
        {
                string diaryFilePath = "diary.json";
                List<DiaryItems> diaryItemsList;

                if (File.Exists(diaryFilePath))
                {
                    string diaryJson = File.ReadAllText(diaryFilePath);
                    diaryItemsList = JsonConvert.DeserializeObject<List<DiaryItems>>(diaryJson);
                }
                else
                {
                    diaryItemsList = new List<DiaryItems>();
                }

                while (true)
                {
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("1. Добавить задачу.");
                    Console.WriteLine("2. Удалить задачу.");
                    Console.WriteLine("3. Редактировать задачу.");
                    Console.WriteLine("4. Задачи на сегодня.");
                    Console.WriteLine("5. Задачи на завтра.");
                    Console.WriteLine("6. Задачи на неделю.");
                    Console.WriteLine("7. Список всех задач.");
                    Console.WriteLine("8. Список предстоящих задач.");
                    Console.WriteLine("9. Список выполненных задач.");
                    Console.WriteLine("10. Выйти из программы.");

                    int choice = GetChoice();

                    switch (choice)
                    {
                        case 1:
                        {
                            AddTask(diaryItemsList);
                            break;
                        }
                        case 2:
                        {
                            RemoveTask(diaryItemsList);
                            break;
                        }
                        case 3:
                        {
                            EditTask(diaryItemsList);
                            break;
                        }
                        case 4:
                        {
                            ViewTasksByDate(diaryItemsList, DateTime.Today);
                            break;
                        }
                        case 5:
                        {
                            ViewTasksByDate(diaryItemsList, DateTime.Today.AddDays(1));
                            break;
                        }
                        case 6:
                        {
                            ViewTasksByWeek(diaryItemsList);
                            break;
                        }
                        case 7:
                        {
                            ViewAllTasks(diaryItemsList);
                            break;
                        }
                        case 8:
                        {
                            ViewUpComingTasks(diaryItemsList);
                            break;
                        }
                        case 9:
                        {
                            ViewCompleteTasks(diaryItemsList);
                            break;
                        }
                        case 10:
                        {
                            string diaryJson = JsonConvert.SerializeObject(diaryItemsList);
                            File.WriteAllText(diaryFilePath, diaryJson);
                            return;
                        }
                        default:
                        {
                            Console.WriteLine("Некорректный ввод. Попробуйте снова.\n");
                            break;
                        }
                    }

                }

                static int GetChoice()
                {
                    while (true)
                    {
                        Console.Write("Действие: ");
                        if (int.TryParse(Console.ReadLine(), out int choice))
                        {
                            return choice;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Попробуйте снова.\n");
                        }
                    }
                }

                static void AddTask(List<DiaryItems> diaryItemsList)
                {
                    Console.WriteLine("Введите название задачи:");
                    string title = Console.ReadLine();
                    
                    Console.WriteLine("Введите описание задачи:");
                    string description = Console.ReadLine();
                    
                    Console.WriteLine("Введите дату завершения (формат: ГГГГ-ММ-ДД):");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
                    {
                        DiaryItems task = new DiaryItems
                        {
                            Title = title,
                            Description = description,
                            DueDate = dueDate
                        };
                        
                        diaryItemsList.Add(task);
                        Console.WriteLine("Задача успешно добавлена.\n");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный дата. Задача не добавлена.\n");
                    }
                }

                static void RemoveTask(List<DiaryItems> diaryItemsList)
                {
                    Console.WriteLine("Введите номер задачи для удаления:");
                    if (int.TryParse(Console.ReadLine(), out int taskNumber))
                    {
                        if (taskNumber >= 1 && taskNumber <= diaryItemsList.Count)
                        {
                            diaryItemsList.RemoveAt(taskNumber - 1);
                            Console.WriteLine("Задача успешно удалена.\n");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный номер задачи.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. ");
                    }
                }

                static void EditTask(List<DiaryItems> diaryItemsList)
                {
                    Console.WriteLine("Введите номер задачи для редактирования:");
                    if (int.TryParse(Console.ReadLine(), out int taskNumber))
                    {
                        if (taskNumber >= 1 && taskNumber <= diaryItemsList.Count)
                        {
                            DiaryItems task = diaryItemsList[taskNumber - 1];
                            
                            Console.WriteLine("Введите новое названия задачи:");
                            task.Title = Console.ReadLine();
                            
                            Console.WriteLine("Введите новое описание задачи:");
                            task.Description = Console.ReadLine();
                            
                            Console.WriteLine("Введите новую дату завершения задачи (формат: ГГГГ-ММ-ДД):");
                            if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
                            {
                                task.DueDate = dueDate;
                                Console.WriteLine("Задача отредактирована успешно.\n");
                            }
                            else
                            {
                                Console.WriteLine("Некорректная дата.\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный номер задачи.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод.\n");
                    }
                }

                static void ViewTasksByDate(List<DiaryItems> diaryItemsList, DateTime date)
                {
                    Console.WriteLine("Задачи на {0}", date.ToShortDateString());

                    bool foundTask = false;

                    foreach (DiaryItems task in diaryItemsList)
                    {
                        if (task.DueDate == date.Date)
                        {
                            Console.WriteLine("Название: {0}", task.Title);
                            Console.WriteLine("Описание: {0}", task.Description);
                            Console.WriteLine("Дата завершения: {0}", task.DueDate);
                            Console.WriteLine();

                            foundTask = true;
                        }
                    }

                    if (!foundTask)
                    {
                        Console.WriteLine("Нет задач на указанную дату.\n");
                    }
                }

                static void ViewTasksByWeek(List<DiaryItems> diaryItemsList)
                {
                    Console.WriteLine("Задачи на следующую неделю:");
                    DateTime endDate = DateTime.Today.AddDays(7);

                    bool foundTask = false;

                    foreach (DiaryItems task in diaryItemsList)
                    {
                        if (task.DueDate.Date >= DateTime.Today.Date && task.DueDate.Date <= endDate.Date)
                        {
                            Console.WriteLine("Название: {0}", task.Title);
                            Console.WriteLine("Описание: {0}", task.Description);
                            Console.WriteLine("Дата завершения: {0}", task.DueDate);
                            Console.WriteLine();

                            foundTask = true;
                        }
                    }
                    
                    if (!foundTask)
                    {
                        Console.WriteLine("Нет задач на следующию неделю.\n");
                    }
                }

                static void ViewAllTasks(List<DiaryItems> diaryItemsList)
                {
                    Console.WriteLine("Все задачи:");
                    if (diaryItemsList.Count == 0)
                    {
                        Console.WriteLine("Список задач пуст.\n");
                    }

                    for (int i = 0; i < diaryItemsList.Count; i++)
                    {
                        DiaryItems task = diaryItemsList[i];
                        Console.WriteLine($"{i + 1}. {task.Title}, Дата завершения: {task.DueDate}.\n");
                    }
                }

                static void ViewUpComingTasks(List<DiaryItems> diaryItemsList)
                {
                    Console.WriteLine("Предстоящие задачи:");

                    bool foundTask = false;

                    foreach (DiaryItems task in diaryItemsList)
                    {
                        if (task.DueDate >= DateTime.Today)
                        {
                            Console.WriteLine("Название: {0}", task.Title);
                            Console.WriteLine("Описание: {0}", task.Description);
                            Console.WriteLine("Дата завершения: {0}", task.DueDate);
                            Console.WriteLine();

                            foundTask = true;
                        }
                    }

                    if (!foundTask)
                    {
                        Console.WriteLine("Нет предстоящих задач.\n");
                    }
                }

                static void ViewCompleteTasks(List<DiaryItems> diaryItemsList)
                {
                    Console.WriteLine("Выполненные задачи:");

                    bool foundTask = false;

                    foreach (DiaryItems task in diaryItemsList)
                    {
                        if (task.DueDate < DateTime.Today)
                        {
                            Console.WriteLine("Название: {0}", task.Title);
                            Console.WriteLine("Описание: {0}", task.Description);
                            Console.WriteLine("Дата завершения: {0}", task.DueDate);
                            Console.WriteLine();

                            foundTask = true;
                        }
                    }

                    if (!foundTask)
                    {
                        Console.WriteLine("Нет выполненных задач.\n");
                    }
                }
        }
    }

    class DiaryItems
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }
} 
