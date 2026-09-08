using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using modeloss.Entidades;

namespace vistaa.GestioneNova
{
    public enum TipoRegistro { Usuario, Cliente, Agente, Propiedad, Venta, Alquiler, Pago, Cita, Mantenimiento }

    public partial class FrmNuevoRegistro : Form
    {
        private class Campo
        {
            public string Nombre, Etiqueta, Tipo;
            public int Maximo;
            public bool Obligatorio;
            public Control Control;
            public Campo(string n, string e, string t, int m = 0, bool o = true) { Nombre = n; Etiqueta = e; Tipo = t; Maximo = m; Obligatorio = o; }
        }

        private readonly TipoRegistro tipo;
        private readonly int idEditar;
        private readonly List<Campo> campos = new List<Campo>();

        public FrmNuevoRegistro(TipoRegistro tipo, int idEditar = 0)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.idEditar = idEditar;
            ConfigurarCampos();
            CrearControles();
            if (idEditar > 0) CargarRegistro();
            lblTitulo.Text = (idEditar > 0 ? "Editar " : "Nuevo ") + tipo;
            Text = lblTitulo.Text;
        }

        private void Agregar(string n, string e, string t, int m = 0, bool o = true) { campos.Add(new Campo(n, e, t, m, o)); }

        private void ConfigurarCampos()
        {
            switch (tipo)
            {
                case TipoRegistro.Usuario:
                    // Se agregan los combos opcionales para vincular Persona
                    Agregar("IdCliente", "Vincular Cliente", "clienteAsociado", 0, false);
                    Agregar("IdAgente", "Vincular Agente", "agenteAsociado", 0, false);
                    Agregar("Nombre", "Nombre", "letras", 100);
                    Agregar("Usuario", "Usuario", "usuario", 50);
                    Agregar("Contrasena", "Contraseña", "clave", 50, idEditar == 0);
                    Agregar("IdRol", "Rol", "rol");
                    Agregar("IdEstado", "Estado", "estadoUsuario");
                    break;

                case TipoRegistro.Cliente:
                    Agregar("Nombres", "Nombres", "letras", 100);
                    Agregar("Apellidos", "Apellidos", "letras", 100);
                    Agregar("DUI", "DUI", "dui", 10);
                    Agregar("Telefono", "Teléfono", "telefono", 20);
                    Agregar("Correo", "Correo", "correo", 100, false);
                    Agregar("Direccion", "Dirección", "texto", 200);
                    break;

                case TipoRegistro.Agente:
                    Agregar("Nombre", "Nombre", "letras", 100);
                    Agregar("Apellido", "Apellido", "letras", 100);
                    Agregar("Telefono", "Teléfono", "telefono", 20);
                    Agregar("Correo", "Correo", "correo", 100);
                    Agregar("Comision", "Comisión", "decimal");
                    Agregar("IdEstado", "Estado", "estadoAgente");
                    break;

                case TipoRegistro.Propiedad:
                    Agregar("IdTipoPropiedad", "Tipo", "tipoPropiedad");
                    Agregar("Direccion", "Dirección", "texto", 200);
                    Agregar("IdDepartamento", "Departamento", "departamento");
                    Agregar("IdMunicipio", "Municipio", "municipio");
                    Agregar("Precio", "Precio", "decimal");
                    Agregar("IdEstado", "Estado", "estadoPropiedad");
                    Agregar("Descripcion", "Descripción", "texto", 500, false);
                    Agregar("FechaRegistro", "Fecha de registro", "fecha");
                    break;

                case TipoRegistro.Venta:
                    Agregar("IdCliente", "Cliente", "cliente");
                    Agregar("IdPropiedad", "Propiedad", "propiedad");
                    Agregar("IdUsuario", "Usuario", "usuarioCombo");
                    Agregar("FechaVenta", "Fecha de venta", "fecha");
                    Agregar("PrecioVenta", "Precio de venta", "decimal");
                    break;

                case TipoRegistro.Alquiler:
                    Agregar("IdCliente", "Cliente", "cliente");
                    Agregar("IdPropiedad", "Propiedad", "propiedad");
                    Agregar("IdUsuario", "Usuario", "usuarioCombo");
                    Agregar("FechaInicio", "Fecha de inicio", "fecha");
                    Agregar("FechaFin", "Fecha de finalización", "fecha");
                    Agregar("PagoMensual", "Pago mensual", "decimal");
                    break;

                case TipoRegistro.Pago:
                    Agregar("IdAlquiler", "Alquiler", "alquiler");
                    Agregar("FechaPago", "Fecha de pago", "fecha");
                    Agregar("Monto", "Monto", "decimal");
                    Agregar("IdMetodoPago", "Método de pago", "metodoPago");
                    Agregar("IdEstado", "Estado", "estadoPago");
                    break;

                case TipoRegistro.Cita:
                    Agregar("IdCliente", "Cliente", "cliente");
                    Agregar("IdAgente", "Agente", "agente");
                    Agregar("IdPropiedad", "Propiedad", "propiedad");
                    Agregar("Fecha", "Fecha", "fecha");
                    Agregar("Hora", "Hora", "hora");
                    Agregar("IdEstado", "Estado", "estadoCita");
                    break;

                default:
                    Agregar("IdPropiedad", "Propiedad", "propiedad");
                    Agregar("Descripcion", "Descripción", "texto", 200);
                    Agregar("Fecha", "Fecha", "fecha");
                    Agregar("Costo", "Costo", "decimal");
                    Agregar("IdEstado", "Estado", "estadoMantenimiento");
                    break;
            }
        }

