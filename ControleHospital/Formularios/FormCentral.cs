using ControleHospital.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleHospital.Formularios
{
    public partial class FormCentral : Form
    {
        List<Pessoa> listaPessoas = new List<Pessoa>();
        List<Medicamento> listaMedicamentos = new List<Medicamento>();
        List<Doenca> listaDoencas = new List<Doenca>();
        List<Paciente> listaPacientes = new List<Paciente>();

        public FormCentral()
        {
            InitializeComponent();

            cbxSeveridade.DataSource = Enum.GetValues(typeof(severidade));
            cbxSeveridade.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnCadastrarPessoa_Click(object sender, EventArgs e)
        {
            Pessoa pessoaQueVouAddNaLista = new Pessoa();
            pessoaQueVouAddNaLista.Nome = txtNomePessoa.Text;
            pessoaQueVouAddNaLista.CPF = txtCpf.Text;
            pessoaQueVouAddNaLista.DataNascimento = dtpDataNascimento.Value;

            listaPessoas.Add(pessoaQueVouAddNaLista);

            cbxPacienteEntrada.DataSource = null;
            cbxPacienteEntrada.DisplayMember = "Nome";
            cbxPacienteEntrada.DataSource = listaPessoas;

        }

        private void btnCadastrarMedicamento_Click(object sender, EventArgs e)
        {
            Medicamento medicamentoQueVouAddNaLista = new Medicamento();
            medicamentoQueVouAddNaLista.Nome = txtNomeMedicamento.Text;
            medicamentoQueVouAddNaLista.IdadeMinima = Convert.ToInt32(txtIdadeMinima.Text);
            medicamentoQueVouAddNaLista.Dosagem = Convert.ToDouble(txtDosagem.Text);

            listaMedicamentos.Add(medicamentoQueVouAddNaLista);

            cbxMedicacaoProPaciente.DataSource = null;
            cbxMedicacaoProPaciente.DisplayMember = "Nome";
            cbxMedicacaoProPaciente.DataSource = listaMedicamentos;
        }

        private void btnCadastrarDoenca_Click(object sender, EventArgs e)
        {
            Doenca doencaQueVouAddNaLista = new Doenca();
            doencaQueVouAddNaLista.Nome = txtNomeDoenca.Text;
            doencaQueVouAddNaLista.CID = txtCid.Text;
            doencaQueVouAddNaLista.Severidade = ((severidade)cbxSeveridade.SelectedIndex);
            listaDoencas.Add(doencaQueVouAddNaLista);


            cbxDoencaPaciente.DataSource = null;
            cbxDoencaPaciente.DisplayMember = "Nome";
            cbxDoencaPaciente.DataSource = listaDoencas;
        }

        private void btnEntradaPaciente_Click(object sender, EventArgs e)
        {
            Paciente pacienteQueVouAddNaLista = new Paciente();
            pacienteQueVouAddNaLista.Pessoa = listaPessoas[cbxPacienteEntrada.SelectedIndex];
            pacienteQueVouAddNaLista.Doenca = listaDoencas[cbxDoencaPaciente.SelectedIndex];
            pacienteQueVouAddNaLista.DataEntrada = DateTime.Now;
            listaPacientes.Add(pacienteQueVouAddNaLista);

            cbxPacienteASerMedicado.DataSource = null;
            cbxPacienteASerMedicado.DisplayMember = "NomePaciente";
            cbxPacienteASerMedicado.DataSource = listaPacientes;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listaPacientes[cbxPacienteASerMedicado.SelectedIndex].Medicamento
           = listaMedicamentos[cbxMedicacaoProPaciente.SelectedIndex];
        }


    }
}
