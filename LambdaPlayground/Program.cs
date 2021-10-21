string[] names = new string[] { "Wannes", "Kim" };

IEnumerable<string> Filter(string[] names, Func<string, bool> predicate)
{
    foreach (var name in names)
    {
        if (predicate(name))
            yield return name;
    }
}

Filter(names, (name) =>
{
    return name.Contains('K');
});
