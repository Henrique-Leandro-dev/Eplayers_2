using System;

namespace Eplayers_2.Models
{
    public class Partida
    {
        public int IdPartida { get; set; }
        public int IdJogador1 { get; set; }
        public int IdJogador2 { get; set; }
        public DateTime Horario { get; set; }
        
    }
}