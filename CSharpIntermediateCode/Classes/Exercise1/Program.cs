using System;

namespace Exercise1
{
    // ************************* StopWatch *************************
    public class Program
    {
        static void Main(string[] args)
        {
            StopWatchControls();
        }

        public static void StopWatchControls()
        {
            StopWatch stopWatch = null;

            while (true)
            {
                Console.WriteLine("Enter one of the options:\n1.Start stop watch \n2.Stop stop watch \n3.Reset \n4.Exit: ");
                int inputVal = Convert.ToInt32(Console.ReadLine());
                bool shouldExit = false;


                switch (inputVal)
                {
                    case 1:
                        if (stopWatch == null)
                        {
                            stopWatch = new StopWatch();
                            stopWatch.Start();
                        }
                        else
                        {
                            Console.WriteLine("Stopwatch already running");
                        }
                        break;
                    case 2:
                        var timeSpent = stopWatch?.Stop();
                        if (timeSpent != null)
                        {
                            Console.WriteLine("Time spent: " + timeSpent);
                        }
                        break;
                    case 3:
                        stopWatch.Reset();
                        break;
                    case 4:
                        shouldExit = true;
                        break;
                    default:
                        Console.WriteLine("Enter valid Input");
                        break;
                }
                if (shouldExit)
                {
                    break;
                }
            }
        }
    }

    

}
