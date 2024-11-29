
namespace ConsoleApp1
{
    public class University
    {
        public string Name { get; set; }
        public int Rating { get; set; }

        public University(string name, int rating)
        {
            Name = name;
            Rating = rating;
        }
    }
}