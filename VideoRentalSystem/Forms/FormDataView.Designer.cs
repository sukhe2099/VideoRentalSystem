namespace VideoRentalSystem.Forms
{
    partial class FormDataView
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
            this.tcDataDisplay = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelMovie = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlot = new System.Windows.Forms.Label();
            this.pbxPoster = new System.Windows.Forms.PictureBox();
            this.btnEditMovie = new System.Windows.Forms.Button();
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.btnRemoveCust = new System.Windows.Forms.Button();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblSMovie = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblSCust = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.btnViewToggle = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNewRental = new System.Windows.Forms.Button();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTopMovie = new System.Windows.Forms.Button();
            this.btnTopCust = new System.Windows.Forms.Button();
            this.tcDataDisplay.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelMovie.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // tcDataDisplay
            // 
            this.tcDataDisplay.Controls.Add(this.tabPage1);
            this.tcDataDisplay.Controls.Add(this.tabPage2);
            this.tcDataDisplay.Controls.Add(this.tabPage3);
            this.tcDataDisplay.Location = new System.Drawing.Point(16, 15);
            this.tcDataDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.tcDataDisplay.Name = "tcDataDisplay";
            this.tcDataDisplay.SelectedIndex = 0;
            this.tcDataDisplay.Size = new System.Drawing.Size(1444, 832);
            this.tcDataDisplay.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.panelMovie);
            this.tabPage1.Controls.Add(this.btnEditMovie);
            this.tabPage1.Controls.Add(this.btnRemoveMovie);
            this.tabPage1.Controls.Add(this.btnAddMovie);
            this.tabPage1.Controls.Add(this.dgvMovies);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1436, 803);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movies";
            // 
            // panelMovie
            // 
            this.panelMovie.Controls.Add(this.flowLayoutPanel2);
            this.panelMovie.Controls.Add(this.flowLayoutPanel1);
            this.panelMovie.Controls.Add(this.pbxPoster);
            this.panelMovie.Location = new System.Drawing.Point(712, 7);
            this.panelMovie.Margin = new System.Windows.Forms.Padding(4);
            this.panelMovie.Name = "panelMovie";
            this.panelMovie.Size = new System.Drawing.Size(713, 750);
            this.panelMovie.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblTitle);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(327, 4);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(383, 359);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(4, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 54);
            this.lblTitle.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblPlot);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 372);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(679, 374);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lblPlot
            // 
            this.lblPlot.AutoSize = true;
            this.lblPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlot.Location = new System.Drawing.Point(4, 0);
            this.lblPlot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(0, 39);
            this.lblPlot.TabIndex = 0;
            // 
            // pbxPoster
            // 
            this.pbxPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxPoster.Location = new System.Drawing.Point(13, 4);
            this.pbxPoster.Margin = new System.Windows.Forms.Padding(4);
            this.pbxPoster.Name = "pbxPoster";
            this.pbxPoster.Size = new System.Drawing.Size(305, 359);
            this.pbxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPoster.TabIndex = 1;
            this.pbxPoster.TabStop = false;
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Location = new System.Drawing.Point(472, 764);
            this.btnEditMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(224, 28);
            this.btnEditMovie.TabIndex = 7;
            this.btnEditMovie.Text = "Edit";
            this.btnEditMovie.UseVisualStyleBackColor = true;
            this.btnEditMovie.Click += new System.EventHandler(this.btnEditMovie_Click);
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.Location = new System.Drawing.Point(240, 764);
            this.btnRemoveMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(224, 28);
            this.btnRemoveMovie.TabIndex = 6;
            this.btnRemoveMovie.Text = "Remove Movie";
            this.btnRemoveMovie.UseVisualStyleBackColor = true;
            this.btnRemoveMovie.Click += new System.EventHandler(this.btnRemoveMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(8, 764);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(224, 28);
            this.btnAddMovie.TabIndex = 4;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AllowUserToResizeRows = false;
            this.dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMovies.Location = new System.Drawing.Point(8, 7);
            this.dgvMovies.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMovies.MultiSelect = false;
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.RowHeadersVisible = false;
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.Size = new System.Drawing.Size(696, 750);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEditCust);
            this.tabPage2.Controls.Add(this.btnRemoveCust);
            this.tabPage2.Controls.Add(this.btnAddCust);
            this.tabPage2.Controls.Add(this.dgvUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1436, 803);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEditCust
            // 
            this.btnEditCust.Location = new System.Drawing.Point(472, 764);
            this.btnEditCust.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(224, 28);
            this.btnEditCust.TabIndex = 10;
            this.btnEditCust.Text = "Edit Customer";
            this.btnEditCust.UseVisualStyleBackColor = true;
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // btnRemoveCust
            // 
            this.btnRemoveCust.Location = new System.Drawing.Point(240, 764);
            this.btnRemoveCust.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveCust.Name = "btnRemoveCust";
            this.btnRemoveCust.Size = new System.Drawing.Size(224, 28);
            this.btnRemoveCust.TabIndex = 9;
            this.btnRemoveCust.Text = "Remove Customer";
            this.btnRemoveCust.UseVisualStyleBackColor = true;
            this.btnRemoveCust.Click += new System.EventHandler(this.btnRemoveCust_Click);
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(8, 764);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(224, 28);
            this.btnAddCust.TabIndex = 8;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvUsers.Location = new System.Drawing.Point(8, 7);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1417, 750);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblSMovie);
            this.tabPage3.Controls.Add(this.lblMovie);
            this.tabPage3.Controls.Add(this.lblSCust);
            this.tabPage3.Controls.Add(this.lblCust);
            this.tabPage3.Controls.Add(this.btnViewToggle);
            this.tabPage3.Controls.Add(this.btnReturn);
            this.tabPage3.Controls.Add(this.btnNewRental);
            this.tabPage3.Controls.Add(this.dgvRentals);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1436, 803);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rentals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblSMovie
            // 
            this.lblSMovie.AutoSize = true;
            this.lblSMovie.Location = new System.Drawing.Point(1151, 777);
            this.lblSMovie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSMovie.Name = "lblSMovie";
            this.lblSMovie.Size = new System.Drawing.Size(40, 17);
            this.lblSMovie.TabIndex = 14;
            this.lblSMovie.Text = "none";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(1031, 777);
            this.lblMovie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(108, 17);
            this.lblMovie.TabIndex = 13;
            this.lblMovie.Text = "Selected Movie:";
            // 
            // lblSCust
            // 
            this.lblSCust.AutoSize = true;
            this.lblSCust.Location = new System.Drawing.Point(844, 777);
            this.lblSCust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSCust.Name = "lblSCust";
            this.lblSCust.Size = new System.Drawing.Size(40, 17);
            this.lblSCust.TabIndex = 12;
            this.lblSCust.Text = "none";
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(704, 777);
            this.lblCust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(131, 17);
            this.lblCust.TabIndex = 11;
            this.lblCust.Text = "Selected Customer:";
            // 
            // btnViewToggle
            // 
            this.btnViewToggle.Location = new System.Drawing.Point(472, 764);
            this.btnViewToggle.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewToggle.Name = "btnViewToggle";
            this.btnViewToggle.Size = new System.Drawing.Size(224, 28);
            this.btnViewToggle.TabIndex = 10;
            this.btnViewToggle.Text = "Show unreturned Rentals";
            this.btnViewToggle.UseVisualStyleBackColor = true;
            this.btnViewToggle.Click += new System.EventHandler(this.btnViewToggle_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(240, 764);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(224, 28);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnNewRental
            // 
            this.btnNewRental.Location = new System.Drawing.Point(8, 764);
            this.btnNewRental.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewRental.Name = "btnNewRental";
            this.btnNewRental.Size = new System.Drawing.Size(224, 28);
            this.btnNewRental.TabIndex = 8;
            this.btnNewRental.Text = "New Rental";
            this.btnNewRental.UseVisualStyleBackColor = true;
            this.btnNewRental.Click += new System.EventHandler(this.btnNewRental_Click);
            // 
            // dgvRentals
            // 
            this.dgvRentals.AllowUserToAddRows = false;
            this.dgvRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRentals.Location = new System.Drawing.Point(8, 7);
            this.dgvRentals.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRentals.MultiSelect = false;
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.ReadOnly = true;
            this.dgvRentals.RowHeadersVisible = false;
            this.dgvRentals.RowHeadersWidth = 51;
            this.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentals.Size = new System.Drawing.Size(1417, 750);
            this.dgvRentals.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1468, 748);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(249, 98);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTopMovie
            // 
            this.btnTopMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopMovie.Location = new System.Drawing.Point(1468, 537);
            this.btnTopMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnTopMovie.Name = "btnTopMovie";
            this.btnTopMovie.Size = new System.Drawing.Size(249, 98);
            this.btnTopMovie.TabIndex = 9;
            this.btnTopMovie.Text = "View Top 5 Movies";
            this.btnTopMovie.UseVisualStyleBackColor = true;
            this.btnTopMovie.Click += new System.EventHandler(this.btnTopMovie_Click);
            // 
            // btnTopCust
            // 
            this.btnTopCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopCust.Location = new System.Drawing.Point(1468, 642);
            this.btnTopCust.Margin = new System.Windows.Forms.Padding(4);
            this.btnTopCust.Name = "btnTopCust";
            this.btnTopCust.Size = new System.Drawing.Size(249, 98);
            this.btnTopCust.TabIndex = 10;
            this.btnTopCust.Text = "View Top 5 Customers";
            this.btnTopCust.UseVisualStyleBackColor = true;
            this.btnTopCust.Click += new System.EventHandler(this.btnTopCust_Click);
            // 
            // FormDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(1788, 900);
            this.Controls.Add(this.btnTopCust);
            this.Controls.Add(this.btnTopMovie);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tcDataDisplay);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormDataView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormDataView";
            this.Load += new System.EventHandler(this.FormDataView_Load);
            this.tcDataDisplay.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelMovie.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDataDisplay;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEditMovie;
        private System.Windows.Forms.Button btnRemoveMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.Button btnRemoveCust;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNewRental;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewToggle;
        private System.Windows.Forms.Panel panelMovie;
        private System.Windows.Forms.PictureBox pbxPoster;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblSMovie;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblSCust;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Button btnTopMovie;
        private System.Windows.Forms.Button btnTopCust;
    }
}