        private void CrearControles()
        {
            pnlCampos.RowCount = campos.Count;
            for (int i = 0; i < campos.Count; i++)
            {
                Campo c = campos[i];
                Label l = new Label { Text = c.Etiqueta + ":", Font = new Font("Segoe UI", 11F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill };
                c.Control = CrearControl(c);
                c.Control.Name = "ctrl" + c.Nombre;
                c.Control.TabIndex = i;
                c.Control.Dock = DockStyle.Fill;
                c.Control.Margin = new Padding(5, 8, 5, 8);

                pnlCampos.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
                pnlCampos.Controls.Add(l, 0, i);
                pnlCampos.Controls.Add(c.Control, 1, i);
            }

            // Manejo de dependencias específicas (Departamentos)
            Campo campoDepartamento = campos.Find(cb => cb.Nombre == "IdDepartamento");
            if (campoDepartamento != null)
            {
                ((ComboBox)campoDepartamento.Control).SelectedIndexChanged += DepartamentoCambiado;
                DepartamentoCambiado(campoDepartamento.Control, EventArgs.Empty);
            }

            // Manejo de eventos de autocompletado en Usuarios
            if (tipo == TipoRegistro.Usuario)
            {
                Campo campoCliente = campos.Find(cb => cb.Nombre == "IdCliente");
                Campo campoAgente = campos.Find(cb => cb.Nombre == "IdAgente");

                if (campoCliente != null)
                {
                    ((ComboBox)campoCliente.Control).SelectedIndexChanged += ClienteSeleccionado;
                }
                if (campoAgente != null)
                {
                    ((ComboBox)campoAgente.Control).SelectedIndexChanged += AgenteSeleccionado;
                }
            }
        }

        private Control CrearControl(Campo c)
        {
            if (c.Tipo == "fecha") return new DateTimePicker { Format = DateTimePickerFormat.Short, MinDate = new DateTime(2000, 1, 1), MaxDate = new DateTime(2100, 12, 31) };
            if (c.Tipo == "hora") return new DateTimePicker { Format = DateTimePickerFormat.Time, ShowUpDown = true };

            DataTable d = null;
            string v = "";

            switch (c.Tipo)
            {
                case "rol": d = Catalogos.Roles(); v = "IdRol"; break;
                case "estadoUsuario": d = Catalogos.Estados("Usuario"); v = "IdEstado"; break;
                case "estadoAgente": d = Catalogos.Estados("Agente"); v = "IdEstado"; break;
                case "estadoPropiedad": d = Catalogos.Estados("Propiedad"); v = "IdEstado"; break;
                case "estadoPago": d = Catalogos.Estados("Pago"); v = "IdEstado"; break;
                case "estadoCita": d = Catalogos.Estados("Cita"); v = "IdEstado"; break;
                case "estadoMantenimiento": d = Catalogos.Estados("Mantenimiento"); v = "IdEstado"; break;
                case "tipoPropiedad": d = Catalogos.TiposPropiedad(); v = "IdTipoPropiedad"; break;
                case "departamento": d = Catalogos.Departamentos(); v = "IdDepartamento"; break;
                case "municipio": d = new DataTable(); v = "IdMunicipio"; break;
                case "cliente": d = Catalogos.Clientes(); v = "IdCliente"; break;
                case "propiedad": d = Catalogos.Propiedades(); v = "IdPropiedad"; break;
                case "usuarioCombo": d = Catalogos.Usuarios(); v = "IdUsuario"; break;
                case "agente": d = Catalogos.Agentes(); v = "IdAgente"; break;
                case "alquiler": d = Catalogos.Alquileres(); v = "IdAlquiler"; break;
                case "metodoPago": d = Catalogos.MetodosPago(); v = "IdMetodoPago"; break;

                // Nuevos catálogos filtrados para asignación única de Usuario
                case "clienteAsociado": d = Catalogos.ClientesSinUsuario(idEditar); v = "IdCliente"; break;
                case "agenteAsociado": d = Catalogos.AgentesSinUsuario(idEditar); v = "IdAgente"; break;
            }

            if (d != null)
            {
                ComboBox cmb = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, DataSource = d, DisplayMember = "Nombre", ValueMember = v };
                if (c.Tipo == "clienteAsociado" || c.Tipo == "agenteAsociado") cmb.SelectedIndex = -1; // Iniciar sin selección
                return cmb;
            }

            TextBox t = new TextBox { MaxLength = c.Maximo > 0 ? c.Maximo : 30, UseSystemPasswordChar = c.Tipo == "clave", Tag = c.Tipo };
            t.KeyPress += ValidarCaracter;
            t.KeyDown += BloquearPortapapeles;
            return t;
        }

