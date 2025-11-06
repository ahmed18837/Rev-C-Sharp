using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1
{
    internal class Program
    {
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int divide(int nem, int dev, out int rem)
        {
            rem = nem % dev;
            return nem / dev;
        }

        static void Main(string[] args)
        {
            int x = default; // 0
            bool y = default; // false

            int aa = 5;
            int b = 10;
            swap(ref aa, ref b);

            Console.WriteLine(divide(aa, b, out int rem));

            string str = Console.ReadLine();

            int input = int.TryParse(str, out int result) ? result : -1;
            Console.WriteLine(input);


            Console.WriteLine("========== الفرق بين Parse / TryParse / Convert / discard ==========\n");

            // 1️⃣ Parse Example
            Console.WriteLine("1️ Parse Example:");
            string num1 = "123";
            int parsedValue = int.Parse(num1);
            Console.WriteLine($"Parse(\"{num1}\") = {parsedValue}");

            try
            {
                string invalid = "abc";
                int invalidParse = int.Parse(invalid); // هيرمى Exception
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Parse(\"abc\") ❌ خطأ: {ex.Message}");
            }

            Console.WriteLine("\n-------------------------------------------------\n");

            // 2️⃣ TryParse Example
            Console.WriteLine("2️ TryParse Example:");
            string num2 = "456";
            if (int.TryParse(num2, out int tryParseResult))
                Console.WriteLine($"TryParse(\"{num2}\") ✅ النتيجة: {tryParseResult}");
            else
                Console.WriteLine("TryParse(\"{num2}\") ❌ فشل التحويل");

            string invalidTry = "xyz";
            bool success = int.TryParse(invalidTry, out int invalidResult);
            Console.WriteLine($"TryParse(\"{invalidTry}\") = {success}, النتيجة = {invalidResult}");

            Console.WriteLine("\n-------------------------------------------------\n");

            // 3️⃣ Convert Example
            Console.WriteLine("3️ Convert Example:");
            string num3 = "789";
            int converted = Convert.ToInt32(num3);
            Console.WriteLine($"Convert.ToInt32(\"{num3}\") = {converted}");

            string nullValue = null;
            int nullConverted = Convert.ToInt32(nullValue);
            Console.WriteLine($"Convert.ToInt32(null) = {nullConverted}");

            try
            {
                string invalidConvert = "hello";
                int invalidConv = Convert.ToInt32(invalidConvert);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Convert.ToInt32(\"hello\") ❌ خطأ: {ex.Message}");
            }

            Console.WriteLine("\n-------------------------------------------------\n");

            // 4️⃣ Discard Example
            Console.WriteLine("4️ Discard Example:");
            string num4 = "999";
            if (int.TryParse(num4, out _))
                Console.WriteLine($"TryParse(\"{num4}\") ✅ لكن تجاهلنا القيمة باستخدام discard (_)");
            else
                Console.WriteLine("فشل التحويل");

            Console.WriteLine("\n========== الفرق بين ref و out ==========\n");

            // 5️⃣ ref Example
            int a = 10;
            Console.WriteLine($"قبل استدعاء الدالة RefExample: a = {a}");
            RefExample(ref a);
            Console.WriteLine($"بعد استدعاء RefExample: a = {a}\n");

            // 6️⃣ out Example
            int bb; // مش لازم نهيأه
            OutExample(out bb);
            Console.WriteLine($"بعد استدعاء OutExample: b = {bb}\n");

            Console.WriteLine("========== نهاية البرنامج ==========");
        }

        // 🧩 ref مثال
        static void RefExample(ref int number)
        {
            number += 5; // تعديل على نفس المتغير
            Console.WriteLine($"داخل الدالة RefExample: number = {number}");
        }

        // 🧩 out مثال
        static void OutExample(out int number)
        {
            // لازم ندي له قيمة
            number = 20;
            Console.WriteLine($"داخل الدالة OutExample: number = {number}");
        }

    }
}