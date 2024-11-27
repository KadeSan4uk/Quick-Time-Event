using UnityEngine;


public class InputHandler : MonoBehaviour
{
    public GameManager gameManager;

    private PlayerInputActions _action;

    private void Awake()
    {
        _action = new PlayerInputActions();
        _action.Enable();
        _action.Player.Left.started += _ => gameManager.CheckHit(0);
        _action.Player.Middle.started += _ => gameManager.CheckHit(1);
        _action.Player.Right.started += _ => gameManager.CheckHit(2);
    }    
}
