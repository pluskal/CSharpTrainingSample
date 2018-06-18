namespace DataGridDataTable
{
  partial class ManualDataTable
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
      this.Insert = new System.Windows.Forms.Button();
      this.DescriptionTextBox = new System.Windows.Forms.TextBox();
      this.NameTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.Save = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ingredientEntitiesBindingSource)).BeginInit();
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
      this.dataGridView1.Location = new System.Drawing.Point(16, 94);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(686, 344);
      this.dataGridView1.TabIndex = 7;
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
      // Insert
      // 
      this.Insert.Location = new System.Drawing.Point(709, 94);
      this.Insert.Name = "Insert";
      this.Insert.Size = new System.Drawing.Size(75, 23);
      this.Insert.TabIndex = 13;
      this.Insert.Text = "Insert";
      this.Insert.UseVisualStyleBackColor = true;
      this.Insert.Click += new System.EventHandler(this.insert_Click);
      // 
      // DescriptionTextBox
      // 
      this.DescriptionTextBox.Location = new System.Drawing.Point(106, 39);
      this.DescriptionTextBox.Name = "DescriptionTextBox";
      this.DescriptionTextBox.Size = new System.Drawing.Size(364, 20);
      this.DescriptionTextBox.TabIndex = 12;
      // 
      // NameTextBox
      // 
      this.NameTextBox.Location = new System.Drawing.Point(106, 13);
      this.NameTextBox.Name = "NameTextBox";
      this.NameTextBox.Size = new System.Drawing.Size(100, 20);
      this.NameTextBox.TabIndex = 11;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(27, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 13);
      this.label2.TabIndex = 10;
      this.label2.Text = "Description";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(27, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Name";
      // 
      // Save
      // 
      this.Save.Location = new System.Drawing.Point(708, 120);
      this.Save.Name = "Save";
      this.Save.Size = new System.Drawing.Size(75, 23);
      this.Save.TabIndex = 8;
      this.Save.Text = "Save";
      this.Save.UseVisualStyleBackColor = true;
      this.Save.Click += new System.EventHandler(this.save_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(709, 149);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 14;
      this.button1.Text = "Reload";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.reload_Click);
      // 
      // ManualDataTable
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.Insert);
      this.Controls.Add(this.DescriptionTextBox);
      this.Controls.Add(this.NameTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Save);
      this.Name = "ManualDataTable";
      this.Load += new System.EventHandler(this.OnLoad);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ingredientEntitiesBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource ingredientEntitiesBindingSource;
    private System.Windows.Forms.Button Insert;
    private System.Windows.Forms.TextBox DescriptionTextBox;
    private System.Windows.Forms.TextBox NameTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button Save;
    private System.Windows.Forms.Button button1;
  }
}