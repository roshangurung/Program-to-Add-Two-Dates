using System;
namespace DateAndTime
{
    class Program
    {
        static int Main()/////This C# program is used to add two dates. DateTime, is a structure that is available from the System namespace within the base class libraries. This structure has a static method called ‘Now’ that returns the current time. There are a large number of additional data members and methods within the DateTime structure. Here the new date is found by adding using function AddDays().///
        {
            DateTime SDate = new DateTime(2010, 10, 7);
            Console.WriteLine("Starting Date : {0}", SDate);
            DateTime EDate = startDate.AddDays(10);
            Console.WriteLine("Ending Date   : {0}\n", EDate);
            Console.ReadLine();
            return 0;
        }
    }
}
///Output:Starting Date : 10/7/2010  12:00:00 AM
//////////Ending Date   : 10/17/2010 12:00:00 AM