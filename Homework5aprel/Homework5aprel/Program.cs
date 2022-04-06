using System;

namespace Homework5aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod -3 integer parametr qebul edir ve iclerinde en boyuk hansidirsa onu tapib return edir Eyni sekilde verilmis 4 ve 5 ededin en boyuyunu tapan metodlar da yazin(method overloading)
            //Console.WriteLine("Birinci ededi Daxil Et:");
            //string num1Str = Console.ReadLine();
            //Console.WriteLine("Ikinci ededi daxil Et:");
            //string num2Str = Console.ReadLine();
            //Console.WriteLine("Ucuncu ededi daxil Et:");
            //string num3Str = Console.ReadLine();
            //Console.WriteLine("Dorduncu ededi daxil Et:");
            //string num4Str = Console.ReadLine();
            //Console.WriteLine("Besinci ededi daxil Et:");
            //string num5Str = Console.ReadLine();
            //try
            //{
            //    int num1 = int.Parse(num1Str);
            //    int num2 = int.Parse(num2Str);
            //    int num3 = int.Parse(num3Str);
            //    int num4 = int.Parse(num4Str);
            //    int num5 = int.Parse(num5Str);

            //    BiggestNumber(num1, num2, num3, num4);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Yalniz Reqem Daxil Edile Biler");
            //}
            #endregion

            #region Task
            //Gonderilmis ededin reqemlerinin cemini qaytaran metod -misalcun bu metodu call ederken arqument olaraq 451 gondersek metoddan geriye 10 qayitmalidir
            //int num;
            //string stringNum = num.ToString();
            //int sum = 0;
            //SumOfDigits(num);


            //#endregion
        }


        #region Task1
        //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod - 3 integer parametr qebul edir ve iclerinde en boyuk hansidirsa onu tapib return edir Eyni sekilde verilmis 4 ve 5 ededin en boyuyunu tapan metodlar da yazin(method overloading)
        static void BiggestNumber(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"En boyuk eded num1-dir.Deyeri={num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"En boyuk eded num2-dir.Deyeri={num2}");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"En boyuk eded num3-dur. Deyeri={num3}");
            }
            else
            {
                Console.WriteLine("Ededler arasinda beraberlik var");
            }
        }
        static void BiggestNumber(int num1, int num2, int num3, int num4)
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"En boyuk eded num1-dir.Deyeri={num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"En boyuk eded num2-dir.Deyeri={num2}");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"En boyuk eded num3-dur. Deyeri={num3}");
            }
            else if (num4 > num1 && num4 > num2)
            {
                Console.WriteLine($"En boyuk eded num3-dur. Deyeri={num4}");
            }
            else
            {
                Console.WriteLine("Ededler arasinda beraberlik var");
            }
        }

        static void BiggestNumber(int num1, int num2, int num3, int num4, int num5)
        {

        }

        #endregion

        #region Task3
        //Gonderilmis ededin reqemlerinin cemini qaytaran metod -misalcun bu metodu call ederken arqument olaraq 451 gondersek metoddan geriye 10 qayitmalidir
//        static int SumOfDigits(int num)
//        {
          
//            for (int i = 0; i < stringNum.Length; i++)
//            {
//                sum += int.Parse(Convert.ToString(stringNum[i]));

//            }
//            if (num % 2 == 1)
//            {
//                sum += num;
//            }
//            return sum;
//        }
//        #endregion
//    }
//}