using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayIcon : MonoBehaviour
{
    public IconsManager iconsManager;
    [SerializeField]
    private Image iconImage;

    private void Start()
    {
        iconImage.sprite = iconsManager.icon;
    }

}
