namespace Ahsel.Winform
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            cmbProjects = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtBalance = new DevExpress.XtraEditors.TextEdit();
            txtGeneralTotalExpanse = new DevExpress.XtraEditors.TextEdit();
            txtGeneralTotal = new DevExpress.XtraEditors.TextEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            btnNew = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl2 = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbProjects.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBalance.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGeneralTotalExpanse.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGeneralTotal.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(cmbProjects);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(txtBalance);
            groupControl1.Controls.Add(txtGeneralTotalExpanse);
            groupControl1.Controls.Add(txtGeneralTotal);
            groupControl1.Controls.Add(simpleButton1);
            groupControl1.Controls.Add(btnNew);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.ShowCaption = false;
            groupControl1.Size = new Size(904, 80);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "groupControl1";
            // 
            // cmbProjects
            // 
            cmbProjects.Location = new Point(505, 32);
            cmbProjects.Name = "cmbProjects";
            cmbProjects.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbProjects.Size = new Size(100, 20);
            cmbProjects.TabIndex = 4;
            cmbProjects.SelectedIndexChanged += cmbProjects_SelectedIndexChanged;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(12, 60);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(31, 13);
            labelControl3.TabIndex = 8;
            labelControl3.Text = "Bakiye";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(12, 34);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(62, 13);
            labelControl2.TabIndex = 7;
            labelControl2.Text = "Toplam Gider";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(12, 8);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(71, 13);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "Toplam Ödeme";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(120, 57);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(126, 20);
            txtBalance.TabIndex = 5;
            // 
            // txtGeneralTotalExpanse
            // 
            txtGeneralTotalExpanse.Location = new Point(120, 31);
            txtGeneralTotalExpanse.Name = "txtGeneralTotalExpanse";
            txtGeneralTotalExpanse.Size = new Size(126, 20);
            txtGeneralTotalExpanse.TabIndex = 4;
            // 
            // txtGeneralTotal
            // 
            txtGeneralTotal.Location = new Point(120, 5);
            txtGeneralTotal.Name = "txtGeneralTotal";
            txtGeneralTotal.Size = new Size(126, 20);
            txtGeneralTotal.TabIndex = 3;
            // 
            // simpleButton1
            // 
            simpleButton1.AllowFocus = false;
            simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new Point(813, 12);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(40, 40);
            simpleButton1.TabIndex = 3;
            simpleButton1.ToolTip = "Bilgi";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // btnNew
            // 
            btnNew.AllowFocus = false;
            btnNew.ImageOptions.Image = (Image)resources.GetObject("btnNew.ImageOptions.Image");
            btnNew.Location = new Point(859, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(40, 40);
            btnNew.TabIndex = 2;
            btnNew.ToolTip = "Yeni Kayıt";
            btnNew.Click += btnNew_Click;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Bottom;
            gridControl1.Location = new Point(0, 184);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(904, 444);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl2
            // 
            gridControl2.Dock = DockStyle.Fill;
            gridControl2.Location = new Point(0, 80);
            gridControl2.MainView = gridView2;
            gridControl2.Name = "gridControl2";
            gridControl2.Size = new Size(904, 104);
            gridControl2.TabIndex = 2;
            gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.GridControl = gridControl2;
            gridView2.Name = "gridView2";
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // splitterControl1
            // 
            splitterControl1.Dock = DockStyle.Bottom;
            splitterControl1.Location = new Point(0, 174);
            splitterControl1.Name = "splitterControl1";
            splitterControl1.Size = new Size(904, 10);
            splitterControl1.TabIndex = 3;
            splitterControl1.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 628);
            Controls.Add(splitterControl1);
            Controls.Add(gridControl2);
            Controls.Add(gridControl1);
            Controls.Add(groupControl1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ahsel";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbProjects.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBalance.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGeneralTotalExpanse.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGeneralTotal.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txtGeneralTotal;
        private DevExpress.XtraEditors.TextEdit txtBalance;
        private DevExpress.XtraEditors.TextEdit txtGeneralTotalExpanse;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbProjects;
    }
}