namespace _16.Task1.Models
{
    public class UniqueItem
    {
        private static int Id = default;
        public int ItemId { get; }
        
        public UniqueItem()
        {
            Id++;
            ItemId = Id;
        }
        
        public UniqueItem(int id)
        {
            Id = id;
            ItemId = Id;
        }
    }
}