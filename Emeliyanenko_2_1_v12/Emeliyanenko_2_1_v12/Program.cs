using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Emeliyanenko_2_1_v12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        //Begin2.Дана сторона квадрата a.Найти его площадь S = a2.
        /*int lenght = 5;
        Console.WriteLine(Math.Pow(lenght, 2));*/




























//Begin22.Поменять местами содержимое переменных A и B и вывести новые значения A и B.
/*int a22 = 10;
        int b22 = 21;
        int temp22 = a22;
        a22 = b22;
b22 = temp22;
Console.WriteLine($"a: {a22}  b: {b22}");*/


























//Begin32.Дано значение температуры T в градусах Цельсия.Определить значение этой же температуры в градусах Фаренгейта.Температура по Цельсию TC и температура по Фаренгейту TF связаны следующим соотношением: TC = (TF − 32)·5/9.
/*float cel = 32;
        float fr = (cel / (5.0f / 9.0f)) + 32;
        Console.WriteLine(fr.ToString("0.0"));*/




























//Integer2.Дана масса M в килограммах.Используя операцию деления нацело, найти количество полных тонн в ней(1 тонна = 1000 кг).
/*int kg = 14500;
        Console.WriteLine(kg / 1000);*/





























//Integer22.С начала суток прошло N секунд(N — целое). Найти количество секунд, прошедших с начала последнего часа.
/*int seconds = 36243;
        Console.WriteLine(seconds % 3600);*/




























//Integer30.Дан номер некоторого года(целое положительное число). Определить соответствующий ему номер столетия, учитывая, что, к примеру, началом 20 столетия был 1901 год.
/*int year = 2030;
        Console.WriteLine((year / 100) + 1);*/




























//Boolean2.Дано целое число A.Проверить истинность высказывания: «Число A является нечетным».
/*int num = 12;
        Console.WriteLine(num % 2 != 0);*/





























//Boolean22.Дано трехзначное число.Проверить истинность высказывания: «Цифры данного числа образуют возрастающую или убывающую последовательность».
/*a22 = 4321;
Console.WriteLine((((a22 / 100) > (a22 % 100 / 10)) & ((a22 % 100 / 10) > (a22 % 10))) | (((a22 / 100) < (a22 % 100 / 10)) & ((a22 % 100 / 10) < (a22 % 10))));*/




























//Boolean32.Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника.Проверить истинность высказывания: «Треугольник со сторонами a, b, c является прямоугольным».
/*int a32 = 4, b32 = 3, c32 = 6;
        Console.WriteLine((a32* a32 == b32* b32 + c32* c32) | (b32* b32 == a32* a32 + c32* c32) | (c32* c32 == a32* a32 + b32* b32));*/



























        //If2.Дано целое число.Если оно является положительным, то прибавить к нему 1; в противном случае вычесть из него 2. Вывести полученное число.
/*int num2 = 13;
if (num2 >= 0)
    num2++;
else
    num2 -= 2;
Console.WriteLine(num2);*/



























//If12.Даны три числа.Найти наименьшее из них.
/*int a12 = 23, b12 = 0, c12 = 34;
if (a12 >= b12 && a12 >= c12)
    Console.WriteLine(a12);
if (b12 >= a12 && b12 >= c12)
    Console.WriteLine(b12);
if (c12 >= b12 && c12 >= a12)
    Console.WriteLine(c12);*/


























//If22.Даны координаты точки, не лежащей на координатных осях OX и OY.Определить номер координатной четверти, в которой находится данная точка.
/*int x22 = 2;
        int y22 = -2;
if ((x22 > 0) & (y22 > 0)) Console.WriteLine("I");
else if ((x22< 0) & (y22 > 0)) Console.WriteLine("II");
else if ((x22< 0) & (y22< 0)) Console.WriteLine("III");
else Console.WriteLine("IV");*/

























//Case2.Дано целое число K.Вывести строку-описание оценки, соответствующей числу K (1 — «плохо», 2 — «неудовлетворительно», 3 — «удовлетворительно», 4 — «хорошо», 5 — «отлично»). Если K не лежит в диапазоне 1–5, то вывести строку «ошибка».
/*int estimation = 5;
switch (estimation)
{
    case 1:
        Console.WriteLine("Плохо");
        break;
    case 2:
        Console.WriteLine("Неудовлетворительно");
        break;
    case 3:
        Console.WriteLine("Удовлетворительно");
        break;
    case 4:
        Console.WriteLine("Хорошо");
        break;
    case 5:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Ошибка");
        break;
}*/


















    //Case12.Элементы окружности пронумерованы следующим образом: 1 — радиус R, 2 — диаметр D = 2 R, 3 — длина L = 2 π R, 4 — площадь круга S = π R2.Дан номер одного из этих элементов и его значение. Вывести значения остальных элементов данной окружности (в том же порядке). В качестве значения π использовать 3.14.
