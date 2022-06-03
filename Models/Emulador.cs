using System;
using System.Collections.Generic;

namespace BotAbrirSoftware.Models
{
    public partial class Emulador
    {
        public long Id { get; set; }
        public string Comando { get; set; } = null!;
        public long Habilitado { get; set; }
        public long Evento { get; set; }
    }
}
