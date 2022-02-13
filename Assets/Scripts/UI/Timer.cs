using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Timer timer;
    [SerializeField]
    private Text text;
    [SerializeField]
    private GameObject score;

    private int time = 60;

    private void Awake()
    {
        timer = this;
    }

    private void Start()
    {
        StartCoroutine(MinusSeconds());
        DontDestroyOnLoad(score);
    }

    private void Update()
    {
        if(time == 0)
        {
            SceneManager.LoadScene(1);
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
