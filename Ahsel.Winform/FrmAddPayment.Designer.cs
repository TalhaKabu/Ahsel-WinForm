namespace Ahsel.Winform
{
    partial class FrmAddPayment
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
            directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            txtPrice = new DevExpress.XtraEditors.TextEdit();
            txtQuantity = new DevExpress.XtraEditors.TextEdit();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            dateDate = new DevExpress.XtraEditors.DateEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            cmbClient = new DevExpress.XtraEditors.ComboBoxEdit();
            directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbClient.Properties).BeginInit();
            SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            directXFormContainerControl1.Controls.Add(txtPrice);
            directXFormContainerControl1.Controls.Add(txtQuantity);
            directXFormContainerControl1.Controls.Add(btnSave);
            directXFormContainerControl1.Controls.Add(labelControl4);
            directXFormContainerControl1.Controls.Add(labelControl3);
            directXFormContainerControl1.Controls.Add(labelControl2);
            directXFormContainerControl1.Controls.Add(dateDate);
            directXFormContainerControl1.Controls.Add(labelControl1);
            directXFormContainerControl1.Controls.Add(cmbClient);
            directXFormContainerControl1.Location = new Point(1, 31);
            directXFormContainerControl1.Name = "directXFormContainerControl1";
            directXFormContainerControl1.Size = new Size(218, 258);
            directXFormContainerControl1.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(10, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 20);
            txtPrice.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(10, 130);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 20);
            txtQuantity.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(10, 220);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Kaydet";
            btnSave.Click += btnSave_Click;
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(10, 160);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(24, 13);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "Fiyat";
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(10, 110);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(29, 13);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Miktar";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(10, 60);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(24, 13);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Tarih";
            // 
            // dateDate
            // 
            dateDate.EditValue = null;
            dateDate.Location = new Point(10, 80);
            dateDate.Name = "dateDate";
            dateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateDate.Size = new Size(200, 20);
            dateDate.TabIndex = 3;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(10, 10);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(19, 13);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Cari";
            // 
            // cmbClient
            // 
            cmbClient.Location = new Point(10, 30);
            cmbClient.Name = "cmbClient";
            cmbClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbClient.Size = new Size(200, 20);
            cmbClient.TabIndex = 1;
            // 
            // FrmAddPayment
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ChildControls.Add(directXFormContainerControl1);
            ClientSize = new Size(220, 290);
            Name = "FrmAddPayment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAddPayment";
            Load += FrmAddPayment_Load;
            directXFormContainerControl1.ResumeLayout(false);
            directXFormContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbClient.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbClient;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.TextEdit txtPrice;
    }
}