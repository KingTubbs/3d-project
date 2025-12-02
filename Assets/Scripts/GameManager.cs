using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool isGameOver = false;

    public int score = 0;
    public TMP_Text scoreText;      // TMP version
    public GameObject gameOverScreen;

    public GameObject player;

    void Awake()
    {
        Instance = this;
        gameOverScreen.SetActive(false);
    }

    public void AddScore(int amount)
    {
        if (isGameOver) return;
        score += amount;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverScreen.SetActive(true);
        Destroy(player);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (!isGameOver && score >= 20)
            GameOver();
    }
}