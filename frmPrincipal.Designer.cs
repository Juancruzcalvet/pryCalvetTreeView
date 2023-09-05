namespace pryCalvetTreeView
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.splitPrincipal = new System.Windows.Forms.SplitContainer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.trvPrincipal = new System.Windows.Forms.TreeView();
            this.lvwPrincipal = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Detalle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).BeginInit();
            this.splitPrincipal.Panel1.SuspendLayout();
            this.splitPrincipal.Panel2.SuspendLayout();
            this.splitPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitPrincipal
            // 
            this.splitPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPrincipal.Location = new System.Drawing.Point(0, 0);
            this.splitPrincipal.Name = "splitPrincipal";
            // 
            // splitPrincipal.Panel1
            // 
            this.splitPrincipal.Panel1.Controls.Add(this.trvPrincipal);
            // 
            // splitPrincipal.Panel2
            // 
            this.splitPrincipal.Panel2.Controls.Add(this.lvwPrincipal);
            this.splitPrincipal.Size = new System.Drawing.Size(800, 450);
            this.splitPrincipal.SplitterDistance = 266;
            this.splitPrincipal.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "kisspng-angle-area-text-brand-open-file-5ab0433c37d482.1593124515215009882287.png" +
        "");
            this.imageList1.Images.SetKeyName(1, "kisspng-angle-text-symbol-document-5ab096f63b42d7.3084172815215224222427.png");
            // 
            // trvPrincipal
            // 
            this.trvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvPrincipal.ImageIndex = 0;
            this.trvPrincipal.ImageList = this.imageList1;
            this.trvPrincipal.Location = new System.Drawing.Point(0, 0);
            this.trvPrincipal.Name = "trvPrincipal";
            this.trvPrincipal.SelectedImageIndex = 0;
            this.trvPrincipal.Size = new System.Drawing.Size(266, 450);
            this.trvPrincipal.TabIndex = 0;
            this.trvPrincipal.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lvwPrincipal
            // 
            this.lvwPrincipal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Tipo,
            this.Detalle});
            this.lvwPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwPrincipal.HideSelection = false;
            this.lvwPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lvwPrincipal.Name = "lvwPrincipal";
            this.lvwPrincipal.Size = new System.Drawing.Size(530, 450);
            this.lvwPrincipal.SmallImageList = this.imageList1;
            this.lvwPrincipal.TabIndex = 1;
            this.lvwPrincipal.UseCompatibleStateImageBehavior = false;
            this.lvwPrincipal.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 115;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 97;
            // 
            // Detalle
            // 
            this.Detalle.Text = "Detalle";
            this.Detalle.Width = 79;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "Uso de controles - Tree View";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.splitPrincipal.Panel1.ResumeLayout(false);
            this.splitPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).EndInit();
            this.splitPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitPrincipal;
        private System.Windows.Forms.ListView lvwPrincipal;
        private System.Windows.Forms.TreeView trvPrincipal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Detalle;
    }
}

