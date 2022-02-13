using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectedB : MonoBehaviour
{
    private playerControler controler;
    private bool buttem;
    [SerializeField]
    private Score score;
    [SerializeField]
    private KeyCode collectedKey;
    [SerializeField]
    private GameObject currentPickUp;
    private pickUpB pickUpAnswer;


    private void Start()
    {
        controler = GetComponent<playerControler>();
        pickUpAnswer = GetComponent<pickUpB>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickUp"))
        {
            currentPickUp = other.gameObject;
            buttem = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("pickUp"))
        {
            currentPickUp = null;
            buttem = false;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(collectedKey) && buttem == true && currentPickUp != null)
        {
            score.AddScore(controler.myPlayer);

            if (currentPickUp != null)
            {
                Destroy(currentPickUp.transform.parent.gameObject);
                currentPickUp = null;
            }
        }
    }
}
