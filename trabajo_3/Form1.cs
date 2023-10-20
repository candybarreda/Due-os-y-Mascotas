namespace trabajo_3
{
    public partial class Form1 : Form
    {
        List<Dueños> listaDueños = new List<Dueños>();
        List<Mascotas> listamascotas = new List<Mascotas>();
        public Form1()
        {
            InitializeComponent();
        }

        private void g_3_button_regsitrar_1_Click(object sender, EventArgs e)
        {

            if (g_3_nombreD.Text == "" || g_3_Direccion.Text == "" || g_3_telefono.Text == "")
                MessageBox.Show("Existen campos vacios", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                string G_3_nombreD = g_3_nombreD.Text;
                string G_3_Direccion = g_3_Direccion.Text;
                int G_3_telefono = int.Parse(g_3_telefono.Text);


                Dueños dueños = new Dueños();
                dueños.G_3_nombreD = G_3_nombreD;
                dueños.G_3_Direccion = G_3_Direccion;
                dueños.G_3_telefono = G_3_telefono;

                listaDueños.Add(dueños);

                ListViewItem lista = getListViewItemByDueños(dueños);

                g_3_listview.Items.Add(lista);
                g_3_dueño.Items.Add(dueños.G_3_nombreD);

                g_3_nombreD.Clear();
                g_3_Direccion.Clear();
                g_3_telefono.Clear();


            }
        }
        private ListViewItem getListViewItemByDueños(Dueños dueños)
        {
            ListViewItem lista = new ListViewItem(dueños.G_3_nombreD);

            lista.SubItems.Add(dueños.G_3_Direccion);
            lista.SubItems.Add(dueños.G_3_telefono.ToString());

            return lista;
        }
        private ListViewItem getListViewItemByMascota(Mascotas mascota)
        {
            ListViewItem lista = new ListViewItem(mascota.G_3_nom_mascota);

            Dueños dueño = buscarDueños(mascota.G_3_dueño);

            lista.SubItems.Add(mascota.G_3_edad_mascota);
            lista.SubItems.Add(mascota.G_3_raza_mascota);
            lista.SubItems.Add(mascota.G_3_dueño);

            lista.SubItems.Add(dueño.G_3_Direccion);
            lista.SubItems.Add(dueño.G_3_telefono.ToString());
            // Completar con los datos de los dueños a buscar


            return lista;
        }
        private void g_3_dueño_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Dueño = g_3_dueño.Text;

            if (Dueño == "")
            {
                MessageBox.Show("Mascota no encontrada", " Error");
                return;
            }

            Mascotas? mascotabuscada = listamascotas.Find((m) =>
            {
                return m.G_3_dueño == Dueño;
            });



        }

        private void g_3_nombreD_TextChanged(object sender, EventArgs e)
        {

        }

        private void g_3_button_registrar_2_Click(object sender, EventArgs e)
        {
            if (g_3_nom_mascota.Text == "" || g_3_edad_mascota.Text == "" || g_3_raza_mascota.Text == "" || g_3_dueño.Text == "")
                MessageBox.Show("Existen campos vacios", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                string G_3_nom_mascota = g_3_nom_mascota.Text;
                string G_3_edad_mascota = g_3_edad_mascota.Text;
                string G_3_raza_mascota = g_3_raza_mascota.Text;
                string G_3_dueño = g_3_dueño.Text;

                Mascotas mascotas = new Mascotas();
                mascotas.G_3_nom_mascota = G_3_nom_mascota;
                mascotas.G_3_edad_mascota = G_3_edad_mascota;
                mascotas.G_3_raza_mascota = G_3_raza_mascota;
                mascotas.G_3_dueño = G_3_dueño;

                listamascotas.Add(mascotas);

                ListViewItem lista = getListViewItemByMascota(mascotas);

                g_3_listview_2.Items.Add(lista);

                g_3_nom_mascota.Clear();
                g_3_edad_mascota.Clear();
                g_3_raza_mascota.Clear();

            }

        }

        private Dueños buscarDueños(string name)
        {
            string Dueño = g_3_dueño.Text;
            // Añadir busqueda de dueño
            Dueños? buscarDueño = listaDueños.Find((m) =>
            {
                return m.G_3_nombreD == name;
            });
            return buscarDueño;
        }

        private void g_3_button_buscar_Click(object sender, EventArgs e)
        {
            string Buscar = g_3_Buscar.Text;

            if (Buscar == "")
            {
                MessageBox.Show("Existen campos vacios", " Error");
                return;
            }

            Mascotas? mascotabuscada = listamascotas.Find((m) =>
            {
                return m.G_3_nom_mascota == Buscar;
            });

            if (mascotabuscada == null)

                MessageBox.Show("No se encontro Mascota", " Error");
            else
                MessageBox.Show("Se encontro Mascota");

            g_3_Buscar.Clear();
        }

        private void g_3_listview_2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}