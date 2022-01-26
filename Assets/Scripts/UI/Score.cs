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
    [SerializeField]
    private playerControler player1;
    [SerializeField]
    private playerControler player2;


    private void Start()
    {
        gameManager.OnIconCollected += AddScore;
        player1.myPlayer = PlayerNumber.Player1;
        player2.myPlayer = PlayerNumber.Player2;

    }

    private void AddScore (int score)
    {
        if (player1.myPlayer == PlayerNumber.Player1)
        {
            //scoreP1++;
            scoreTextP1.text = $"Score:{score.ToString()}" + scoreP1;
        }
        if (player2.myPlayer == PlayerNumber.Player2)
        {
            //scoreP2++;
            scoreTextP2.text = $"Score:{score.ToString()}" + scoreP2;
        }

    }




}
