using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    [SerializeField] private string currentScene;
    [SerializeField] private string nextLevel;

    public void RestartLevel()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
