using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private Sprite icon;
    [SerializeField]
    private int iconScore;

    public string IconName => iconName;
    public Sprite Icon => icon;
    public int IconScore => iconScore;

}
