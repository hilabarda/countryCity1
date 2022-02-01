using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollected : MonoBehaviour
{
    private playerControler controler;
    private bool buttem;
    [SerializeField]
    private Score score;
    [SerializeField]
    private KeyCode collectedKey;


    private void Start()
    {
        controler = GetComponent<playerControler>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("picUp"))
        {
            buttem = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("picUp"))
        {
            buttem = false;
        }
    }

    public void Update()
    {
        if(Input.GetKeyDown(collectedKey) && buttem == true)
        {
            score.AddScore(controler.myPlayer);
            Debug.Log("icon collected");
        }
    }
}
