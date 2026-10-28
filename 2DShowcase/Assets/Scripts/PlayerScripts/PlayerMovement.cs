using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float maxMoveSpeed = 15f;
    public Vector2 moveDir = new Vector2(0, 0);
    public void OnMove(InputValue value)
    {
        moveDir = value.Get<Vector2>();
        GetComponent<Rigidbody2D>().linearVelocity = moveDir * moveSpeed;
    }
    public void WhenMove()
    {

        if (Keyboard.current.aKey.isPressed || Keyboard.current.sKey.isPressed || Keyboard.current.dKey.isPressed || Keyboard.current.wKey.isPressed)
        {
            moveSpeed += 0.2f;
            if (moveSpeed > maxMoveSpeed)
            {
                moveSpeed = maxMoveSpeed;
            }
        }
        else if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.leftArrowKey.isPressed || Keyboard.current.upArrowKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            moveSpeed += 0.2f;
            if (moveSpeed > maxMoveSpeed)
            {
                moveSpeed = maxMoveSpeed;
            }
        }
        else
        {
            moveSpeed = 1;
        }
    }
    public void Update()
    {
        GetComponent<Rigidbody2D>().linearVelocity = moveDir * moveSpeed;
        WhenMove();
    }
}
