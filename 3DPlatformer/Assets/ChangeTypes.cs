using UnityEngine;

public class ChangeTypes : MonoBehaviour
{

    public GameObject popup;


    private void OnTriggerEnter(Collider other)
    {
        popup.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        popup.SetActive(false);
    }
}
