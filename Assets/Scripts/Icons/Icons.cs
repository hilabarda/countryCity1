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

public enum Category
{
    Country,
    City,
    Animal,
    Growing,
    Inanimate
}
public class Icons : MonoBehaviour
{
    [SerializeField]
    AnswersData answersLetterAlefCategoryCountry;
    [SerializeField]
    AnswersData answersLetterAlefCategoryCity;
    [SerializeField]
    AnswersData answersLetterAlefCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterAlefCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterAlefCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterBetCategoryCountry;
    [SerializeField]
    AnswersData answersLetterBetCategoryCity;
    [SerializeField]
    AnswersData answersLetterBetCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterBetCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterBetCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterGimelCategoryCountry;
    [SerializeField]
    AnswersData answersLetterGimelCategoryCity;
    [SerializeField]
    AnswersData answersLetterGimelCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterGimelCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterGimelCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterDaletCategoryCountry;
    [SerializeField]
    AnswersData answersLetterDaletCategoryCity;
    [SerializeField]
    AnswersData answersLetterDaletCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterDaletCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterDaletCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterHeyCategoryCountry;
    [SerializeField]
    AnswersData answersLetterHeyCategoryCity;
    [SerializeField]
    AnswersData answersLetterHeyCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterHeyCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterHeyCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterVavCategoryCountry;
    [SerializeField]
    AnswersData answersLetterVavCategoryCity;
    [SerializeField]
    AnswersData answersLetterVavCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterVavCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterVavCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterZayinCategoryCountry;
    [SerializeField]
    AnswersData answersLetterZayinCategoryCity;
    [SerializeField]
    AnswersData answersLetterZayinCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterZayinCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterZayinCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterChetCategoryCountry;
    [SerializeField]
    AnswersData answersLetterChetCategoryCity;
    [SerializeField]
    AnswersData answersLetterChetCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterChetCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterChetCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterTetCategoryCountry;
    [SerializeField]
    AnswersData answersLetterTetCategoryCity;
    [SerializeField]
    AnswersData answersLetterTetCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterTetCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterTetCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterYudCategoryCountry;
    [SerializeField]
    AnswersData answersLetterYudCategoryCity;
    [SerializeField]
    AnswersData answersLetterYudCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterYudCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterYudCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterChafCategoryCountry;
    [SerializeField]
    AnswersData answersLetterChafCategoryCity;
    [SerializeField]
    AnswersData answersLetterChafCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterChafCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterChafCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterLamedCategoryCountry;
    [SerializeField]
    AnswersData answersLetterLamedCategoryCity;
    [SerializeField]
    AnswersData answersLetterLamedCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterLamedCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterLamedCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterMemCategoryCountry;
    [SerializeField]
    AnswersData answersLetterMemCategoryCity;
    [SerializeField]
    AnswersData answersLetterMemCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterMemCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterMemCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterNonCategoryCountry;
    [SerializeField]
    AnswersData answersLetterNonCategoryCity;
    [SerializeField]
    AnswersData answersLetterNonCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterNonCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterNonCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterSamechCategoryCountry;
    [SerializeField]
    AnswersData answersLetterSamechCategoryCity;
    [SerializeField]
    AnswersData answersLetterSamechCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterSamechCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterSamechCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterAyinCategoryCountry;
    [SerializeField]
    AnswersData answersLetterAyinCategoryCity;
    [SerializeField]
    AnswersData answersLetterAyinCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterAyinCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterAyinCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterPayCategoryCountry;
    [SerializeField]
    AnswersData answersLetterPayCategoryCity;
    [SerializeField]
    AnswersData answersLetterPayCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterPayCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterPayCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterTsadiCategoryCountry;
    [SerializeField]
    AnswersData answersLetterTsadiCategoryCity;
    [SerializeField]
    AnswersData answersLetterTsadiCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterTsadiCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterTsadiCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterKufCategoryCountry;
    [SerializeField]
    AnswersData answersLetterKufCategoryCity;
    [SerializeField]
    AnswersData answersLetterKufCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterKufCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterKufCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterReshCategoryCountry;
    [SerializeField]
    AnswersData answersLetterReshCategoryCity;
    [SerializeField]
    AnswersData answersLetterReshCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterReshCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterReshCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterShinCategoryCountry;
    [SerializeField]
    AnswersData answersLetterShinCategoryCity;
    [SerializeField]
    AnswersData answersLetterShinCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterShinCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterShinCategoryInanimate;

    [SerializeField]
    AnswersData answersLetterTavCategoryCountry;
    [SerializeField]
    AnswersData answersLetterTavCategoryCity;
    [SerializeField]
    AnswersData answersLetterTavCategoryAnimal;
    [SerializeField]
    AnswersData answersLetterTavCategoryGrowing;
    [SerializeField]
    AnswersData answersLetterTavCategoryInanimate;

