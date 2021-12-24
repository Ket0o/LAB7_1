public class Luggage
{
    public int count_object;
    public double total_weight_items;
}

public class Program
{
    public static void Main(string[] args)
    {
        List<double> numbers = new List<double>();

        Luggage luggage1 = new Luggage();
        luggage1.count_object = 1;
        luggage1.total_weight_items = 0.1;
        double c = (luggage1.total_weight_items) / (luggage1.count_object);
        c = Math.Round(c, 2);
        numbers.Add(c);

        Luggage luggage2 = new Luggage();
        luggage2.count_object = 2;
        luggage2.total_weight_items = 3;
        c = (luggage2.total_weight_items) / (luggage2.count_object);
        c = Math.Round(c, 2);
        numbers.Add(c);

        Luggage luggage3 = new Luggage();
        luggage3.count_object = 3;
        luggage3.total_weight_items = 4;
        c = (luggage3.total_weight_items) / (luggage3.count_object);
        c = Math.Round(c, 2);
        numbers.Add(c);

        Luggage luggage4 = new Luggage();
        luggage4.count_object = 4;
        luggage4.total_weight_items = 5;
        c = (luggage4.total_weight_items) / (luggage4.count_object);
        c = Math.Round(c, 2);
        numbers.Add(c);

        Luggage luggage5 = new Luggage();
        luggage5.count_object = 5;
        luggage5.total_weight_items = 0.6;
        c = (luggage5.total_weight_items) / (luggage5.count_object);
        c = Math.Round(c, 2);
        numbers.Add(c);

        Luggage luggage6 = new Luggage();
        luggage6.count_object = 6;
        luggage6.total_weight_items = 7;
        c = (luggage6.total_weight_items) / (luggage6.count_object);
        c = Math.Round(c, 2);
        numbers.Add(c);

        Luggage luggage7 = new Luggage();
        luggage7.count_object = 7;
        luggage7.total_weight_items = 8;
        c = (luggage7.total_weight_items) / (luggage7.count_object);
        c = Math.Round(c, 2);
        numbers.Add(c);

        Luggage luggage8 = new Luggage();
        luggage8.count_object = 8;
        luggage8.total_weight_items = 9;
        c = (luggage8.total_weight_items) / (luggage8.count_object);
        c = Math.Round(c, 2);
        numbers.Add(c);

        Luggage luggage9 = new Luggage();
        luggage9.count_object = 9;
        luggage9.total_weight_items = 10;
        c = (luggage9.total_weight_items) / (luggage9.count_object);
        c = Math.Round(c, 2);
        numbers.Add(c);

        Luggage luggage10 = new Luggage();
        luggage10.count_object = 10;
        luggage10.total_weight_items = 11;
        c = (luggage10.total_weight_items) / (luggage10.count_object);
        c = Math.Round(c, 2);
        numbers.Add(c);

        double average_weight_item = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            average_weight_item = average_weight_item + numbers[i];
        }
        average_weight_item = average_weight_item / 10;
        average_weight_item = Math.Round(average_weight_item, 2);

        List<double> Luggage_true = new List<double>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] >= average_weight_item - 0.3 && numbers[i] <= average_weight_item + 0.3)
            {
                Luggage_true.Add(i + 1);
            }
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine();

        for (int i = 0; i < Luggage_true.Count; i++)
        {
            Console.WriteLine(Luggage_true[i]);
        }

        Console.WriteLine();

        Console.WriteLine(Convert.ToString(Math.Round(average_weight_item - 0.3, 2)) + " -- " +  Convert.ToString(Math.Round(average_weight_item + 0.3, 2))) ;
    }
}
