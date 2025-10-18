using UnityEngine;

public class WaterScript : MonoBehaviour
{
    [SerializeField] private bool AllowRed;
    [SerializeField] private bool AllowBlue;
    [SerializeField] private LevelManager LevelManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(!AllowBlue && !AllowRed)
        {
            if()
        }
    }
}
