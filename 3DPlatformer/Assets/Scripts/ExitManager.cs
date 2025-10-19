using UnityEngine;

public class ExitManager : MonoBehaviour
{
    public bool RedActive = false;
    public bool BlueActive = false;
    public LevelManager LevelManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RedActive && BlueActive)
        {
            LevelManager.NextLevel();
        }

    }
}
