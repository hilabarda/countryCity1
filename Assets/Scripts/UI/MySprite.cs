using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MySprite : MonoBehaviour
{
    [SerializeField]
    public SpriteRenderer quad;


    private void Start()
    {
        quad = gameObject.GetComponent<SpriteRenderer>();

    }

 
    
    
}
