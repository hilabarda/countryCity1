using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class UiManager : MonoBehaviour
{
    
    

    [SerializeField]
    private Image countryImage;
    private Color color;
    

    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private playerControler player;

    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>();
        gameManager.OnIconCollected += ChangeIconsCollectedText;
        gameManager.OnAllIconsCollected += DisplayWinText;
        player = GameObject.FindObjectOfType<playerControler>().GetComponent<playerControler>();
        
    }

    private void DisplayWinText()
    {
        ChangeIconsCollectedText(gameManager.MaxIcons);
    }

    private void ChangeIconsCollectedText(int icons)
    {
        


    }

   


    public void ClickEndGameButtom()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }



}
