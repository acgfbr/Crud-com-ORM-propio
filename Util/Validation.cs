using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Util
{
    public class Validation
    {
        private ErrorProvider errorProvider;
        private Boolean isValid = true;
        private Control invalidControl;

        public Boolean IsValid
        {
            get { return isValid; }
            set { isValid = value; }
        }

        public ErrorProvider ErrorProvider
        {
            get { return getErrorProvider(); }
            set { errorProvider = value; }
        }

        public Validation()
        {

        }

        public Boolean validateText(Control control, String message)
        {
            if (!String.IsNullOrEmpty(control.Text))
            {
                this.ErrorProvider.SetError(control, String.Empty);
            }
            else
            {
                this.isValid = false;
                this.ErrorProvider.SetError(control, message);
                this.setFirstInvalidation(control);
            }
            return this.isValid;
        }

        public Boolean validateTamanhoMinimo(Control control, int tamanho, String message)
        {
            if (control.Text.Length < tamanho)
            {
                this.ErrorProvider.SetError(control, String.Empty);
            }
            else
            {
                this.isValid = false;
                this.ErrorProvider.SetError(control, message);
                this.setFirstInvalidation(control);
            }
            return this.isValid;
        }

        public Boolean validateTextCPF(Control control, String message)
        {
            string cpf = control.Text.Replace("-", "");
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("/", "");
            cpf = cpf.Replace(" ", "");
            cpf = cpf.Replace("_", "");

            if (String.IsNullOrEmpty(cpf))
                this.ErrorProvider.SetError(control, String.Empty);
            else
            {
                string valor = cpf;
                //valor = valor.Replace("-", "");

                if (valor.Length != 11)
                    this.isValid = false;
                else
                {
                    bool igual = true;

                    for (int i = 1; i < 11 && igual; i++)
                        if (valor[i] != valor[0])
                            igual = false;

                    if (igual || valor == "12345678909")
                        this.isValid = false;

                    int[] numeros = new int[11];

                    for (int i = 0; i < 11; i++)
                        numeros[i] = int.Parse(valor[i].ToString());

                    int soma = 0;

                    for (int i = 0; i < 9; i++)
                        soma += (10 - i) * numeros[i];

                    int resultado = soma % 11;

                    if (resultado == 1 || resultado == 0)
                    {
                        if (numeros[9] != 0)
                            this.isValid = false;
                    }

                    else if (numeros[9] != 11 - resultado)
                        this.isValid = false;

                    soma = 0;

                    for (int i = 0; i < 10; i++)
                        soma += (11 - i) * numeros[i];

                    resultado = soma % 11;

                    if (resultado == 1 || resultado == 0)
                    {
                        if (numeros[10] != 0)
                            this.isValid = false;
                    }
                    else
                        if (numeros[10] != 11 - resultado)
                            this.isValid = false;
                }
                if (this.isValid == false)
                {
                    this.ErrorProvider.SetError(control, message);
                    this.setFirstInvalidation(control);
                }
                else
                {
                    this.ErrorProvider.SetError(control, String.Empty);
                }
            }
            return this.isValid;
        }

        public Boolean validateTextCNPJ(Control control, String message)
        {
            string cnpj = control.Text.Replace("-", "");
            cnpj = cnpj.Replace(".", "");
            cnpj = cnpj.Replace("/", "");
            cnpj = cnpj.Replace(" ", "");
            cnpj = cnpj.Replace("_", "");

            if (String.IsNullOrEmpty(cnpj))
                this.ErrorProvider.SetError(control, String.Empty);
            else
            {
                string CNPJ = cnpj.Replace(".", "");
                CNPJ = CNPJ.Replace("/", "");
                CNPJ = CNPJ.Replace("-", "");

                int[] digitos, soma, resultado;
                int nrDig;
                string ftmt;
                bool[] CNPJOk;
                ftmt = "6543298765432";
                digitos = new int[14];
                soma = new int[2];
                soma[0] = 0;
                soma[1] = 0;
                resultado = new int[2];
                resultado[0] = 0;
                resultado[1] = 0;
                CNPJOk = new bool[2];
                CNPJOk[0] = false;
                CNPJOk[1] = false;

                try
                {
                    for (nrDig = 0; nrDig < 14; nrDig++)
                    {
                        digitos[nrDig] = int.Parse(CNPJ.Substring(nrDig, 1));
                        if (nrDig <= 11)
                            soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));
                        if (nrDig <= 12)
                            soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
                    }

                    for (nrDig = 0; nrDig < 2; nrDig++)
                    {
                        resultado[nrDig] = (soma[nrDig] % 11);
                        if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                            CNPJOk[nrDig] = (digitos[12 + nrDig] == 0);
                        else
                            CNPJOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
                    }
                    this.isValid = (CNPJOk[0] && CNPJOk[1]);
                }
                catch
                {
                    this.isValid = false;
                }

                if (this.isValid == false)
                {
                    this.ErrorProvider.SetError(control, message);
                    this.setFirstInvalidation(control);
                }
                else
                {
                    this.ErrorProvider.SetError(control, String.Empty);
                }
            }
            return this.isValid;
        }

        public Boolean validateMaskedText(Control c, String message)
        {
            MaskedTextBox control = (MaskedTextBox)c;
            control.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!String.IsNullOrEmpty(control.Text))
            {
                this.ErrorProvider.SetError(control, String.Empty);
            }
            else
            {
                this.isValid = false;
                this.ErrorProvider.SetError(control, message);
                this.setFirstInvalidation(control);
            }
            control.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return this.isValid;
        }

        public Boolean validateEmailColoborador(Control control, String message)
        {
            if (!String.IsNullOrEmpty(control.Text))
            {
                Regex rx = new Regex(@"[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+");
                if (!rx.IsMatch(control.Text))
                {
                    this.isValid = false;
                    this.ErrorProvider.SetError(control, message);
                    this.setFirstInvalidation(control);
                }
            }

            return this.isValid;
        }

        internal void validateTelefoneMaskedText(MaskedTextBox tbNumeroTel, string p)
        {
            Regex r = new Regex(@"\(\d{2}\)\s?\d{3,4}-\d{3,}");
            if (r.IsMatch(tbNumeroTel.Text))
            {
                this.ErrorProvider.SetError(tbNumeroTel, String.Empty);
            }
            else
            {
                this.isValid = false;
                this.ErrorProvider.SetError(tbNumeroTel, p);
                this.setFirstInvalidation(tbNumeroTel);
            }
        }

        public Boolean validatePassword(Control control1, Control control2, String message)
        {
            if (!control1.Text.Equals(control2.Text))
            {
                this.isValid = false;
                this.ErrorProvider.SetError(control1, message);
                this.setFirstInvalidation(control1);
            }
            return this.isValid;
        }

        public Boolean validateEmail(Control control, String message)
        {
            Regex rx = new Regex(@"[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+");
            if (!rx.IsMatch(control.Text))
            {
                this.isValid = false;
                this.ErrorProvider.SetError(control, message);
                this.setFirstInvalidation(control);
            }
            return this.isValid;
        }

        internal Boolean validateCheckBox(CheckBox checkBox, string message, bool targetValue)
        {
            if (checkBox.Checked == targetValue)
            {
                this.ErrorProvider.SetError(checkBox, "");
            }
            else
            {
                this.isValid = false;
                this.ErrorProvider.SetError(checkBox, message);
                this.setFirstInvalidation(checkBox);
            }
            return this.isValid;
        }

        public Boolean validateComboBox(Control control, String message)
        {
            if (!String.IsNullOrEmpty(control.Text))
            {
                this.ErrorProvider.SetError(control, "");
            }
            else
            {
                this.isValid = false;
                this.ErrorProvider.SetError(control, message);
                this.setFirstInvalidation(control);
            }
            return this.isValid;
        }

        public Boolean validateInteger(Control control, String message)
        {
            try
            {
                Int32 n = Int32.Parse(control.Text);
                this.ErrorProvider.SetError(control, String.Empty);
            }
            catch (Exception)
            {
                this.ErrorProvider.SetError(control, message);
                this.isValid = false;
                this.setFirstInvalidation(control);
            }
            return this.isValid;
        }

        public Boolean validateDouble(Control control, String message)
        {
            try
            {
                Double n = Double.Parse(control.Text);
                this.ErrorProvider.SetError(control, String.Empty);
            }
            catch (Exception)
            {
                this.ErrorProvider.SetError(control, message);
                this.isValid = false;
                this.setFirstInvalidation(control);
            }
            return this.isValid;
        }

        public Boolean validateBirthday(Control control, string message)
        {
            try
            {
                MaskedTextBox bc = control as MaskedTextBox;
                if (!String.IsNullOrEmpty(bc.Text) && bc.Text != "  /  /")
                {
                    Regex rx = new Regex(@"^\d+/\d+/$"); //teste se a data é somente dia e mes
                    if (rx.IsMatch(bc.Text))
                    { //adiciona o ano 1800 como padrão caso nao informado
                        bc.Text += "1800";
                    }

                    DateTime nasc;
                    if (!DateTime.TryParse(bc.Text, out nasc)) //tenta parcear a data
                    {
                        this.ErrorProvider.SetError(control, message);
                        this.isValid = false;
                    }
                    else //se parse, ve se a data é superior a atual
                        if (nasc > DateTime.Today)
                        {
                            this.ErrorProvider.SetError(control, message);
                            this.isValid = false;
                        }
                        else
                            this.ErrorProvider.SetError(control, String.Empty);

                }
                else
                    this.ErrorProvider.SetError(control, String.Empty);
            }
            catch (Exception)
            {
                this.ErrorProvider.SetError(control, message);
                this.isValid = false;
                this.setFirstInvalidation(control);
            }
            return this.isValid;
        }

        public Boolean validateDate(Control control, string message, DateTime? start, DateTime? limit)
        {
            try
            {
                DateTime? dt = null;
                if (control.GetType().Name == "DateTimePicker") //Teste para DateTimePicker
                {
                    DateTimePicker dtp = ((DateTimePicker)control);
                    if (dtp.ShowCheckBox)
                    {
                        if (dtp.Checked)
                            dt = dtp.Value;
                    }
                    else
                        dt = dtp.Value;
                }
                else if (!String.IsNullOrEmpty(control.Text))
                {
                    dt = Convert.ToDateTime(control.Text);
                }

                if (dt != null)
                { //Existe uma data valida
                    if (start != null || limit != null)
                    {
                        if (start != null)
                        {
                            if (dt > start)
                            {
                                this.ErrorProvider.SetError(control, String.Empty);
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }

                        if (limit != null)
                        {
                            if (dt < limit)
                            {
                                this.ErrorProvider.SetError(control, String.Empty);
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                    else
                        this.ErrorProvider.SetError(control, String.Empty);
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                this.ErrorProvider.SetError(control, message);
                this.isValid = false;
                this.setFirstInvalidation(control);
            }
            return this.isValid;
        }


        public ErrorProvider getErrorProvider()
        {
            if (errorProvider == null)
            {
                errorProvider = new ErrorProvider();
                errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            }
            return this.errorProvider;
        }

        public void Free()
        {
            if (this.errorProvider != null)
                this.ErrorProvider.Clear();
            if (invalidControl != null)
                invalidControl = null;
            this.IsValid = true;
        }

        public void setFirstInvalidation(Control control)
        {
            if (invalidControl == null)
                invalidControl = control;
        }

        public void setFocus()
        {
            if (invalidControl != null)
                invalidControl.Select();
            //invalidControl.Focus();
        }

        public void validateCanceling(FormClosingEventArgs e, bool editing, TabControl control)
        {
            if (control.SelectedTab.Text == "tabDetalhes" && editing)
            {/*
                MsgBox mensagem = new MsgBox();
                mensagem.showMessage(MessageType.Confirmation, "Deseja cancelar atualizações?");
                */
                MessageBox.Show("Deseja cancelar atualizações?");
                /*
                e.Cancel = (mensagem.DialogResult != DialogResult.OK);*/
            }
        }

        public Boolean validateNomeIntencao(Control control, String message)
        {
            if (!String.IsNullOrEmpty(control.Text))
            {
                this.ErrorProvider.SetError(control, String.Empty);
            }
            else
            {
                this.isValid = false;
                this.ErrorProvider.SetError(control, message);
                this.setFirstInvalidation(control);
            }
            return this.isValid;
        }

        internal Boolean validateRadio(RadioButton[] radios, string message)
        {
            bool someCheck = false;
            foreach (RadioButton item in radios)
            {
                if (item.Checked)
                {
                    someCheck = true;
                    break;
                }
            }

            if (someCheck)
            {
                this.ErrorProvider.SetError(radios[0], "");
            }
            else
            {
                this.isValid = false;
                this.ErrorProvider.SetError(radios[0], message);
                this.setFirstInvalidation(radios[0]);
            }
            return this.isValid;
        }

        internal Boolean validateRadio(RadioButton[] radios, string message, Control aternativeAlertControl)
        {
            bool someCheck = false;
            foreach (RadioButton item in radios)
            {
                if (item.Checked)
                {
                    someCheck = true;
                    break;
                }
            }

            if (someCheck)
            {
                this.ErrorProvider.SetError(aternativeAlertControl, "");
            }
            else
            {
                this.isValid = false;
                this.ErrorProvider.SetError(aternativeAlertControl, message);
                this.setFirstInvalidation(aternativeAlertControl);
            }
            return this.isValid;
        }
    }
}
