namespace DesignPatterns.OpenClose
{
    public class LineItem
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public float Tax { get; set; } = 0;
    }
}
