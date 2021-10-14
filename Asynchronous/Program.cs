var lines = await File.ReadAllLinesAsync("largefile.txt");

lines
    .Where(line => line.StartsWith("this"))
    .Count();