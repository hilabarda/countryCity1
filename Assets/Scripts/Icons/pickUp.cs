using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class pickUp : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private float minTime = 1;
    [SerializeField]
    private float maxTime = 1.5f;
    [SerializeField]
    private float minPos;
    [SerializeField]
    private float maxPos;
    [SerializeField]
    private GameObject[] pickupPlane;

    private Dictionary<int, bool> isCatch = new Dictionary<int, bool>();



    private void Start()
    {
        StartCoroutine(pickUpRandom());

        for(int i = 0; i < pickupPlane.Length; i++)
        {
            isCatch.Add(i, false);
        }
    }

    private IEnumerator pickUpRandom()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            pickUpShow();
        }
    }

    private void pickUpShow()
    {
        //transform.localPosition = new Vector3(Random.Range(minPos, maxPos), 0.001f, Random.Range(minPos, maxPos));
        int randomIndex = Random.Range(0, pickupPlane.Length - 1);

        if(isCatch[randomIndex] == false)
        {
            GameObject game = Instantiate(prefab, pickupPlane[randomIndex].transform);
            isCatch[randomIndex] = true;
        }
       

       
        
        
    }
   
}
