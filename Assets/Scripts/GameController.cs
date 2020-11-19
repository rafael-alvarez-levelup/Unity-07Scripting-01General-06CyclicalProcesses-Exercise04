using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private EndPoint endPoint;

    private void OnEnable()
    {
        endPoint.OnReached += EndPoint_OnReached;
    }

    private void OnDisable()
    {
        endPoint.OnReached -= EndPoint_OnReached;
    }

    private void EndPoint_OnReached()
    {
        endPoint.OnReached -= EndPoint_OnReached;

        GameOver();
    }

    private void GameOver()
    {
        SceneManager.LoadScene(1);
    }
}