/*int n12 = 2;
    float x = 5, r = 3, d = 4, l = 6, s = 1;

switch (n12)
{
    case 1:
        r = x;
        d = 2 * r;
    l = 2 * 3.14f * r;
    s = 3.14f * r * r;
    Console.WriteLine("{0} {1} {2}", d, l, s);
        break;
    case 2:
        r = x / 2;
        d = x;
        l = 2 * 3.14f * r;
    s = 3.14f * r * r;
    Console.WriteLine("{0} {1} {2}", r, l, s);
        break;
    case 3:
        r = x / 2 * 3.14f;
        d = 2 * r;
    l = x;
        s = 3.14f * r * r;
    Console.WriteLine("{0} {1} {2}", r, d, s);
        break;
    case 4:
        r = (float) Math.Sqrt(x / 3.14f);
    d = 2 * r;
    l = 2 * 3.14f * r;
    s = x;
        Console.WriteLine("{0} {1} {2}", r, d, l);
        break;
}*/












//For2.Даны два целых числа A и B (A < B). Вывести в порядке возрастания все целые числа, расположенные между A и B (включая сами числа A и B), а также количество N этих чисел.
/*int numA = 4, numB = 10, count = 0;
for (int i = numA; i <= numB; i++)
{
    count++;
    Console.Write(i + " ");
}
Console.WriteLine(count);*/

























//For12.Дано целое число N (> 0). Найти произведение 1.1 · 1.2 · 1.3 · . . . (N сомножителей).
/*n12 = 2;
float res = 1;
for (float i = 1; i < n12; i += 0.1f)
{
    res *= i;
}
Console.WriteLine(res.ToString("0.00"));*/


























//While2.Даны положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений). Не используя операции умножения и деления, найти количество отрезков B, размещенных на отрезке A.
/*numA = 42; numB = 10; count = 0;
while (numA >= numB)
{
    numA -= numB;
    count++;
}
Console.WriteLine(count);*/

























//While12.Дано целое число N (> 1). Вывести наибольшее из целых чисел K, для которых сумма 1 + 2 + . . . + K будет меньше или равна N, и саму эту сумму.
/*int k = 0, temp = 0;
while (!(temp + k + 1 > n12))
{
    ++k;
    temp += k;
}
Console.WriteLine($"{k} {temp}");*/


























//While22.Дано целое число N (> 1). Если оно является простым, то есть не имеет положительных делителей, кроме 1 и самого себя, то вывести TRUE, иначе вывести FALSE.
/*int n22 = 13;
while ((n22 > 0) & ((n22 % 10) % 2 == 0))
{
    n22 /= 10;
}

Console.WriteLine((n22 % 10) % 2 != 0 ? "True" : "False");*/

























//Series12.Дан набор ненулевых целых чисел; признак его завершения — число 0. Вывести количество чисел в наборе.
/*Console.WriteLine(GetCountAtZero(new int[] { 1, 2, 3, 4, 5, 6, 7, 9, 0, 6, 5 }));

static int GetCountAtZero(int[] ints)
{
    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] <= 0)
        {
            return i;
        }
    }
    return 0;
}*/






















//Series22.Дано целое число N (> 1) и набор из N вещественных чисел. Если данный набор образует убывающую последовательность, то вывести 0; в противном случае вывести номер первого числа, нарушающего закономерность.
/*ints = new List<int>() { 9, 8, 6, 5, 4, 3, 6, 2, 1 };
bool isTrue = true;
for (int i = ints.Count - 1; i > 0; i--)
{
    if (ints[i] < ints[i - 1])
    {
        isTrue = false;
        Console.Write((i + 1) + " ");
    }
}
if (isTrue) Console.WriteLine(0);*/
























//Proc2.Описать процедуру PowerA234(A, B, C, D), вычисляющую вторую, третью и четвертую степень числа A и возвращающую эти степени соответственно в переменных B, C и D (A — входной, B, C, D — выходные параметры; все параметры являются вещественными). С помощью этой процедуры найти вторую, третью и четвертую степень пяти данных чисел.
/*int A = 4, B, C, D;
B = A * A;
C = B * A;
D = B * B;
Console.WriteLine($"B={B} C={C} D={D}");*/

























