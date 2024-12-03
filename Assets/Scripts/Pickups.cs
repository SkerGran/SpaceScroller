using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pickups : MonoBehaviour
{
    public TMP_Text scoreText;

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
