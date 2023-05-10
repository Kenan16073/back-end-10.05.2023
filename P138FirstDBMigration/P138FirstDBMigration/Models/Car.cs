namespace P138FirstDBMigration.Models
{
    public class Car
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public int ModelId { get; set; }

        public Model Model { get; set; }
    }
}
