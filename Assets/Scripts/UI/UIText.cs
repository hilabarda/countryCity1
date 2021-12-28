using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class UIText : MonoBehaviour
{
    [SerializeField]
    private GameObject [] gameObjectLetters;
    private int letters = 22;
   

    private void Start()
    {
        StartCoroutine(TextShow());
    }


    private IEnumerator TextShow()
    {
        for(int i = 0; i < letters; i++)
        {
            gameObjectLetters[i].SetActive(true);
            yield return new WaitForSeconds(0.3f);
            gameObjectLetters[i].SetActive(false);

            if (i >= letters)
            {
                
            }

        }

       
       

    }

    


}
