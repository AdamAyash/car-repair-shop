#region
using Microsoft.Data.SqlClient;
#endregion

/// <summary></summary>
public class DatabaseConnection
{
    //-------------------------
    //Constants:
    //-------------------------
    private const string CREDITIONALS =
            @"Data Source=DESKTOP-CREALSR\AAYASH;
            Initial Catalog=CarRepairShop;
           Integrated Security=True;
            TrustServerCertificate=True;";

    //-------------------------
    //Members:
    //-------------------------

    private SqlConnection _connection;

    private static DatabaseConnection? _datebaseConnectionInsatnce = null;

    //-------------------------
    //Properties:
    //-------------------------
    public SqlConnection Connection
    {
        get
        {
            return _connection;
        }

        private set { }
    }

    //-------------------------
    //Constructor/Destructor:
    //-------------------------
    private DatabaseConnection()
    {
    }

    ~DatabaseConnection()
    {
        CloseConnection();
    }

    //-------------------------
    //Methods:
    //-------------------------
    public static DatabaseConnection GetDatebaseConnectionInstance()
    {
        if (_datebaseConnectionInsatnce == null)
        {
            _datebaseConnectionInsatnce = new DatabaseConnection();
        }

        return _datebaseConnectionInsatnce;
    }

    public void OpenConnection()
    {
        _connection = new SqlConnection(CREDITIONALS);
        _connection.Open();
    }

    private void CloseConnection()
    {
        _connection.Close();
    }

    //-------------------------
    //Overrides:
    //-------------------------
}
