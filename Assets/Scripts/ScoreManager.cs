using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text finalScoree;
    [SerializeField] private GameObject scoreTextt;
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private GameObject finalScore;
    [SerializeField] private GameObject backGr;
    
    public int score;
    public bool isFinish=false;

    private void Awake()
    {
        instance = this;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            score++;
            scoreText.SetText("Score : " + score);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Gate"))
        {
            score = score * 2;
            scoreText.SetText("Score : " + score);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("ExtraGate"))
        {
            score = score * 3;
            scoreText.SetText("Score : " + score);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Decrease"))
        {
            score -= 2;
            scoreText.SetText("Score : " + score);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Net"))
        {
            isFinish = true;
            gameOverText.SetActive(true);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Finish"))
        {
            isFinish = true;
            winText.SetActive(true);
        }
    }
    private void Update()
    {
        if (isFinish)
        {
            Finish();
        }
    }

    public void Finish()
    {
        finalScoree.SetText("Score : " + score);
        scoreTextt.SetActive(false);
        backGr.SetActive(true);
        finalScore.SetActive(true);
    }
}
