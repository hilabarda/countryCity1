using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroyer : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField]
    private bool buttem = false;

    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && buttem == true)
        {
            Destroy(gameObject);
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
