using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour//Þessi kóði er til þess að hreya myndavélina
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;//Reiknar og geymir offset gildið með því að fá fjarlægðina milli stöðu spilarans og stöðu myndavélarinnar.
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        // Stillir stöðu umbreytingar myndavélarinnar þannig að hún sé eins og spilarans, en e. offset á móti reiknaðri fjarlægð.
    }
}