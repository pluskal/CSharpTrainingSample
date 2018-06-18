namespace DataGridDataTable
{
  partial class GeneratedDataTable
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ingredientEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this._CookBook_DAL_CookBookDbContextDataSet = new DataGridDataTable._CookBook_DAL_CookBookDbContextDataSet();
      this.ingredientEntitiesTableAdapter = new DataGridDataTable._CookBook_DAL_CookBookDbContextDataSetTableAdapters.IngredientEntitiesTableAdapter();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.NameTextBox = new System.Windows.Forms.TextBox();
      this.DescriptionTextBox = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ingredientEntitiesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this._CookBook_DAL_CookBookDbContextDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.ingredientEntitiesBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(2, 94);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(686, 344);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      // 
      // descriptionDataGridViewTextBoxColumn
      // 
      this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
      this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
      this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
      // 
      // ingredientEntitiesBindingSource
      // 
      this.ingredientEntitiesBindingSource.DataMember = "IngredientEntities";
      this.ingredientEntitiesBindingSource.DataSource = this._CookBook_DAL_CookBookDbContextDataSet;
      this.ingredientEntitiesBindingSource.CurrentChanged += new System.EventHandler(this.ingredientEntitiesBindingSource_CurrentChanged);
      // 
      // _CookBook_DAL_CookBookDbContextDataSet
      // 
      this._CookBook_DAL_CookBookDbContextDataSet.DataSetName = "_CookBook_DAL_CookBookDbContextDataSet";
      this._CookBook_DAL_CookBookDbContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // ingredientEntitiesTableAdapter
      // 
      this.ingredientEntitiesTableAdapter.ClearBeforeFill = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(694, 120);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Save";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Name";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Description";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // NameTextBox
      // 
      this.NameTextBox.Location = new System.Drawing.Point(92, 13);
      this.NameTextBox.Name = "NameTextBox";
      this.NameTextBox.Size = new System.Drawing.Size(100, 20);
      this.NameTextBox.TabIndex = 4;
      this.NameTextBox.TextChanged += new System.EventHandler(this.Name_TextChanged);
      // 
      // DescriptionTextBox
      // 
      this.DescriptionTextBox.Location = new System.Drawing.Point(92, 39);
      this.DescriptionTextBox.Name = "DescriptionTextBox";
      this.DescriptionTextBox.Size = new System.Drawing.Size(364, 20);
      this.DescriptionTextBox.TabIndex = 5;
      this.DescriptionTextBox.TextChanged += new System.EventHandler(this.Description_TextChanged);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(695, 94);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 6;
      this.button2.Text = "Insert";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // GeneratedDataTable
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.DescriptionTextBox);
      this.Controls.Add(this.NameTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "GeneratedDataTable";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ingredientEntitiesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this._CookBook_DAL_CookBookDbContextDataSet)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private _CookBook_DAL_CookBookDbContextDataSet _CookBook_DAL_CookBookDbContextDataSet;
    private System.Windows.Forms.BindingSource ingredientEntitiesBindingSource;
    private _CookBook_DAL_CookBookDbContextDataSetTableAdapters.IngredientEntitiesTableAdapter ingredientEntitiesTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox NameTextBox;
    private System.Windows.Forms.TextBox DescriptionTextBox;
    private System.Windows.Forms.Button button2;
  }
}

