namespace domain.Entities
{
    internal class Category
    {


        private int Reference { get; set; }
        private string Name { get; set; }
        public Category(int reference, string name)
        {
            Reference = reference;
            Name = name;
        }
    }
}