//Proc12.Описать процедуру SortInc3(A, B, C), меняющую содержимое переменных A, B, C таким образом, чтобы их значения оказались упорядоченными по возрастанию (A, B, C — вещественные параметры, являющиеся одновременно входными и выходными). С помощью этой процедуры упорядочить по возрастанию два данных набора из трех чисел: (A1, B1, C1) и(A2, B2, C2).
/*int resA, resB, resC;
SortInc3(5, 3, 6, out resA, out resB, out resC);
Console.WriteLine($"{resA} { resB} { resC}");
SortInc3(15, 35, 26, out resA, out resB, out resC);
Console.WriteLine($"{resA} {resB} {resC}");*/

























//Proc22.Описать функцию Calc(A, B, Op) вещественного типа, выполняющую над ненулевыми вещественными числами A и B одну из арифметических операций и возвращающую ее результат. Вид операции определяется целым параметром Op: 1 — вычитание, 2 — умножение, 3 — деление, остальные значения — сложение. С помощью Calc выполнить для данных A и B операции, определяемые данными целыми N1, N2, N3.
/*int A = 21;
int B = 12;
Console.WriteLine(calc(A, B, 3));

static float calc(float a, float b, int op)
{
    switch (op)
    {
        case 1:
            return a - b;
            break;
        case 2:
            return a * b;
            break;
        case 3:
            return a / b;
            break;
        default:
            return a + b;
            break;
    }
}*/
















//Minmax2.Дано целое число N и набор из N прямоугольников, заданных своими сторонами — парами чисел (a, b). Найти минимальную площадь прямоугольника из данного набора.
/*int[] intsA = { 3, 5, 6, 2, 4, 7 };
int[] intsB = { 8, 4, 3, 6, 8, 2 };
int min = 0;
for (int i = 0; i < intsA.Length; i++)
{
    if (intsA[i] * intsB[i] > min)
    {
        min = intsA[i] * intsB[i];
    }
}
Console.WriteLine(min);*/
























//Minmax22.Дано целое число N (> 2) и набор из N чисел. Найти два наименьших элемента из данного набора и вывести эти элементы в порядке возрастания их значений.
/*List<int> ints2 = new List<int>() { 4, 2, 5, 8, 6, 7, 8, 3, 4, 0 };
ints2.Sort();
Console.WriteLine($"{ints2[0]} {ints2[1]}");*/




























//Array2.Дано целое число N (> 0). Сформировать и вывести целочисленный массив размера N, содержащий степени двойки от первой до N-й: 2, 4, 8, 16, . . . .
/*int n = 10;
int[] ints1 = new int[n];
ints1[0] = 2;
for (int i = 1; i < n; i++)
{
    ints1[i] = ints1[i - 1] * 2;
    Console.Write(ints1[i] + " ");
}
Console.WriteLine();*/

























//Array22.Дан массив размера N и целые числа K и L (1 < K L N ). Найти сумму всех элементов массива, кроме элементов с номерами от K до L включительно.
/*int n = 13;
int[] ints1 = new int[n];
int k = 2;
int l = 5;
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    ints1[i] = rnd.Next(3000);
}
for (int i = 0; i < n; i++)
{
    if (i < k || i >= l)
    {
        Console.Write(ints1[i] + " ");
    }
}
Console.WriteLine();*/




















//Matrix2.Даны целые положительные числа M и N. Сформировать целочисленную матрицу размера M × N, у которой все элементы J -го столбца имеют значение 5·J (J = 1, . . ., N).
/*int M = 5, N = 10;
int[,] a = new int[M, N];
for (int row = 0; row < M; ++row)
{
    for (int col = 1; col < N; ++col)
    {
        a[row, col] = 5 * col;
    }
}
for (int row = 0; row < M; ++row)
{
    for (int col = 1; col < N; ++col)
    {
        Console.Write(a[row, col] + " ");
    }
    Console.WriteLine();
}*/




















//Matrix22.Дана матрица размера M N. Для каждого столбца матрицы с четным номером (2, 4, . . .) найти сумму его элементов. Условный оператор не использовать.
/*int s;
for (int i = 1; i < N; i += 2)
{
    s = 0;
    for (int j = 0; j < M; ++j)
        s += a[j, i];
    Console.Write(s + " ");
}
Console.WriteLine();*/

























