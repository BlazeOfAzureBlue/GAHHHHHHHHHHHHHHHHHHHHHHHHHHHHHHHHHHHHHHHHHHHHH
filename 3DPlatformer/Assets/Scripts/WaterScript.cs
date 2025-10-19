using UnityEngine;

public class WaterScript : MonoBehaviour
{
    [SerializeField] private bool AllowRed;
    [SerializeField] private bool AllowBlue;
    [SerializeField] private LevelManager LevelManager;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Red") || collision.transform.CompareTag("Blue"))
        {
            if (!AllowBlue && !AllowRed)
            {
                print("Restarting level..");
                LevelManager.RestartLevel();
            }
            else if (!AllowRed && collision.transform.CompareTag("Red"))
            {
                print("Restarting level..");
                LevelManager.RestartLevel();
            }
            else if (!AllowBlue && collision.transform.CompareTag("Blue"))
            {
                print("Restarting level..");
                LevelManager.RestartLevel();
            }
        }
    }
}
