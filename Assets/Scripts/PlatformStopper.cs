using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformStopper : MonoBehaviour//Þegar þú snertir hlutinn sem þessi kóði er á þá hættiru að hreyfa þig með e. platform
{
    public GameObject ThePlayer;

    private void OnTriggerEnter()
    {
        ThePlayer.transform.parent = null;
    }
}
