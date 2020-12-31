
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
      this.textBoxSearchingBill = new System.Windows.Forms.TextBox();
      this.labelSearchingBill = new System.Windows.Forms.Label();
      this.buttonSearchBill = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // listBoxDatabaseName
      // 
      this.listBoxDatabaseName.FormattingEnabled = true;
      this.listBoxDatabaseName.Location = new System.Drawing.Point(20, 44);
      this.listBoxDatabaseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.listBoxDatabaseName.Name = "listBoxDatabaseName";
      this.listBoxDatabaseName.Size = new System.Drawing.Size(150, 290);
      this.listBoxDatabaseName.TabIndex = 0;
      // 
      // labelListOfDatabaseName
      // 
      this.labelListOfDatabaseName.AutoSize = true;
      this.labelListOfDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelListOfDatabaseName.Location = new System.Drawing.Point(20, 11);
      this.labelListOfDatabaseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelListOfDatabaseName.Name = "labelListOfDatabaseName";
      this.labelListOfDatabaseName.Size = new System.Drawing.Size(150, 17);
      this.labelListOfDatabaseName.TabIndex = 1;
      this.labelListOfDatabaseName.Text = "List of Database name";
      // 
      // textBoxSearchingBill
      // 
      this.textBoxSearchingBill.Location = new System.Drawing.Point(243, 44);
      this.textBoxSearchingBill.Name = "textBoxSearchingBill";
      this.textBoxSearchingBill.Size = new System.Drawing.Size(122, 20);
      this.textBoxSearchingBill.TabIndex = 2;
      this.textBoxSearchingBill.Text = "852012001";
      // 
      // labelSearchingBill
      // 
      this.labelSearchingBill.AutoSize = true;
      this.labelSearchingBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSearchingBill.Location = new System.Drawing.Point(240, 9);
      this.labelSearchingBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelSearchingBill.Name = "labelSearchingBill";
      this.labelSearchingBill.Size = new System.Drawing.Size(125, 17);
      this.labelSearchingBill.TabIndex = 3;
      this.labelSearchingBill.Text = "Recherche facture";
      // 
      // buttonSearchBill
      // 
      this.buttonSearchBill.Location = new System.Drawing.Point(405, 40);
      this.buttonSearchBill.Name = "buttonSearchBill";
      this.buttonSearchBill.Size = new System.Drawing.Size(75, 23);
      this.buttonSearchBill.TabIndex = 4;
      this.buttonSearchBill.Text = "Rechercher";
      this.buttonSearchBill.UseVisualStyleBackColor = true;
      this.buttonSearchBill.Click += new System.EventHandler(this.ButtonSearchBill_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(600, 366);
      this.Controls.Add(this.buttonSearchBill);
      this.Controls.Add(this.labelSearchingBill);
      this.Controls.Add(this.textBoxSearchingBill);
      this.Controls.Add(this.labelListOfDatabaseName);
      this.Controls.Add(this.listBoxDatabaseName);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "FormMain";
      this.Text = "Multiple databases";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBoxDatabaseName;
    private System.Windows.Forms.Label labelListOfDatabaseName;
    private System.Windows.Forms.TextBox textBoxSearchingBill;
    private System.Windows.Forms.Label labelSearchingBill;
    private System.Windows.Forms.Button buttonSearchBill;
  }
}

