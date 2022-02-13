using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LinerTimerB : MonoBehaviour
{
    public Image linearTimer;
    public float maxTime = 50f;
    float timeLeft;



    void Start()
    {
        linearTimer = GetComponent<Image>();
        timeLeft = maxTime;
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            linearTimer.fillAmount = timeLeft / maxTime;
        }
        else
        {
            SceneManager.LoadScene(3);
        }


    }
}
