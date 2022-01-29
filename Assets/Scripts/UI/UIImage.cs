using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImage : MonoBehaviour
{
    [SerializeField]
    private Image imageCollectedP1;
    [SerializeField]
    private Image[] imageCollectedP2;
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private Sprite sprite;

    private void Start()
    {
        gameManager.OnIconCollected += ChangeImage;
        imageCollectedP1 = GetComponent<Image>();
    }

    private void ChangeImage(int Icons)
    {
        imageCollectedP1.sprite = sprite;
    }
}
