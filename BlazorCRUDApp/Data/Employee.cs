namespace BlazorCRUDApp.Data
{
    public class Employee
    {
        public Guid Guid { get; set; }
        public int ID { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }


    }
}
