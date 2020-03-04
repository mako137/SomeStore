namespace SomeStoreDBCodeFirst.Model
{
    public class Building
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public int NumbOfBuilding { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}