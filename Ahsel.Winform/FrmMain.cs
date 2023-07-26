using Ahsel.Winform.DataAccess;
using Ahsel.Winform.Entities;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahsel.Winform
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        private readonly IGeneralDal GeneralDal;
        private List<PaymentDto> Payments;

        public FrmMain(IGeneralDal generalDal)
        {
            InitializeComponent();
            GeneralDal = generalDal;
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            SetGridViewPattern();
            LoadPayments();
        }

        private async void LoadPayments()
        {
            Payments = await GeneralDal.GetPaymentListAsync();

            if (!gridControl1.IsDisposed)
            {
                while (gridView1.DataRowCount != 0)
                    gridView1.DeleteRow(gridView1.DataRowCount - 1);

                foreach (var payment in Payments)
                {
                    gridView1.AddNewRow();
                    int rowHandle = gridView1.GetRowHandle(gridView1.DataRowCount);
                    if (gridView1.IsNewItemRow(rowHandle))
                    {
                        gridView1.SetRowCellValue(rowHandle, "Id", payment.Id);
                        gridView1.SetRowCellValue(rowHandle, "ClientName", payment.ClientName);
                        gridView1.SetRowCellValue(rowHandle, "Date", payment.Date);
                        gridView1.SetRowCellValue(rowHandle, "Quantity", payment.Quantity);
                        gridView1.SetRowCellValue(rowHandle, "Price", payment.Price + " ₺");
                        gridView1.SetRowCellValue(rowHandle, "Description", payment.Description);
                    }
                }

                gridView1.FocusedRowHandle = 0;
            }
        }

        private void SetGridViewPattern()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("ClientName", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            gridControl1.DataSource = dt;

            gridView1.Columns["Id"].Visible = false;

            gridView1.Columns["ClientName"].Caption = "Cari Adı";
            gridView1.Columns["ClientName"].OptionsColumn.AllowEdit = false;

            gridView1.Columns["Date"].Caption = "Tarih";
            gridView1.Columns["Date"].OptionsColumn.AllowEdit = false;

            gridView1.Columns["Quantity"].Caption = "Miktar";
            gridView1.Columns["Quantity"].OptionsColumn.AllowEdit = false;

            gridView1.Columns["Price"].Caption = "Fiyat";
            gridView1.Columns["Price"].OptionsColumn.AllowEdit = false;

            gridView1.Columns["Description"].Caption = "Açılama";
            gridView1.Columns["Description"].OptionsColumn.AllowEdit = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmAddPayment frm = new FrmAddPayment();
            frm.FormClosed += new FormClosedEventHandler(FrmAddPayment_Closed);
            frm.ShowDialog();
        }

        private void FrmAddPayment_Closed(object? sender, FormClosedEventArgs e)
        {
            LoadPayments();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}