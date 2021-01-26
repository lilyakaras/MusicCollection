namespace MusicCollection
{
    partial class ModificateData
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddCollective = new System.Windows.Forms.Button();
            this.buttonAllCollectives = new System.Windows.Forms.Button();
            this.buttonDeleteCollective = new System.Windows.Forms.Button();
            this.buttonAddPublisher = new System.Windows.Forms.Button();
            this.buttonAllPublishers = new System.Windows.Forms.Button();
            this.buttonDeletePublisher = new System.Windows.Forms.Button();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.buttonAllGenres = new System.Windows.Forms.Button();
            this.buttonDeleteGenre = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAllUsers = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(386, 411);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // buttonAddCollective
            // 
            this.buttonAddCollective.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCollective.Location = new System.Drawing.Point(13, 38);
            this.buttonAddCollective.Name = "buttonAddCollective";
            this.buttonAddCollective.Size = new System.Drawing.Size(152, 55);
            this.buttonAddCollective.TabIndex = 1;
            this.buttonAddCollective.Text = "Add Collective";
            this.buttonAddCollective.UseVisualStyleBackColor = true;
            this.buttonAddCollective.Click += new System.EventHandler(this.buttonAddCollective_Click);
            // 
            // buttonAllCollectives
            // 
            this.buttonAllCollectives.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllCollectives.Location = new System.Drawing.Point(13, 99);
            this.buttonAllCollectives.Name = "buttonAllCollectives";
            this.buttonAllCollectives.Size = new System.Drawing.Size(152, 55);
            this.buttonAllCollectives.TabIndex = 2;
            this.buttonAllCollectives.Text = "All Collectives";
            this.buttonAllCollectives.UseVisualStyleBackColor = true;
            this.buttonAllCollectives.Click += new System.EventHandler(this.buttonAllCollectives_Click);
            // 
            // buttonDeleteCollective
            // 
            this.buttonDeleteCollective.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCollective.Location = new System.Drawing.Point(12, 160);
            this.buttonDeleteCollective.Name = "buttonDeleteCollective";
            this.buttonDeleteCollective.Size = new System.Drawing.Size(153, 55);
            this.buttonDeleteCollective.TabIndex = 3;
            this.buttonDeleteCollective.Text = "Delete Collective";
            this.buttonDeleteCollective.UseVisualStyleBackColor = true;
            this.buttonDeleteCollective.Click += new System.EventHandler(this.buttonDeleteCollective_Click);
            // 
            // buttonAddPublisher
            // 
            this.buttonAddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPublisher.Location = new System.Drawing.Point(12, 272);
            this.buttonAddPublisher.Name = "buttonAddPublisher";
            this.buttonAddPublisher.Size = new System.Drawing.Size(152, 55);
            this.buttonAddPublisher.TabIndex = 4;
            this.buttonAddPublisher.Text = "Add Publisher";
            this.buttonAddPublisher.UseVisualStyleBackColor = true;
            this.buttonAddPublisher.Click += new System.EventHandler(this.buttonAddPublisher_Click);
            // 
            // buttonAllPublishers
            // 
            this.buttonAllPublishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllPublishers.Location = new System.Drawing.Point(13, 333);
            this.buttonAllPublishers.Name = "buttonAllPublishers";
            this.buttonAllPublishers.Size = new System.Drawing.Size(152, 55);
            this.buttonAllPublishers.TabIndex = 5;
            this.buttonAllPublishers.Text = "All Publishers";
            this.buttonAllPublishers.UseVisualStyleBackColor = true;
            this.buttonAllPublishers.Click += new System.EventHandler(this.buttonAllPublishers_Click);
            // 
            // buttonDeletePublisher
            // 
            this.buttonDeletePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeletePublisher.Location = new System.Drawing.Point(13, 394);
            this.buttonDeletePublisher.Name = "buttonDeletePublisher";
            this.buttonDeletePublisher.Size = new System.Drawing.Size(152, 55);
            this.buttonDeletePublisher.TabIndex = 6;
            this.buttonDeletePublisher.Text = "Delete Publisher";
            this.buttonDeletePublisher.UseVisualStyleBackColor = true;
            this.buttonDeletePublisher.Click += new System.EventHandler(this.buttonDeletePublisher_Click);
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddGenre.Location = new System.Drawing.Point(584, 38);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(152, 55);
            this.buttonAddGenre.TabIndex = 7;
            this.buttonAddGenre.Text = "Add Genre";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // buttonAllGenres
            // 
            this.buttonAllGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllGenres.Location = new System.Drawing.Point(584, 99);
            this.buttonAllGenres.Name = "buttonAllGenres";
            this.buttonAllGenres.Size = new System.Drawing.Size(152, 55);
            this.buttonAllGenres.TabIndex = 8;
            this.buttonAllGenres.Text = "All Genres";
            this.buttonAllGenres.UseVisualStyleBackColor = true;
            this.buttonAllGenres.Click += new System.EventHandler(this.buttonAllGenres_Click);
            // 
            // buttonDeleteGenre
            // 
            this.buttonDeleteGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteGenre.Location = new System.Drawing.Point(584, 160);
            this.buttonDeleteGenre.Name = "buttonDeleteGenre";
            this.buttonDeleteGenre.Size = new System.Drawing.Size(152, 55);
            this.buttonDeleteGenre.TabIndex = 9;
            this.buttonDeleteGenre.Text = "Delete Genre";
            this.buttonDeleteGenre.UseVisualStyleBackColor = true;
            this.buttonDeleteGenre.Click += new System.EventHandler(this.buttonDeleteGenre_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddUser.Location = new System.Drawing.Point(584, 272);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(152, 55);
            this.buttonAddUser.TabIndex = 10;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonAllUsers
            // 
            this.buttonAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllUsers.Location = new System.Drawing.Point(584, 333);
            this.buttonAllUsers.Name = "buttonAllUsers";
            this.buttonAllUsers.Size = new System.Drawing.Size(152, 55);
            this.buttonAllUsers.TabIndex = 11;
            this.buttonAllUsers.Text = "All Users";
            this.buttonAllUsers.UseVisualStyleBackColor = true;
            this.buttonAllUsers.Click += new System.EventHandler(this.buttonAllUsers_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(584, 394);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(152, 55);
            this.buttonDeleteUser.TabIndex = 12;
            this.buttonDeleteUser.Text = "Delete User";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // ModificateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonAllUsers);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonDeleteGenre);
            this.Controls.Add(this.buttonAllGenres);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.buttonDeletePublisher);
            this.Controls.Add(this.buttonAllPublishers);
            this.Controls.Add(this.buttonAddPublisher);
            this.Controls.Add(this.buttonDeleteCollective);
            this.Controls.Add(this.buttonAllCollectives);
            this.Controls.Add(this.buttonAddCollective);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModificateData";
            this.Text = "ModificateData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonAddCollective;
        private System.Windows.Forms.Button buttonAllCollectives;
        private System.Windows.Forms.Button buttonDeleteCollective;
        private System.Windows.Forms.Button buttonAddPublisher;
        private System.Windows.Forms.Button buttonAllPublishers;
        private System.Windows.Forms.Button buttonDeletePublisher;
        private System.Windows.Forms.Button buttonAddGenre;
        private System.Windows.Forms.Button buttonAllGenres;
        private System.Windows.Forms.Button buttonDeleteGenre;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAllUsers;
        private System.Windows.Forms.Button buttonDeleteUser;
    }
}