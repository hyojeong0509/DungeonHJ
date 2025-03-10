using UnityEngine;

public class _Camera : MonoBehaviour
{
    public Transform player;  
    public float distance = 5.0f;  
    public float height = 2.0f;  
    public float rotationSpeed = 3.0f;  

    private float currentRotation = 0.0f;

    void Update()
    { 
        currentRotation += Input.GetAxis("Mouse X") * rotationSpeed;
        float horizontal = Mathf.Sin(currentRotation) * distance;
        float vertical = Mathf.Cos(currentRotation) * distance;

        transform.position = player.position + new Vector3(horizontal, height, vertical);

        transform.LookAt(player);
    }
}

