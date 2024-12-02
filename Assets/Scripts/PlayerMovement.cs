using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 100f;
    [SerializeField] float xClampRange = 50f;
 
    Vector3 movement;
    // Update is called once per frame
    void Update()
    {
        ProcessTranslationZ();
        ProcessTranslationY();
    }

    void ProcessTranslationZ()
    {   
        // // xOffset is the movement speed (x-axis) multiplied a speed modifier and time 
        // since last frame. 
        float xOffset = movement.x * controlSpeed * Time.deltaTime;
        float rawXPosition = xOffset;
        float clampedXPosition = Mathf.Clamp(rawXPosition, -xClampRange, xClampRange);
        transform.localPosition += new Vector3(0f, 0f, -clampedXPosition);
  
    }

    void ProcessTranslationY()
    {
        float yOffset = movement.y * controlSpeed * Time.deltaTime;
        transform.localPosition += new Vector3(0f, yOffset, 0f);
    }    

    public void OnMovement(InputValue value) 
    {
        Debug.Log(movement);
        movement = value.Get<Vector2>();

    }
}
