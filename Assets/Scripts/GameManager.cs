using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int maxIcons = 5;

    private int iconsCollected = 0;
    private Color iconsCollectedColor;


    public UnityAction OnAllIconsCollected;
    public UnityAction<int> OnIconCollected;
    public UnityAction<Color> OnIconCollectedColor;

    public int Icons
    {
        get { return iconsCollected; }
        set { iconsCollected = value;
            if(iconsCollected >= maxIcons)
            {
                OnAllIconsCollected?.Invoke();
            }
            else
            {
                OnIconCollected?.Invoke(iconsCollected);
            }
        }
    }

    //public Color IconsColor
    //{
        //get { return iconsCollectedColor; }
        //set { iconsCollectedColor = value;
            //if (iconsCollectedColor)
            //{
                //OnIconCollectedColor?.Invoke();
            //}
        //}
    //}

    public int MaxIcons
    {
        get { return maxIcons; }
    }
}
