(int min, int max) GetMinMax(int a, int b)
{
    var min = Math.Min(a, b);
    var max = Math.Max(a, b);

    return (min, max);
}

var result = GetMinMax(1, 5);
