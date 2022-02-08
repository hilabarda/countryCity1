using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Letters
{
    Alef,
    Bet,
    Gimel,
    Dalet,
    Hey,
    Vav,
    Zayin,
    Chet,
    Tet,
    Yud,
    Chaf,
    Lamed,
    Mem,
    Non,
    Samech,
    Ayin,
    Pay,
    Tsadi,
    Kuf,
    Resh,
    Shin,
    Tav
}
public class Icons : MonoBehaviour
{
    [SerializeField]
    private List<IconsManager> icons;
    [SerializeField]
    private List<List<Texture>> answers = new List<List<Texture>>();
    private Dictionary<Letters, List<Texture>> texturesDict = new Dictionary<Letters, List<Texture>>();

    public List<List<Texture>> Answers => answers;
    public Dictionary<Letters, List<Texture>> TexturesDict => texturesDict;

    private void Start()
    {
        texturesDict.Add(Letters.Alef, answers[0]);
        texturesDict.Add(Letters.Bet, answers[1]);
        texturesDict.Add(Letters.Gimel, answers[2]);
        texturesDict.Add(Letters.Dalet, answers[3]);
        texturesDict.Add(Letters.Hey, answers[4]);
        texturesDict.Add(Letters.Vav, answers[5]);
        texturesDict.Add(Letters.Zayin, answers[6]);
        texturesDict.Add(Letters.Chet, answers[7]);
        texturesDict.Add(Letters.Tet, answers[8]);
        texturesDict.Add(Letters.Yud, answers[9]);
        texturesDict.Add(Letters.Chaf, answers[10]);
        texturesDict.Add(Letters.Lamed, answers[11]);
        texturesDict.Add(Letters.Mem, answers[12]);
        texturesDict.Add(Letters.Non, answers[13]);
        texturesDict.Add(Letters.Samech, answers[14]);
        texturesDict.Add(Letters.Ayin, answers[15]);
        texturesDict.Add(Letters.Pay, answers[16]);
        texturesDict.Add(Letters.Tsadi, answers[17]);
        texturesDict.Add(Letters.Kuf, answers[18]);
        texturesDict.Add(Letters.Resh, answers[19]);
        texturesDict.Add(Letters.Shin, answers[20]);
        texturesDict.Add(Letters.Tav, answers[21]);
    }

    private List<Texture> GetAnswers (Letters letter)
    {
        return texturesDict[letter];
    }
}
