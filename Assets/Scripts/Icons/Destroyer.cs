using UnityEngine;



public class Destroyer : MonoBehaviour
{
    private GameManager gameManager;
    private bool buttemP1 = false;
    private bool buttemP2 = false;
    private GameObject player1;
    private GameObject player2;

    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>();
        player1 = GameObject.FindWithTag("Player1");
        player2 = GameObject.FindWithTag("Player2");
    }

    private void Update()
    {

        if (player1)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) && buttemP1 == true)
            {
                Destroy(gameObject);
            }
        }

        else if (player2)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2) && buttemP2 == true)
            {
                Destroy(gameObject);
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            buttemP1 = true;
        }
        else if (other.gameObject.CompareTag("Player2"))
        {
            buttemP2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            buttemP1 = false;
        }
        else if (other.gameObject.CompareTag("Player2"))
        {
            buttemP2 = false;
        }

    }
}