using Ahsel.Winform.DataAccess;
using Ahsel.Winform.Entities;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Ahsel.Winform
{
    public partial class FrmAddPayment : DevExpress.XtraEditors.DirectXForm
    {
        private readonly IGeneralDal GeneralDal;
        private List<ClientDto> Clients;
        int ProjectRef = -1;
        public FrmAddPayment(int projectRef)
        {
            InitializeComponent();
            ProjectRef = projectRef;
            GeneralDal = (IGeneralDal)Program.ServiceProvider.GetService(typeof(IGeneralDal));
        }

        private async void FrmAddPayment_Load(object sender, EventArgs e)
        {
            Clients = await GeneralDal.GetClientListAsync(ProjectRef);

            FillCmbClient();

            FillDateDate();

            FillQuantity();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbClient.EditValue.ToString()))
            {
                MessageBox.Show("Cari boş olamaz!", "Hata");
                return;
            }

            var clientId = await GetClientId();
            var date = GetDate();
            var quantity = GetQuantity();

            if (string.IsNullOrEmpty(txtPrice.EditValue.ToString()))
            {
                MessageBox.Show("Fiyat boş olamaz!", "Hata");
                return;
            }

            var price = GetPrice();

            var reff = await GeneralDal.CreatePaymentAsync(new PaymentCreateDto { ClientRef = clientId, Quantity = quantity, Price = price, Date = date, Description = txtDescription.EditValue == null ? string.Empty : txtDescription.EditValue.ToString(), ProjectRef = ProjectRef });

            if (reff > 0)
                this.Close();
            else
                MessageBox.Show("Ödeme kaydederken bir hata oluştu!", "Hata");
        }

        private float GetPrice()
        {
            return string.IsNullOrEmpty(txtPrice.EditValue.ToString()) ? 1 : ((float.TryParse(txtPrice.EditValue.ToString(), out float p)) ? p : 1);
        }

        private int GetQuantity()
        {
            return string.IsNullOrEmpty(txtQuantity.EditValue.ToString()) ? 1 : ((int.TryParse(txtQuantity.EditValue.ToString(), out int q)) ? q : 1);
        }

        private DateTime GetDate()
        {
            if (dateDate.EditValue == null)
                return DateTime.Now;
            else return (DateTime)dateDate.EditValue;
        }

        private async Task<int> GetClientId()
        {
            var clientName = ((string)cmbClient.EditValue).Trim();

            var selectedClient = Clients.Find(x => x.Name.Equals(clientName, StringComparison.OrdinalIgnoreCase));

            if (selectedClient == null)
                return await GeneralDal.CreateClientAsync(clientName, ProjectRef);
            else
                return selectedClient.Id;
        }

        private void FillDateDate()
        {
            dateDate.EditValue = DateTime.Now;
        }

        private void FillQuantity()
        {
            txtQuantity.EditValue = 1;
        }

        private void FillCmbClient()
        {
            ComboBoxItemCollection coll = cmbClient.Properties.Items;
            coll.BeginUpdate();

            try
            {
                foreach (var client in Clients)
                    coll.Add(client.Name);
            }
            finally
            {
                coll.EndUpdate();
            }

            cmbClient.SelectedIndex = 0;
        }

        private void directXFormContainerControl1_Click(object sender, EventArgs e)
        {

        }
    }
}