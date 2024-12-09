using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainmenuManager : MonoBehaviour
{
    public GameObject mainMenuUI;
    [SerializeField]
    private TMP_Text highScoreText;
    private bool gameStarted = false;
    void Start(){
        //Display main menu and freez game
        mainMenuUI.SetActive(true);
        Time.timeScale = 0;

        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + highScore.ToString();
    }

    // Update is called once per frame
    public void StartGame(){
        // Hide the main menu and start the game
        mainMenuUI.SetActive(false);
        Time.timeScale = 1;
        gameStarted = true;
    }
}
