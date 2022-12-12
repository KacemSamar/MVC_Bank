namespace View
{
    partial class Menu
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
            this.exit = new System.Windows.Forms.Button();
            this.Transaction = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.Bank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DarkRed;
            this.exit.Location = new System.Drawing.Point(37, 552);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(236, 68);
            this.exit.TabIndex = 7;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Transaction
            // 
            this.Transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction.ForeColor = System.Drawing.Color.DarkRed;
            this.Transaction.Location = new System.Drawing.Point(37, 340);
            this.Transaction.Margin = new System.Windows.Forms.Padding(4);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(236, 68);
            this.Transaction.TabIndex = 6;
            this.Transaction.Text = "Transaction";
            this.Transaction.UseVisualStyleBackColor = true;
            this.Transaction.Click += new System.EventHandler(this.Transaction_Click);
            // 
            // Account
            // 
            this.Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.ForeColor = System.Drawing.Color.DarkRed;
            this.Account.Location = new System.Drawing.Point(37, 241);
            this.Account.Margin = new System.Windows.Forms.Padding(4);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(236, 68);
            this.Account.TabIndex = 5;
            this.Account.Text = "Account";
            this.Account.UseVisualStyleBackColor = true;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // Client
            // 
            this.Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client.ForeColor = System.Drawing.Color.DarkRed;
            this.Client.Location = new System.Drawing.Point(37, 39);
            this.Client.Margin = new System.Windows.Forms.Padding(4);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(236, 68);
            this.Client.TabIndex = 4;
            this.Client.Text = "Client";
            this.Client.UseVisualStyleBackColor = true;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.DarkRed;
            this.Admin.Location = new System.Drawing.Point(37, 137);
            this.Admin.Margin = new System.Windows.Forms.Padding(4);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(236, 68);
            this.Admin.TabIndex = 8;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Bank
            // 
            this.Bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bank.ForeColor = System.Drawing.Color.DarkRed;
            this.Bank.Location = new System.Drawing.Point(37, 446);
            this.Bank.Margin = new System.Windows.Forms.Padding(4);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(236, 68);
            this.Bank.TabIndex = 9;
            this.Bank.Text = "Bank";
            this.Bank.UseVisualStyleBackColor = true;
            this.Bank.Click += new System.EventHandler(this.Bank_Click);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(337, 646);
            this.Controls.Add(this.Bank);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Transaction);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Client);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Transaction;
        private System.Windows.Forms.Button Account;
        private System.Windows.Forms.Button Client;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button Bank;
    }
}