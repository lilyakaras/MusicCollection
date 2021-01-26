namespace MusicCollection
{
    partial class AddGenreToDisk
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
            this.labelIdDisk = new System.Windows.Forms.Label();
            this.labelIdGenre = new System.Windows.Forms.Label();
            this.comboBoxIdDisk = new System.Windows.Forms.ComboBox();
            this.comboBoxIdGenre = new System.Windows.Forms.ComboBox();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIdDisk
            // 
            this.labelIdDisk.AutoSize = true;
            this.labelIdDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdDisk.Location = new System.Drawing.Point(29, 30);
            this.labelIdDisk.Name = "labelIdDisk";
            this.labelIdDisk.Size = new System.Drawing.Size(56, 20);
            this.labelIdDisk.TabIndex = 0;
            this.labelIdDisk.Text = "IdDisk";
            // 
            // labelIdGenre
            // 
            this.labelIdGenre.AutoSize = true;
            this.labelIdGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdGenre.Location = new System.Drawing.Point(29, 81);
            this.labelIdGenre.Name = "labelIdGenre";
            this.labelIdGenre.Size = new System.Drawing.Size(68, 20);
            this.labelIdGenre.TabIndex = 1;
            this.labelIdGenre.Text = "IdGenre";
            // 
            // comboBoxIdDisk
            // 
            this.comboBoxIdDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxIdDisk.FormattingEnabled = true;
            this.comboBoxIdDisk.Location = new System.Drawing.Point(132, 30);
            this.comboBoxIdDisk.Name = "comboBoxIdDisk";
            this.comboBoxIdDisk.Size = new System.Drawing.Size(245, 28);
            this.comboBoxIdDisk.TabIndex = 2;
            // 
            // comboBoxIdGenre
            // 
            this.comboBoxIdGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxIdGenre.FormattingEnabled = true;
            this.comboBoxIdGenre.Location = new System.Drawing.Point(132, 81);
            this.comboBoxIdGenre.Name = "comboBoxIdGenre";
            this.comboBoxIdGenre.Size = new System.Drawing.Size(245, 28);
            this.comboBoxIdGenre.TabIndex = 3;
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddGenre.Location = new System.Drawing.Point(417, 68);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(134, 41);
            this.buttonAddGenre.TabIndex = 4;
            this.buttonAddGenre.Text = "Add Genre";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(33, 136);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(163, 44);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(229, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(163, 44);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddGenreToDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 216);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.comboBoxIdGenre);
            this.Controls.Add(this.comboBoxIdDisk);
            this.Controls.Add(this.labelIdGenre);
            this.Controls.Add(this.labelIdDisk);
            this.Name = "AddGenreToDisk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Genre To Disk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdDisk;
        private System.Windows.Forms.Label labelIdGenre;
        private System.Windows.Forms.ComboBox comboBoxIdDisk;
        private System.Windows.Forms.ComboBox comboBoxIdGenre;
        private System.Windows.Forms.Button buttonAddGenre;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}