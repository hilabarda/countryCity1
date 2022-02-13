using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImage : MonoBehaviour
{
    [SerializeField]
    private RawImage imageCollectedP1;
    [SerializeField]
    private RawImage[] imageCollectedP2;
    [SerializeField]
    private Texture texture;
    [SerializeField]
    private PlayerCollected Pcollected;
    [SerializeField]
    private GameObject[] country;
    [SerializeField]
    private GameObject[] city;
    [SerializeField]
    private GameObject[] animal;
    [SerializeField]
    private GameObject[] growing;
    [SerializeField]
    private GameObject[] inanimate;
    private Sprite sprite;

    


    private void Start()
    {
        Pcollected.OnCollectedPickUp += ChangeImage;
        imageCollectedP1 = GetComponent<RawImage>();
    }

   


    private void ChangeImage(SpriteRenderer Icons)
    {
1       //Texture newTexture = Icons.material.mainTexture;
        imageCollectedP1.texture = newTexture;

        

    }
}
