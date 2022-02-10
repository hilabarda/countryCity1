using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Icons Manager", menuName = "Icon", order = 51)]

public class IconsManager : ScriptableObject
{
    [SerializeField]
    private string category;
    [SerializeField]
    private string iconLetter;
    [SerializeField]
    private string iconName;
    [SerializeField]
    public Sprite icon;
    [SerializeField]
    private int iconScore;

    public string Category => category;
    public string IconLetter => iconLetter;
    public string IconName => iconName;
    public Sprite Icon => icon;
    public int IconScore => iconScore;

}
