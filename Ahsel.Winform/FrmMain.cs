using Ahsel.Winform.DataAccess;
using Ahsel.Winform.Entities;
using DevExpress.CodeParser;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private List<TotalPaymentDto> TotalPayments;
        private float GeneralTotal = 0;
        private float GeneralTotalExpanse = 0;

        public FrmMain(IGeneralDal generalDal)
        {
            InitializeComponent();
            GeneralDal = generalDal;
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            SetGridViewPattern();
            await LoadPayments();

            SetGridViewPattern2();
            await LoadTotalPayments();
        }

        private async Task GetTotalPayments()
        {
            var clients = new List<string>();
            foreach (var payment in Payments)
            {
                if (!payment.ClientName.Equals("gider", StringComparison.OrdinalIgnoreCase) && !payment.ClientName.Equals("satış", StringComparison.OrdinalIgnoreCase))
                    if (!clients.Any(x => x == payment.ClientName))
                        clients.Add(payment.ClientName);
            }
            clients.Sort();

            TotalPayments = new List<TotalPaymentDto>();

            foreach (var client in clients)
            {
                var x = Payments.FindAll(x => x.ClientName == client).Sum(x => x.Quantity * x.Price);
                TotalPayments.Add(
                    new TotalPaymentDto
                    {
                        ClientName = client,
                        TotalPayment = x,
                        RemainPayment = GeneralTotal / clients.Count - x
                    });
            }

            txtGeneralTotal.EditValue = string.Format("{0:#,#.##}", GeneralTotal) + "₺";
            txtGeneralTotalExpanse.EditValue = string.Format("{0:#,#.##}", GeneralTotalExpanse) + "₺";
            txtBalance.EditValue = string.Format("{0:#,#.##}", (GeneralTotal - GeneralTotalExpanse)) + "₺";
        }

        private async Task LoadTotalPayments()
        {
            await GetTotalPayments();

            if (!gridControl2.IsDisposed)
            {
                while (gridView2.DataRowCount != 0)
                    gridView2.DeleteRow(gridView2.DataRowCount - 1);

                foreach (var totalPayment in TotalPayments)
                {
                    gridView2.AddNewRow();
                    int rowHandle = gridView2.GetRowHandle(gridView2.DataRowCount);
                    if (gridView2.IsNewItemRow(rowHandle))
                    {
                        gridView2.SetRowCellValue(rowHandle, "ClientName", totalPayment.ClientName);
                        gridView2.SetRowCellValue(rowHandle, "TotalPayment", string.Format("{0:#,#.##}", totalPayment.TotalPayment) + "₺");
                        gridView2.SetRowCellValue(rowHandle, "RemainPayment", string.Format("{0:#,#.##}", totalPayment.RemainPayment) + "₺");
                    }
                }

                gridView1.FocusedRowHandle = 0;
            }
        }

        private async Task LoadPayments()
        {
            Payments = await GeneralDal.GetPaymentListAsync();
            GeneralTotal = Payments.Where(x => !x.ClientName.Equals("gider", StringComparison.OrdinalIgnoreCase) && !x.ClientName.Equals("satış", StringComparison.OrdinalIgnoreCase)).Sum(x => x.Quantity * x.Price);
            GeneralTotalExpanse = Payments.Where(x => x.ClientName.Equals("gider", StringComparison.OrdinalIgnoreCase) || x.ClientName.Equals("satış", StringComparison.OrdinalIgnoreCase)).Sum(x => x.Quantity * x.Price);

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
                        gridView1.SetRowCellValue(rowHandle, "Price", string.Format("{0:#,#.##}", payment.Price) + " ₺");
                        gridView1.SetRowCellValue(rowHandle, "Description", payment.Description);
                    }
                }

                gridView1.FocusedRowHandle = 0;
            }
        }

        private void SetGridViewPattern2()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Columns.Add("TotalPayment", typeof(string));
            dt.Columns.Add("RemainPayment", typeof(string));
            gridControl2.DataSource = dt;

            gridView2.Columns["ClientName"].Caption = "Cari Adı";
            gridView2.Columns["ClientName"].OptionsColumn.AllowEdit = false;

            gridView2.Columns["TotalPayment"].Caption = "Toplam Ödeme";
            gridView2.Columns["TotalPayment"].OptionsColumn.AllowEdit = false;

            gridView2.Columns["RemainPayment"].Caption = "Ödemesi Gereken";
            gridView2.Columns["RemainPayment"].OptionsColumn.AllowEdit = false;
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

            gridView1.Columns["Description"].Caption = "Açıklama";
            gridView1.Columns["Description"].OptionsColumn.AllowEdit = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmAddPayment frm = new FrmAddPayment();
            frm.FormClosed += new FormClosedEventHandler(FrmAddPayment_Closed);
            frm.ShowDialog();
        }

        private async void FrmAddPayment_Closed(object? sender, FormClosedEventArgs e)
        {
            await LoadPayments();
            await LoadTotalPayments();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}