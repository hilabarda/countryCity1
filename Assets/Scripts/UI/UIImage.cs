using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImage : MonoBehaviour
{
    [SerializeField]
    private RawImage countryP1;
    [SerializeField]
    private RawImage countryP2;
    [SerializeField]
    private RawImage cityP1;
    [SerializeField]
    private RawImage cityP2;
    [SerializeField]
    private RawImage animalP1;
    [SerializeField]
    private RawImage animalP2;
    [SerializeField]
    private RawImage growingP1;
    [SerializeField]
    private RawImage growingP2;
    [SerializeField]
    private RawImage inanimateP1;
    [SerializeField]
    private RawImage inanimateP2;
    private Sprite sprite;
    
    private Texture texture;
    [SerializeField]
    private PlayerCollected Pcollected;




    private void Start()
    {
        Pcollected.OnCollectedPickUp += ChangeImage;
        countryP1 = GetComponent<RawImage>();
        countryP2 = GetComponent<RawImage>();
        cityP1 = GetComponent<RawImage>();
        cityP2 = GetComponent<RawImage>();
        animalP1 = GetComponent<RawImage>();
        animalP2 = GetComponent<RawImage>();
        growingP1 = GetComponent<RawImage>();
        growingP2 = GetComponent<RawImage>();
        inanimateP1 = GetComponent<RawImage>();
        inanimateP2 = GetComponent<RawImage>();
    }

   


    private void ChangeImage(SpriteRenderer Icons)
    {
        countryP1.texture = Icons.sprite.texture;
        (countryP1.texture as Texture2D).Apply();
        countryP2.texture = Icons.sprite.texture;
        (countryP2.texture as Texture2D).Apply();
        //Texture newTexture = Icons.material.mainTexture;
        //imageCollectedP1.texture = newTexture;



    }
}
