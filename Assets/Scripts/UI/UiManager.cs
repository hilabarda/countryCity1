using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class UiManager : MonoBehaviour
{
    
    [SerializeField]
    private Text playerScoreTextP1;
    [SerializeField]
    private Text playerScoreTextP2;

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
        gameManager.OnIconCollected += ChangeIconsCollectedImage;
        gameManager.OnAllIconsCollected += DisplayWinText;
        player = GameObject.FindObjectOfType<playerControler>().GetComponent<playerControler>();
        
    }

    private void DisplayWinText()
    {
        ChangeIconsCollectedText(gameManager.MaxIcons);
        ChangeIconsCollectedImage(gameManager.MaxIcons);
    }

    private void ChangeIconsCollectedText(int icons)
    {
        if (player.myPlayer == PlayerNumber.Player1)
        {
            playerScoreTextP1.text = $"Score: {icons.ToString()}";
        }
        if (player.myPlayer == PlayerNumber.Player2)
        {
            playerScoreTextP2.text = $"Score: {icons.ToString()}";
        }


    }

    private void ChangeIconsCollectedImage(int Color)
    {
        countryImage.GetComponent<Image>(Color = new Color (100, 50, 100));
        Debug.Log("image");
    }


    public void ClickEndGameButtom()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }



}
