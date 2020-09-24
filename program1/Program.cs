using System;

namespace program1
{
    class program
    {

    

    static int Main(string[] args)
    {
        int[] num = new int[10];

        var first = num.GetLowerBound(0);
        var second = num.GetLowerBound(1);
        if (first == second)
            return first;
        while (true)
        {

                if(second - first == 1)
                {
                    if(num[first] == 0)
                        return first;
                    if (num[second] == 0)
                        return second;
                    return -1;
                    
                }
                else
                {
                    var third = first + (second - first) / 2;
                    var Result = num[third];
                    if(Result == 0)
                    {
                        Console.WriteLine("Нашёл число" + third);
                        return third;
                    }
                    if (Result < 0)
                       first = third;
                    if (Result > 0)
                        second = third;
                }

        }
    }

    }
}
