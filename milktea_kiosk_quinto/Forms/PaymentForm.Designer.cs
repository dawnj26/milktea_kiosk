
namespace milktea_kiosk_quinto.Forms
{
    partial class PaymentForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.close_app_btn = new FontAwesome.Sharp.IconButton();
            this.order_no_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.order_date_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grand_total_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cash_label = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.change_textbox = new System.Windows.Forms.TextBox();
            this.proceed_btn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand SemiBold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label7.Location = new System.Drawing.Point(16, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 33);
            this.label7.TabIndex = 5;
            this.label7.Text = "Payment";
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
            this.close_app_btn.Location = new System.Drawing.Point(350, -1);
            this.close_app_btn.Name = "close_app_btn";
            this.close_app_btn.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.close_app_btn.Size = new System.Drawing.Size(24, 24);
            this.close_app_btn.TabIndex = 2;
            this.close_app_btn.UseVisualStyleBackColor = false;
            this.close_app_btn.Click += new System.EventHandler(this.close_app_btn_Click);
            // 
            // order_no_label
            // 
            this.order_no_label.AutoSize = true;
            this.order_no_label.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_no_label.ForeColor = System.Drawing.Color.Black;
            this.order_no_label.Location = new System.Drawing.Point(127, 76);
            this.order_no_label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.order_no_label.Name = "order_no_label";
            this.order_no_label.Size = new System.Drawing.Size(32, 21);
            this.order_no_label.TabIndex = 6;
            this.order_no_label.Text = "No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order date:";
            // 
            // order_date_label
            // 
            this.order_date_label.AutoSize = true;
            this.order_date_label.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_date_label.ForeColor = System.Drawing.Color.Black;
            this.order_date_label.Location = new System.Drawing.Point(127, 101);
            this.order_date_label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.order_date_label.Name = "order_date_label";
            this.order_date_label.Size = new System.Drawing.Size(32, 21);
            this.order_date_label.TabIndex = 6;
            this.order_date_label.Text = "No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grand total:";
            // 
            // grand_total_textbox
            // 
            this.grand_total_textbox.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grand_total_textbox.Location = new System.Drawing.Point(131, 153);
            this.grand_total_textbox.Name = "grand_total_textbox";
            this.grand_total_textbox.ReadOnly = true;
            this.grand_total_textbox.Size = new System.Drawing.Size(217, 24);
            this.grand_total_textbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cash tendered:";
            // 
            // cash_label
            // 
            this.cash_label.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_label.Location = new System.Drawing.Point(131, 183);
            this.cash_label.Name = "cash_label";
            this.cash_label.Size = new System.Drawing.Size(217, 24);
            this.cash_label.TabIndex = 8;
            this.cash_label.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cash_label_KeyPress);
            this.cash_label.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cash_label_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount paid:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Change:";
            // 
            // amount_textbox
            // 
            this.amount_textbox.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_textbox.Location = new System.Drawing.Point(131, 230);
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.ReadOnly = true;
            this.amount_textbox.Size = new System.Drawing.Size(217, 24);
            this.amount_textbox.TabIndex = 8;
            // 
            // change_textbox
            // 
            this.change_textbox.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_textbox.Location = new System.Drawing.Point(131, 260);
            this.change_textbox.Name = "change_textbox";
            this.change_textbox.ReadOnly = true;
            this.change_textbox.Size = new System.Drawing.Size(217, 24);
            this.change_textbox.TabIndex = 8;
            this.change_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cash_label_KeyPress);
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
            this.proceed_btn.Location = new System.Drawing.Point(22, 364);
            this.proceed_btn.Name = "proceed_btn";
            this.proceed_btn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.proceed_btn.Size = new System.Drawing.Size(321, 35);
            this.proceed_btn.TabIndex = 9;
            this.proceed_btn.Text = "Proceed to payment";
            this.proceed_btn.UseVisualStyleBackColor = false;
            this.proceed_btn.Click += new System.EventHandler(this.proceed_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(235)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 26);
            this.panel1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Quicksand SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Payment";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.proceed_btn);
            this.Controls.Add(this.change_textbox);
            this.Controls.Add(this.cash_label);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.grand_total_textbox);
            this.Controls.Add(this.order_date_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.order_no_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.close_app_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton close_app_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label order_no_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label order_date_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grand_total_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cash_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.TextBox change_textbox;
        private FontAwesome.Sharp.IconButton proceed_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}