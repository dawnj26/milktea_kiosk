
namespace milktea_kiosk_quinto
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_time_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regular_item = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.regular_picture = new System.Windows.Forms.PictureBox();
            this.pudding_item = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pudding_picture = new System.Windows.Forms.PictureBox();
            this.matcha_item = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.matcha_picture = new System.Windows.Forms.PictureBox();
            this.pearl_item = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pearl_picture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cart_table = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.close_app_btn = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.grand_total_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.proceed_btn = new FontAwesome.Sharp.IconButton();
            this.order_no_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.regular_item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regular_picture)).BeginInit();
            this.pudding_item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pudding_picture)).BeginInit();
            this.matcha_item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matcha_picture)).BeginInit();
            this.pearl_item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pearl_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.date_time_label);
            this.panel1.Controls.Add(this.order_no_label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 26);
            this.panel1.TabIndex = 1;
            // 
            // date_time_label
            // 
            this.date_time_label.AutoSize = true;
            this.date_time_label.Font = new System.Drawing.Font("Quicksand SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time_label.ForeColor = System.Drawing.Color.Black;
            this.date_time_label.Location = new System.Drawing.Point(806, 1);
            this.date_time_label.Name = "date_time_label";
            this.date_time_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date_time_label.Size = new System.Drawing.Size(119, 21);
            this.date_time_label.TabIndex = 2;
            this.date_time_label.Text = "TeaTea with Milk";
            this.date_time_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "TeaTea with Milk";
            // 
            // regular_item
            // 
            this.regular_item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.regular_item.Controls.Add(this.label2);
            this.regular_item.Controls.Add(this.regular_picture);
            this.regular_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regular_item.Location = new System.Drawing.Point(29, 72);
            this.regular_item.Name = "regular_item";
            this.regular_item.Size = new System.Drawing.Size(170, 200);
            this.regular_item.TabIndex = 3;
            this.regular_item.Click += new System.EventHandler(this.regular_item_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Regular";
            this.label2.Click += new System.EventHandler(this.regular_item_Click);
            // 
            // regular_picture
            // 
            this.regular_picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.regular_picture.Image = global::milktea_kiosk_quinto.Properties.Resources.Regular_Milk_tea;
            this.regular_picture.Location = new System.Drawing.Point(0, 0);
            this.regular_picture.Name = "regular_picture";
            this.regular_picture.Size = new System.Drawing.Size(166, 165);
            this.regular_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regular_picture.TabIndex = 2;
            this.regular_picture.TabStop = false;
            this.regular_picture.Click += new System.EventHandler(this.regular_item_Click);
            // 
            // pudding_item
            // 
            this.pudding_item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pudding_item.Controls.Add(this.label3);
            this.pudding_item.Controls.Add(this.pudding_picture);
            this.pudding_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pudding_item.Location = new System.Drawing.Point(251, 71);
            this.pudding_item.Name = "pudding_item";
            this.pudding_item.Size = new System.Drawing.Size(170, 200);
            this.pudding_item.TabIndex = 3;
            this.pudding_item.Click += new System.EventHandler(this.pudding_item_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Red Bean and Pudding";
            this.label3.Click += new System.EventHandler(this.pudding_item_Click);
            // 
            // pudding_picture
            // 
            this.pudding_picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pudding_picture.Image = global::milktea_kiosk_quinto.Properties.Resources.Red_Bean_and_Pudding_Milk_Tea;
            this.pudding_picture.Location = new System.Drawing.Point(0, 0);
            this.pudding_picture.Name = "pudding_picture";
            this.pudding_picture.Size = new System.Drawing.Size(166, 165);
            this.pudding_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pudding_picture.TabIndex = 2;
            this.pudding_picture.TabStop = false;
            this.pudding_picture.Click += new System.EventHandler(this.pudding_item_Click);
            // 
            // matcha_item
            // 
            this.matcha_item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.matcha_item.Controls.Add(this.label4);
            this.matcha_item.Controls.Add(this.matcha_picture);
            this.matcha_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matcha_item.Location = new System.Drawing.Point(31, 290);
            this.matcha_item.Name = "matcha_item";
            this.matcha_item.Size = new System.Drawing.Size(170, 200);
            this.matcha_item.TabIndex = 3;
            this.matcha_item.Click += new System.EventHandler(this.matcha_item_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Red Bean and Pudding Matcha";
            this.label4.Click += new System.EventHandler(this.matcha_item_Click);
            // 
            // matcha_picture
            // 
            this.matcha_picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.matcha_picture.Image = global::milktea_kiosk_quinto.Properties.Resources.Red_Bean_and_Pudding_Matcha;
            this.matcha_picture.Location = new System.Drawing.Point(0, 0);
            this.matcha_picture.Name = "matcha_picture";
            this.matcha_picture.Size = new System.Drawing.Size(166, 165);
            this.matcha_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.matcha_picture.TabIndex = 2;
            this.matcha_picture.TabStop = false;
            this.matcha_picture.Click += new System.EventHandler(this.matcha_item_Click);
            // 
            // pearl_item
            // 
            this.pearl_item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pearl_item.Controls.Add(this.label5);
            this.pearl_item.Controls.Add(this.pearl_picture);
            this.pearl_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pearl_item.Location = new System.Drawing.Point(251, 289);
            this.pearl_item.Name = "pearl_item";
            this.pearl_item.Size = new System.Drawing.Size(170, 200);
            this.pearl_item.TabIndex = 3;
            this.pearl_item.Click += new System.EventHandler(this.pearl_item_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pearl";
            this.label5.Click += new System.EventHandler(this.pearl_item_Click);
            // 
            // pearl_picture
            // 
            this.pearl_picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pearl_picture.Image = global::milktea_kiosk_quinto.Properties.Resources.Pearl_milk_tea;
            this.pearl_picture.Location = new System.Drawing.Point(0, 0);
            this.pearl_picture.Name = "pearl_picture";
            this.pearl_picture.Size = new System.Drawing.Size(166, 165);
            this.pearl_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pearl_picture.TabIndex = 2;
            this.pearl_picture.TabStop = false;
            this.pearl_picture.Click += new System.EventHandler(this.pearl_item_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand SemiBold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label6.Location = new System.Drawing.Point(23, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Items";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cart_table
            // 
            this.cart_table.AllowUserToAddRows = false;
            this.cart_table.AllowUserToDeleteRows = false;
            this.cart_table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cart_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cart_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            this.cart_table.Location = new System.Drawing.Point(507, 71);
            this.cart_table.MultiSelect = false;
            this.cart_table.Name = "cart_table";
            this.cart_table.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_table.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.cart_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cart_table.Size = new System.Drawing.Size(454, 279);
            this.cart_table.TabIndex = 5;
            this.cart_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cart_table_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand SemiBold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label7.Location = new System.Drawing.Point(501, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cart";
            // 
            // close_app_btn
            // 
            this.close_app_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.close_app_btn.FlatAppearance.BorderSize = 0;
            this.close_app_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_app_btn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.close_app_btn.IconColor = System.Drawing.Color.White;
            this.close_app_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close_app_btn.IconSize = 20;
            this.close_app_btn.Location = new System.Drawing.Point(962, 0);
            this.close_app_btn.Name = "close_app_btn";
            this.close_app_btn.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.close_app_btn.Size = new System.Drawing.Size(24, 24);
            this.close_app_btn.TabIndex = 0;
            this.close_app_btn.UseVisualStyleBackColor = false;
            this.close_app_btn.Click += new System.EventHandler(this.close_app_btn_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Item no";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 72;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.Width = 76;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 58;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "Sub-total";
            this.Column5.Name = "Column5";
            this.Column5.Width = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(502, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Grand Total:";
            // 
            // grand_total_label
            // 
            this.grand_total_label.AutoSize = true;
            this.grand_total_label.Font = new System.Drawing.Font("Quicksand Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grand_total_label.ForeColor = System.Drawing.Color.Black;
            this.grand_total_label.Location = new System.Drawing.Point(626, 383);
            this.grand_total_label.Name = "grand_total_label";
            this.grand_total_label.Size = new System.Drawing.Size(0, 28);
            this.grand_total_label.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(556, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "(Select cart item to edit)";
            // 
            // proceed_btn
            // 
            this.proceed_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.proceed_btn.FlatAppearance.BorderSize = 0;
            this.proceed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceed_btn.Font = new System.Drawing.Font("Quicksand SemiBold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed_btn.ForeColor = System.Drawing.Color.White;
            this.proceed_btn.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.proceed_btn.IconColor = System.Drawing.Color.White;
            this.proceed_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.proceed_btn.IconSize = 20;
            this.proceed_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.proceed_btn.Location = new System.Drawing.Point(507, 445);
            this.proceed_btn.Name = "proceed_btn";
            this.proceed_btn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.proceed_btn.Size = new System.Drawing.Size(454, 35);
            this.proceed_btn.TabIndex = 6;
            this.proceed_btn.Text = "Proceed to payment";
            this.proceed_btn.UseVisualStyleBackColor = false;
            this.proceed_btn.Click += new System.EventHandler(this.proceed_btn_Click);
            // 
            // order_no_label
            // 
            this.order_no_label.AutoSize = true;
            this.order_no_label.Font = new System.Drawing.Font("Quicksand SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_no_label.ForeColor = System.Drawing.Color.Black;
            this.order_no_label.Location = new System.Drawing.Point(463, 2);
            this.order_no_label.Name = "order_no_label";
            this.order_no_label.Size = new System.Drawing.Size(59, 21);
            this.order_no_label.TabIndex = 2;
            this.order_no_label.Text = "Order 1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(985, 538);
            this.Controls.Add(this.proceed_btn);
            this.Controls.Add(this.cart_table);
            this.Controls.Add(this.grand_total_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pearl_item);
            this.Controls.Add(this.matcha_item);
            this.Controls.Add(this.pudding_item);
            this.Controls.Add(this.regular_item);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close_app_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milktea kiosk";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.regular_item.ResumeLayout(false);
            this.regular_item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regular_picture)).EndInit();
            this.pudding_item.ResumeLayout(false);
            this.pudding_item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pudding_picture)).EndInit();
            this.matcha_item.ResumeLayout(false);
            this.matcha_item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matcha_picture)).EndInit();
            this.pearl_item.ResumeLayout(false);
            this.pearl_item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pearl_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton close_app_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox regular_picture;
        private System.Windows.Forms.Panel regular_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label date_time_label;
        private System.Windows.Forms.Panel pudding_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pudding_picture;
        private System.Windows.Forms.Panel matcha_item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox matcha_picture;
        private System.Windows.Forms.Panel pearl_item;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pearl_picture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView cart_table;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label grand_total_label;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton proceed_btn;
        private System.Windows.Forms.Label order_no_label;
    }
}

