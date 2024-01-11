﻿using MoveInatorForms.Domains.Entities;
using MoveInatorForms.Utilities.Extensions;

namespace MoveInatorForms.Forms.Views
{
    public partial class CadastrosViewControl : UserControl
    {
        private readonly BindingSource EmpresasBindingSource = new BindingSource() { DataSource = new List<Empresa>() };

        private readonly BindingSource MotoristasBindingSource = new BindingSource() { DataSource = new List<Motorista>() };

        private List<Empresa> Empresas => EmpresasBindingSource.OfType<Empresa>().ToList();

        private List<Motorista> Motoristas => MotoristasBindingSource.OfType<Motorista>().ToList();

        public CadastrosViewControl()
        {
            InitializeComponent();

            Load();
        }

        private async Task Load()
        {
            dataGridViewEmpresas.DataSource = EmpresasBindingSource;
            dataGridViewMotoristas.DataSource = MotoristasBindingSource;
        }

        #region About Motoristas

        private Motorista BuildMotorista()
        {
            return new Motorista
            {
                Cpf = maskedTextBoxCpfMotorista.Text.OnlyNumber(),
                Nome = textBoxNomeMotorista.Text,
                Password = textBoxPassword.Text
            };
        }

        private void AddMotorista()
        {
            var motorista = BuildMotorista();

            MotoristasBindingSource.Add(motorista);
        }

        private void ValidateMotorista()
        {
            if (string.IsNullOrEmpty(textBoxNomeMotorista.Text))
                throw new Exception("Informe um Nome!");

            if (string.IsNullOrEmpty(maskedTextBoxCpfMotorista.Text.OnlyNumber()))
                throw new Exception("Informe um CPF para Motorista!");

            if (Motoristas.Any(x => x.Cpf == maskedTextBoxCpfMotorista.Text.OnlyNumber()))
                throw new Exception("Já possuí um Motorista com esse CPF!");
        }

        private void EnabledButtonsMotorista(bool enabled = true)
        {
            buttonAdicionarMotorista.Enabled = enabled;
        }

        private void ClearFieldsMotorista()
        {
            maskedTextBoxCpfMotorista.Text = string.Empty;
            textBoxNomeMotorista.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
        }

        #endregion

        #region About Empresas

        private Empresa BuildEmpresa()
        {
            return new Empresa
            {
                RazaoSocial = textBoxNomeRazaoSocial.Text,
                Cnpj = maskedTextBoxCnpjEmpresa.Text.OnlyNumber(),

                ClientId = textBoxClientId.Text,
                ClientSecrect = textBoxClientSecret.Text
            };
        }

        private void AddEmpresa()
        {
            var empresa = BuildEmpresa();

            EmpresasBindingSource.Add(empresa);
        }

        private void ValidateEmpresa()
        {
            if (string.IsNullOrEmpty(textBoxNomeRazaoSocial.Text))
                throw new Exception("Informe uma Razão Social!");

            if (string.IsNullOrEmpty(maskedTextBoxCnpjEmpresa.Text.OnlyNumber()))
                throw new Exception("Informe um CNPJ para Empresa!");

            if (Empresas.Any(x => x.Cnpj == maskedTextBoxCnpjEmpresa.Text.OnlyNumber()))
                throw new Exception("Já possuí uma empresa com esse CNPJ!");
        }

        private void EnabledButtonsEmpresa(bool enabled = true)
        {
            buttonAdicionarEmpresa.Enabled = enabled;
        }

        private void ClearFieldsEmpresa()
        {
            textBoxNomeRazaoSocial.Text = string.Empty;
            maskedTextBoxCnpjEmpresa.Text = string.Empty;
            textBoxClientId.Text = string.Empty;
            textBoxClientSecret.Text = string.Empty;
        }

        #endregion

        #region Events

        private void AdicionarEmpresa_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                EnabledButtonsEmpresa(false);

                ValidateEmpresa();

                AddEmpresa();

                ClearFieldsEmpresa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                EnabledButtonsEmpresa();
            }
        }

        private void RemoverEmpresa_ClickEvent(object sender, EventArgs e)
        {
            var row = dataGridViewEmpresas.SelectedRows.OfType<DataGridViewRow>().FirstOrDefault();

            if (row is null)
            {
                MessageBox.Show("Selecione uma empresa!");
                return;
            }

            EmpresasBindingSource.RemoveAt(row.Index);
        }



        private void AdicionarMotorista_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                EnabledButtonsMotorista(false);

                ValidateMotorista();

                AddMotorista();

                ClearFieldsMotorista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                EnabledButtonsMotorista();
            }
        }

        private void RemoverMotorista_ClickEvent(object sender, EventArgs e)
        {
            var row = dataGridViewMotoristas.SelectedRows.OfType<DataGridViewRow>().FirstOrDefault();

            if (row is null)
            {
                MessageBox.Show("Selecione um Motorista!");
                return;
            }

            MotoristasBindingSource.RemoveAt(row.Index);
        }

        #endregion

    }
}
