using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text scoreTextP1;
    [SerializeField]
    private Text scoreTextP2;
    private int scoreP1 = 0;
    private int scoreP2 = 0;
    [SerializeField]
    private GameManager gameManager;
    private playerControler player;
   

    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>();
        gameManager.OnIconCollected += ScoreText;
        player = GameObject.FindObjectOfType<playerControler>().GetComponent<playerControler>();

    }

    private void ScoreText (int score)
    {
        if (player.myPlayer == PlayerNumber.Player1)
        {
            scoreP1++;
            scoreTextP1.text = $"Score:{score.ToString()}" + scoreP1;
        }
        if (player.myPlayer == PlayerNumber.Player2)
        {
            scoreP2++;
            scoreTextP2.text = $"Score:{score.ToString()}" + scoreP2;
        }

    }




}
