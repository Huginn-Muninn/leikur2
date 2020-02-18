using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{ 
    public float speed;//hraði
    public Text countText;//fyrir textan uppi í horninu sem telur krónurnar
    public Text winText;//Fyrir texta
    public bool grounded = true;//til að sjá hvort spilari sé á jörðinni

    private Rigidbody rb;//rb er ridgid body
    private int count;//fyrir teljarann

    public void Grounded()//til þess að gá hvort spilari sé á jörðinni
    {
        grounded = true;//þú ert á jörðinni
        Debug.Log("Grounded");
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();//nær í ridgid body
        count = 0;//teljarinn er 0
        SetCountText();
        winText.text = "";//setur textan að engu
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");//Þetta er til þess að hreyf sig áframm 
        float moveVertical = Input.GetAxis("Vertical");//og til hliðar 

        Vector3 targetDirection = new Vector3(moveHorizontal, 0f, moveVertical);//til þess að þú munir alltaf hreyfa þig áfram frá sjónarhorni spilarans
        targetDirection = Camera.main.transform.TransformDirection(targetDirection);//Sjá fyrir ofan
        targetDirection.y = 0.0f;//þú ferð aldrei upp með wasd eða örvunum
        

        rb.AddForce(targetDirection * speed);//Fyrir hoppið
        if (Input.GetKey(KeyCode.Space) && grounded == true)//Ef þú ert á jörðinni
        {
            grounded = false;//þú ert að hoppa svo þú ert ekki á jörðinni
            rb.AddForce(0, 500*Time.deltaTime, 0, ForceMode.Impulse);//lætur þig hreyfa þig upp í smá tíma
        }
    }

    void OnTriggerEnter(Collider other)//fyrir krónurnar
    {
        if (other.gameObject.CompareTag("Pick Up"))//ef þetta er af gerðinni pick upp
        {
            other.gameObject.SetActive(false);//lætur hlutinn hverfa
            count = count + 1;//bætir einum við á stigatöfluna
            SetCountText();//breytir stigunum á skjáinum

        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 5)// ef þú ert búinn að ná 5 krónum
        {
            winText.text = "You Win!";//kemur textinn you win
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Leikurinn breytir um borð
            count = 0;//stigataflan núllstillist
        }
    }
}