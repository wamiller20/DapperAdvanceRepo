namespace RepoExample.Entities
{
    public interface IPerson
    {
        int AdditionalContactInfo { get; set; }
        int Demographics { get; set; }
        int EmailPromotion { get; set; }
        int FirstName { get; set; }
        int LastName { get; set; }
        int MiddleName { get; set; }
        int ModifiedDate { get; set; }
        int NameStyle { get; set; }
        int PersonType { get; set; }
        int Rowguid { get; set; }
        int Suffix { get; set; }
        int Title { get; set; }
    }
}