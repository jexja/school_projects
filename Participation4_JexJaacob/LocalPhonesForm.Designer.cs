namespace Participation4_JexJaacob
{
    partial class LocalPhonesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalPhonesForm));
            this.phoneListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.phoneListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.phoneListDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonesDbDataSet = new Participation4_JexJaacob.PhonesDbDataSet();
            this.phoneListTableAdapter = new Participation4_JexJaacob.PhonesDbDataSetTableAdapters.PhoneListTableAdapter();
            this.tableAdapterManager = new Participation4_JexJaacob.PhonesDbDataSetTableAdapters.TableAdapterManager();
            this.BtnSortByLastName = new System.Windows.Forms.Button();
            this.BtnAgeOver30 = new System.Windows.Forms.Button();
            this.BtnAverageAge = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingNavigator)).BeginInit();
            this.phoneListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneListBindingNavigator
            // 
            this.phoneListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phoneListBindingNavigator.BindingSource = this.phoneListBindingSource;
            this.phoneListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.phoneListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.phoneListBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.phoneListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.phoneListBindingNavigatorSaveItem});
            this.phoneListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phoneListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phoneListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phoneListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phoneListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phoneListBindingNavigator.Name = "phoneListBindingNavigator";
            this.phoneListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phoneListBindingNavigator.Size = new System.Drawing.Size(1659, 38);
            this.phoneListBindingNavigator.TabIndex = 0;
            this.phoneListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // phoneListBindingNavigatorSaveItem
            // 
            this.phoneListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.phoneListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneListBindingNavigatorSaveItem.Image")));
            this.phoneListBindingNavigatorSaveItem.Name = "phoneListBindingNavigatorSaveItem";
            this.phoneListBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.phoneListBindingNavigatorSaveItem.Text = "Save Data";
            this.phoneListBindingNavigatorSaveItem.Click += new System.EventHandler(this.phoneListBindingNavigatorSaveItem_Click);
            // 
            // phoneListDataGridView
            // 
            this.phoneListDataGridView.AutoGenerateColumns = false;
            this.phoneListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.phoneListDataGridView.DataSource = this.phoneListBindingSource;
            this.phoneListDataGridView.Location = new System.Drawing.Point(0, 36);
            this.phoneListDataGridView.Name = "phoneListDataGridView";
            this.phoneListDataGridView.RowHeadersWidth = 62;
            this.phoneListDataGridView.RowTemplate.Height = 28;
            this.phoneListDataGridView.Size = new System.Drawing.Size(1647, 280);
            this.phoneListDataGridView.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(204, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PersonId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn5.HeaderText = "Age";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // phoneListBindingSource
            // 
            this.phoneListBindingSource.DataMember = "PhoneList";
            this.phoneListBindingSource.DataSource = this.phonesDbDataSet;
            // 
            // phonesDbDataSet
            // 
            this.phonesDbDataSet.DataSetName = "PhonesDbDataSet";
            this.phonesDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneListTableAdapter
            // 
            this.phoneListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PhoneListTableAdapter = this.phoneListTableAdapter;
            this.tableAdapterManager.UpdateOrder = Participation4_JexJaacob.PhonesDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BtnSortByLastName
            // 
            this.BtnSortByLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSortByLastName.Location = new System.Drawing.Point(862, 363);
            this.BtnSortByLastName.Name = "BtnSortByLastName";
            this.BtnSortByLastName.Size = new System.Drawing.Size(232, 90);
            this.BtnSortByLastName.TabIndex = 4;
            this.BtnSortByLastName.Text = "Sort By Last Name";
            this.BtnSortByLastName.UseVisualStyleBackColor = true;
            this.BtnSortByLastName.Click += new System.EventHandler(this.BtnSortByLastName_Click);
            // 
            // BtnAgeOver30
            // 
            this.BtnAgeOver30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgeOver30.Location = new System.Drawing.Point(1249, 363);
            this.BtnAgeOver30.Name = "BtnAgeOver30";
            this.BtnAgeOver30.Size = new System.Drawing.Size(232, 90);
            this.BtnAgeOver30.TabIndex = 4;
            this.BtnAgeOver30.Text = "Age > 30";
            this.BtnAgeOver30.UseVisualStyleBackColor = true;
            this.BtnAgeOver30.Click += new System.EventHandler(this.BtnAgeOver30_Click);
            // 
            // BtnAverageAge
            // 
            this.BtnAverageAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAverageAge.Location = new System.Drawing.Point(862, 508);
            this.BtnAverageAge.Name = "BtnAverageAge";
            this.BtnAverageAge.Size = new System.Drawing.Size(232, 90);
            this.BtnAverageAge.TabIndex = 4;
            this.BtnAverageAge.Text = "Average Age";
            this.BtnAverageAge.UseVisualStyleBackColor = true;
            this.BtnAverageAge.Click += new System.EventHandler(this.BtnAverageAge_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(1249, 508);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(232, 90);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LocalPhonesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 723);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnAverageAge);
            this.Controls.Add(this.BtnAgeOver30);
            this.Controls.Add(this.BtnSortByLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.phoneListDataGridView);
            this.Controls.Add(this.phoneListBindingNavigator);
            this.Name = "LocalPhonesForm";
            this.Text = "LocalPhonesForm";
            this.Load += new System.EventHandler(this.LocalPhonesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingNavigator)).EndInit();
            this.phoneListBindingNavigator.ResumeLayout(false);
            this.phoneListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhonesDbDataSet phonesDbDataSet;
        private System.Windows.Forms.BindingSource phoneListBindingSource;
        private PhonesDbDataSetTableAdapters.PhoneListTableAdapter phoneListTableAdapter;
        private PhonesDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator phoneListBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton phoneListBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView phoneListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSortByLastName;
        private System.Windows.Forms.Button BtnAgeOver30;
        private System.Windows.Forms.Button BtnAverageAge;
        private System.Windows.Forms.Button BtnClear;
    }
}