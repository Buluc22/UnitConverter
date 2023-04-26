using System.Diagnostics;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        private ConverterService _converterService;
        public Form1()
        {
            InitializeComponent();
            _converterService = new ConverterService();

            cmbType.DataSource = Enum.GetValues(typeof(TypeEnum));
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            lstFrom.DataSource = Enum.GetValues(typeof(MassEnum));
            lstTo.DataSource = Enum.GetValues(typeof(MassEnum));
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAmount.Text = String.Empty;
            txtConvertedAmount.Text = String.Empty;

            var type = (TypeEnum)cmbType.SelectedItem;

            switch (type)
            {
                case TypeEnum.Mass:
                    lstFrom.DataSource = Enum.GetValues(typeof(MassEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(MassEnum));
                    break;
                case TypeEnum.Temperature:
                    lstFrom.DataSource = Enum.GetValues(typeof(TemperatureEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(TemperatureEnum));
                    break;
                case TypeEnum.Time:
                    lstFrom.DataSource = Enum.GetValues(typeof(TimeEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(TimeEnum));
                    break;
                default:
                    break;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length <= 0)
            {
                return;
            }

            if (lstFrom.SelectedItems == lstTo.SelectedItems)
            {
                txtConvertedAmount.Text = txtAmount.Text;
            }

            var type = (TypeEnum)cmbType.SelectedItem;
            double amount = double.Parse(txtAmount.Text);
            double convertedAmount = 0;

            switch (type)
            {
                case TypeEnum.Mass:
                    var massFrom = (MassEnum)lstFrom.SelectedItem;
                    var massTo = (MassEnum)lstTo.SelectedItem;
                    convertedAmount = _converterService.ConvertMassUnit(massFrom, massTo, amount);
                    break;
                case TypeEnum.Temperature:
                    convertedAmount = _converterService.ConvertTemperatureUnit((TemperatureEnum)lstFrom.SelectedItem, (TemperatureEnum)lstTo.SelectedItem, amount);
                    break;
                case TypeEnum.Time:
                    var from = (TimeEnum)lstFrom.SelectedItem;
                    var to = (TimeEnum)lstTo.SelectedItem;
                    convertedAmount = _converterService.ConvertTimeUnit(from, to, amount);
                    break;
            }

            txtConvertedAmount.Text = convertedAmount.ToString();

        }
    }
}