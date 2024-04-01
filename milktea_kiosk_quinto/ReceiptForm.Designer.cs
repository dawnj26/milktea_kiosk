
namespace milktea_kiosk_quinto.Forms
{
    partial class ReceiptForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teatea_milkDataSet = new milktea_kiosk_quinto.teatea_milkDataSet();
            this.dataTable1TableAdapter = new milktea_kiosk_quinto.teatea_milkDataSetTableAdapters.DataTable1TableAdapter();
            this.close_app_btn = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatea_milkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "milktea_kiosk_quinto.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(693, 378);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.teatea_milkDataSet;
            // 
            // teatea_milkDataSet
            // 
            this.teatea_milkDataSet.DataSetName = "teatea_milkDataSet";
            this.teatea_milkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
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
            this.close_app_btn.Location = new System.Drawing.Point(694, 0);
            this.close_app_btn.Name = "close_app_btn";
            this.close_app_btn.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.close_app_btn.Size = new System.Drawing.Size(24, 24);
            this.close_app_btn.TabIndex = 3;
            this.close_app_btn.UseVisualStyleBackColor = false;
            this.close_app_btn.Click += new System.EventHandler(this.close_app_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand SemiBold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "Receipt";
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.close_app_btn);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatea_milkDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private teatea_milkDataSet teatea_milkDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private teatea_milkDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private FontAwesome.Sharp.IconButton close_app_btn;
        private System.Windows.Forms.Label label7;
    }
}