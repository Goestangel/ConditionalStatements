using System;

class BonusScore
//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.
{
    static void Main()
    {
         int bonusScore = int.Parse(Console.ReadLine());
         switch (bonusScore)
          {
                 case 1:
                 case 2:
                 case 3: Console.WriteLine(bonusScore * 10); break;
                 case 4:
                 case 5:
                 case 6: Console.WriteLine(bonusScore * 100); break;
                 case 7:
                 case 8:
                 case 9: Console.WriteLine(bonusScore * 1000); break;
                 default: if ((bonusScore == 0) || (bonusScore > 9))
                 {
                     Console.WriteLine("invalid score"); ;
                 }
                 break;
            }
    }
}

