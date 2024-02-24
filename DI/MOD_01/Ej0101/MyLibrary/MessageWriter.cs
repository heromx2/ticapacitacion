namespace MyLibrary
{
    public class MessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"MessageWriter.Write (Clase 'MessageWriter' y su método 'Write' ): {message}");
        }
    }
}
