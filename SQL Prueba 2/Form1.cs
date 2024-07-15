using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Prueba_2
{
    public partial class Form1 : Form
    {
        private List<Disco> listadisco;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscoServer server = new DiscoServer();
            listadisco = server.ListaDisco();
            dGVDiscos.DataSource = listadisco;
            pBxTapa.Load(listadisco[0].UrlImagenTapa);

        }

        private void dGVDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco Seleccionado = (Disco)dGVDiscos.CurrentRow.DataBoundItem;
            cargaimagen(Seleccionado.UrlImagenTapa);
        }
        private void cargaimagen(string Imagen) 
        {
            try
            {
                pBxTapa.Load(Imagen);
            }
            catch (Exception ex)
            {
                pBxTapa.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }
    }
}
 