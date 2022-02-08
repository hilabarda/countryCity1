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
        //gameManager.OnIconCollected += AddScore;
        player1.myPlayer = PlayerNumber.Player1;
        player2.myPlayer = PlayerNumber.Player2;


    }

    public void AddScore (PlayerNumber pNumber)
    {
        if (pNumber == PlayerNumber.Player1)
        {
            scoreP1++;
            scoreTextP1.text = $"Score:{scoreP1.ToString()}";
            PlayerPrefs.SetInt("Score:", scoreP1);
        }
        else if (pNumber == PlayerNumber.Player2)
        {
            scoreP2++;
            scoreTextP2.text = $"Score:{scoreP2.ToString()}";
            PlayerPrefs.SetInt("Score:", scoreP2);
        }

    }




}
