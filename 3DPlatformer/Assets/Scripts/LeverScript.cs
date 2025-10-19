using UnityEngine;

public class LeverScript : MonoBehaviour
{
    public GameObject triggerObject;

    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Red") || collision.transform.CompareTag("Blue"))
        {
            animator.SetBool("IsStoodOn", true);
        }
    }

    private void Start()
    {
        animator = triggerObject.GetComponent<Animator>();
    }
}