    Dictionary<Category, AnswersData> answerDataDictLetterAlef = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterBet = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterGimel = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterDalet = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterHey = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterVav = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterZayin = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterChet = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterTet = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterYud = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterChaf = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterLamed = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterMem = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterNon = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterSamech = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterAyin = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterPay = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterTsadi = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterKuf = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterResh = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterShin = new Dictionary<Category, AnswersData>();
    Dictionary<Category, AnswersData> answerDataDictLetterTav = new Dictionary<Category, AnswersData>();

    Dictionary<Letters, Dictionary<Category, AnswersData>> answersSprites = new Dictionary<Letters, Dictionary<Category, AnswersData>>();

    




    private void Start()
    {
        answerDataDictLetterAlef.Add(Category.Country, answersLetterAlefCategoryCountry);
        answerDataDictLetterAlef.Add(Category.City, answersLetterAlefCategoryCity);
        answerDataDictLetterAlef.Add(Category.Animal, answersLetterAlefCategoryAnimal);
        answerDataDictLetterAlef.Add(Category.Growing, answersLetterAlefCategoryGrowing);
        answerDataDictLetterAlef.Add(Category.Inanimate, answersLetterAlefCategoryInanimate);

        answerDataDictLetterBet.Add(Category.Country, answersLetterBetCategoryCountry);
        answerDataDictLetterBet.Add(Category.City, answersLetterBetCategoryCity);
        answerDataDictLetterBet.Add(Category.Animal, answersLetterBetCategoryAnimal);
        answerDataDictLetterBet.Add(Category.Growing, answersLetterBetCategoryGrowing);
        answerDataDictLetterBet.Add(Category.Inanimate, answersLetterBetCategoryInanimate);

        answerDataDictLetterGimel.Add(Category.Country, answersLetterGimelCategoryCountry);
        answerDataDictLetterGimel.Add(Category.City, answersLetterGimelCategoryCity);
        answerDataDictLetterGimel.Add(Category.Animal, answersLetterGimelCategoryAnimal);
        answerDataDictLetterGimel.Add(Category.Growing, answersLetterGimelCategoryGrowing);
        answerDataDictLetterGimel.Add(Category.Inanimate, answersLetterGimelCategoryInanimate);

        answerDataDictLetterDalet.Add(Category.Country, answersLetterDaletCategoryCountry);
        answerDataDictLetterDalet.Add(Category.City, answersLetterDaletCategoryCity);
        answerDataDictLetterDalet.Add(Category.Animal, answersLetterDaletCategoryAnimal);
        answerDataDictLetterDalet.Add(Category.Growing, answersLetterDaletCategoryGrowing);
        answerDataDictLetterDalet.Add(Category.Inanimate, answersLetterDaletCategoryInanimate);

        answerDataDictLetterHey.Add(Category.Country, answersLetterHeyCategoryCountry);
        answerDataDictLetterHey.Add(Category.City, answersLetterHeyCategoryCity);
        answerDataDictLetterHey.Add(Category.Animal, answersLetterHeyCategoryAnimal);
        answerDataDictLetterHey.Add(Category.Growing, answersLetterHeyCategoryGrowing);
        answerDataDictLetterHey.Add(Category.Inanimate, answersLetterHeyCategoryInanimate);

        answerDataDictLetterVav.Add(Category.Country, answersLetterVavCategoryCountry);
        answerDataDictLetterVav.Add(Category.City, answersLetterVavCategoryCity);
        answerDataDictLetterVav.Add(Category.Animal, answersLetterVavCategoryAnimal);
        answerDataDictLetterVav.Add(Category.Growing, answersLetterVavCategoryGrowing);
        answerDataDictLetterVav.Add(Category.Inanimate, answersLetterVavCategoryInanimate);

        answerDataDictLetterZayin.Add(Category.Country, answersLetterZayinCategoryCountry);
        answerDataDictLetterZayin.Add(Category.City, answersLetterZayinCategoryCity);
        answerDataDictLetterZayin.Add(Category.Animal, answersLetterZayinCategoryAnimal);
        answerDataDictLetterZayin.Add(Category.Growing, answersLetterZayinCategoryGrowing);
        answerDataDictLetterZayin.Add(Category.Inanimate, answersLetterZayinCategoryInanimate);

        answerDataDictLetterChet.Add(Category.Country, answersLetterChetCategoryCountry);
        answerDataDictLetterChet.Add(Category.City, answersLetterChetCategoryCity);
        answerDataDictLetterChet.Add(Category.Animal, answersLetterChetCategoryAnimal);
        answerDataDictLetterChet.Add(Category.Growing, answersLetterChetCategoryGrowing);
        answerDataDictLetterChet.Add(Category.Inanimate, answersLetterChetCategoryInanimate);

        answerDataDictLetterTet.Add(Category.Country, answersLetterTetCategoryCountry);
        answerDataDictLetterTet.Add(Category.City, answersLetterTetCategoryCity);
        answerDataDictLetterTet.Add(Category.Animal, answersLetterTetCategoryAnimal);
        answerDataDictLetterTet.Add(Category.Growing, answersLetterTetCategoryGrowing);
        answerDataDictLetterTet.Add(Category.Inanimate, answersLetterTetCategoryInanimate);

        answerDataDictLetterYud.Add(Category.Country, answersLetterYudCategoryCountry);
        answerDataDictLetterYud.Add(Category.City, answersLetterYudCategoryCity);
        answerDataDictLetterYud.Add(Category.Animal, answersLetterYudCategoryAnimal);
        answerDataDictLetterYud.Add(Category.Growing, answersLetterYudCategoryGrowing);
        answerDataDictLetterYud.Add(Category.Inanimate, answersLetterYudCategoryInanimate);

        answerDataDictLetterChaf.Add(Category.Country, answersLetterChafCategoryCountry);
        answerDataDictLetterChaf.Add(Category.City, answersLetterChafCategoryCity);
        answerDataDictLetterChaf.Add(Category.Animal, answersLetterChafCategoryAnimal);
        answerDataDictLetterChaf.Add(Category.Growing, answersLetterChafCategoryGrowing);
        answerDataDictLetterChaf.Add(Category.Inanimate, answersLetterChafCategoryInanimate);

        answerDataDictLetterLamed.Add(Category.Country, answersLetterLamedCategoryCountry);
        answerDataDictLetterLamed.Add(Category.City, answersLetterLamedCategoryCity);
        answerDataDictLetterLamed.Add(Category.Animal, answersLetterLamedCategoryAnimal);
        answerDataDictLetterLamed.Add(Category.Growing, answersLetterLamedCategoryGrowing);
        answerDataDictLetterLamed.Add(Category.Inanimate, answersLetterLamedCategoryInanimate);

        answerDataDictLetterMem.Add(Category.Country, answersLetterMemCategoryCountry);
        answerDataDictLetterMem.Add(Category.City, answersLetterMemCategoryCity);
        answerDataDictLetterMem.Add(Category.Animal, answersLetterMemCategoryAnimal);
        answerDataDictLetterMem.Add(Category.Growing, answersLetterMemCategoryGrowing);
        answerDataDictLetterMem.Add(Category.Inanimate, answersLetterMemCategoryInanimate);

        answerDataDictLetterNon.Add(Category.Country, answersLetterNonCategoryCountry);
        answerDataDictLetterNon.Add(Category.City, answersLetterNonCategoryCity);
        answerDataDictLetterNon.Add(Category.Animal, answersLetterNonCategoryAnimal);
        answerDataDictLetterNon.Add(Category.Growing, answersLetterNonCategoryGrowing);
        answerDataDictLetterNon.Add(Category.Inanimate, answersLetterNonCategoryInanimate);

        answerDataDictLetterSamech.Add(Category.Country, answersLetterSamechCategoryCountry);
        answerDataDictLetterSamech.Add(Category.City, answersLetterSamechCategoryCity);
        answerDataDictLetterSamech.Add(Category.Animal, answersLetterSamechCategoryAnimal);
        answerDataDictLetterSamech.Add(Category.Growing, answersLetterSamechCategoryGrowing);
        answerDataDictLetterSamech.Add(Category.Inanimate, answersLetterSamechCategoryInanimate);

        answerDataDictLetterAyin.Add(Category.Country, answersLetterAyinCategoryCountry);
        answerDataDictLetterAyin.Add(Category.City, answersLetterAyinCategoryCity);
        answerDataDictLetterAyin.Add(Category.Animal, answersLetterAyinCategoryAnimal);
        answerDataDictLetterAyin.Add(Category.Growing, answersLetterAyinCategoryGrowing);
        answerDataDictLetterAyin.Add(Category.Inanimate, answersLetterAyinCategoryInanimate);

        answerDataDictLetterPay.Add(Category.Country, answersLetterPayCategoryCountry);
        answerDataDictLetterPay.Add(Category.City, answersLetterPayCategoryCity);
        answerDataDictLetterPay.Add(Category.Animal, answersLetterPayCategoryAnimal);
        answerDataDictLetterPay.Add(Category.Growing, answersLetterPayCategoryGrowing);
        answerDataDictLetterPay.Add(Category.Inanimate, answersLetterPayCategoryInanimate);

        answerDataDictLetterTsadi.Add(Category.Country, answersLetterTsadiCategoryCountry);
        answerDataDictLetterTsadi.Add(Category.City, answersLetterTsadiCategoryCity);
        answerDataDictLetterTsadi.Add(Category.Animal, answersLetterTsadiCategoryAnimal);
        answerDataDictLetterTsadi.Add(Category.Growing, answersLetterTsadiCategoryGrowing);
        answerDataDictLetterTsadi.Add(Category.Inanimate, answersLetterTsadiCategoryInanimate);

        answerDataDictLetterKuf.Add(Category.Country, answersLetterKufCategoryCountry);
        answerDataDictLetterKuf.Add(Category.City, answersLetterKufCategoryCity);
        answerDataDictLetterKuf.Add(Category.Animal, answersLetterKufCategoryAnimal);
        answerDataDictLetterKuf.Add(Category.Growing, answersLetterKufCategoryGrowing);
        answerDataDictLetterKuf.Add(Category.Inanimate, answersLetterKufCategoryInanimate);

        answerDataDictLetterResh.Add(Category.Country, answersLetterReshCategoryCountry);
        answerDataDictLetterResh.Add(Category.City, answersLetterReshCategoryCity);
        answerDataDictLetterResh.Add(Category.Animal, answersLetterReshCategoryAnimal);
        answerDataDictLetterResh.Add(Category.Growing, answersLetterReshCategoryGrowing);
        answerDataDictLetterResh.Add(Category.Inanimate, answersLetterReshCategoryInanimate);

        answerDataDictLetterShin.Add(Category.Country, answersLetterShinCategoryCountry);
        answerDataDictLetterShin.Add(Category.City, answersLetterShinCategoryCity);
        answerDataDictLetterShin.Add(Category.Animal, answersLetterShinCategoryAnimal);
        answerDataDictLetterShin.Add(Category.Growing, answersLetterShinCategoryGrowing);
        answerDataDictLetterShin.Add(Category.Inanimate, answersLetterShinCategoryInanimate);

        answerDataDictLetterTav.Add(Category.Country, answersLetterTavCategoryCountry);
        answerDataDictLetterTav.Add(Category.City, answersLetterTavCategoryCity);
        answerDataDictLetterTav.Add(Category.Animal, answersLetterTavCategoryAnimal);
        answerDataDictLetterTav.Add(Category.Growing, answersLetterTavCategoryGrowing);
        answerDataDictLetterTav.Add(Category.Inanimate, answersLetterTavCategoryInanimate);


        answersSprites.Add(Letters.Alef, answerDataDictLetterAlef);
        answersSprites.Add(Letters.Bet, answerDataDictLetterBet);
        answersSprites.Add(Letters.Gimel, answerDataDictLetterGimel);
        answersSprites.Add(Letters.Dalet, answerDataDictLetterDalet);
        answersSprites.Add(Letters.Hey, answerDataDictLetterHey);
        answersSprites.Add(Letters.Vav, answerDataDictLetterVav);
        answersSprites.Add(Letters.Zayin, answerDataDictLetterZayin);
        answersSprites.Add(Letters.Chet, answerDataDictLetterChet);
        answersSprites.Add(Letters.Tet, answerDataDictLetterTet);
        answersSprites.Add(Letters.Yud, answerDataDictLetterYud);
        answersSprites.Add(Letters.Chaf, answerDataDictLetterChaf);
        answersSprites.Add(Letters.Lamed, answerDataDictLetterLamed);
        answersSprites.Add(Letters.Mem, answerDataDictLetterMem);
        answersSprites.Add(Letters.Non, answerDataDictLetterNon);
        answersSprites.Add(Letters.Samech, answerDataDictLetterSamech);
        answersSprites.Add(Letters.Ayin, answerDataDictLetterAyin);
        answersSprites.Add(Letters.Pay, answerDataDictLetterPay);
        answersSprites.Add(Letters.Tsadi, answerDataDictLetterTsadi);
        answersSprites.Add(Letters.Kuf, answerDataDictLetterKuf);
        answersSprites.Add(Letters.Resh, answerDataDictLetterResh);
        answersSprites.Add(Letters.Shin, answerDataDictLetterShin);
        answersSprites.Add(Letters.Tav, answerDataDictLetterTav);

    }

    private List<Sprite> GetAnswers (Letters letter, Category category)
    {
        List<IconsManager> a1 = answersSprites[Letters.Alef][Category.Country].answerIconData;
     
        List<Sprite> spritesAns = null;

        for(int i = 0; i < a1.Count; i++)
        {
            spritesAns.Add(a1[i].Icon);
        }

        return spritesAns;
    }

    [System.Serializable]
    public class AnswersData
    {
        public List<IconsManager> answerIconData;
    }
}
