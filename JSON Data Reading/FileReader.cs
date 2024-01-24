namespace JSON_Data_Reading
{
    internal class FileReader
    {
        //Fields
        private readonly string _fileDirectory = "src";
        private readonly string[]? _fileNames;

        //Constructor
        public FileReader()
        {
            try
            {
                _fileNames = Directory.GetFiles(_fileDirectory);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error Occurred: {e.Message}");
            }
        }

        //Properties
        public string[]? FileNames => _fileNames;
    }
}
