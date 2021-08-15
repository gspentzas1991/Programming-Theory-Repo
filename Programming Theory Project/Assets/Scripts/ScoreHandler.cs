using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    private int score;
    [SerializeField] private TMP_Text highscoreText;
    [SerializeField] private TMP_Text scoreText;

    public void IncreaseScore(int scoreValue)
    {
        score += scoreValue;
        UpdateScoreText();
        if (score>DataManager.GetBestScore().Score)
        {
            var scoreModel = new ScoreModel();
            scoreModel.Username = DataManager.username;
            scoreModel.Score = score;
            DataManager.SaveBestScore(scoreModel);
            GameManager.Instance.UpdateHighscore(highscoreText);
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = $"Score: {score}";
    }
}
