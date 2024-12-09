using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int currentScore = 0;
    public int highScore = 0;

    void Start()
    {
        // Load high score from PlayerPrefs
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public void AddPoint()
    {
        currentScore++;
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore); // Save high score
        }
    }

    public void ResetScore()
    {
        currentScore = 0;
    }
}
