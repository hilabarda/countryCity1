using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class UIText : MonoBehaviour
{
    [SerializeField]
    public GameObject [] gameObjectLetters;

    

    private void Start()
    {
        StartCoroutine(TextShow());
        
    }


    public IEnumerator TextShow()
    {
        yield return new WaitForSeconds(1.5f);
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
