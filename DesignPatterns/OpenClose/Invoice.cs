namespace DesignPatterns.OpenClose
{
    public class Invoice
    {
        public IEnumerable<LineItem> Items { get; }
        public string Number { get; set; }
        public string Title { get; set; }

        public float Total { get; set; }
        
        
        public Invoice(IEnumerable<LineItem> items, string number, string title)
        {
            Items = items;
            Number = number;
            Title = title;

            Total = CalculateTotal();
        }

        private float CalculateTotal()
        {
            float totalSum = 0;
            foreach (var ss in Items)
            {
                totalSum += ss.Price + (ss.Price * (1 - ss.Tax));
            }

            return totalSum;
        }
    }
}
