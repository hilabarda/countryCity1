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
    private Destroyer destroyer;


    private void Start()
    {
        controler = GetComponent<playerControler>();
        destroyer = GetComponent<Destroyer>();
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
        if(Input.GetKeyDown(collectedKey) && buttem == true && currentPickUp != null)
        {
            score.AddScore(controler.myPlayer);
            //Destroy(currentPickUp.gameObject);

            if(currentPickUp != null)
            {
                Destroy(currentPickUp.transform.parent.gameObject);
                currentPickUp = null;
            }
        }
    }
}
