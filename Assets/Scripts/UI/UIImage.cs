using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImage : MonoBehaviour
{
    [SerializeField]
    private Image[] imageCollectedP1;
    [SerializeField]
    private Image[] imageCollectedP2;
    [SerializeField]
    private GameManager gameManager;

    private void Start()
    {
        gameManager.OnIconCollected += ChangeImage;
        
    }

    private void ChangeImage(int Icons)
    {
        
    }
}
