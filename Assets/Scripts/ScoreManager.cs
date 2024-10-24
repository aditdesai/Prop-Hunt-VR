using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    private int score = 0;
    [SerializeField] int scoreToFinish = 50;

    [SerializeField] UnityEvent OnFinishEvent;

    public void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score: " + score.ToString();

        if (score >= scoreToFinish)
        {
            OnFinishEvent.Invoke();
        }
    }
}
