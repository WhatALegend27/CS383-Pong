using UnityEngine;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    [Header("UI Objects")]
    public TMP_Text gameOverText;

    public void SetGameOverText(int player1Score, int player2Score)
    {
        if (player1Score > player2Score)
            gameOverText.text = "Left Side wins!";
        else
            gameOverText.text = "Right Side wins!";
    }
}
