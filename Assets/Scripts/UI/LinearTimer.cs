using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LinearTimer : MonoBehaviour
{
    Image linearTimer;
    public float maxTime = 50f;
    float timeLeft;



    // Start is called before the first frame update
    void Start()
    {
        linearTimer = GetComponet<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            linearTimer.fillAmount = timeLeft / maxTime;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}