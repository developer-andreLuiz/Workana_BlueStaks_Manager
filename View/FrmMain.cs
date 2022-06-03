using BotAbrirSoftware.DAO;
using BotAbrirSoftware.Helper;
using BotAbrirSoftware.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotAbrirSoftware.View
{
    public partial class FrmMain : Form
    {
        #region Variables
        int segundos = 0;
        string path = string.Empty;
        List<Emulador> ListaEmulador = new List<Emulador>();
        List<string> ListaComando = new List<string>();
         
        #endregion
        #region Functions
        void AbrirEmulador(string argumento)
        {
            
            Process.Start($"{Configuracao.pathBlueStacks}", $"--instance {argumento}");
        }
        void FecharEmuladores()
        {
            try
            {
                Process[] processos = Process.GetProcesses();
                foreach (Process p in processos)
                {
                    if (p.ProcessName.ToUpper().Equals("HD-PLAYER"))
                    {
                        try
                        {
                            p.Kill();
                            p.Close();
                        }
                        catch { }
                    }
                }
            }
            catch { }
           
        }

        //Configuração
        void ExibirConfig()
        {
            nUDIntervaloMinuto.Value = Configuracao.intervaloMinuto;
            nUDEmuladoresSimultaneos.Value = Configuracao.emuladorSimultaneo;
            lblPathBlueStacks.Text = Configuracao.pathBlueStacks;
        }

        //Banco de Dados
        void CarregarGrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = ListaEmulador;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 75;
            dataGridView.Columns[3].Width = 50;


            StatusLista();

        }
        void StatusLista()
        {
            lblEmuladoresTotais.Text = ListaEmulador.Count.ToString();
            lblEmuladoresHabilitados.Text=ListaEmulador.FindAll(x=>x.Habilitado>0).Count.ToString();
            lblEmuladoresEvento.Text = ListaEmulador.FindAll(x => x.Habilitado > 0 && x.Evento>0).Count.ToString();
        }
        void Limpar()
        {
            lblId.Text = String.Empty;
            txtComando.Text = String.Empty;
            chkHabilitado.Checked = true;
            chkEvento.Checked = false;
        }
       

        #endregion
        #region Events
        public FrmMain()
        {
            InitializeComponent();

            lblStatusSistema.Text = "Parado";

            //Configuração
            Configuracao.Informacoes();
            path = Configuracao.pathBlueStacks;
            ExibirConfig();

            //Banco de Dados
            ListaEmulador = EmuladorDAO.GetAll();
            CarregarGrid();
           
        }


        //Configuração
        private void btnSalvarConfig_Click(object sender, EventArgs e)
        {
            if (path.Contains("HD-Player.exe"))
            {
                Configuracao.Atualizar((int)nUDIntervaloMinuto.Value, (int)nUDEmuladoresSimultaneos.Value, path);
                ExibirConfig();
                MessageBox.Show("Atualizado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Caminho Incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btnPathBlueStacks_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileName.Contains("HD-Player.exe"))
                    {
                        path = openFileDialog.FileName;
                    }
                    else
                    {
                        MessageBox.Show("Caminho Incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        //Banco de Dados
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();

            txtComando.Focus();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Apagar Emulador ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    EmuladorDAO.Delete(ListaEmulador.Find(x => x.Id == int.Parse(lblId.Text)));
                    ListaEmulador = EmuladorDAO.GetAll();
                    Limpar();
                    CarregarGrid();
                    MessageBox.Show("Emulador Apagado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void btnResetar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Reiniciar o Evento dos Emuladores ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var list = ListaEmulador.FindAll(x => x.Habilitado > 0 && x.Evento > 0);
                foreach (var item in list)
                {
                    item.Evento = 0;
                    EmuladorDAO.Update(item);
                }
                ListaEmulador = EmuladorDAO.GetAll();
                Limpar();
                CarregarGrid();
                MessageBox.Show("Resetado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnApagarTodosEmuladores_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apagar Todos os  Emulador ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                EmuladorDAO.Truncate();
                ListaEmulador = EmuladorDAO.GetAll();
                Limpar();
                CarregarGrid();
                MessageBox.Show("Todos Emuladores Apagados", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSalvarEmulador_Click(object sender, EventArgs e)
        {
            if (txtComando.Text.Length == 0)
            {
                MessageBox.Show("Comando Incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (lblId.Text.Length == 0)//novo
            {
                Emulador emulador = new Emulador();
                emulador.Comando = txtComando.Text.Trim();
                emulador.Habilitado = chkHabilitado.Checked == true ? 1 : 0;
                emulador.Evento = chkEvento.Checked == true ? 1 : 0;
                EmuladorDAO.Insert(emulador);
                ListaEmulador = EmuladorDAO.GetAll();
                Limpar();
                CarregarGrid();
                MessageBox.Show("Inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Emulador emulador = new Emulador();
                emulador.Id = int.Parse(lblId.Text);
                emulador.Comando = txtComando.Text.Trim();
                emulador.Habilitado = chkHabilitado.Checked == true ? 1 : 0;
                emulador.Evento = chkEvento.Checked == true ? 1 : 0;
                EmuladorDAO.Update(emulador);
                ListaEmulador = EmuladorDAO.GetAll();
                Limpar();
                CarregarGrid();
                MessageBox.Show("Atualizado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                id = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch { }
            if (id > 0)
            {
                Emulador emulador = ListaEmulador.Find(x => x.Id == id);
                lblId.Text = emulador.Id.ToString();
                txtComando.Text = emulador.Comando.ToString();
                chkHabilitado.Checked = emulador.Habilitado == 1 ? true : false;
                chkEvento.Checked = emulador.Evento == 1 ? true : false;
            }
        }

        //Bot
        private void timer_Tick(object sender, EventArgs e)
        {

            segundos--;
            lblTimer.Text=segundos.ToString();
            if (segundos < 0)
            {
                FecharEmuladores();
                segundos = 60 * (int)nUDIntervaloMinuto.Value;
                int simultaneo = (int)nUDEmuladoresSimultaneos.Value;

                //reseta  
                if (ListaEmulador.FindAll(x=>x.Habilitado>0 && x.Evento==0).Count==0)
                {
                    var list = ListaEmulador.FindAll(x => x.Habilitado > 0 && x.Evento > 0);
                    foreach (var item in list)
                    {
                        item.Evento = 0;
                        EmuladorDAO.Update(item);
                    }
                    ListaEmulador = EmuladorDAO.GetAll();
                    Limpar();
                    CarregarGrid();

                }

                

                var list1 = ListaEmulador.FindAll(x => x.Habilitado > 0 && x.Evento == 0);
                foreach (var item in list1)
                {
                    if (simultaneo>0)
                    {
                        ListaComando.Add(item.Comando);
                        //AbrirEmulador(item.Comando);
                        item.Evento = 1;
                        EmuladorDAO.Update(item);
                        ListaEmulador = EmuladorDAO.GetAll();
                        Limpar();
                        CarregarGrid();
                        simultaneo--;
                    }

                }
                
               

                
               



            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (ListaEmulador.FindAll(x=>x.Habilitado>0).Count>0 && Configuracao.pathBlueStacks.Length>0)
            {
                lblStatusSistema.Text = "Rodando";
                timer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sem Emulador habilitado ou Caminho do BlueStacks invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }



        #endregion

        private void btnParar_Click(object sender, EventArgs e)
        {
            lblStatusSistema.Text = "Parado";
            timer.Enabled = false;
            ListaComando = new List<string>();
            FecharEmuladores();
        }

       

        private void timerOpenApp_Tick(object sender, EventArgs e)
        {
            if (ListaComando.Count>0)
            {
                AbrirEmulador(ListaComando[0]);
                ListaComando.RemoveAt(0);
            }
        }
    }
}
