
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


// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(grades);

// foreach (int grade in grades) {
//     Console.WriteLine(grade);
// } //задание 5


// System.Console.WriteLine();
// System.Console.WriteLine("Задание А");

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int[] numbers = new int[num];

// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = (i + 1) * (i + 1);
// }

// foreach (int item in numbers)
// {
//     Console.Write(item + " ");
// }


// System.Console.WriteLine();
// System.Console.WriteLine("Задание Б");

// int[] numbers = { 1, -1, -4, -5, 24, 25 };

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] < 0)
//     {
//         numbers[i] = 0;
//     }
// }
// foreach (int number in numbers)
// {
//     System.Console.Write(number + " ");
// }


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


System.Console.WriteLine();
System.Console.WriteLine("Задание 1");

System.Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
int total = 0;

int[] massiv = new int[N];

for (int i = 0; i < massiv.Length; i++)
{
    Console.Write("Введите числа для массива: ");
    massiv[i] = int.Parse(Console.ReadLine());
    total += massiv[i];
}

System.Console.WriteLine($"Сумма масива {total}");

System.Console.WriteLine("Сам массив: ");
foreach (int mass in massiv)
{
    System.Console.Write(mass + " ");
}

System.Console.WriteLine();
System.Console.WriteLine("Задание 10");

int[] secund = { 144, 214, 23, 21, 24, 214};

Array.Sort(secund);

int max = secund[secund.Length - 1];
int secondMax = max;

for (int i = secund.Length - 1; i >= 0; i--)
{
    if (secund[i] < max) 
    {
        secondMax = secund[i];
        break; 
    }
}

System.Console.WriteLine($"Второе по величине число: {secondMax}");