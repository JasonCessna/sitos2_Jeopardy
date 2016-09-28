namespace sitos_jeapordy
{
    partial class teamNameTxt
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTxtTeamName = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Indigo;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(171, 79);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 40);
            this.btnSubmit.TabIndex = 50;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Tag = "btnSubmit";
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Indigo;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Yellow;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(16, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 40);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTxtTeamName
            // 
            this.lblTxtTeamName.AutoSize = true;
            this.lblTxtTeamName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtTeamName.Location = new System.Drawing.Point(12, 9);
            this.lblTxtTeamName.Name = "lblTxtTeamName";
            this.lblTxtTeamName.Size = new System.Drawing.Size(184, 21);
            this.lblTxtTeamName.TabIndex = 52;
            this.lblTxtTeamName.Text = "Enter Team\'s Name:";
            this.lblTxtTeamName.Click += new System.EventHandler(this.lblTxtTeamName_Click);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamName.Location = new System.Drawing.Point(16, 33);
            this.txtTeamName.MinimumSize = new System.Drawing.Size(4, 40);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(300, 31);
            this.txtTeamName.TabIndex = 53;
            this.txtTeamName.TextChanged += new System.EventHandler(this.txtTeamName_TextChanged);
            // 
            // teamNameTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(331, 129);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lblTxtTeamName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "teamNameTxt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTxtTeamName;
        private System.Windows.Forms.TextBox txtTeamName;

    }
}