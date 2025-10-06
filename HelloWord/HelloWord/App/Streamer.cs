namespace HelloWord.App
{
    public class Streamer
    {

        public string writePath = @"C:\Users\Utilizador\Desktop\DEV\C#\HelloWord\HelloWord\test.txt"; // change to your local path
        public string readPath = @"C:\Users\Utilizador\Desktop\DEV\C#\HelloWord\HelloWord\test.txt";

        public string content = "Hello, World! This is a test file.\nThis file is used to demonstrate file writing and reading in C#.\nHave a great day!";

        public void WriteFile()
        {
            if (File.Exists(writePath))
            {
                File.Delete(writePath);
            }
            File.WriteAllText(writePath, content);
        }

        public void ReadFile()
        {

            string readText = File.ReadAllText(readPath);
            Console.WriteLine(readText);
        }

    }
}
