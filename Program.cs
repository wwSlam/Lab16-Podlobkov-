
// System.Console.Write("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];


// for (int i = 0; i < grades.Length; i++)
// {
//     System.Console.WriteLine($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
// }

// double sum = 0;
// foreach(int gradee in grades)
// {
//     sum += gradee;
// }
// System.Console.WriteLine($"средний балл {sum / grades.Length}" );


// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
// } //задание 1


// int[] points = { 4, 7, 2, 9, 5, 11 };

// for (int i = 0; i < points.Length; i++)
// {
//     if (points[i] < 10)
//     {
//           points[i] = points[i] + 1;
//     }
//     else
//     {
//         continue;
//     }
// }

// foreach (int point in points)
// {
//     System.Console.WriteLine(point);
// } // задание 2



// int[] grades = { 4, 5, 3, 5, 4, 2 };

// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[i] < grades[j + 1])
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }

// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
// } // 3 задание 


// int[] GenerateScheduleSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];

//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = i + 1;
//     }

//     return slots;
// }

// int[] slots = GenerateScheduleSlots(6);
// int[] GenerateEvenSlots(int lessonsCount)
// {
//     for (int j = 0; j < lessonsCount; j++)
//     {
//         if (slots[j] % 2 != 0)
//         {
//             slots[j] += 1;
//         }
//     }
//     return slots;
// }

// int[] slotsEven = GenerateEvenSlots(6);
// foreach (int slot in slotsEven)
// {
//     System.Console.WriteLine(slot);
// } //задание 4


