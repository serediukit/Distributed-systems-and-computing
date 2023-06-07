using System;
using System.CodeDom;
using System.Collections.Generic;

namespace Client
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        public void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.get_table = new System.Windows.Forms.Button();
            this.table_name = new System.Windows.Forms.TextBox();
            this.resultintable = new System.Windows.Forms.DataGridView();
            this.table_id = new System.Windows.Forms.TextBox();
            this.table_value = new System.Windows.Forms.TextBox();
            this.parameters = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.insert_data = new System.Windows.Forms.Button();
            this.find_by_id = new System.Windows.Forms.Button();
            this.delete_by_id = new System.Windows.Forms.Button();
            this.find_by_value = new System.Windows.Forms.Button();
            this.column_name = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.TextBox();
            this.find_by_filter = new System.Windows.Forms.Button();
            this.employee_list = new System.Windows.Forms.Button();
            this.order_list = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultintable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "get tables";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // get_table
            // 
            this.get_table.Location = new System.Drawing.Point(629, 12);
            this.get_table.Name = "get_table";
            this.get_table.Size = new System.Drawing.Size(119, 31);
            this.get_table.TabIndex = 2;
            this.get_table.Text = "get table";
            this.get_table.UseVisualStyleBackColor = true;
            this.get_table.Click += new System.EventHandler(this.get_table_by_name);
            // 
            // table_name
            // 
            this.table_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.table_name.BackColor = System.Drawing.SystemColors.Window;
            this.table_name.Location = new System.Drawing.Point(528, 59);
            this.table_name.Name = "table_name";
            this.table_name.Size = new System.Drawing.Size(132, 22);
            this.table_name.TabIndex = 3;
            this.table_name.Text = "table name";
            // 
            // resultintable
            // 
            this.resultintable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultintable.Location = new System.Drawing.Point(12, 12);
            this.resultintable.Name = "resultintable";
            this.resultintable.RowHeadersWidth = 51;
            this.resultintable.RowTemplate.Height = 24;
            this.resultintable.Size = new System.Drawing.Size(486, 308);
            this.resultintable.TabIndex = 6;
            // 
            // table_id
            // 
            this.table_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.table_id.BackColor = System.Drawing.SystemColors.Window;
            this.table_id.Location = new System.Drawing.Point(680, 59);
            this.table_id.Name = "table_id";
            this.table_id.Size = new System.Drawing.Size(132, 22);
            this.table_id.TabIndex = 7;
            this.table_id.Text = "table id";
            // 
            // table_value
            // 
            this.table_value.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.table_value.BackColor = System.Drawing.SystemColors.Window;
            this.table_value.Location = new System.Drawing.Point(840, 59);
            this.table_value.Name = "table_value";
            this.table_value.Size = new System.Drawing.Size(132, 22);
            this.table_value.TabIndex = 8;
            this.table_value.Text = "table value";
            // 
            // parameters
            // 
            this.parameters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.parameters.BackColor = System.Drawing.SystemColors.Window;
            this.parameters.Location = new System.Drawing.Point(680, 103);
            this.parameters.Name = "parameters";
            this.parameters.Size = new System.Drawing.Size(132, 22);
            this.parameters.TabIndex = 9;
            this.parameters.Text = "parameters";
            // 
            // data
            // 
            this.data.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.data.BackColor = System.Drawing.SystemColors.Window;
            this.data.Location = new System.Drawing.Point(840, 103);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(132, 22);
            this.data.TabIndex = 10;
            this.data.Text = "data";
            // 
            // insert_data
            // 
            this.insert_data.Location = new System.Drawing.Point(990, 99);
            this.insert_data.Name = "insert_data";
            this.insert_data.Size = new System.Drawing.Size(119, 31);
            this.insert_data.TabIndex = 11;
            this.insert_data.Text = "insert";
            this.insert_data.UseVisualStyleBackColor = true;
            this.insert_data.Click += new System.EventHandler(this.insert_data_Click);
            // 
            // find_by_id
            // 
            this.find_by_id.Location = new System.Drawing.Point(754, 12);
            this.find_by_id.Name = "find_by_id";
            this.find_by_id.Size = new System.Drawing.Size(119, 31);
            this.find_by_id.TabIndex = 12;
            this.find_by_id.Text = "find by id";
            this.find_by_id.UseVisualStyleBackColor = true;
            this.find_by_id.Click += new System.EventHandler(this.find_by_id_Click);
            // 
            // delete_by_id
            // 
            this.delete_by_id.Location = new System.Drawing.Point(879, 12);
            this.delete_by_id.Name = "delete_by_id";
            this.delete_by_id.Size = new System.Drawing.Size(119, 31);
            this.delete_by_id.TabIndex = 13;
            this.delete_by_id.Text = "delete by id";
            this.delete_by_id.UseVisualStyleBackColor = true;
            this.delete_by_id.Click += new System.EventHandler(this.delete_by_id_Click);
            // 
            // find_by_value
            // 
            this.find_by_value.Location = new System.Drawing.Point(990, 55);
            this.find_by_value.Name = "find_by_value";
            this.find_by_value.Size = new System.Drawing.Size(119, 31);
            this.find_by_value.TabIndex = 14;
            this.find_by_value.Text = "find by value";
            this.find_by_value.UseVisualStyleBackColor = true;
            this.find_by_value.Click += new System.EventHandler(this.find_by_value_Click);
            // 
            // column_name
            // 
            this.column_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.column_name.BackColor = System.Drawing.SystemColors.Window;
            this.column_name.Location = new System.Drawing.Point(528, 103);
            this.column_name.Name = "column_name";
            this.column_name.Size = new System.Drawing.Size(132, 22);
            this.column_name.TabIndex = 15;
            this.column_name.Text = "column name";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(1004, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(119, 31);
            this.edit.TabIndex = 16;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // filter
            // 
            this.filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filter.BackColor = System.Drawing.SystemColors.Window;
            this.filter.Location = new System.Drawing.Point(528, 140);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(230, 22);
            this.filter.TabIndex = 17;
            this.filter.Text = "filter";
            // 
            // find_by_filter
            // 
            this.find_by_filter.Location = new System.Drawing.Point(782, 136);
            this.find_by_filter.Name = "find_by_filter";
            this.find_by_filter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.find_by_filter.Size = new System.Drawing.Size(119, 31);
            this.find_by_filter.TabIndex = 18;
            this.find_by_filter.Text = "find by filter";
            this.find_by_filter.Click += new System.EventHandler(this.find_by_filter_Click);
            // 
            // employee_list
            // 
            this.employee_list.Location = new System.Drawing.Point(528, 192);
            this.employee_list.Name = "employee_list";
            this.employee_list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.employee_list.Size = new System.Drawing.Size(119, 31);
            this.employee_list.TabIndex = 19;
            this.employee_list.Text = "employee list";
            this.employee_list.Click += new System.EventHandler(this.employee_list_Click);
            // 
            // order_list
            // 
            this.order_list.Location = new System.Drawing.Point(653, 196);
            this.order_list.Name = "order_list";
            this.order_list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.order_list.Size = new System.Drawing.Size(119, 27);
            this.order_list.TabIndex = 20;
            this.order_list.Text = "order list";
            this.order_list.Click += new System.EventHandler(this.order_list_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1121, 631);
            this.Controls.Add(this.order_list);
            this.Controls.Add(this.employee_list);
            this.Controls.Add(this.find_by_filter);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.column_name);
            this.Controls.Add(this.find_by_value);
            this.Controls.Add(this.delete_by_id);
            this.Controls.Add(this.find_by_id);
            this.Controls.Add(this.insert_data);
            this.Controls.Add(this.data);
            this.Controls.Add(this.parameters);
            this.Controls.Add(this.table_value);
            this.Controls.Add(this.table_id);
            this.Controls.Add(this.resultintable);
            this.Controls.Add(this.table_name);
            this.Controls.Add(this.get_table);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resultintable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button get_table;
        private System.Windows.Forms.TextBox table_name;
        private System.Windows.Forms.DataGridView resultintable;
        private System.Windows.Forms.TextBox table_id;


        private System.Windows.Forms.TextBox table_value;
        private System.Windows.Forms.TextBox parameters;
        private System.Windows.Forms.TextBox data;


        private System.Windows.Forms.Button insert_data;
        private System.Windows.Forms.Button find_by_id;
        private System.Windows.Forms.Button delete_by_id;
        private System.Windows.Forms.Button find_by_value;
        private System.Windows.Forms.TextBox column_name;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox filter;
        private System.Windows.Forms.Button find_by_filter;
        private System.Windows.Forms.Button employee_list;
        private System.Windows.Forms.Button order_list;

    }

}
