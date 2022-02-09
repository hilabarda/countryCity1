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
        scoreTextP1.text = PlayerPrefs.GetInt("Score").ToString();
        scoreTextP2.text = PlayerPrefs.GetInt("Score").ToString();
    }
}