//String2.Дано целое число N (32 N 126). Вывести символ с кодом, равным N.
/*int n = 35;
Console.WriteLine(Convert.ToChar(n));*/





























//String22.Дана строка, изображающая целое положительное число. Вывести сумму цифр этого числа.
/*string numsS = "43562";
int n = 0;
for (int i = 0; i < numsS.Length; i++)
{
    n += int.Parse(numsS[i].ToString());
}
Console.WriteLine(n);*/


























//File2.Дано имя файла и целое число N (> 1). Создать файл целых чисел с данным именем и записать в него N первых положительных четных чисел (2, 4, . . .).
/*int n = 30;
string save = "";
for (int i = 0; i < n; i++)
{
    if (i > 0 && i % 2 == 0)
    {
        save += i + " ";
    }
}
File.WriteAllText($"numers_{n}.txt", save);*/
























//Text2.Дано имя файла и целое число N (0 < N < 27). Создать текстовый файл с указанным именем и записать в него N строк: первая строка должна содержать строчную (то есть маленькую) латинскую букву «a», вторая— буквы «ab», третья — буквы «abc» и т. д.; последняя строка должна содержать N начальных строчных латинских букв в алфавитном порядке.
/*int n = 20;
string chars = "abcdefghijklmnopqrstuvwxyz";
string save = "";
for (int i = 1; i <= n; i++)
{
    for (int j = 0; j < i; j++)
    {
        save += chars[j];
    }
    save += "\n";
}
File.WriteAllText($"chars_{n}.txt", save);*/





















//Text22.Дано целое число K (0 < K < 10) и текстовый файл, содержащий более K строк. Удалить из файла последние K строк.
/*int k = 9;
string[] fileReads = File.ReadLines("strings2.txt").ToArray();
fileWrite = "";
for (int i = 0; i < fileReads.Length - k; i++)
{
    fileWrite += fileReads[i] + "\n";
}
File.WriteAllText("strings3.txt", fileWrite);*/
























//Param2.Описать функцию MaxNum(A, N ) целого типа, находящую номер максимального элемента вещественного массива A размера N. С помощью этой функции найти номера максимальных элементов массивов A, B, C размера NA, NB, NC соответственно.
/*int[] intsA2 = { 4,5,2,1,5,7 }, intsB2 = { 5,6,8,9,5,0,2}, intsC2 = { 2,5,7,4,4,4,56};
Console.WriteLine(MaxNum(intsA2, intsA2.Length));
Console.WriteLine(MaxNum(intsB2, intsB2.Length));
Console.WriteLine(MaxNum(intsC2, intsC2.Length));

static int MaxNum(int[] a, int n)
{
    int max = 0;
    int index = 0;
    for (int i = 0; i < n; i++)
    {
        if (max < a[i])
        {
            max = a[i];
            index = i;
        }
    }
    return index;
}*/



















//Recur2.Описать рекурсивную функцию Fact2(N ) вещественного типа, вычисляющую значение двойного факториала N!! = N·(N−2)·(N−4)·. . . (N > 0 — параметр целого типа; последний сомножитель в произведении равен 2, если N — четное число, и 1, если N — нечетное). С помощью этой функции вычислить двойные факториалы пяти данных чисел.
/*Console.WriteLine(Fact2(7));

static double Fact2(double n)
{
    double result = 1;
    for (int i = n % 2 == 0 ? 2 : 1; i <= n; i += 2)
    {
        result *= i;
    }
    return result;
}*/






















//Dynamic2.Дан адрес P1 записи типа TNode. Эта запись связана полем Next со следующей записью того же типа, она, в свою очередь, — со следующей, и так далее до записи, поле Next которой равно nil (таким образом, возникает цепочка связанных записей). Вывести значения полей Data для всех элементов цепочки, длину цепочки (то есть число ее элементов) и адрес ее последнего элемента.
/*Address P =  new Address() { Id = 0, Date = 12, Next = new Address() { Id = 1, Date = 490, Next = new Address() { Id = 2, Date = 4940, Next = new Address() { Id = 3, Date = 123, Next = null } } } };
Address next = P;
count = 1;
while (next != null)
{
    Console.WriteLine($"Date: {next.Date}");
    if (next.Next == null)
    {
        Console.WriteLine($"Lenght: {count} Last index: {next.Id}");
    }
    next = next.Next;
    count++;
}*/

    }
}
