using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Sprite : MonoBehaviour
{
    [SerializeField]
    public SpriteRenderer quad;

    public UnityAction<SpriteRenderer> OnCollected;

    private void Start()
    {
        quad = gameObject.GetComponent<SpriteRenderer>();
    }

    public SpriteRenderer Quad
    {
        get { return quad; }
        set { quad = value;
            OnCollected?.Invoke(quad);
        }
    }
    
    
}
