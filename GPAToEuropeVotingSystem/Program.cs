using System.Threading.Channels;
bool w = true;
bool y = true;
bool z = true;
Console.WriteLine("Please input which conversion would you like to do, based on these numbers \n 1. Europe Grade to GPA  \n 2. GPA to Europe Grade");

while (y)
{
    try
    {
        int x = Convert.ToInt32(Console.ReadLine());
        y = false;
        while (w)
        {
            if (x != 1 && x != 2)
            {
                Console.WriteLine("Wrong number detected, please retry.");
                
                x = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                switch (x)
                {

                    case 1:

                        Console.WriteLine("Please input the grade you want to convert, from 4 to 10.");
                        while (z)
                        {
                            double a = double.Parse(Console.ReadLine());

                            if (a <= 10 && a >= 4)
                            {
                                double gradeEtoG = (4*a-16) / 6;
                                Console.WriteLine("The result is {0}", gradeEtoG);
                                z = false;
                            }
                            else
                            {
                                Console.WriteLine("Wrong number detected, please retry.");

                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Please input the grade you want to convert, from 0 to 4.");
                        while (z)
                        {
                            double a = double.Parse(Console.ReadLine());

                            if (a >= 0 && a <= 4)
                            {
                                double gradeGtoE= (1.5*a)+4;
                                Console.WriteLine("The result is {0}", gradeGtoE);
                                z = false;
                            }
                            else
                            {
                                Console.WriteLine("Wrong number detected, please retry.");

                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong number detected, please retry.");
                        break;

                }
                w = false;
            }
        }
    }
    catch
    {
        Console.WriteLine("Wrong format detected, please retry again.");
    }
    
}

