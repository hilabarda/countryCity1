using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImage : MonoBehaviour
{
    [SerializeField]
    private RawImage [] imageCollectedP1;
    [SerializeField]
    private RawImage[] imageCollectedP2;
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private Texture texture;
    private Icons currentIcons;
    [SerializeField]
    private PlayerCollected Pcollected;

    private void Start()
    {
        gameManager.OnIconCollected += ChangeImage;
        GameObject.FindObjectOfType<Icons>();
        
    }

   

    private void ChangeImage(int Icons)
    {

        


    }
}
