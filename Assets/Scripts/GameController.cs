using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private EndPoint endPoint;

    private void OnEnable()
    {
        endPoint.OnEndPointReached += EndPoint_OnEndPointReached;
    }

    private void OnDisable()
    {
        endPoint.OnEndPointReached -= EndPoint_OnEndPointReached;
    }

    private void EndPoint_OnEndPointReached()
    {
        endPoint.OnEndPointReached -= EndPoint_OnEndPointReached;

        GameOver();
    }

    private void GameOver()
    {
        SceneManager.LoadScene(1);
    }
}