using Football.File;

namespace Football
{
    public class Program
    {
        public static void Main(String[] args)
        {
            FileAssistant fileAssistant = new FileAssistant();
            List<List<string>> list = fileAssistant.Read("../../KEA-CS-FOOTBALL/csv files/");

            fileAssistant.format(list);
            
        }
    }
}