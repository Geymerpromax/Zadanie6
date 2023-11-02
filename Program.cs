using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    internal class Program
    {
        static double Ax = 0;
        static double Ay = 0;
        static double Az = 0;

        static double Bx = 0;
        static double By = 0;
        static double Bz = 0;

        static double Cx = 0;
        static double Cy = 0;
        static double Cz = 0;
        static double Mod_a = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Начало Работы");
            ReadTxtFile("C:\\Users\\Руслан\\Desktop\\Программинг\\Z6.txt");
        }

        static void ReadTxtFile(string fileName)
        {
            List<string> list = new List<string>();
            string line;
            try
            {
                StreamReader sr = new StreamReader(fileName);
                line = sr.ReadLine();
                while (line != null)
                {
                    list.Add(line);
                    line = sr.ReadLine();                   
                }
                
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            finally
            {
                StringToInt(list);
                Console.WriteLine("Чтение файла успешно завершено.");
            }
        }
       
        static double Length(double X, double Y, double Z)
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        static void StringToInt(List<string> text)
        {           
            string str = "";        
            
            int ZapNum = -1;
            int ZapCount = 0;
        

            for (int i = 0; i < text.Count; i++)
            {
                Console.WriteLine("Задание " + (i+1));
                for (int j = 0; j < text[i].Length; j++)
                {
                    if (text[i][j] == ',')
                    {
                        for (int k = ++ZapNum; k < j; k++)
                        {
                            str += text[i][k];
                        }
                        ZapNum = j;
                        ZapCount++;
                        if (ZapCount == 1)
                        {
                            Ax = Convert.ToInt32(str);
                            str = "";
                        }
                        else if (ZapCount == 2)
                        {
                            Ay = Convert.ToInt32(str);
                            str = "";
                        }
                        else if (ZapCount == 3)
                        {
                            Az = Convert.ToInt32(str);
                            str = "";
                        }
                        else if (ZapCount == 4)
                        {
                            Bx = Convert.ToInt32(str);
                            str = "";
                        }
                        else if (ZapCount == 5)
                        {
                            By = Convert.ToInt32(str);
                            str = "";
                        }
                        else if (ZapCount == 6)
                        {
                            Bz = Convert.ToInt32(str);
                            str = "";
                        }
                        else if (ZapCount == 7)
                        {
                            Cx = Convert.ToInt32(str);
                            str = "";
                        }
                        else if (ZapCount == 8)
                        {
                            Cy = Convert.ToInt32(str);
                            str = "";
                        }
                        else if (ZapCount == 9)
                        {
                            Cz = Convert.ToInt32(str);
                            str = "";
                        }
                        else if (ZapCount == 10)
                        {
                            string operand = "";
                            int operandNum = -1;
                            int operandCount = 0;

                            int firstMultiplier = 1;
                            int secondMultiplier = 1;

                            string Point = "";
                            string firstValue = "";
                            string secondValue = "";
                            string firstPoint = "";
                            string secondPoint = "";

                            var ArrNum = "0123456789";
                            //var ArrABC = "ABC";
                            var Arr = "+-";                            

                            for (int f = 0; f < str.Length; f++)
                            {
                                if (Arr.Contains(str[f]))
                                {
                                    operand = Convert.ToString(str[f]);
                                    for (int l = 0; l < ++operandNum; l++)
                                    {
                                        Point += str[l];
                                    }
                                    operandNum = f;
                                    operandCount++;
                                    if (operandCount == 1)
                                    {
                                        firstValue = Point;
                                        Point = "";
                                        
                                        switch (firstValue.Length)
                                        {
                                            case 2:
                                                firstPoint = ($"{firstValue[0] + firstValue[1]}");
                                                break;
                                            case 3:
                                                firstMultiplier = Convert.ToInt32(firstValue[0]);
                                                firstPoint = ($"{firstValue[1] + firstValue[2]}");
                                                break;
                                        }
                                        //Здесь перебирать варианты сочетаний вектора 1
                                    }
                                    else if (operandCount == 2)
                                    {
                                        secondValue = Point;
                                        Point = "";
                                        switch (secondValue.Length)
                                        {
                                            case 2:
                                                secondPoint = ($"{secondValue[0] + secondValue[1]}");
                                                break;
                                            case 3:
                                                secondMultiplier = Convert.ToInt32(secondValue[0]);
                                                secondPoint = ($"{secondValue[1] + secondValue[2]}");
                                                break;                                         
                                        }
                                        //Здесь перебирать варианты сочетаний вектора 2
                                    }
                                }

                            }
                        }
                        else if (ZapCount == 11)
                        {
                            string b = str;
                        }
                        else if (ZapCount == 12)
                        {
                            string c = str;
                        }
                        else if (ZapCount == 13)
                        {
                           string l = str;
                        }
                        else if (ZapCount == 14)
                        {
                            string alpha = str;
                        }
                        else if (ZapCount == 15)
                        {
                           string betta = str;
                        }
                    }

                }
                Console.WriteLine($"Условие:\n  Координаты точек: A({Ax}, {Ay},{Az}) B({Bx}, {By}, {Bz}) C({Cx}, {Cy}, {Cz})");
                Console.WriteLine(" a = ");
                Console.WriteLine("Решение: ");
            }
            //switch ()
            //{
            //    case 1:
            //        Ax = X;
            //        Ay = Y;
            //        Az = Z;
            //        break;
            //    case 2:
            //        Bx = X;
            //        By = Y;
            //        Bz = Z;
            //        break;
            //    case 3:
            //        Cx = X;
            //        Cy = Y;
            //        Cz = Z;
            //        break;
            //    default:
            //        Console.WriteLine("Error"); 
            //        break;
            //}

        }

        static void GetLenght_a(List<string> text, int num)
        {
            
           
        }
    }
}
