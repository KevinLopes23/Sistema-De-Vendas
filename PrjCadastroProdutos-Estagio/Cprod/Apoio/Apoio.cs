namespace Cprod.code.Apoio
{
    using System;


    public class Util
    {
        public static void ValidaData(MaskedTextBox campo)
        {
            try
            {
                if (campo.Text == "  /  /")
                {
                    return;
                }

                DateTime data = Convert.ToDateTime(campo.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Data invalida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                campo.Text = string.Empty;
                campo.Focus();
            }
        }

        public static bool IsNumber(ComboBox txtFiltro)
        {
            return txtFiltro.SelectedItem != null && txtFiltro.SelectedItem.ToString() == "CODPRODUTO";
        }

    }
}



