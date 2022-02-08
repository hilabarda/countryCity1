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
    [SerializeField]
    private GameObject currentPickUp;


    private void Start()
    {
        controler = GetComponent<playerControler>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("picUp"))
        {
            currentPickUp = other.gameObject;
            buttem = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("picUp"))
        {
            currentPickUp = null;
            buttem = false;
        }
    }

    public void Update()
    {
        if(Input.GetKeyDown(collectedKey) && buttem == true)
        {
            score.AddScore(controler.myPlayer);
            if(currentPickUp != null)
            {
                Destroy(currentPickUp);
                currentPickUp = null;
            }
        }
    }
}
