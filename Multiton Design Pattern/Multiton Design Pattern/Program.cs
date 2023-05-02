var  MSSql = Database.GetInstance("MsSQL");
MSSql.Connection();
MSSql.DisConnection();

var MongoDb = Database.GetInstance("MongoDb");

var Oracle = Database.GetInstance("Oracle");
Oracle.Connection();
Oracle.DisConnection();

var MSSql1 = Database.GetInstance("MsSQL");
MSSql1.Connection();
MSSql1.DisConnection();

var MongoDb2 = Database.GetInstance("MongoDb");

var Oracle2 = Database.GetInstance("Oracle");
Oracle2.Connection();
Oracle2.DisConnection();

class Database
{
	private	Database()
	{
        Console.WriteLine($"{nameof(Database)} Creating class  ");
    }
	static Dictionary<string, Database> _Databases = new();

	public static Database GetInstance (String key)
	{
		if (!_Databases.ContainsKey(key))
			_Databases[key] = new Database();

		return _Databases[key];
	}
	public void Connection()
	{
		Console.WriteLine("Database Opeing...");
        Console.WriteLine();
    }
	public void DisConnection()
	{
		Console.WriteLine("Database Closing...");
        Console.WriteLine();
    }

}

