using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    internal class Expediente
    {
        private int idExpediente;
        private string enfermedades;
        private string alergias;
        private int pacienteId;

        public int IdExpediente { get => idExpediente; set => idExpediente = value; }
        public string Enfermedades { get => enfermedades; set => enfermedades = value; }
        public string Alergias { get => alergias; set => alergias = value; }
        public int PacienteId { get => pacienteId; set => pacienteId = value; }
    }
}
