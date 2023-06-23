using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Nhập câu:");
        string sentence = Console.ReadLine();
        int averageLetters = Check(sentence);
        Console.WriteLine("Trung bình số chữ cái trên mỗi từ là: " + averageLetters);
    }

    public static int Check(string sentence)
    {
        string[] words = sentence.Split(' ');
        int totalLetters = 0;
        int validWordCount = 0;

        foreach (string word in words)
        {
            if (word.Length >= 2)
            {
                totalLetters += word.Length;
                validWordCount++;
            }
        }

        return validWordCount > 0 ? totalLetters / validWordCount : 0;
    }
}