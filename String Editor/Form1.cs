using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace String_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<StringContainer> StringList = new List<StringContainer>();


        string ISO = "ISO-8859-1";
        public int lastid3;
        public int lastid4;
        public int lastid5;
        public int lastid6;
        public string FileName;
        public string FileOpen;
        public string nation;

        public string ERROR_TITULO = "ERRO";
        public string ERROR_SUPORTE = "Este arquivo não é suportado";
        public string ERROR_NATION = "Por favor insira a nação no nome do arquivo, Exemplo: (strClient_XX.lod) XX = Nação";
        public string ERROR_SALVAR = "";

        public string SUCESSO_TITULO = "SUCESSO";
        public string SUCESSO_SALVAR = "Arquivo salvo com sucesso";

        public string INFORMACAO_TITULO = "INFORMAÇÃO";
        public string INFORMACAO_SALVAR = "Por favor insira a nação no nome do arquivo, Exemplo: (strClient_XX.lod) XX = Nação";


        private void Form1_Load(object sender, EventArgs e)
        {

            checkDir();

            
        }


        private void clean()
        {
            StringList.Clear();

            listBox1.Items.Clear();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            
        }


        private void readFile()
        {
  
            try
            {
                string SelectedItemName = FileName;
                string[] ItemSplit = SelectedItemName.Split('_');
                string[] SelectedStringItem = ItemSplit[1].Split('.');

                textBox4.Enabled = false;
                textBox5.Enabled = false;

                

                nation = SelectedStringItem[0];

               // if (nation.Length == 2)
                {
                    try
                    {
                        using (BinaryReader b = new BinaryReader(File.Open(FileOpen, FileMode.Open)))
                        {

                           

                            int lastid = b.ReadInt32();
                            int lastid2 = b.ReadInt32();
                            int lastidread = 0;

                            for (int i = 0; lastidread < lastid; i++)
                            {
                                StringContainer temp = new StringContainer();

                                int tmpID = b.ReadInt32();
                                temp.Index = tmpID;
                                lastidread = tmpID;
                                temp.name = b.ReadBytes(b.ReadInt32());

                                StringList.Add(temp);
                            }
                            
                            b.Close();
                            b.Dispose();
                        }

                        listBox1.Items.Clear();
                        makelist();
                    }
                    catch
                    {

                        MessageBox.Show(ERROR_SUPORTE, ERROR_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gbGeral.Enabled = false;
                    }

                }
            }
            catch
            {
                MessageBox.Show(ERROR_SUPORTE, ERROR_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbGeral.Enabled = false;
            }
        }

        private void makelist()
        {
            listBox1.Items.Clear();

            int sk = StringList.Count();
            for (int i = 0; i < sk; i++)
            {
                int ID = StringList[i].Index;
                string Name = Encoding.GetEncoding(ISO).GetString(StringList[i].name);

                listBox1.Items.Add(ID + " - " + Name);
            }

            menu_salvar.Enabled = true;
            gbGeral.Enabled = true;

        }

        private void checkDir()
        {

            if (!Directory.Exists(@"idiomas"))
            {
                Directory.CreateDirectory(@"idiomas");
                checkTranducao();
            }
            else
            {

                checkTranducao();
                
            }
            

        }

        private void checkTranducao()
        {

            if (Directory.EnumerateFileSystemEntries(@"idiomas").Any())
            {
                string[] filePatchs = Directory.GetFiles(@"idiomas");


                for (int i = 0; i < filePatchs.Length; i++)
                {

                    string filename = Path.GetFileNameWithoutExtension(filePatchs[i]);
                    cb_idioma.Items.Add(filename);

                    if (i == 0)
                    {
                        cb_idioma.Text = "pt-BR";
                        cb_idioma.SelectedItem = "pt-BR";
                    }

                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(@"idiomas\\en-US.txt"))
                {
                    writer.WriteLine("############## English - USA ##############");
                    writer.WriteLine("------------------- Menus -------------------");
                    writer.WriteLine("menu_arquivo=File");
                    writer.WriteLine("menu_abrir=Open");
                    writer.WriteLine("menu_salvar=Save");
                    writer.WriteLine("menu_sair=Exit");
                    writer.WriteLine("------------------- Label -------------------");
                    writer.WriteLine("label_buscar=Search");
                    writer.WriteLine("gb_geral=General");
                    writer.WriteLine("gb_editar=Edit");
                    writer.WriteLine("------------------- Buttons -----------------");
                    writer.WriteLine("btn_gravar=Save");
                    writer.WriteLine("------------------- ERRORs -----------------");
                    writer.WriteLine("erro_titulo=ERROR");
                    writer.WriteLine("erro_suporte=This File is not Supported");
                    writer.WriteLine("erro_nation=Please enter the nation in the file name, Example: (strClient_XX.lod) XX = Nation");
                    writer.WriteLine("erro_salvar=Could not save the file");
                    writer.WriteLine("------------------- SUCCESS -----------------");
                    writer.WriteLine("sucesso_titulo=SUCCESS");
                    writer.WriteLine("sucesso_gravar=Successfully saved changes");
                    writer.WriteLine("sucesso_salvar=Successfully saved file");
                    writer.WriteLine("------------------- INFORMATION ------------");
                    writer.WriteLine("iformacao_titulo=INFORMATION");
                    writer.WriteLine("informacao_salvar=Please enter the nation in the file name, Example: (strClient_XX.lod) XX = Nation");

                }

                using (StreamWriter writer = new StreamWriter(@"idiomas\\ru-RU.txt"))
                {
                    writer.WriteLine("############## Russian ##############");
                    writer.WriteLine("------------------- Menus -------------------");
                    writer.WriteLine("menu_arquivo=Файл");
                    writer.WriteLine("menu_abrir=Открыть");
                    writer.WriteLine("menu_salvar=Сохранить");
                    writer.WriteLine("menu_sair=Выход");
                    writer.WriteLine("------------------- Label -------------------");
                    writer.WriteLine("label_buscar=Поиск");
                    writer.WriteLine("gb_geral=Основное");
                    writer.WriteLine("gb_editar=Редактирование");
                    writer.WriteLine("------------------- Buttons -----------------");
                    writer.WriteLine("btn_gravar=Сохранить");
                    writer.WriteLine("------------------- ERRORs -----------------");
                    writer.WriteLine("erro_titulo=ОШИБКА");
                    writer.WriteLine("erro_suporte=Данный файл не поддерживается!");
                    writer.WriteLine("erro_nation=Пожалуйста укажите национальный код, Пример: (strClient_XX.lod) XX = Национальный код");
                    writer.WriteLine("erro_salvar=Cannot save file");
                    writer.WriteLine("------------------- SUCESS -----------------");
                    writer.WriteLine("sucesso_titulo=УСПЕШНО");
                    writer.WriteLine("sucesso_gravar=Изменения сохранены");
                    writer.WriteLine("sucesso_salvar=Файл сохранен");
                    writer.WriteLine("------------------- INFORMATION ------------");
                    writer.WriteLine("iformacao_titulo=ИНФОРМАЦИЯ");
                    writer.WriteLine("informacao_salvar=Пожалуйста используйте оригинальные названия файлов с национальным кодом,Пример: (strClient_XX.lod) XX = Национальный код");

                }

                using (StreamWriter writer = new StreamWriter(@"idiomas\\fr-FR.txt", true, Encoding.GetEncoding(ISO)))
                {
                    writer.WriteLine("############## Français - FRA ##############");
                    writer.WriteLine("------------------- Menus -------------------");
                    writer.WriteLine("menu_arquivo=File");
                    writer.WriteLine("menu_abrir=Ouvrir");
                    writer.WriteLine("menu_salvar=Sauvegarder");
                    writer.WriteLine("menu_sair=quitter");
                    writer.WriteLine("------------------- Label -------------------");
                    writer.WriteLine("label_buscar=Chercher");
                    writer.WriteLine("gb_geral=General");
                    writer.WriteLine("gb_editar=Edité");
                    writer.WriteLine("------------------- Bouttons -----------------");
                    writer.WriteLine("btn_gravar=Sauvegardé");
                    writer.WriteLine("------------------- ERREURs -----------------");
                    writer.WriteLine("erro_titulo=ERREUR");
                    writer.WriteLine("erro_suporte=Le fichier n'est pas supporter");
                    writer.WriteLine("erro_nation=S'il vous plait entré la nation du  fichier, Exemple: (strClient_XX.lod) XX = nation");
                    writer.WriteLine("erro_salvar=Ne peut pas sauvegardé  le fichier");
                    writer.WriteLine("------------------- SUCCESS -----------------");
                    writer.WriteLine("sucesso_titulo=Réussi");
                    writer.WriteLine("sucesso_gravar=Changement  réussi avec  succes");
                    writer.WriteLine("sucesso_salvar=Réussi fichier changé");
                    writer.WriteLine("------------------- INFORMATION ------------");
                    writer.WriteLine("iformacao_titulo=INFORMATION");
                    writer.WriteLine("informacao_salvar=S'il vous plait entré la nation du  fichier, Exemple: (strClient_XX.lod) XX = nation");

                }

                using (StreamWriter writer = new StreamWriter(@"idiomas\\pt-BR.txt", true, Encoding.GetEncoding(ISO)))
                {
                    writer.WriteLine("############## Português - BRASIL ##############");
                    writer.WriteLine("------------------- Menus -------------------");
                    writer.WriteLine("menu_arquivo=Arquivo");
                    writer.WriteLine("menu_abrir=Abrir");
                    writer.WriteLine("menu_salvar=Salvar");
                    writer.WriteLine("menu_sair=Sair");
                    writer.WriteLine("------------------- Label -------------------");
                    writer.WriteLine("label_buscar=Buscar");
                    writer.WriteLine("gb_geral=Geral");
                    writer.WriteLine("gb_editar=Editar");
                    writer.WriteLine("------------------- Buttons -----------------");
                    writer.WriteLine("btn_gravar=Gravar");
                    writer.WriteLine("------------------- ERRORs -----------------");
                    writer.WriteLine("erro_titulo=ERRO");
                    writer.WriteLine("erro_suporte=Este arquivo não é suportado");
                    writer.WriteLine("erro_nation=Por favor insira a nação no nome do arquivo, Exemplo: (strClient_XX.lod) XX = Nação");
                    writer.WriteLine("erro_salvar=Não foi possivel salvar o arquivo");
                    writer.WriteLine("------------------- SUCESS -----------------");
                    writer.WriteLine("sucesso_titulo=SUCESSO");
                    writer.WriteLine("sucesso_gravar=Alterações salvas com sucesso");
                    writer.WriteLine("sucesso_salvar=Arquivo salvo com sucesso");
                    writer.WriteLine("------------------- INFORMATION ------------");
                    writer.WriteLine("iformacao_titulo=INFORMAÇÃO");
                    writer.WriteLine("informacao_salvar=Por favor insira a nação no nome do arquivo, Exemplo: (strClient_XX.lod) XX = Nação");

                }

                using (StreamWriter writer = new StreamWriter(@"idiomas\\es-ES.txt", true, Encoding.GetEncoding(ISO)))
                {
                    writer.WriteLine("############## Espanhol - Google ##############");
                    writer.WriteLine("------------------- Menus -------------------");
                    writer.WriteLine("menu_arquivo=Archivo");
                    writer.WriteLine("menu_abrir=Abrir");
                    writer.WriteLine("menu_salvar=Guardar");
                    writer.WriteLine("menu_sair=Salir");
                    writer.WriteLine("------------------- Label -------------------");
                    writer.WriteLine("label_buscar=Hallar");
                    writer.WriteLine("gb_geral=General");
                    writer.WriteLine("gb_editar=Editar");
                    writer.WriteLine("------------------- Buttons -----------------");
                    writer.WriteLine("btn_gravar=Cambiar");
                    writer.WriteLine("------------------- ERRORs -----------------");
                    writer.WriteLine("erro_titulo=ERROR");
                    writer.WriteLine("erro_suporte=Este archivo no es compatible");
                    writer.WriteLine("erro_nation=Por favor, introduzca la nación en el nombre del archivo, Ejemplo: (strClient_XX.lod / strClient_XX.lod) XX = Nación");
                    writer.WriteLine("erro_salvar=No se pudo guardar el archivo");
                    writer.WriteLine("------------------- SUCCESS -----------------");
                    writer.WriteLine("sucesso_titulo=ÉXITO");
                    writer.WriteLine("sucesso_gravar=Cambios guardados con éxito");
                    writer.WriteLine("sucesso_salvar=Archivo guardado con éxito");
                    writer.WriteLine("------------------- INFORMATION ------------");
                    writer.WriteLine("iformacao_titulo=INFORMACIÓN");
                    writer.WriteLine("informacao_salvar=Por favor, introduzca la nación en el nombre del archivo, Ejemplo: (strClient_XX.lod / strClient_XX.lod) XX = Nación");
                }

                checkDir();



            }

        }

        private void menu_abrir_Click(object sender, EventArgs e)
        {
            


            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Abrir str*.dta";
            openFile.InitialDirectory = "";
            openFile.Filter = "str.lod|str*.lod|All|*.*";

            if (openFile.ShowDialog() != DialogResult.Cancel)
            {
                clean();

                this.Text = "Fenix LastChaos - Editando(" + openFile.SafeFileName + ")";
                FileName = openFile.SafeFileName;
                FileOpen = openFile.FileName;

                readFile();
                
                

                

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSucesso.Visible = false;

            if (listBox1.SelectedIndex != -1)
            {
                string SelectedItem = listBox1.SelectedItem.ToString();
                string[] ItemSplit = SelectedItem.Split('-');
                int Item = Convert.ToInt32(ItemSplit[0]);



                int it = StringList.FindIndex(p => p.Index.Equals(Item));


                textBox2.Text = Convert.ToString(Item);
                textBox3.Text = Encoding.GetEncoding(ISO).GetString(StringList[it].name);
                if (StringList[it].descr != null)
                {
                    textBox4.Text = Encoding.GetEncoding(ISO).GetString(StringList[it].descr);
                }

                if (StringList[it].descr2 != null)
                {
                    textBox5.Text = Encoding.GetEncoding(ISO).GetString(StringList[it].descr2);
                }





            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string SelectedItem = listBox1.SelectedItem.ToString();
                string[] ItemSplit = SelectedItem.Split('-');
                int Item = Convert.ToInt32(ItemSplit[0]);



                int it = StringList.FindIndex(p => p.Index.Equals(Item));


                StringList[it].Index = Convert.ToInt32(textBox2.Text);
                StringList[it].name = Encoding.GetEncoding(ISO).GetBytes(textBox3.Text);
                StringList[it].descr = Encoding.GetEncoding(ISO).GetBytes(textBox4.Text);




                int index = listBox1.SelectedIndex;
                string ItemName1 = listBox1.SelectedItem.ToString();
                string[] ItemNameSplit = ItemName1.Split('-');
                ItemNameSplit[1] = textBox3.Text;
                listBox1.Items[index] = (Item + " - " + ItemNameSplit[1]);

                lbSucesso.Visible = true;
            }
        }

        private void menu_salvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "All|*.*";
            saveFile.FileName = FileName;
            saveFile.Title = "Salvar str.dta";

            MessageBox.Show(INFORMACAO_SALVAR, INFORMACAO_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);



            if (saveFile.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    FileStream output = new FileStream(saveFile.FileName, FileMode.Create);
                    BinaryWriter w = new BinaryWriter(output);



                   // if (nation.Length == 2)
                    {
                        w.Write(StringList[StringList.Count() - 1].Index);
                        w.Write(StringList[StringList.Count() - 1].Index);

                       

                        for (int i = 0; i <= StringList.Count() - 1; i++)
                        {


                            w.Write(StringList[i].Index);
                            w.Write(StringList[i].name.Length);
                            w.Write(StringList[i].name);

                           


                        }
                        w.Close();

                       
                    }
                



                    MessageBox.Show(SUCESSO_SALVAR, SUCESSO_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch
                {
                    MessageBox.Show(ERROR_SALVAR, ERROR_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cb_idioma_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string line;

            StreamReader file;

            if (cb_idioma.Text == "ru-RU")
            {
                ISO = "windows-1251";
                if (FileOpen != null)
                {
                    makelist();
                }

                file = new StreamReader(@"idiomas\\" + cb_idioma.Text + ".txt");
               
            }
            else
            {
                

                ISO = "ISO-8859-1";
                if (FileOpen != null)
                {
                    makelist();
                }
                file = new StreamReader(@"idiomas\\" + cb_idioma.Text + ".txt", Encoding.GetEncoding(ISO), true);

            }

            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split('=');
                //----------------Menu----------------------------
                if (words[0] == "menu_arquivo")
                {
                    menu_arquivo.Text = words[1];
                }
                if (words[0] == "menu_abrir")
                {
                    menu_abrir.Text = words[1];
                }
                if (words[0] == "menu_salvar")
                {
                    menu_salvar.Text = words[1];
                }
                if (words[0] == "menu_sair")
                {
                    menu_sair.Text = words[1];
                }
                //----------------Label----------------------------
                if (words[0] == "label_buscar")
                {
                    lbBuscar.Text = words[1];
                }
                if (words[0] == "gb_geral")
                {
                    gbGeral.Text = words[1];
                }
                if (words[0] == "gb_editar")
                {

                    gbEditar.Text = words[1];

                }

                //----------------Buttons---------------------------
                if (words[0] == "btn_gravar")
                {

                    btnGravar.Text = words[1];
                }

                //----------------ERRORs---------------------------

                if (words[0] == "erro_titulo")
                {
                    ERROR_TITULO = words[1];
                }
                if (words[0] == "erro_suporte")
                {
                    ERROR_SUPORTE = words[1];
                }
                if (words[0] == "erro_nation")
                {
                    ERROR_NATION = words[1];
                }
                if (words[0] == "erro_salvar")
                {
                    ERROR_SALVAR = words[1];
                }

                //----------------SUCESSOs---------------------------

                if (words[0] == "sucesso_titulo")
                {
                    SUCESSO_TITULO = words[1];
                }
                if (words[0] == "sucesso_gravar")
                {
                    lbSucesso.Text = words[1];
                }
                if (words[0] == "sucesso_salvar")
                {
                    SUCESSO_SALVAR = words[1];
                }


                //------------------- INFORMATION ------------
                if (words[0] == "iformacao_titulo")
                {
                    INFORMACAO_TITULO = words[1];
                }
                if (words[0] == "informacao_salvar")
                {
                    INFORMACAO_SALVAR = words[1];
                }
            }

        }

        private void menu_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://www.fenixlastchaos.com";
            System.Diagnostics.Process.Start(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {

            this.listBox1.Items.Clear();
            int num = StringList.Count<StringContainer>();

            for (int i = 0; i < num; i++)
            {

                int ID = StringList[i].Index;
                string text = ID + " - " + Encoding.GetEncoding(ISO).GetString(StringList[i].name);

                if (text.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    this.listBox1.Items.Add(ID + " - " + Encoding.GetEncoding(ISO).GetString(StringList[i].name));
                }


            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count -1; i++)
            {
                
                listBox1.SelectedIndex = i;

                string SelectedItem = listBox1.SelectedItem.ToString();
                string[] ItemSplit = SelectedItem.Split('-');
                int Item = Convert.ToInt32(ItemSplit[0]);



                int it = StringList.FindIndex(p => p.Index.Equals(Item));


                StringList[it].Index = Convert.ToInt32(textBox2.Text);
                StringList[it].name = Encoding.GetEncoding(ISO).GetBytes(textBox3.Text);
                StringList[it].descr = Encoding.GetEncoding(ISO).GetBytes(textBox4.Text);
                StringList[it].descr2 = Encoding.GetEncoding(ISO).GetBytes(textBox5.Text);

                string conn = "server=192.168.15.225;user=admin;password=123;database=2015_data;";
                MySqlConnection myconn = new MySqlConnection(conn);
                string sq2 = "UPDATE t_rareoption SET a_name = \"" + Encoding.GetEncoding(ISO).GetString(StringList[it].name).Replace("'", @"\'").Replace("\"", "\\\"") + "\" WHERE a_index = " + StringList[it].Index.ToString() + ";";
                MySqlCommand cmd = new MySqlCommand(sq2, myconn);
                myconn.Open();
                cmd.ExecuteNonQuery();              // Updates database to set used = 1 for recovered number.
                myconn.Close();


                int index = listBox1.SelectedIndex;
                string ItemName1 = listBox1.SelectedItem.ToString();
                string[] ItemNameSplit = ItemName1.Split('-');
                ItemNameSplit[1] = textBox3.Text;
                listBox1.Items[index] = (Item + " - " + ItemNameSplit[1]);

                lbSucesso.Visible = true;

            }

            MessageBox.Show("FIM");
        }

       
    }
}
