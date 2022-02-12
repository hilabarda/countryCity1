using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayIcon : MonoBehaviour
{
    public IconsManager iconsManager;
    [SerializeField]
    private Sprite iconImage;

    private void Start()
    {
        iconImage = iconsManager.icon;
    }

}
