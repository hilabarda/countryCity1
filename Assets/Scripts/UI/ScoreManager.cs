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

        scoreTextP1 = GetComponent<Text>();
        scoreTextP2 = GetComponent<Text>();
        scoreTextP1.text = "SP1 " + PlayerPrefs.GetInt(" ").ToString();
        scoreTextP2.text = "SP2 " + PlayerPrefs.GetInt(" ").ToString();
    }
}
