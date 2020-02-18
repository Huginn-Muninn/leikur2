using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour//Þegar þú snertir hlut með þennann þá hreyfir þú þig með e. platform
{
    public GameObject TheLedge;
    public GameObject ThePlayer;

    private void OnTriggerEnter()
    {
        ThePlayer.transform.parent = TheLedge.transform;
    }
}
