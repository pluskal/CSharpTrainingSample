using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace DataGridDataTable
{
  public partial class ManualDataTable : Form
  {
    private readonly BindingSource _bindingSource1 = new BindingSource();
    private SqlDataAdapter _dataAdapter;
    private string _connectionString;

    public ManualDataTable()
    {
      InitializeComponent();
      // Specify a connection string. Replace the given value with a 
      // valid connection string for a SQL Server sample
      // database accessible to your system.
      _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CookBook.DAL.CookBookDbContext;Integrated Security=True;";

    }

    private void OnLoad(object sender, EventArgs e)
    {
      // Bind the DataGridView to the BindingSource
      // and load the data from the database.
      dataGridView1.DataSource = _bindingSource1;
      GetData("SELECT * FROM IngredientEntities");
    }

    private void GetData(string selectCommand)
    {
      try
      {
        // Create a new data adapter based on the specified query.
        _dataAdapter = new SqlDataAdapter(selectCommand, _connectionString);
        
        // Populate a new data table and bind it to the BindingSource.
        var table = new DataTable {Locale = CultureInfo.InvariantCulture};
        _dataAdapter.Fill(table);
        _bindingSource1.DataSource = table;

        // Resize the DataGridView columns to fit the newly loaded content.
        dataGridView1.AutoResizeColumns(
          DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
      }
      catch (SqlException)
      {
        MessageBox.Show("To run this example, replace the value of the " +
                        "connectionString variable with a connection string that is " +
                        "valid for your system.");
      }
    }

    private void insert_Click(object sender, EventArgs e)
    {
      using (SqlDataAdapter adapter = new SqlDataAdapter())
      using (var connection = new SqlConnection(this._connectionString))
      {
        try
        {
          connection.Open();
          _dataAdapter.InsertCommand = new SqlCommand("INSERT INTO IngredientEntities(Id, Name, Description) VALUES(@Id, @Name, @Description)");
          _dataAdapter.InsertCommand.Connection = connection;
          _dataAdapter.InsertCommand.CommandType = CommandType.Text;
          _dataAdapter.InsertCommand.Parameters.Clear();
          _dataAdapter.InsertCommand.Parameters.AddWithValue("@Id", typeof(Guid)).Value = Guid.NewGuid();
          _dataAdapter.InsertCommand.Parameters.AddWithValue("@Name", typeof(string)).Value = NameTextBox.Text;
          _dataAdapter.InsertCommand.Parameters.AddWithValue("@Description", typeof(string)).Value = DescriptionTextBox.Text;
          _dataAdapter.InsertCommand.ExecuteNonQuery();
          MessageBox.Show("Row inserted !! ");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
      }
    }

    private void save_Click(object sender, EventArgs e)
    {
      // Update the database with the user's changes.
      _dataAdapter.Update((DataTable) _bindingSource1.DataSource);
    }

    private void reload_Click(object sender, EventArgs e)
    {
      // Reload the data from the database.
      GetData(_dataAdapter.SelectCommand.CommandText);
    }
  }
}