using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum CategoryIcon
{
    Country,
    City,
    Animal,
    Growing,
    Inanimate

}

[CreateAssetMenu(fileName = "New Icons Manager", menuName = "Icon", order = 51)]

public class IconsManager : ScriptableObject
{
    [SerializeField]
    private CategoryIcon types;
    [SerializeField]
    private string iconLetter;
    [SerializeField]
    private string iconName;
    [SerializeField]
    public GameObject gameObjectIcon;
    [SerializeField]
    private int iconScore;

    public CategoryIcon Types => types;
    public string IconLetter => iconLetter;
    public string IconName => iconName;
    public GameObject GameObjectIcon => gameObjectIcon;
    public int IconScore => iconScore;

}
