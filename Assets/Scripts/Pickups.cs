using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Pickups : MonoBehaviour
{
    public TMP_Text scoreText;

    private void Start()
    {
        Scoring.totalScore = 0;
        scoreText.text = "SCORE: " + Scoring.totalScore;
    }
    private void Update()
    {
        if (Scoring.totalScore >= 3)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
            Scoring.totalScore = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Gem")
        {
            Scoring.totalScore++;
            AudioManager.Instance.PlaySfx(1);
            scoreText.text = "SCORE: " + Scoring.totalScore;
            Destroy(collision.gameObject);
        }
    }
}
