namespace View
{
    partial class Adminform
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
            System.Windows.Forms.Label nomLabel1;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label cardLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminform));
            this.Log_Info = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.Client_Info = new System.Windows.Forms.GroupBox();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.adminBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.adminBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridSplitContainer1Grid = new DevExpress.XtraGrid.GridControl();
            this.gridSplitContainer1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            nomLabel1 = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            cardLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.Log_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.Client_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingNavigator)).BeginInit();
            this.adminBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            this.gridSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel1
            // 
            nomLabel1.AutoSize = true;
            nomLabel1.Location = new System.Drawing.Point(60, 52);
            nomLabel1.Name = "nomLabel1";
            nomLabel1.Size = new System.Drawing.Size(49, 20);
            nomLabel1.TabIndex = 8;
            nomLabel1.Text = "Nom:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(53, 100);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(56, 20);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(72, 155);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(37, 20);
            telLabel.TabIndex = 10;
            telLabel.Text = "Tel:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(42, 207);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(67, 20);
            adressLabel.TabIndex = 11;
            adressLabel.Text = "Adress:";
            // 
            // cardLabel
            // 
            cardLabel.AutoSize = true;
            cardLabel.Location = new System.Drawing.Point(59, 262);
            cardLabel.Name = "cardLabel";
            cardLabel.Size = new System.Drawing.Size(50, 20);
            cardLabel.TabIndex = 12;
            cardLabel.Text = "Card:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(41, 103);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(91, 20);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(44, 158);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(88, 20);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // Log_Info
            // 
            this.Log_Info.BackColor = System.Drawing.Color.Salmon;
            this.Log_Info.Controls.Add(passwordLabel);
            this.Log_Info.Controls.Add(this.passwordTextBox);
            this.Log_Info.Controls.Add(usernameLabel);
            this.Log_Info.Controls.Add(this.usernameTextBox);
            this.Log_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Info.ForeColor = System.Drawing.Color.DarkRed;
            this.Log_Info.Location = new System.Drawing.Point(350, 56);
            this.Log_Info.Name = "Log_Info";
            this.Log_Info.Size = new System.Drawing.Size(312, 321);
            this.Log_Info.TabIndex = 19;
            this.Log_Info.TabStop = false;
            this.Log_Info.Text = "Log_Info";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(155, 155);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 26);
            this.passwordTextBox.TabIndex = 3;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataSource = typeof(MVCModal.Admin);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(155, 100);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 26);
            this.usernameTextBox.TabIndex = 1;
            // 
            // Client_Info
            // 
            this.Client_Info.BackColor = System.Drawing.Color.Salmon;
            this.Client_Info.Controls.Add(cardLabel);
            this.Client_Info.Controls.Add(this.cardTextBox);
            this.Client_Info.Controls.Add(adressLabel);
            this.Client_Info.Controls.Add(this.adressTextBox);
            this.Client_Info.Controls.Add(telLabel);
            this.Client_Info.Controls.Add(this.telTextBox);
            this.Client_Info.Controls.Add(emailLabel);
            this.Client_Info.Controls.Add(this.emailTextBox);
            this.Client_Info.Controls.Add(nomLabel1);
            this.Client_Info.Controls.Add(this.nomTextBox);
            this.Client_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_Info.ForeColor = System.Drawing.Color.DarkRed;
            this.Client_Info.Location = new System.Drawing.Point(32, 56);
            this.Client_Info.Name = "Client_Info";
            this.Client_Info.Size = new System.Drawing.Size(308, 321);
            this.Client_Info.TabIndex = 18;
            this.Client_Info.TabStop = false;
            this.Client_Info.Text = "Client_Info";
            // 
            // cardTextBox
            // 
            this.cardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "Card", true));
            this.cardTextBox.Location = new System.Drawing.Point(141, 259);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(100, 26);
            this.cardTextBox.TabIndex = 13;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(141, 204);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(100, 26);
            this.adressTextBox.TabIndex = 12;
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "Tel", true));
            this.telTextBox.Location = new System.Drawing.Point(141, 152);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(100, 26);
            this.telTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(141, 97);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 26);
            this.emailTextBox.TabIndex = 10;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(141, 49);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 26);
            this.nomTextBox.TabIndex = 9;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.DarkRed;
            this.add.Location = new System.Drawing.Point(1107, 96);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(172, 45);
            this.add.TabIndex = 20;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // modify
            // 
            this.modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.ForeColor = System.Drawing.Color.DarkRed;
            this.modify.Location = new System.Drawing.Point(1107, 187);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(172, 45);
            this.modify.TabIndex = 21;
            this.modify.Text = "modify";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.DarkRed;
            this.delete.Location = new System.Drawing.Point(1107, 275);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(172, 45);
            this.delete.TabIndex = 22;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.DarkRed;
            this.save.Location = new System.Drawing.Point(866, 187);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(172, 45);
            this.save.TabIndex = 23;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // adminBindingNavigator
            // 
            this.adminBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.adminBindingNavigator.BindingSource = this.adminBindingSource;
            this.adminBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.adminBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.adminBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.adminBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.adminBindingNavigatorSaveItem});
            this.adminBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.adminBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.adminBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.adminBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.adminBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.adminBindingNavigator.Name = "adminBindingNavigator";
            this.adminBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.adminBindingNavigator.Size = new System.Drawing.Size(1359, 27);
            this.adminBindingNavigator.TabIndex = 24;
            this.adminBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // adminBindingNavigatorSaveItem
            // 
            this.adminBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.adminBindingNavigatorSaveItem.Enabled = false;
            this.adminBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("adminBindingNavigatorSaveItem.Image")));
            this.adminBindingNavigatorSaveItem.Name = "adminBindingNavigatorSaveItem";
            this.adminBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.adminBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridSplitContainer1.Grid = this.gridSplitContainer1Grid;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 443);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // gridSplitContainer1.Panel1
            // 
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridSplitContainer1Grid);
            this.gridSplitContainer1.Panel1.Text = "Panel1";
            // 
            // gridSplitContainer1.Panel2
            // 
            this.gridSplitContainer1.Panel2.Text = "Panel2";
            this.gridSplitContainer1.Size = new System.Drawing.Size(1359, 223);
            this.gridSplitContainer1.TabIndex = 25;
            // 
            // gridSplitContainer1Grid
            // 
            this.gridSplitContainer1Grid.DataSource = this.adminBindingSource;
            this.gridSplitContainer1Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1Grid.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1Grid.MainView = this.gridSplitContainer1View;
            this.gridSplitContainer1Grid.Name = "gridSplitContainer1Grid";
            this.gridSplitContainer1Grid.Size = new System.Drawing.Size(1359, 223);
            this.gridSplitContainer1Grid.TabIndex = 0;
            this.gridSplitContainer1Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSplitContainer1View});
            // 
            // gridSplitContainer1View
            // 
            this.gridSplitContainer1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNom,
            this.colEmail,
            this.colTel,
            this.colAdress,
            this.colCard,
            this.colUsername,
            this.colPassword});
            this.gridSplitContainer1View.GridControl = this.gridSplitContainer1Grid;
            this.gridSplitContainer1View.Name = "gridSplitContainer1View";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 94;
            // 
            // colNom
            // 
            this.colNom.FieldName = "Nom";
            this.colNom.MinWidth = 25;
            this.colNom.Name = "colNom";
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 1;
            this.colNom.Width = 94;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            this.colEmail.Width = 94;
            // 
            // colTel
            // 
            this.colTel.FieldName = "Tel";
            this.colTel.MinWidth = 25;
            this.colTel.Name = "colTel";
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 3;
            this.colTel.Width = 94;
            // 
            // colAdress
            // 
            this.colAdress.FieldName = "Adress";
            this.colAdress.MinWidth = 25;
            this.colAdress.Name = "colAdress";
            this.colAdress.Visible = true;
            this.colAdress.VisibleIndex = 4;
            this.colAdress.Width = 94;
            // 
            // colCard
            // 
            this.colCard.FieldName = "Card";
            this.colCard.MinWidth = 25;
            this.colCard.Name = "colCard";
            this.colCard.Visible = true;
            this.colCard.VisibleIndex = 5;
            this.colCard.Width = 94;
            // 
            // colUsername
            // 
            this.colUsername.FieldName = "Username";
            this.colUsername.MinWidth = 25;
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 6;
            this.colUsername.Width = 94;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.MinWidth = 25;
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 7;
            this.colPassword.Width = 94;
            // 
            // Adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1359, 666);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.adminBindingNavigator);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Log_Info);
            this.Controls.Add(this.Client_Info);
            this.Name = "Adminform";
            this.Text = "Adminform";
            this.Load += new System.EventHandler(this.Adminform_Load);
            this.Log_Info.ResumeLayout(false);
            this.Log_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.Client_Info.ResumeLayout(false);
            this.Client_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingNavigator)).EndInit();
            this.adminBindingNavigator.ResumeLayout(false);
            this.adminBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            this.gridSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Log_Info;
        private System.Windows.Forms.GroupBox Client_Info;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private System.Windows.Forms.BindingNavigator adminBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton adminBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gridSplitContainer1Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSplitContainer1View;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colAdress;
        private DevExpress.XtraGrid.Columns.GridColumn colCard;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
    }
}