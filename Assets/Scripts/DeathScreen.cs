using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public GameObject deathUI;
    [SerializeField]
    private TMP_Text currentScoreText;
    private bool isDead = false;

    
    public void showDeathScreen(){
        isDead = true;
        deathUI.SetActive(true);

        Time.timeScale = 0;

        int currentScore = PlayerPrefs.GetInt("CurrentScore", 0);
        currentScoreText.text = "High Score: " + currentScore.ToString();
    }

    public void mainMenu(){
        isDead = false;
        SceneManager.LoadScene("GameScene");
    }
}
