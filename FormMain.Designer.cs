
namespace MultipleDatabases
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.listBoxDatabaseName = new System.Windows.Forms.ListBox();
      this.labelListOfDatabaseName = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // listBoxDatabaseName
      // 
      this.listBoxDatabaseName.FormattingEnabled = true;
      this.listBoxDatabaseName.ItemHeight = 16;
      this.listBoxDatabaseName.Location = new System.Drawing.Point(27, 54);
      this.listBoxDatabaseName.Name = "listBoxDatabaseName";
      this.listBoxDatabaseName.Size = new System.Drawing.Size(198, 356);
      this.listBoxDatabaseName.TabIndex = 0;
      // 
      // labelListOfDatabaseName
      // 
      this.labelListOfDatabaseName.AutoSize = true;
      this.labelListOfDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelListOfDatabaseName.Location = new System.Drawing.Point(27, 13);
      this.labelListOfDatabaseName.Name = "labelListOfDatabaseName";
      this.labelListOfDatabaseName.Size = new System.Drawing.Size(179, 20);
      this.labelListOfDatabaseName.TabIndex = 1;
      this.labelListOfDatabaseName.Text = "List of Database name";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.labelListOfDatabaseName);
      this.Controls.Add(this.listBoxDatabaseName);
      this.Name = "FormMain";
      this.Text = "Multiple databases";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBoxDatabaseName;
    private System.Windows.Forms.Label labelListOfDatabaseName;
  }
}

