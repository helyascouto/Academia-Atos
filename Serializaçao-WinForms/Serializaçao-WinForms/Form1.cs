using Newtonsoft.Json;
using Serialização;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Serializaçao_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Elias Couto\source\repos\Serializaçao-WinForms\Serializaçao-WinForms\Mensagem.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, txbMensagem.Text);
            fs.Close();
            MessageBox.Show("Searilizado com Sucesso");
        }
        private void btnDeserializar_Click_1(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Elias Couto\source\repos\Serializaçao-WinForms\Serializaçao-WinForms\Mensagem.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string texto;
            texto = (string)bf.Deserialize(fs);
            MessageBox.Show(texto);
            txbMensagem.Text = texto;

        }



        private void btnSerializeXML_Click_1(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.idade = 21;
            p.nome = "Ricardo";
            p.salario = 850;
            FileStream fs = new FileStream(@"C:\Users\Elias Couto\source\repos\Serializaçao-WinForms\Serializaçao-WinForms\Pessoa.xml", FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            xml.Serialize(fs, p);
            fs.Close();
            /*  StreamWriter sw = new StreamWriter(@"C:\Teste\pessoa.xml");
              XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
              xml.Serialize(sw.BaseStream, p);
              sw.Close();*/
            MessageBox.Show("XML Serializado com sucesso!");
        }
        private void btnDesserializarXML_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            StreamReader sr = new StreamReader(@"C:\Users\Elias Couto\source\repos\Serializaçao-WinForms\Serializaçao-WinForms\Pessoa.xml");
            Pessoa pXML;
            pXML = (Pessoa)xml.Deserialize(sr.BaseStream);
            MessageBox.Show("Desserializado com sucesso!");
            txbXml.Text = pXML.nome;

        }

        private void btnSerializeJsomL_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.idade = 35;
            p.nome = "Elias";
            p.salario = 999;

            JsonSerializer serializer = new JsonSerializer();
            StreamWriter sw = new StreamWriter(@"C:\Users\Elias Couto\source\repos\Serializaçao-WinForms\Serializaçao-WinForms\Pessoa.json");
            JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, p);
            sw.Close();
            writer.Close();
            MessageBox.Show("Json serializado com sucesso!");
        }

        private void btnDeserializarJson_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\Users\Elias Couto\source\repos\Serializaçao-WinForms\Serializaçao-WinForms\Pessoa.json");
            Pessoa p = new Pessoa();
            p.idade = 2;
            p.nome = "Yam Couto";
            p.salario = 00;
            txbJson.Text = p.nome + p.idade.ToString() + p.salario.ToString();
            MessageBox.Show("Desserializado com sucesso!");
        }

        private void btnSerializeSoap_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.idade = 32;
            p.nome = "Lorena Couto";
            p.salario = 800;

            FileStream fs = new FileStream(@"C:\Users\Elias Couto\source\repos\Serializaçao-WinForms\Serializaçao-WinForms\Pessoa.data", FileMode.Create);
            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(fs, p);
            fs.Close();
            MessageBox.Show("Json serializado com sucesso!");


        }

        private void btnDeserializeSoap_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Elias Couto\source\repos\Serializaçao-WinForms\Serializaçao-WinForms\Pessoa.data", FileMode.Open);
            SoapFormatter soap = new SoapFormatter();
            Pessoa pessoa = new Pessoa();

            pessoa= (Pessoa)soap.Deserialize(fs);
            txbSoap.Text = pessoa.nome + pessoa.idade.ToString() + pessoa.salario.ToString();
            MessageBox.Show("Desserializado com sucesso!");
        }

       
    }
}