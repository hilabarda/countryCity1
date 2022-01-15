using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Destroyer : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField]
    private bool buttem = false;
    private playerControler player;

    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>();
        player = GameObject.FindObjectOfType<playerControler>().GetComponent<playerControler>();
    }

    private void Update()
    {
        
        if(player.myPlayer == PlayerNumber.Player1)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) && buttem == true)
            {
                Destroy(gameObject);
                gameManager.Icons += 1;
                Debug.Log("icon collectedP1");
            }
        }

        if (player.myPlayer == PlayerNumber.Player2)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2) && buttem == true)
            {
                Destroy(gameObject);
                gameManager.Icons += 1;
                Debug.Log("icon collectedP2");
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            buttem = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        buttem = false;
    }

  





}
