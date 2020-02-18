using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkplayer : MonoBehaviour//Þetta forrit er bara til þess að kíkja hvort spilarinn sé að snerta þennan hlut sem telst vera ground
{

    public PlayerController Player;
    private void OnCollisionEnter(Collision collision)
    {
        Player.Grounded();
    }
}
