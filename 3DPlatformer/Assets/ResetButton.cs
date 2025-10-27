using UnityEngine;

public class ResetButton : MonoBehaviour
{

    private Vector3 objectPosition;
    private Rigidbody physicsObjectRigidbody;
    public GameObject physicsObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        physicsObjectRigidbody = physicsObject.GetComponent<Rigidbody>();
        objectPosition = physicsObject.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        print(objectPosition);
        print("I HATE TIS HIF+CVHsdjiogfj");
        physicsObjectRigidbody.linearVelocity = Vector3.zero;
        physicsObject.transform.position = objectPosition;
        physicsObject.transform.rotation = new Quaternion(0, 0, 0, 0);
       
    }
}
