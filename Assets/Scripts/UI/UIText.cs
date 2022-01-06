using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class UIText : MonoBehaviour
{
    [SerializeField]
    private GameObject [] gameObjectLetters;
    

    private void Start()
    {
        StartCoroutine(TextShow());

    }


    private IEnumerator TextShow()
    {
        int randomLetters = Random.Range(0, 22);

        int index = 0;

        while (index <= randomLetters)
        {
            int indexOfArray = index % gameObjectLetters.Length;
            gameObjectLetters[indexOfArray].SetActive(true);

            if (indexOfArray == 0)
            {
                gameObjectLetters[gameObjectLetters.Length - 1].SetActive(false);
            }
            else
            {
                gameObjectLetters[indexOfArray - 1].SetActive(false);
            }

            index++;

            yield return new WaitForSeconds(0.3f);
        }
       

        

        

    }

  

    




}
