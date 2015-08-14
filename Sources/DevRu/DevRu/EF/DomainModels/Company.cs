namespace DevRu.EF.DomainModels
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public string OfficialName { get; set; }
        public int EmployeesQty { get; set; }
        public short EstablishYear { get; set; }
        public string Description { get; set; }
    }
}
