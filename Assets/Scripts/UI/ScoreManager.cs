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
    private Score score;
 

    private void Start()
    {
        score = GetComponent<Score>();
        scoreTextP1 = GetComponent<Text>();
        scoreTextP2 = GetComponent<Text>();
        GetScore();

    }

    private void GetScore()
    {
        score.scoreP1 = PlayerPrefs.GetInt(" ");
        score.scoreP2 = PlayerPrefs.GetInt(" ");

        scoreTextP1.text = " " + PlayerPrefs.GetInt(" ", score.scoreP1);
        Debug.Log("SP1");
        scoreTextP2.text = " " + PlayerPrefs.GetInt(" ", score.scoreP2);
        Debug.Log("SP2");
    }
}
