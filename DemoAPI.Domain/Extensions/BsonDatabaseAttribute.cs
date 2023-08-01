namespace DemoAPI.Domain.Extensions
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class BsonDatabaseAttribute : Attribute
    {
        public string DatabaseName { get; }
        public BsonDatabaseAttribute(string databaseName)
        {
            this.DatabaseName = databaseName;
        }
    }
}