        private void ClienteSeleccionado(object sender, EventArgs e)
        {
            ComboBox cmbCliente = (ComboBox)sender;
            if (cmbCliente.SelectedValue != null && int.TryParse(cmbCliente.SelectedValue.ToString(), out int idCliente) && idCliente > 0)
            {
                // Desactivar el de Agente para evitar doble selección
                Campo campoAgente = campos.Find(cb => cb.Nombre == "IdAgente");
                if (campoAgente != null)
                {
                    ComboBox cmbAgente = (ComboBox)campoAgente.Control;
                    cmbAgente.SelectedIndexChanged -= AgenteSeleccionado;
                    cmbAgente.SelectedIndex = -1;
                    cmbAgente.SelectedIndexChanged += AgenteSeleccionado;
                }

                // Generar sugerencia de nombre y usuario
                string usuarioSugerido = Usuario.SugerirUsuarioDesdeCliente(idCliente, out string nombreCompleto);

                Campo campoNombre = campos.Find(cb => cb.Nombre == "Nombre");
                Campo campoUsuario = campos.Find(cb => cb.Nombre == "Usuario");

                if (campoNombre != null) campoNombre.Control.Text = nombreCompleto;
                if (campoUsuario != null) campoUsuario.Control.Text = usuarioSugerido;
            }
        }

        private void AgenteSeleccionado(object sender, EventArgs e)
        {
            ComboBox cmbAgente = (ComboBox)sender;
            if (cmbAgente.SelectedValue != null && int.TryParse(cmbAgente.SelectedValue.ToString(), out int idAgente) && idAgente > 0)
            {
                // Desactivar el de Cliente para evitar doble selección
                Campo campoCliente = campos.Find(cb => cb.Nombre == "IdCliente");
                if (campoCliente != null)
                {
                    ComboBox cmbCliente = (ComboBox)campoCliente.Control;
                    cmbCliente.SelectedIndexChanged -= ClienteSeleccionado;
                    cmbCliente.SelectedIndex = -1;
                    cmbCliente.SelectedIndexChanged += ClienteSeleccionado;
                }

                // Generar sugerencia de nombre y usuario
                string usuarioSugerido = Usuario.SugerirUsuarioDesdeAgente(idAgente, out string nombreCompleto);

                Campo campoNombre = campos.Find(cb => cb.Nombre == "Nombre");
                Campo campoUsuario = campos.Find(cb => cb.Nombre == "Usuario");

                if (campoNombre != null) campoNombre.Control.Text = nombreCompleto;
                if (campoUsuario != null) campoUsuario.Control.Text = usuarioSugerido;
            }
        }

        private void DepartamentoCambiado(object s, EventArgs e)
        {
            ComboBox comboDepartamento = (ComboBox)s;
            Campo campoMunicipio = campos.Find(campoBuscado => campoBuscado.Nombre == "IdMunicipio");
            if (campoMunicipio == null || comboDepartamento.SelectedValue == null || comboDepartamento.SelectedValue is DataRowView) return;
            ComboBox comboMunicipio = (ComboBox)campoMunicipio.Control;
            comboMunicipio.DataSource = Catalogos.Municipios(Convert.ToInt32(comboDepartamento.SelectedValue));
            comboMunicipio.DisplayMember = "Nombre";
            comboMunicipio.ValueMember = "IdMunicipio";
        }

