using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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
    private pickUp pickUpAnswer;

    public UnityAction<SpriteRenderer> OnCollectedPickUp;


    private void Start()
    {
        controler = GetComponent<playerControler>();
        pickUpAnswer = GetComponent<pickUp>();
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
        if(Input.GetKeyDown(collectedKey) && buttem == true && currentPickUp != null)
        {
            score.AddScore(controler.myPlayer);

            if(currentPickUp != null)
            {
                SpriteRenderer sprite = currentPickUp.transform.parent.GetComponent<MySprite>().quad;
                OnCollectedPickUp?.Invoke(sprite);
                Destroy(currentPickUp.transform.parent.gameObject);
                currentPickUp = null;
            }
        }
    }
}
