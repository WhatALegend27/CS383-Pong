using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour
{
    [Header("Score UI Objects")]
    public TMP_Text p1ScoreText;
    public TMP_Text p2ScoreText;

    [Header("Game Over UI Objects")]
    public GameObject gameOverPanel;
    public TMP_Text gameOverBodyText;

    [Header("Max Score")]
    public int maxScore = 10;

    public void UpdateScore(int player1Score, int player2Score)
    {
        p1ScoreText.text = player1Score.ToString();
        p2ScoreText.text = player2Score.ToString();

        if (player1Score >= maxScore)
            GameOver("PLAYER 1 WINS!");
        if (player2Score >= maxScore)
            GameOver("PLAYER 2 WINS!");
    }

    void GameOver(string gameOverMessage)
    {
        gameOverPanel.SetActive(true);
        gameOverBodyText.text = gameOverMessage;

        Time.timeScale = 0f;
    }
}
