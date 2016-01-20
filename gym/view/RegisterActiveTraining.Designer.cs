namespace gym
{
    partial class RegisterActiveTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterActiveTraining));
            this.activetraining = new System.Windows.Forms.DataGridView();
            this.register = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activetraining)).BeginInit();
            this.SuspendLayout();
            // 
            // activetraining
            // 
            this.activetraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activetraining.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.register});
            this.activetraining.Location = new System.Drawing.Point(-1, 0);
            this.activetraining.Name = "activetraining";
            this.activetraining.Size = new System.Drawing.Size(1173, 223);
            this.activetraining.TabIndex = 4;
            this.activetraining.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activetraining_CellContentClick);
            // 
            // register
            // 
            this.register.HeaderText = "";
            this.register.Name = "register";
            this.register.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.register.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.register.Text = "הרשם";
            this.register.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1068, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "תעודת זהות מתאמן";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(1071, 131);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(101, 20);
            this.txt_id.TabIndex = 6;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.BackgroundImage")));
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.Location = new System.Drawing.Point(1112, 0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(60, 59);
            this.btnPrev.TabIndex = 104;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // RegisterActiveTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1172, 223);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.activetraining);
            this.Name = "RegisterActiveTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "רישום לאימונים פעילים";
            ((System.ComponentModel.ISupportInitialize)(this.activetraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView activetraining;
        private System.Windows.Forms.DataGridViewButtonColumn register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btnPrev;
    }
}