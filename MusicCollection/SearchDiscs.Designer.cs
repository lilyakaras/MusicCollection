namespace MusicCollection
{
    partial class SearchDiscs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTitle = new System.Windows.Forms.RadioButton();
            this.radioButtonCollective = new System.Windows.Forms.RadioButton();
            this.radioButtonGenre = new System.Windows.Forms.RadioButton();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxCollective = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxGenre);
            this.groupBox1.Controls.Add(this.textBoxCollective);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.radioButtonGenre);
            this.groupBox1.Controls.Add(this.radioButtonCollective);
            this.groupBox1.Controls.Add(this.radioButtonTitle);
            this.groupBox1.Location = new System.Drawing.Point(49, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonTitle
            // 
            this.radioButtonTitle.AutoSize = true;
            this.radioButtonTitle.Location = new System.Drawing.Point(20, 36);
            this.radioButtonTitle.Name = "radioButtonTitle";
            this.radioButtonTitle.Size = new System.Drawing.Size(56, 21);
            this.radioButtonTitle.TabIndex = 0;
            this.radioButtonTitle.TabStop = true;
            this.radioButtonTitle.Text = "Title";
            this.radioButtonTitle.UseVisualStyleBackColor = true;
            // 
            // radioButtonCollective
            // 
            this.radioButtonCollective.AutoSize = true;
            this.radioButtonCollective.Location = new System.Drawing.Point(20, 73);
            this.radioButtonCollective.Name = "radioButtonCollective";
            this.radioButtonCollective.Size = new System.Drawing.Size(89, 21);
            this.radioButtonCollective.TabIndex = 1;
            this.radioButtonCollective.TabStop = true;
            this.radioButtonCollective.Text = "Collective";
            this.radioButtonCollective.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenre
            // 
            this.radioButtonGenre.AutoSize = true;
            this.radioButtonGenre.Location = new System.Drawing.Point(20, 118);
            this.radioButtonGenre.Name = "radioButtonGenre";
            this.radioButtonGenre.Size = new System.Drawing.Size(69, 21);
            this.radioButtonGenre.TabIndex = 2;
            this.radioButtonGenre.TabStop = true;
            this.radioButtonGenre.Text = "Genre";
            this.radioButtonGenre.UseVisualStyleBackColor = true;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(128, 36);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(268, 22);
            this.textBoxTitle.TabIndex = 3;
            // 
            // textBoxCollective
            // 
            this.textBoxCollective.Location = new System.Drawing.Point(128, 73);
            this.textBoxCollective.Name = "textBoxCollective";
            this.textBoxCollective.Size = new System.Drawing.Size(268, 22);
            this.textBoxCollective.TabIndex = 4;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(128, 118);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(268, 22);
            this.textBoxGenre.TabIndex = 5;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(49, 252);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(177, 52);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(293, 252);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(177, 52);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // SearchDiscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 329);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchDiscs";
            this.Text = "SearchDiscs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxCollective;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.RadioButton radioButtonGenre;
        private System.Windows.Forms.RadioButton radioButtonCollective;
        private System.Windows.Forms.RadioButton radioButtonTitle;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}