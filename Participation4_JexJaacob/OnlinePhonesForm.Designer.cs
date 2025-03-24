namespace Participation4_JexJaacob
{
    partial class OnlinePhonesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlinePhonesForm));
            System.Windows.Forms.Label uVUPhoneNumsIdLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label departmentLabel;
            this.iNFO2200_CrandallSayDataSet = new Participation4_JexJaacob.INFO2200_CrandallSayDataSet();
            this.uVUPhoneNumsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uVUPhoneNumsTableTableAdapter = new Participation4_JexJaacob.INFO2200_CrandallSayDataSetTableAdapters.UVUPhoneNumsTableTableAdapter();
            this.tableAdapterManager = new Participation4_JexJaacob.INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager();
            this.uVUPhoneNumsTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.uVUPhoneNumsTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uVUPhoneNumsIdLabel1 = new System.Windows.Forms.Label();
            this.firstNameListBox = new System.Windows.Forms.ListBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            uVUPhoneNumsIdLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsTableBindingNavigator)).BeginInit();
            this.uVUPhoneNumsTableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iNFO2200_CrandallSayDataSet
            // 
            this.iNFO2200_CrandallSayDataSet.DataSetName = "INFO2200_CrandallSayDataSet";
            this.iNFO2200_CrandallSayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uVUPhoneNumsTableBindingSource
            // 
            this.uVUPhoneNumsTableBindingSource.DataMember = "UVUPhoneNumsTable";
            this.uVUPhoneNumsTableBindingSource.DataSource = this.iNFO2200_CrandallSayDataSet;
            // 
            // uVUPhoneNumsTableTableAdapter
            // 
            this.uVUPhoneNumsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Participation4_JexJaacob.INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UVUPhoneNumsTableTableAdapter = this.uVUPhoneNumsTableTableAdapter;
            // 
            // uVUPhoneNumsTableBindingNavigator
            // 
            this.uVUPhoneNumsTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uVUPhoneNumsTableBindingNavigator.BindingSource = this.uVUPhoneNumsTableBindingSource;
            this.uVUPhoneNumsTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uVUPhoneNumsTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uVUPhoneNumsTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uVUPhoneNumsTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uVUPhoneNumsTableBindingNavigatorSaveItem});
            this.uVUPhoneNumsTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uVUPhoneNumsTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uVUPhoneNumsTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uVUPhoneNumsTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uVUPhoneNumsTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uVUPhoneNumsTableBindingNavigator.Name = "uVUPhoneNumsTableBindingNavigator";
            this.uVUPhoneNumsTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uVUPhoneNumsTableBindingNavigator.Size = new System.Drawing.Size(1149, 38);
            this.uVUPhoneNumsTableBindingNavigator.TabIndex = 0;
            this.uVUPhoneNumsTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // uVUPhoneNumsTableBindingNavigatorSaveItem
            // 
            this.uVUPhoneNumsTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uVUPhoneNumsTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uVUPhoneNumsTableBindingNavigatorSaveItem.Image")));
            this.uVUPhoneNumsTableBindingNavigatorSaveItem.Name = "uVUPhoneNumsTableBindingNavigatorSaveItem";
            this.uVUPhoneNumsTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.uVUPhoneNumsTableBindingNavigatorSaveItem.Text = "Save Data";
            this.uVUPhoneNumsTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.uVUPhoneNumsTableBindingNavigatorSaveItem_Click);
            // 
            // uVUPhoneNumsIdLabel
            // 
            uVUPhoneNumsIdLabel.AutoSize = true;
            uVUPhoneNumsIdLabel.Location = new System.Drawing.Point(156, 97);
            uVUPhoneNumsIdLabel.Name = "uVUPhoneNumsIdLabel";
            uVUPhoneNumsIdLabel.Size = new System.Drawing.Size(157, 20);
            uVUPhoneNumsIdLabel.TabIndex = 1;
            uVUPhoneNumsIdLabel.Text = "UVUPhone Nums Id:";
            // 
            // uVUPhoneNumsIdLabel1
            // 
            this.uVUPhoneNumsIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uVUPhoneNumsTableBindingSource, "UVUPhoneNumsId", true));
            this.uVUPhoneNumsIdLabel1.Location = new System.Drawing.Point(319, 97);
            this.uVUPhoneNumsIdLabel1.Name = "uVUPhoneNumsIdLabel1";
            this.uVUPhoneNumsIdLabel1.Size = new System.Drawing.Size(100, 23);
            this.uVUPhoneNumsIdLabel1.TabIndex = 2;
            this.uVUPhoneNumsIdLabel1.Text = "label1";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(535, 100);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameListBox
            // 
            this.firstNameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uVUPhoneNumsTableBindingSource, "FirstName", true));
            this.firstNameListBox.DataSource = this.uVUPhoneNumsTableBindingSource;
            this.firstNameListBox.DisplayMember = "FirstName";
            this.firstNameListBox.FormattingEnabled = true;
            this.firstNameListBox.ItemHeight = 20;
            this.firstNameListBox.Location = new System.Drawing.Point(631, 100);
            this.firstNameListBox.Name = "firstNameListBox";
            this.firstNameListBox.Size = new System.Drawing.Size(172, 144);
            this.firstNameListBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(223, 129);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uVUPhoneNumsTableBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(319, 126);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(194, 165);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(119, 20);
            phoneNumberLabel.TabIndex = 7;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uVUPhoneNumsTableBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(319, 162);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.phoneNumberTextBox.TabIndex = 8;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(215, 201);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(98, 20);
            departmentLabel.TabIndex = 9;
            departmentLabel.Text = "Department:";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uVUPhoneNumsTableBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(319, 198);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(100, 26);
            this.departmentTextBox.TabIndex = 10;
            // 
            // OnlinePhonesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1149, 692);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameListBox);
            this.Controls.Add(uVUPhoneNumsIdLabel);
            this.Controls.Add(this.uVUPhoneNumsIdLabel1);
            this.Controls.Add(this.uVUPhoneNumsTableBindingNavigator);
            this.Name = "OnlinePhonesForm";
            this.Text = "OnlinePhonesForm";
            this.Load += new System.EventHandler(this.OnlinePhonesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsTableBindingNavigator)).EndInit();
            this.uVUPhoneNumsTableBindingNavigator.ResumeLayout(false);
            this.uVUPhoneNumsTableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private INFO2200_CrandallSayDataSet iNFO2200_CrandallSayDataSet;
        private System.Windows.Forms.BindingSource uVUPhoneNumsTableBindingSource;
        private INFO2200_CrandallSayDataSetTableAdapters.UVUPhoneNumsTableTableAdapter uVUPhoneNumsTableTableAdapter;
        private INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uVUPhoneNumsTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uVUPhoneNumsTableBindingNavigatorSaveItem;
        private System.Windows.Forms.Label uVUPhoneNumsIdLabel1;
        private System.Windows.Forms.ListBox firstNameListBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
    }
}