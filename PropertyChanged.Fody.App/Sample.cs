namespace PropertyChanged.Fody.App
{
    public class Sample : AbstractNotifyChanges
    {
        public Sample()
        {
        }

        public Sample(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DoNotNotify]
        public string FullName => $"{FirstName} {LastName}".Trim();
    }
}
