using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private GameObject _gameOverCanvas;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(_gameOverCanvas);
        }
        
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);

        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        _gameOverCanvas.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
