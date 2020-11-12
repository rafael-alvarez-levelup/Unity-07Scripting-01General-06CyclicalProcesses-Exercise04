using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool IsGameOver { get; private set; }

    private EndPoint _endPoint;

    private void Awake()
    {
        _endPoint = FindObjectOfType<EndPoint>();
    }

    private void Update()
    {
        if (_endPoint.IsEnter && !IsGameOver)
        {
            GameOver();

            IsGameOver = true;
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
