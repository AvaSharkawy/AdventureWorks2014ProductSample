using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnventureWorks2014Sample
{
    public static class UIHelpers
    {
        public static void ValidataNumberWithHotKeys(this KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        public static void ValidataNumberWithSeperators(this KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public static void ValidataNumberWithOneSeperator(this KeyPressEventArgs e, object sender)
        {
            e.ValidataNumberWithSeperators();

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static void SetComboBoxDataSource(this ComboBox combo, DataTable dataTable)
        {
            combo.DataSource = dataTable;
        }
    }
}
