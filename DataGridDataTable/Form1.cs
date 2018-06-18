using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridDataTable
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the '_CookBook_DAL_CookBookDbContextDataSet.IngredientEntities' table. You can move, or remove it, as needed.
      FillDataTable();
    }

    private void FillDataTable()
    {
      this.ingredientEntitiesTableAdapter.Fill(this._CookBook_DAL_CookBookDbContextDataSet.IngredientEntities);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.ingredientEntitiesTableAdapter.Adapter.Update(this._CookBook_DAL_CookBookDbContextDataSet
        .IngredientEntities);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.ingredientEntitiesTableAdapter.Insert(Guid.NewGuid(), this.Name.Text, this.Description.Text);
      FillDataTable();
    }
  }
}
