using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImage : MonoBehaviour
{
    [SerializeField]
    private Image imageCollectedP1;
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
        sprite = GetComponent<Sprite>();
        sprite.OnCollected += ChangeImage;
    }

   


    private void ChangeImage(SpriteRenderer Icons)
    {
        imageCollectedP1.GetComponent<Image>().sprite = sprite.GetComponent<SpriteRenderer>().sprite;
        

    }
}
