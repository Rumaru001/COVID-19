using Autofac;
using CoVID.Parser;
using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CoVID
{
    public partial class MainPage : Form
    {
        Autofac.IContainer container;
        IDatabase database;
        Table table;
        int cntr = 0;
        public MainPage()
        {
            CreateInstance();
            database.Run(database);
            InitializeComponent();
        }


        #region Functions
        private void CreateInstance()
        {
            this.container = ContainerConfig.Configure();
            this.database = container.Resolve<IDatabase>();
            this.table = Table.GetTable(new string[] { "Country", "Cases", "Deaths", "Recoveries" });
        }
        
        private void Parse()
        {
            database.DeleteAll();
            ParserWorker parser = new ParserWorker(container.Resolve<IParser>(),
                                        container.Resolve<IParserSettings>(), database);
            parser.Start();
            
            for (int i = 0; i < 500; i++)
                Thread.Sleep(10);

        }
        private void ComboboxLoad()
        {
            try
            {
                string selectQuery = "SELECT * FROM info.countriesinfo2";
                var reader = database.GetReader(selectQuery);
                
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("country"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Check(string v)
        {
            if (File.Exists(v))
                File.Delete(v);
        }

        #endregion

        #region Events
        private void bParse_Click(object sender, EventArgs e)
        {
            using (LoadForm loadForm = new LoadForm(Parse))
            {
                loadForm.ShowDialog(this);
            }
            ComboboxLoad();
        }
        private void bUpdate_Click(object sender, EventArgs e)
        {
            ComboboxLoad();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT * FROM info.countriesinfo2 where country='"+comboBox1.Text+"'";
                var reader = database.GetReader(selectQuery);
                
                while (reader.Read())
                {
                    tBCountry.Text = reader.GetString("country");
                    tBCases.Text = reader.GetString("cases");
                    tBDeaths.Text = reader.GetString("deaths");
                    tBRecoveries.Text = reader.GetString("recoveries");
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                table.Rows.Add(tBCountry.Text, tBCases.Text, tBDeaths.Text, tBRecoveries.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            try
            {
                Check($"test{cntr}.pdf");
                var converter = container.Resolve<IConverter>(new TypedParameter(typeof(Table), table),
                    new NamedParameter("path", $"test{cntr}.pdf"), new NamedParameter("headerName", "COVID-19"));
                converter.Convert();
                if (chBPdf.Checked)
                {
                    System.Diagnostics.Process.Start($"test{cntr}.pdf");
                }
                table.Rows.Clear();
                cntr++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            database.DeleteAll();
            database.CloseConnection();
        }
        #endregion

    }
}
