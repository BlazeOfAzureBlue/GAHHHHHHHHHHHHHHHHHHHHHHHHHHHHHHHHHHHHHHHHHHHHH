using UnityEngine;

public class WaterScript : MonoBehaviour
{
    [SerializeField] private bool AllowRed;
    [SerializeField] private bool AllowBlue;
    [SerializeField] private GameObject GameOverScreen;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Red") || collision.transform.CompareTag("Blue"))
        {
            if (!AllowBlue && !AllowRed)
            {
                print("Restarting level..");
                Cursor.lockState = CursorLockMode.Confined;
                GameOverScreen.SetActive(true);
            }
            else if (!AllowRed && collision.transform.CompareTag("Red"))
            {
                print("Restarting level..");
                Cursor.lockState = CursorLockMode.Confined;
                GameOverScreen.SetActive(true);
            }
            else if (!AllowBlue && collision.transform.CompareTag("Blue"))
            {
                print("Restarting level..");
                Cursor.lockState = CursorLockMode.Confined;
                GameOverScreen.SetActive(true);
            }
        }
    }
}
