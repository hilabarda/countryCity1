using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreTextP1;
    [SerializeField]
    private Text scoreTextP2;
    [SerializeField]
    private playerControler player1;
    [SerializeField]
    private playerControler player2;

    private void Start()
    {
        player1.myPlayer = PlayerNumber.Player1;
        player2.myPlayer = PlayerNumber.Player2;
        scoreTextP1.text = PlayerPrefs.GetInt("Score").ToString();
        scoreTextP2.text = PlayerPrefs.GetInt("Score").ToString();
    }
}
