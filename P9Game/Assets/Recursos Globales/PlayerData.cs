using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData
{

    public string nombreprota;
    public int scoretotal;
    public int nivelcarga;

    public PlayerData(Player player)
    {
        nombreprota = player.nombre;
        scoretotal = player.score;
        nivelcarga = player.nivel;
    }

}
