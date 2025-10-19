using UnityEngine;

public class ExitScript : MonoBehaviour
{

    public bool IsBlueExit;
    public ExitManager exitManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Blue") && IsBlueExit)
        {
            exitManager.BlueActive = true;
        }
        else if(other.CompareTag("Red") && !IsBlueExit)
        {
            exitManager.RedActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Blue") && IsBlueExit == true)
        {
            exitManager.BlueActive = false;
        }
        else if (other.CompareTag("Red") && !IsBlueExit)
        {
            exitManager.RedActive = false;
        }
    }
}
