using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class IconStart : MonoBehaviour
{
    [SerializeField]
    private GameObject iconPrefab;
    [SerializeField]
    private GameObject[] prefabPlane;
    private float minTime = 1;
    private float maxTime = 1.05f;

    private Dictionary<int, bool> isprefab = new Dictionary<int, bool>();

    private void Start()
    {
        StartCoroutine(iconRandom());

        for(int i = 0; i < prefabPlane.Length; i++)
        {
            isprefab.Add(i, false);
        }
    }

    private IEnumerator iconRandom()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            iconShow();

        }

    }

    private void iconShow()
    {
        int randomIndex = Random.Range(0, prefabPlane.Length - 1);

        if(isprefab[randomIndex] == false)
        {
            GameObject icons = Instantiate(iconPrefab, prefabPlane[randomIndex].transform);
            isprefab[randomIndex] = true;
            
        }
        
    }

    private void Destroyer()
    {
        Destroy(iconPrefab);
    }
}
