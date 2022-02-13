using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILettersB : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Letters;


    private void Start()
    {
        StartCoroutine(DisplayLetters());


    }

    public IEnumerator DisplayLetters()
    {
        yield return new WaitForSeconds(1.5f);

        for (int i = 0; i < Letters.Length; i++)
        {
            Instantiate(Letters[i]);
            Letters[i].SetActive(true);
            yield return new WaitForSeconds(0.3f);
            Letters[i].SetActive(false);

        }
        Letters[1].SetActive(true);

    }
}
