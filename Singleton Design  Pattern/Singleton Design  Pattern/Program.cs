
DbConnection dbConnection = DbConnection.Connection;
dbConnection.OpenConnection();
dbConnection.CloseConnection();


DbConnection dbConnection2 = DbConnection.Connection;
dbConnection.OpenConnection();
dbConnection.CloseConnection();


DbConnection dbConnection3 = DbConnection.Connection;
dbConnection.OpenConnection();
dbConnection.CloseConnection();

class DbConnection
{
	private DbConnection()
	{
		Console.WriteLine($"{nameof(DbConnection)}s class connection is being created ");
	}

	private static DbConnection _connection;

	public static DbConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				_connection = new DbConnection();
			}
			return _connection;
		}
	}

	public void OpenConnection()
	{
		Console.WriteLine("Connection Open... ");
		Console.WriteLine();
	}

	public void CloseConnection()
	{
		Console.WriteLine("Connection Close...");
		Console.WriteLine();
	}
}

