using System;

namespace Lab3
{
    class Program
    {
        public static void data_change(object sourse, DataChangedEventArgs args)
        {
            Console.WriteLine();
            Console.WriteLine(args.ToString());
        }
        static void Main(string[] args)
        {
            V3MainCollection test = new V3MainCollection();
            test.DataChanged += data_change;
            V3DataCollection vdc = new V3DataCollection("first", new DateTime(2020, 1, 1));
            V3DataOnGrid vdon = new V3DataOnGrid("second", new DateTime(2019, 2, 2), new Grid1D((float)0.25, 2), new Grid1D((float)0.3, 2));
            test.Add(vdc);
            Console.WriteLine(test.ToString());

            test.Add(vdon);
            Console.WriteLine(test.ToString());

            V3DataCollection vdc1 = new V3DataCollection("fourth", new DateTime(2018, 3, 3));
            test[1] = vdc1;
            Console.WriteLine(test.ToString());

            vdc.Info = "third";
            Console.WriteLine(test.ToString());

            test.Remove("fourth", new DateTime(2018, 3, 3));
            Console.WriteLine(test.ToString());
        }
    }
}
