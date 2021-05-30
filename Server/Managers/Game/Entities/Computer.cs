using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Server.Managers.Game.Entities
{
    public class Computer
    {

        public enum CState
        {
            Off = 0,
            On = 1
        }


        // la ip public del ordenador
        public string PublicIP;

        // la posicion de ese ordenador en el mapa
        public Vector2 Position = new Vector2(0, 0);

        // se pondra en true si algun jugador interactua con el en la partida. Si esta en false no será guardado.
        public bool Modified = false;

        public CState State = CState.Off;



    }
}
