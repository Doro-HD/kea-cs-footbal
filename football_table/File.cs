namespace Football.File
{
    public class FileAssistant
    {
        public List<List<string>> Read(string path)
        {
            var lines = new List<List<string>>();
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var columns = line.Split(',');
                    var columnList = new List<string>(columns);
                    lines.Add(columnList);
                }
            }
            return lines;
        }

        public void format(List<List<string>> lines)
        {

            foreach (var line in lines)
            {
                foreach (var column in line)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
