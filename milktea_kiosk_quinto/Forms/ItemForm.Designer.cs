
namespace milktea_kiosk_quinto.Forms
{
    partial class ItemForm
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
            this.close_app_btn = new FontAwesome.Sharp.IconButton();
            this.item_picture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.no_label = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.quantity_updown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.add_btn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.item_picture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_updown)).BeginInit();
            this.SuspendLayout();
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
            this.close_app_btn.Location = new System.Drawing.Point(388, 0);
            this.close_app_btn.Name = "close_app_btn";
            this.close_app_btn.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.close_app_btn.Size = new System.Drawing.Size(24, 24);
            this.close_app_btn.TabIndex = 1;
            this.close_app_btn.UseVisualStyleBackColor = false;
            this.close_app_btn.Click += new System.EventHandler(this.close_app_btn_Click);
            // 
            // item_picture
            // 
            this.item_picture.Location = new System.Drawing.Point(116, 38);
            this.item_picture.Name = "item_picture";
            this.item_picture.Size = new System.Drawing.Size(180, 178);
            this.item_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.item_picture.TabIndex = 2;
            this.item_picture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 26);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price:";
            // 
            // no_label
            // 
            this.no_label.AutoSize = true;
            this.no_label.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_label.ForeColor = System.Drawing.Color.Black;
            this.no_label.Location = new System.Drawing.Point(115, 238);
            this.no_label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.no_label.Name = "no_label";
            this.no_label.Size = new System.Drawing.Size(32, 21);
            this.no_label.TabIndex = 3;
            this.no_label.Text = "No:";
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_label.ForeColor = System.Drawing.Color.Black;
            this.desc_label.Location = new System.Drawing.Point(115, 263);
            this.desc_label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(41, 21);
            this.desc_label.TabIndex = 3;
            this.desc_label.Text = "desc";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.Black;
            this.price_label.Location = new System.Drawing.Point(115, 288);
            this.price_label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(43, 21);
            this.price_label.TabIndex = 3;
            this.price_label.Text = "price";
            // 
            // quantity_updown
            // 
            this.quantity_updown.Font = new System.Drawing.Font("Quicksand Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_updown.Location = new System.Drawing.Point(146, 332);
            this.quantity_updown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.quantity_updown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity_updown.Name = "quantity_updown";
            this.quantity_updown.Size = new System.Drawing.Size(120, 24);
            this.quantity_updown.TabIndex = 4;
            this.quantity_updown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(71, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity:";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Quicksand SemiBold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.add_btn.IconColor = System.Drawing.Color.White;
            this.add_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_btn.IconSize = 20;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_btn.Location = new System.Drawing.Point(93, 376);
            this.add_btn.Name = "add_btn";
            this.add_btn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.add_btn.Size = new System.Drawing.Size(227, 35);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.quantity_updown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.desc_label);
            this.Controls.Add(this.no_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.item_picture);
            this.Controls.Add(this.close_app_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.item_picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_updown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton close_app_btn;
        private System.Windows.Forms.PictureBox item_picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label no_label;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.NumericUpDown quantity_updown;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton add_btn;
    }
}