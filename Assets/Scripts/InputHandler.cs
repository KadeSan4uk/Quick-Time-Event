using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameManager gameManager; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameManager.CheckHit(0); 
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameManager.CheckHit(1); 
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameManager.CheckHit(2); 
        }
    }
}
