
namespace ExercisePABD_B
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.MainMenu = new System.Windows.Forms.Label();
            this.buttonDataGrid = new System.Windows.Forms.Button();
            this.buttonBinding = new System.Windows.Forms.Button();
            this.labelDataGrid = new System.Windows.Forms.Label();
            this.labelBinding = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.AutoSize = true;
            this.MainMenu.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ForeColor = System.Drawing.Color.Aqua;
            this.MainMenu.Location = new System.Drawing.Point(291, 64);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(239, 55);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // buttonDataGrid
            // 
            this.buttonDataGrid.BackColor = System.Drawing.Color.Transparent;
            this.buttonDataGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDataGrid.BackgroundImage")));
            this.buttonDataGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDataGrid.Location = new System.Drawing.Point(125, 166);
            this.buttonDataGrid.Name = "buttonDataGrid";
            this.buttonDataGrid.Size = new System.Drawing.Size(205, 197);
            this.buttonDataGrid.TabIndex = 1;
            this.buttonDataGrid.UseVisualStyleBackColor = false;
            this.buttonDataGrid.Click += new System.EventHandler(this.buttonDataGrid_Click);
            // 
            // buttonBinding
            // 
            this.buttonBinding.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBinding.BackgroundImage")));
            this.buttonBinding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBinding.Location = new System.Drawing.Point(455, 166);
            this.buttonBinding.Name = "buttonBinding";
            this.buttonBinding.Size = new System.Drawing.Size(205, 197);
            this.buttonBinding.TabIndex = 2;
            this.buttonBinding.UseVisualStyleBackColor = true;
            this.buttonBinding.Click += new System.EventHandler(this.buttonBinding_Click);
            // 
            // labelDataGrid
            // 
            this.labelDataGrid.AutoSize = true;
            this.labelDataGrid.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataGrid.ForeColor = System.Drawing.Color.Aqua;
            this.labelDataGrid.Location = new System.Drawing.Point(126, 377);
            this.labelDataGrid.Name = "labelDataGrid";
            this.labelDataGrid.Size = new System.Drawing.Size(195, 37);
            this.labelDataGrid.TabIndex = 3;
            this.labelDataGrid.Text = "DataGridView";
            // 
            // labelBinding
            // 
            this.labelBinding.AutoSize = true;
            this.labelBinding.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBinding.ForeColor = System.Drawing.Color.Aqua;
            this.labelBinding.Location = new System.Drawing.Point(469, 377);
            this.labelBinding.Name = "labelBinding";
            this.labelBinding.Size = new System.Drawing.Size(172, 37);
            this.labelBinding.TabIndex = 4;
            this.labelBinding.Text = "DataBinding";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(728, 439);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(85, 55);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(825, 506);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelBinding);
            this.Controls.Add(this.labelDataGrid);
            this.Controls.Add(this.buttonBinding);
            this.Controls.Add(this.buttonDataGrid);
            this.Controls.Add(this.MainMenu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenu;
        private System.Windows.Forms.Button buttonDataGrid;
        private System.Windows.Forms.Button buttonBinding;
        private System.Windows.Forms.Label labelDataGrid;
        private System.Windows.Forms.Label labelBinding;
        private System.Windows.Forms.Button buttonExit;
    }
}