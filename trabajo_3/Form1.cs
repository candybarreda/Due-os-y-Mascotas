namespace trabajo_3
{
    public partial class Form1 : Form
    {
        List<Due�os> listaDue�os = new List<Due�os>();
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


                Due�os due�os = new Due�os();
                due�os.G_3_nombreD = G_3_nombreD;
                due�os.G_3_Direccion = G_3_Direccion;
                due�os.G_3_telefono = G_3_telefono;

                listaDue�os.Add(due�os);

                ListViewItem lista = getListViewItemByDue�os(due�os);

                g_3_listview.Items.Add(lista);
                g_3_due�o.Items.Add(due�os.G_3_nombreD);

                g_3_nombreD.Clear();
                g_3_Direccion.Clear();
                g_3_telefono.Clear();


            }
        }
        private ListViewItem getListViewItemByDue�os(Due�os due�os)
        {
            ListViewItem lista = new ListViewItem(due�os.G_3_nombreD);

            lista.SubItems.Add(due�os.G_3_Direccion);
            lista.SubItems.Add(due�os.G_3_telefono.ToString());

            return lista;
        }
        private ListViewItem getListViewItemByMascota(Mascotas mascota)
        {
            ListViewItem lista = new ListViewItem(mascota.G_3_nom_mascota);

            Due�os due�o = buscarDue�os(mascota.G_3_due�o);

            lista.SubItems.Add(mascota.G_3_edad_mascota);
            lista.SubItems.Add(mascota.G_3_raza_mascota);
            lista.SubItems.Add(mascota.G_3_due�o);

            lista.SubItems.Add(due�o.G_3_Direccion);
            lista.SubItems.Add(due�o.G_3_telefono.ToString());
            // Completar con los datos de los due�os a buscar


            return lista;
        }
        private void g_3_due�o_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Due�o = g_3_due�o.Text;

            if (Due�o == "")
            {
                MessageBox.Show("Mascota no encontrada", " Error");
                return;
            }

            Mascotas? mascotabuscada = listamascotas.Find((m) =>
            {
                return m.G_3_due�o == Due�o;
            });



        }

        private void g_3_nombreD_TextChanged(object sender, EventArgs e)
        {

        }

        private void g_3_button_registrar_2_Click(object sender, EventArgs e)
        {
            if (g_3_nom_mascota.Text == "" || g_3_edad_mascota.Text == "" || g_3_raza_mascota.Text == "" || g_3_due�o.Text == "")
                MessageBox.Show("Existen campos vacios", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                string G_3_nom_mascota = g_3_nom_mascota.Text;
                string G_3_edad_mascota = g_3_edad_mascota.Text;
                string G_3_raza_mascota = g_3_raza_mascota.Text;
                string G_3_due�o = g_3_due�o.Text;

                Mascotas mascotas = new Mascotas();
                mascotas.G_3_nom_mascota = G_3_nom_mascota;
                mascotas.G_3_edad_mascota = G_3_edad_mascota;
                mascotas.G_3_raza_mascota = G_3_raza_mascota;
                mascotas.G_3_due�o = G_3_due�o;

                listamascotas.Add(mascotas);

                ListViewItem lista = getListViewItemByMascota(mascotas);

                g_3_listview_2.Items.Add(lista);

                g_3_nom_mascota.Clear();
                g_3_edad_mascota.Clear();
                g_3_raza_mascota.Clear();

            }

        }

        private Due�os buscarDue�os(string name)
        {
            string Due�o = g_3_due�o.Text;
            // A�adir busqueda de due�o
            Due�os? buscarDue�o = listaDue�os.Find((m) =>
            {
                return m.G_3_nombreD == name;
            });
            return buscarDue�o;
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