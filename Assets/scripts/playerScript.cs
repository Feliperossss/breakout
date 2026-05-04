using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerScript : MonoBehaviour
{
    private Vector2 direction;
    private float playerInitialY;
    public float speed = 1;
    private void Start()
    {
    
    }
    public void move(InputAction.CallbackContext context)
    {
       direction = context.ReadValue<Vector2>();
       Debug.Log(direction);
    }

    public void playerMovement()
    {
      Cursor.visible = false;
      Cursor.lockState = CursorLockMode.Confined;
      
      Vector3 movement = new Vector3(direction.x, 0, 0);
      this.transform.position += movement * speed * Time.deltaTime;

    }

    public void Update()
    {
        playerMovement();
           
    }

}
