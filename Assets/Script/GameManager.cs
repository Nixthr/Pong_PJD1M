using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int playerScore;
    [SerializeField] private int aiScore;
    [SerializeField] private TextMeshProUGUI playerScoreText;
    [SerializeField] private TextMeshProUGUI aiScoreText;

    public void PlayerAddPoint()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();

    }
    
}
