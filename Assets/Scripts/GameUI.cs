using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI userNameText;
    [SerializeField]
    private TMPro.TextMeshProUGUI scoreText;
    int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        userNameText.text = GameManager.Instance.UserName;
    }

    internal void AddScore(int scoreValue)
    {
        scoreText.text = "Score: " + (score += scoreValue).ToString();
    }
}
