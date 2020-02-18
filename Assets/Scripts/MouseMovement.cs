using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public float speedH = 2.0f;//breyta
    public float speedV = 2.0f;//breyta

    private float yaw = 0.0f;//breyta
    private float pitch = 0.0f;//breyta


    // Update is called once per frame
    void Update()
    {

        yaw += speedH * Input.GetAxis("Mouse X");//Þetta er til þess að líta til hægri og vinstri
        pitch -= speedV * Input.GetAxis("Mouse Y");//Þetta er til þess að horfa upp og niður

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);//Breytir hvert myndavélin er að horfa meðal við hvert músin er að fara

    }
}