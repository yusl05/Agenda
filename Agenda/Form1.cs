using Agenda.Utilidades;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public string rutaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "datos.json");
        //string contenido = File.ReadAllText(rutaJson);

        public Form1()
        {
            if (!File.Exists(rutaJson))
            {
                var datosIniciales = new BaseDatosJson
                {
                    personas = new List<Persona>(),
                    totalRegistros = 0
                };

                guardarJson(datosIniciales);
            }

            InitializeComponent();
            tmrTiempo.Interval = 5000;
            tmrTiempo.Tick += timer1_Tick;
            tmrTiempo.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var datos = CargarDatos();
            guardarJson(datos);
        }

        private BaseDatosJson CargarDatos()
        {
            var registros = new BaseDatosJson();
            foreach (DataGridViewRow fila in dGVDatos.Rows)
            {
                if (fila.IsNewRow) continue;
                var persona = new Persona();
                {
                    persona.nombre = fila.Cells[0].Value?.ToString() ?? "";
                    persona.apPat = fila.Cells[1].Value?.ToString() ?? "";
                    persona.apMat = fila.Cells[2].Value?.ToString() ?? "";
                    persona.direccion = fila.Cells[3].Value?.ToString() ?? "";
                    persona.telefono = fila.Cells[4].Value?.ToString() ?? "";
                    persona.correo = fila.Cells[5].Value?.ToString() ?? "";
                }
                registros.personas.Add(persona);

            }
            registros.totalRegistros = registros.personas.Count;
            return registros;

        }

        public void guardarJson(BaseDatosJson lista)
        {
            var caracteristicas = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore,

            };

            string json = JsonConvert.SerializeObject(lista, caracteristicas);
            File.WriteAllText(rutaJson, json);
        }
    }
}
