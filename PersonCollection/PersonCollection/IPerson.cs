namespace PersonCollection
{
    public interface IPerson
    {
        public int getId();
        public String getFirstName();
        public String getLastName();
        public DateTime getDateOfBirth();
        public int getHeight();
    }
}