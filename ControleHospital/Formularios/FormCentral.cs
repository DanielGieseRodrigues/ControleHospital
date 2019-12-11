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

        //REPOSITÓRIO DE DADOS (ONDE A GENTE VAI CADASTRAR OS NOSSOS DADOS
        List<Pessoa> listaPessoas = new List<Pessoa>();
        List<Medicamento> listaMedicamentos = new List<Medicamento>();
        List<Doenca> listaDoencas = new List<Doenca>();

        List<Paciente> listaPacientes = new List<Paciente>();

        public FormCentral()
        {
            InitializeComponent();

            //Carregar a minha caixa de severidade com os valores do Enumerador Severidade
            cbxSeveridade.DataSource = Enum.GetValues(typeof(severidade));
            //Recarrego a caixa de severidade
            cbxSeveridade.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnCadastrarPessoa_Click(object sender, EventArgs e)
        {
            //Crio uma nova pessoa para ser populada e adicionada na lista =)
            Pessoa pessoaQueVouAddNaLista = new Pessoa();
            //Preencho as informações da pessoa com os dados informados pelo usuário
            pessoaQueVouAddNaLista.Nome = txtNomePessoa.Text;
            pessoaQueVouAddNaLista.CPF = txtCpf.Text;
            pessoaQueVouAddNaLista.DataNascimento = dtpDataNascimento.Value;

            //Adiciono a pessoa recém criada na minha lista de pessoas.
            listaPessoas.Add(pessoaQueVouAddNaLista);
            MessageBox.Show("Cadastrado com sucesso");


            //Gambiarra para atualizar o nosso comboBox, pois senão ele vai ficar sempre com apenas um valor. 
            cbxPacienteEntrada.DataSource = null;
            //Qual a propriedade do objeto que eu vou querer exibir na lista.
            cbxPacienteEntrada.DisplayMember = "Nome";
            //Finalmente passo a fonte de dados do combobox para a Lista De pessoas.
            cbxPacienteEntrada.DataSource = listaPessoas;

        }

        private void btnCadastrarMedicamento_Click(object sender, EventArgs e)
        {
            //Crio um medicamento com o construtor padrão para popular e adicionar na lista.
            Medicamento medicamentoQueVouAddNaLista = new Medicamento();
            //Preencho as informacoes do medicamento com as informacoes digitadas pelo usuário
            medicamentoQueVouAddNaLista.Nome = txtNomeMedicamento.Text;
            medicamentoQueVouAddNaLista.IdadeMinima = Convert.ToInt32(txtIdadeMinima.Text);
            medicamentoQueVouAddNaLista.Dosagem = Convert.ToDouble(txtDosagem.Text);
            //Adiciono o medicamento na lista =)
            listaMedicamentos.Add(medicamentoQueVouAddNaLista);

            MessageBox.Show("Cadastrado com sucesso");

            cbxMedicacaoProPaciente.DataSource = null;
            cbxMedicacaoProPaciente.DisplayMember = "Nome";
            cbxMedicacaoProPaciente.DataSource = listaMedicamentos;
        }

        //Evento clique do botão cadastrar doença;
        private void btnCadastrarDoenca_Click(object sender, EventArgs e)
        {
            //Crio a doença com seu construtor padrão =)
            Doenca doencaQueVouAddNaLista = new Doenca();
            //Populo a doença com as informações digitadas pelo usuário
            doencaQueVouAddNaLista.Nome = txtNomeDoenca.Text;
            doencaQueVouAddNaLista.CID = txtCid.Text;
            //Conversão implícita de um Index para o nosso enumerador Severidade.
            doencaQueVouAddNaLista.Severidade = ((severidade)cbxSeveridade.SelectedIndex);
            //Adiciono a doença que eu populei na Lista.
            listaDoencas.Add(doencaQueVouAddNaLista);

            MessageBox.Show("Cadastrado com sucesso");

            //Zeramos a fonte de dados
            cbxDoencaPaciente.DataSource = null;
            //Escolhemos a propriedade que vamos exibir
            cbxDoencaPaciente.DisplayMember = "Nome";
            //Passamos a fonte de dados atualizada.
            cbxDoencaPaciente.DataSource = listaDoencas;
        }

        private void btnEntradaPaciente_Click(object sender, EventArgs e)
        {
            //Criar um objeto Paciente que vai ser populado com as informações do comboBox
            Paciente pacienteQueVouAddNaLista = new Paciente();
            //Populo o objeto paciente com a pessoa e a doenca selecionada. 
            //( São indices iguais, tanto o repositório quanto o combobox)
            pacienteQueVouAddNaLista.Pessoa = listaPessoas[cbxPacienteEntrada.SelectedIndex];
            pacienteQueVouAddNaLista.Doenca = listaDoencas[cbxDoencaPaciente.SelectedIndex];
            //Passo a hora atual como dataEntrada
            pacienteQueVouAddNaLista.DataEntrada = DateTime.Now;

            //Checo se a pessoa já é um paciente do hospital
            if (PessoaJaEhPaciente(pacienteQueVouAddNaLista))
            {
                MessageBox.Show("Essa pessoa já é um paciente do hospital!");
            }
            else
            {
                listaPacientes.Add(pacienteQueVouAddNaLista);
            }

            //Eu atualizo a combobox De pacientes com os novos dados.
            cbxPacienteASerMedicado.DataSource = null;
            cbxPacienteASerMedicado.DisplayMember = "NomePaciente";
            cbxPacienteASerMedicado.DataSource = listaPacientes;
        }

        private bool PessoaJaEhPaciente(Paciente pacienteQueVouProcurar)
        {
            Boolean ehPaciente =false;
            for (int i = 0; i < listaPacientes.Count; i++)
            {
                if (listaPacientes[i].Pessoa == pacienteQueVouProcurar.Pessoa)
                {
                    ehPaciente = true;
                    break;
                }
            }
            return ehPaciente;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
               /*Lista de paciente*/listaPacientes[/*Cara que ele selecionou*/cbxPacienteASerMedicado.SelectedIndex].Medicamento
                = /*Lista de medicamento*/listaMedicamentos[/*medicamento que ele selecionou*/cbxMedicacaoProPaciente.SelectedIndex];
        }

    }
}
