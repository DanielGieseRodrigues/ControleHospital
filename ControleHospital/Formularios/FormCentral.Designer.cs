namespace ControleHospital.Formularios
{
    partial class FormCentral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnCadastrarPessoa = new System.Windows.Forms.Button();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDosagem = new System.Windows.Forms.TextBox();
            this.txtNomeMedicamento = new System.Windows.Forms.TextBox();
            this.btnCadastrarMedicamento = new System.Windows.Forms.Button();
            this.txtIdadeMinima = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtNomeDoenca = new System.Windows.Forms.TextBox();
            this.btnCadastrarDoenca = new System.Windows.Forms.Button();
            this.cbxSeveridade = new System.Windows.Forms.ComboBox();
            this.cbxPacienteEntrada = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEntradaPaciente = new System.Windows.Forms.Button();
            this.cbxPacienteASerMedicado = new System.Windows.Forms.ComboBox();
            this.cbxMedicacaoProPaciente = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRegistrarMedicacao = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxDoencaPaciente = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 274);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbxSeveridade);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtCid);
            this.tabPage1.Controls.Add(this.txtNomeDoenca);
            this.tabPage1.Controls.Add(this.btnCadastrarDoenca);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro Doença";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dtpDataNascimento);
            this.tabPage2.Controls.Add(this.txtCpf);
            this.tabPage2.Controls.Add(this.txtNomePessoa);
            this.tabPage2.Controls.Add(this.btnCadastrarPessoa);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro Pessoa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtIdadeMinima);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtDosagem);
            this.tabPage3.Controls.Add(this.txtNomeMedicamento);
            this.tabPage3.Controls.Add(this.btnCadastrarMedicamento);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(385, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cadastro Medicamento";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.cbxDoencaPaciente);
            this.tabPage4.Controls.Add(this.btnEntradaPaciente);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.cbxPacienteEntrada);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(385, 248);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Entrada paciente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnRegistrarMedicacao);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.cbxMedicacaoProPaciente);
            this.tabPage5.Controls.Add(this.cbxPacienteASerMedicado);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(385, 248);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Medicacao Paciente";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(385, 248);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Saida Paciente";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarPessoa
            // 
            this.btnCadastrarPessoa.Location = new System.Drawing.Point(25, 178);
            this.btnCadastrarPessoa.Name = "btnCadastrarPessoa";
            this.btnCadastrarPessoa.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrarPessoa.TabIndex = 0;
            this.btnCadastrarPessoa.Text = "Cadastrar";
            this.btnCadastrarPessoa.UseVisualStyleBackColor = true;
            this.btnCadastrarPessoa.Click += new System.EventHandler(this.btnCadastrarPessoa_Click);
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Location = new System.Drawing.Point(25, 44);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(100, 20);
            this.txtNomePessoa.TabIndex = 1;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(25, 88);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNascimento.Location = new System.Drawing.Point(25, 134);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.dtpDataNascimento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Idade minima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dosagem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome";
            // 
            // txtDosagem
            // 
            this.txtDosagem.Location = new System.Drawing.Point(21, 73);
            this.txtDosagem.Name = "txtDosagem";
            this.txtDosagem.Size = new System.Drawing.Size(100, 20);
            this.txtDosagem.TabIndex = 9;
            // 
            // txtNomeMedicamento
            // 
            this.txtNomeMedicamento.Location = new System.Drawing.Point(21, 29);
            this.txtNomeMedicamento.Name = "txtNomeMedicamento";
            this.txtNomeMedicamento.Size = new System.Drawing.Size(100, 20);
            this.txtNomeMedicamento.TabIndex = 8;
            // 
            // btnCadastrarMedicamento
            // 
            this.btnCadastrarMedicamento.Location = new System.Drawing.Point(21, 163);
            this.btnCadastrarMedicamento.Name = "btnCadastrarMedicamento";
            this.btnCadastrarMedicamento.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrarMedicamento.TabIndex = 7;
            this.btnCadastrarMedicamento.Text = "Cadastrar";
            this.btnCadastrarMedicamento.UseVisualStyleBackColor = true;
            this.btnCadastrarMedicamento.Click += new System.EventHandler(this.btnCadastrarMedicamento_Click);
            // 
            // txtIdadeMinima
            // 
            this.txtIdadeMinima.Location = new System.Drawing.Point(22, 119);
            this.txtIdadeMinima.Name = "txtIdadeMinima";
            this.txtIdadeMinima.Size = new System.Drawing.Size(100, 20);
            this.txtIdadeMinima.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Severidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "CID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nome";
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(22, 75);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 20);
            this.txtCid.TabIndex = 17;
            // 
            // txtNomeDoenca
            // 
            this.txtNomeDoenca.Location = new System.Drawing.Point(22, 31);
            this.txtNomeDoenca.Name = "txtNomeDoenca";
            this.txtNomeDoenca.Size = new System.Drawing.Size(100, 20);
            this.txtNomeDoenca.TabIndex = 16;
            // 
            // btnCadastrarDoenca
            // 
            this.btnCadastrarDoenca.Location = new System.Drawing.Point(22, 165);
            this.btnCadastrarDoenca.Name = "btnCadastrarDoenca";
            this.btnCadastrarDoenca.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrarDoenca.TabIndex = 15;
            this.btnCadastrarDoenca.Text = "Cadastrar";
            this.btnCadastrarDoenca.UseVisualStyleBackColor = true;
            this.btnCadastrarDoenca.Click += new System.EventHandler(this.btnCadastrarDoenca_Click);
            // 
            // cbxSeveridade
            // 
            this.cbxSeveridade.FormattingEnabled = true;
            this.cbxSeveridade.Location = new System.Drawing.Point(22, 126);
            this.cbxSeveridade.Name = "cbxSeveridade";
            this.cbxSeveridade.Size = new System.Drawing.Size(100, 21);
            this.cbxSeveridade.TabIndex = 21;
            // 
            // cbxPacienteEntrada
            // 
            this.cbxPacienteEntrada.FormattingEnabled = true;
            this.cbxPacienteEntrada.Location = new System.Drawing.Point(8, 36);
            this.cbxPacienteEntrada.Name = "cbxPacienteEntrada";
            this.cbxPacienteEntrada.Size = new System.Drawing.Size(135, 21);
            this.cbxPacienteEntrada.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Pessoa que irá dar entrada";
            // 
            // btnEntradaPaciente
            // 
            this.btnEntradaPaciente.Location = new System.Drawing.Point(12, 142);
            this.btnEntradaPaciente.Name = "btnEntradaPaciente";
            this.btnEntradaPaciente.Size = new System.Drawing.Size(135, 23);
            this.btnEntradaPaciente.TabIndex = 2;
            this.btnEntradaPaciente.Text = "Dar entrada";
            this.btnEntradaPaciente.UseVisualStyleBackColor = true;
            this.btnEntradaPaciente.Click += new System.EventHandler(this.btnEntradaPaciente_Click);
            // 
            // cbxPacienteASerMedicado
            // 
            this.cbxPacienteASerMedicado.DisplayMember = "Pessoa.Nome";
            this.cbxPacienteASerMedicado.FormattingEnabled = true;
            this.cbxPacienteASerMedicado.Location = new System.Drawing.Point(18, 43);
            this.cbxPacienteASerMedicado.Name = "cbxPacienteASerMedicado";
            this.cbxPacienteASerMedicado.Size = new System.Drawing.Size(121, 21);
            this.cbxPacienteASerMedicado.TabIndex = 0;
            // 
            // cbxMedicacaoProPaciente
            // 
            this.cbxMedicacaoProPaciente.FormattingEnabled = true;
            this.cbxMedicacaoProPaciente.Location = new System.Drawing.Point(18, 101);
            this.cbxMedicacaoProPaciente.Name = "cbxMedicacaoProPaciente";
            this.cbxMedicacaoProPaciente.Size = new System.Drawing.Size(121, 21);
            this.cbxMedicacaoProPaciente.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Medicamento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Paciente";
            // 
            // btnRegistrarMedicacao
            // 
            this.btnRegistrarMedicacao.Location = new System.Drawing.Point(18, 152);
            this.btnRegistrarMedicacao.Name = "btnRegistrarMedicacao";
            this.btnRegistrarMedicacao.Size = new System.Drawing.Size(121, 23);
            this.btnRegistrarMedicacao.TabIndex = 4;
            this.btnRegistrarMedicacao.Text = "Registrar medicação";
            this.btnRegistrarMedicacao.UseVisualStyleBackColor = true;
            this.btnRegistrarMedicacao.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Doença que o paciente tem";
            // 
            // cbxDoencaPaciente
            // 
            this.cbxDoencaPaciente.FormattingEnabled = true;
            this.cbxDoencaPaciente.Location = new System.Drawing.Point(12, 90);
            this.cbxDoencaPaciente.Name = "cbxDoencaPaciente";
            this.cbxDoencaPaciente.Size = new System.Drawing.Size(135, 21);
            this.cbxDoencaPaciente.TabIndex = 3;
            // 
            // FormCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 274);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCentral";
            this.Text = "Hospital do Necão";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNomePessoa;
        private System.Windows.Forms.Button btnCadastrarPessoa;
        private System.Windows.Forms.TextBox txtIdadeMinima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDosagem;
        private System.Windows.Forms.TextBox txtNomeMedicamento;
        private System.Windows.Forms.Button btnCadastrarMedicamento;
        private System.Windows.Forms.ComboBox cbxSeveridade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtNomeDoenca;
        private System.Windows.Forms.Button btnCadastrarDoenca;
        private System.Windows.Forms.Button btnEntradaPaciente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxPacienteEntrada;
        private System.Windows.Forms.Button btnRegistrarMedicacao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxMedicacaoProPaciente;
        private System.Windows.Forms.ComboBox cbxPacienteASerMedicado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxDoencaPaciente;
    }
}