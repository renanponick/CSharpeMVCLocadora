using System;
using Models;
using Controllers;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using View.Lib;

namespace View{
    public partial class ListagemClientes : Form{
        private Listners listagemClientes;
        private ButtonsVoltar buttonVoltar;
        private TablePadrao TablePadrao;
        public void InitializeComponent(){
            this.Text = "Listar Filmes";
            this.Size = new Size(370, 400);
            String[] coluns = {"ID","Nome","Data de Nascimento","Cpf"};
            listagemClientes = new Listners(coluns, 335, 300);
            this.TablePadrao = new TablePadrao(this.Width, this.Height-100);
            try{
                IEnumerable funcQuery = from clientes in ControllerCliente.GetClientes() select clientes;
                foreach (Cliente cliente in funcQuery) {
                    ListViewItem cliente1 = new ListViewItem(cliente.ClienteId.ToString());
                    cliente1.SubItems.Add(cliente.Nome);
                    cliente1.SubItems.Add(cliente.DataNascimento);
                    cliente1.SubItems.Add(cliente.Cpf.ToString());
                    listagemClientes.Items.AddRange(new ListViewItem[]{cliente1});
                }
            }catch(Exception){
                ListViewItem filme1 = new ListViewItem("Nenhum Cliente encontrado");
                listagemClientes.Items.AddRange(new ListViewItem[]{filme1});
            } 
            buttonVoltar = new ButtonsVoltar(this.Width/2, this.TablePadrao.Height, this ,this.parent);
            TablePadrao.Controls.Add(listagemClientes);
            this.Controls.Add(TablePadrao);
            this.Controls.Add(buttonVoltar);
        }
    }
    public partial class GetCliente : Form{
        private ButtonsVoltar buttonVoltar;
        private ButtonsBuscar buttonsBuscar;
        private ErrorProvider inputIdError;
        private LabelPadrao labelId;
        private InputPadrao inputId;
        private TablePadrao TablePadrao;
        public void InitializeComponent(){
            this.inputIdError = new ErrorProvider();
            this.inputIdError.SetIconAlignment(this.inputId, ErrorIconAlignment.MiddleRight);
            this.inputIdError.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.TablePadrao = new TablePadrao(this.Width, this.Height-100);
            this.Text = "Buscar Cliente";
            this.Height = 250;
            labelId = new LabelPadrao("Digite o ID do Cliente:", 200);
            inputId = new InputPadrao(150);
            buttonVoltar = new ButtonsVoltar(this.Width/3, this.TablePadrao.Height, this ,this.parent);
            buttonsBuscar = new ButtonsBuscar(this.Width/3, this.TablePadrao.Height, Buscar);
            this.Controls.Add(buttonVoltar);
            this.Controls.Add(buttonsBuscar);
            this.TablePadrao.Controls.Add(labelId);
            this.TablePadrao.Controls.Add(inputId);
            this.Controls.Add(TablePadrao);
        }
    }
     public partial class AddCliente : Form{
        ButtonsVoltar buttonVoltar;
        ButtonsSalvar buttonSalvar;
        LabelPadrao labelNome;
        LabelPadrao labelNascimento;
        LabelPadrao labelCpf;
        LabelPadrao labelDiasDev;
        InputPadrao inputNome;
        InputMascarado inputNascimento;
        InputMascarado inputCpf;
        InputMascarado inputDiasDev;
        private TablePadrao TablePadrao;
        public void InitializeComponent(Form parent, Boolean update){
            this.TablePadrao = new TablePadrao(this.Width, this.Height-100);
            this.parent = parent;
            this.Text = "Adicionar Cliente";
            this.Height = 400;

            if(update){
                // this.Load += new EventHandler(this.setDataClient);
            }
            
            labelNome = new LabelPadrao("Digite o Nome:", 10);
            inputNome = new InputPadrao(150);

            labelNascimento = new LabelPadrao("Digite a data de nascimento:", 200);
            inputNascimento = new InputMascarado(90, "99/99/9999");
            
            labelCpf = new LabelPadrao("Descreva o CPF:", 200);
            inputCpf = new InputMascarado(150, "999,999,999-99");

            labelDiasDev = new LabelPadrao("Digite a quantidade de dias para devolução:", 200);
            inputDiasDev = new InputMascarado(210, "09");

            buttonVoltar = new ButtonsVoltar(this.Width/3, this.TablePadrao.Height, this ,this.parent);
            buttonSalvar = new ButtonsSalvar(this.Width/3, this.TablePadrao.Height, Salvar);

            this.TablePadrao.Controls.Add(labelNome);
            this.TablePadrao.Controls.Add(inputNome);
            this.TablePadrao.Controls.Add(labelNascimento);
            this.TablePadrao.Controls.Add(inputNascimento);
            this.TablePadrao.Controls.Add(labelCpf);
            this.TablePadrao.Controls.Add(inputCpf);
            this.TablePadrao.Controls.Add(labelDiasDev);
            this.TablePadrao.Controls.Add(inputDiasDev);
            this.Controls.Add(TablePadrao);
            
            this.Controls.Add(buttonVoltar);
            this.Controls.Add(buttonSalvar);
        }
    }
}
           