        private void ValidarCaracter(object s, KeyPressEventArgs e)
        {
            string t = (string)((TextBox)s).Tag;
            if (char.IsControl(e.KeyChar)) return;
            if (t == "decimal" && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.') e.Handled = true;
            if (t == "letras" && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-') e.Handled = true;
            if (t == "dui" && !char.IsDigit(e.KeyChar) && e.KeyChar != '-') e.Handled = true;
            if (t == "telefono" && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ') e.Handled = true;
            if (t == "codigo" && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-') e.Handled = true;
        }

        private void BloquearPortapapeles(object s, KeyEventArgs e) { if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X)) { e.SuppressKeyPress = true; MessageBox.Show("Debe digitar la información."); } }

        private DataRow ObtenerRegistro()
        {
            switch (tipo) { case TipoRegistro.Usuario: return Usuario.Obtener(idEditar); case TipoRegistro.Cliente: return Cliente.Obtener(idEditar); case TipoRegistro.Agente: return Agente.Obtener(idEditar); case TipoRegistro.Propiedad: return Propiedad.Obtener(idEditar); case TipoRegistro.Venta: return Venta.Obtener(idEditar); case TipoRegistro.Alquiler: return Alquiler.Obtener(idEditar); case TipoRegistro.Pago: return Pago.Obtener(idEditar); case TipoRegistro.Cita: return Cita.Obtener(idEditar); default: return Mantenimiento.Obtener(idEditar); }
        }

        private void CargarRegistro()
        {
            DataRow f = ObtenerRegistro(); if (f == null) return;
            if (tipo == TipoRegistro.Propiedad)
            {
                int municipio = Convert.ToInt32(f["IdMunicipio"]); ComboBox dep = (ComboBox)campos.Find(campoBuscado => campoBuscado.Nombre == "IdDepartamento").Control;
                foreach (DataRow r in Catalogos.Departamentos().Rows) { int id = Convert.ToInt32(r["IdDepartamento"]); foreach (DataRow mr in Catalogos.Municipios(id).Rows) if (Convert.ToInt32(mr["IdMunicipio"]) == municipio) { dep.SelectedValue = id; break; } }
            }
            foreach (Campo c in campos)
            {
                if (c.Nombre == "IdDepartamento" || !f.Table.Columns.Contains(c.Nombre) || f[c.Nombre] == DBNull.Value) continue;
                if (c.Control is ComboBox) ((ComboBox)c.Control).SelectedValue = f[c.Nombre];
                else if (c.Control is DateTimePicker) ((DateTimePicker)c.Control).Value = c.Tipo == "hora" ? DateTime.Today.Add((TimeSpan)f[c.Nombre]) : Convert.ToDateTime(f[c.Nombre]);
                else if (c.Tipo != "clave") c.Control.Text = f[c.Nombre].ToString();
            }
        }

        private bool Validar(out Dictionary<string, object> v)
        {
            v = new Dictionary<string, object>();
            foreach (Campo c in campos)
            {
                if (c.Nombre == "IdDepartamento") continue;
                object x;

                if (c.Control is ComboBox) x = ((ComboBox)c.Control).SelectedValue;
                else if (c.Control is DateTimePicker) x = c.Tipo == "hora" ? ((DateTimePicker)c.Control).Value.TimeOfDay : (object)((DateTimePicker)c.Control).Value.Date;
                else x = c.Control.Text.Trim();

                if (c.Obligatorio && (x == null || x == DBNull.Value || x.ToString() == "")) { MessageBox.Show("El campo " + c.Etiqueta + " es obligatorio."); c.Control.Focus(); return false; }
                if (!c.Obligatorio && (x == null || x.ToString() == "")) x = DBNull.Value;

                if (c.Tipo == "decimal" && x != DBNull.Value)
                {
                    decimal n;
                    if (!decimal.TryParse(x.ToString(), out n) || n < 0)
                    {
                        MessageBox.Show(c.Etiqueta + " debe ser un número válido y no negativo."); c.Control.Focus(); return false;
                    }
                    if ((c.Nombre == "Precio" || c.Nombre == "PrecioVenta" || c.Nombre == "PagoMensual" || c.Nombre == "Monto") && n <= 0)
                    {
                        MessageBox.Show(c.Etiqueta + " debe ser mayor que cero."); c.Control.Focus(); return false;
                    }
                    x = n;
                }
                if (c.Tipo == "correo" && x != DBNull.Value && (!x.ToString().Contains("@") || !x.ToString().Contains("."))) { MessageBox.Show("Ingrese un correo válido."); c.Control.Focus(); return false; }
                if (c.Tipo == "dui" && (x.ToString().Length != 10 || x.ToString()[8] != '-')) { MessageBox.Show("El DUI debe tener el formato 00000000-0."); c.Control.Focus(); return false; }
                if (c.Tipo == "telefono" && x.ToString().Replace("-", "").Replace(" ", "").Length < 8) { MessageBox.Show("Ingrese un teléfono válido."); c.Control.Focus(); return false; }
                if (c.Tipo == "clave" && x != DBNull.Value && x.ToString().Length < 8) { MessageBox.Show("La contraseña debe tener al menos 8 caracteres."); c.Control.Focus(); return false; }
                if (c.Tipo == "usuario" && x.ToString().Contains(" ")) { MessageBox.Show("El nombre de usuario no puede contener espacios."); c.Control.Focus(); return false; }

                v[c.Nombre] = x;
            }

            if (tipo == TipoRegistro.Alquiler && (DateTime)v["FechaFin"] <= (DateTime)v["FechaInicio"]) { MessageBox.Show("La fecha final debe ser posterior a la fecha inicial."); return false; }
            if (tipo == TipoRegistro.Cita && (DateTime)v["Fecha"] < DateTime.Today) { MessageBox.Show("La cita no puede registrarse en una fecha pasada."); return false; }
            if (tipo == TipoRegistro.Venta && (DateTime)v["FechaVenta"] > DateTime.Today) { MessageBox.Show("La venta no puede registrarse con una fecha futura."); return false; }
            if (tipo == TipoRegistro.Pago && (DateTime)v["FechaPago"] > DateTime.Today) { MessageBox.Show("El pago no puede registrarse con una fecha futura."); return false; }
            if (tipo == TipoRegistro.Propiedad && (DateTime)v["FechaRegistro"] > DateTime.Today) { MessageBox.Show("La fecha de registro no puede ser futura."); return false; }
            if (tipo == TipoRegistro.Usuario && idEditar > 0 && v["Contrasena"] == DBNull.Value) v.Remove("Contrasena");

            return true;
        }

        private void Guardar(Dictionary<string, object> v)
        {
            bool e = idEditar > 0;
            switch (tipo)
            {
                case TipoRegistro.Usuario:
                    if (e) Usuario.Actualizar(idEditar, v); else Usuario.Guardar(v);
                    break;
                case TipoRegistro.Cliente:
                    if (e) Cliente.Actualizar(idEditar, v); else Cliente.Guardar(v);
                    break;
                case TipoRegistro.Agente:
                    if (e) Agente.Actualizar(idEditar, v); else Agente.Guardar(v);
                    break;
                case TipoRegistro.Propiedad:
                    if (e) Propiedad.Actualizar(idEditar, v); else Propiedad.Guardar(v);
                    break;
                case TipoRegistro.Venta:
                    if (e) Venta.Actualizar(idEditar, v); else Venta.Guardar(v);
                    break;
                case TipoRegistro.Alquiler:
                    if (e) Alquiler.Actualizar(idEditar, v); else Alquiler.Guardar(v);
                    break;
                case TipoRegistro.Pago:
                    if (e) Pago.Actualizar(idEditar, v); else Pago.Guardar(v);
                    break;
                case TipoRegistro.Cita:
                    if (e) Cita.Actualizar(idEditar, v); else Cita.Guardar(v);
                    break;
                default:
                    if (e) Mantenimiento.Actualizar(idEditar, v); else Mantenimiento.Guardar(v);
                    break;
            }
        }

        private void btnGuardar_Click(object s, EventArgs e)
        {
            Dictionary<string, object> v; if (!Validar(out v)) return;
            try { Guardar(v); MessageBox.Show(idEditar > 0 ? "Registro actualizado correctamente." : "Registro guardado correctamente."); DialogResult = DialogResult.OK; Close(); }
            catch (Exception ex) { MessageBox.Show("No se pudo guardar. Verifique que los datos no estén repetidos.\n\n" + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object s, EventArgs e) { Close(); }

        private void pnlCampos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}