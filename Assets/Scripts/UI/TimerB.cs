using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerB : MonoBehaviour
{
    public Timer timerB;
    [SerializeField]
    private Text text;
    [SerializeField]
    private GameObject score;

    private int time = 60;

    private void Awake()
    {
        timerB = gameObject.GetComponent<Timer>();
    }

    private void Start()
    {
        StartCoroutine(MinusSeconds());
        DontDestroyOnLoad(score);
    }

    private void Update()
    {
        if (time == 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    private IEnumerator MinusSeconds()
    {
        yield return new WaitForSeconds(1.5f);
        while (true)
        {
            yield return new WaitForSeconds(1);
            time--;
            text.text = time.ToString();
        }
    }
}
