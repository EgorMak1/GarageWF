namespace GarageWF
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.garageDataSet1 = new GarageWF.garageDataSet();
            this.emploeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Работа с клиентом";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // garageDataSet1
            // 
            this.garageDataSet1.DataSetName = "garageDataSet1";
            this.garageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emploeeBindingSource
            // 
            this.emploeeBindingSource.DataMember = "Emploee";
            this.emploeeBindingSource.DataSource = this.garageDataSet1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.garageDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private garageDataSet garageDataSet1;
        private System.Windows.Forms.BindingSource emploeeBindingSource;
        private System.Windows.Forms.Button button3;
    }
}

