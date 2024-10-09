using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public float scoreValue = 0f;
    public float highScoredValue;
    public float pointIncreasedPerSecond = 1f;
    public bool scoreIncreasing;

    void Start()
    {
        if (PlayerPrefs.GetFloat("HighScore") != null)
        {
            highScoredValue = PlayerPrefs.GetFloat("HighScore");
        }


    }

    void FixedUpdate()
    {
        scoreText.text = "SCORE: " + Mathf.Round(scoreValue);
        highScoreText.text = "HIGH SCORE: " + Mathf.Round(highScoredValue);

        if (scoreIncreasing)
        {
            scoreValue += pointIncreasedPerSecond * Time.fixedDeltaTime;
        }

        if (scoreValue > highScoredValue)
        {
            highScoredValue = scoreValue;
            PlayerPrefs.SetFloat("HighScore", highScoredValue);
        }
    }
}
