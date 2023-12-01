var input = File.ReadAllLines("input.txt");

List<int> values = new List<int>();

foreach(var item in input)
{
    var first = item.First(c => char.IsDigit(c));
    var last = item.Last(c => char.IsDigit(c));

    char[] arrNumber = {first, last};

    values.Add(Convert.ToInt32(new string(arrNumber)));
}

Console.WriteLine(values.Sum());

