using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public List<GameObject> triggerObjects;
    public bool IsLever;


    private Animator animator;
    

    private void OnCollisionEnter(Collision collision)
    {
        foreach(GameObject obj in triggerObjects)
        {
            animator = obj.GetComponent<Animator>();
            animator.SetBool("IsStoodOn", true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(!IsLever)
        {
            foreach (GameObject obj in triggerObjects)
            {
                animator = obj.GetComponent<Animator>();
                animator.SetBool("IsStoodOn", false);
            }
        }
    }
}
