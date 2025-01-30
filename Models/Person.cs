using ValidotPOC.Validators;

namespace ValidotPOC.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public Ocupation Ocupation { get; set; }
        public Address Address { get; set; } = new();
        public bool HasDifferentMailingAddress { get; set; }
        public Address MailingAddress { get; set; } = new();
    }

    public enum Ocupation
    {
        Dr,
        Nurse,
        Cop
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
