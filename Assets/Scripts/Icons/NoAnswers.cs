using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAnswers : MonoBehaviour
{
    [SerializeField]
    private GameObject[] noAnswers;
    [SerializeField]
    private float minTime = 1;
    [SerializeField]
    private float maxTime = 1.1f;

    [SerializeField]
    private GameObject[] pickupPlane;

    private Dictionary<int, bool> isCatch = new Dictionary<int, bool>();



    private void Start()
    {
        StartCoroutine(pickUpRandom());

        for (int i = 0; i < pickupPlane.Length; i++)
        {
            isCatch.Add(i, false);
        }

    }

    private IEnumerator pickUpRandom()
    {
        yield return new WaitForSeconds(5.8f);
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
        int randomnoAnswers = Random.Range(0, noAnswers.Length - 1);

        if (isCatch[randomIndex] == false)
        {
            GameObject noanswers = Instantiate(noAnswers[randomnoAnswers], pickupPlane[randomIndex].transform);
            isCatch[randomIndex] = true;
        }


    }
}
