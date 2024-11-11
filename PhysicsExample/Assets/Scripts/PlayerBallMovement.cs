using UnityEngine;

public class PlayerBallMovement : MonoBehaviour
{
    private SpherePhysics spherePhysics;
    public float movementSpeed = 10f;
    public Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        spherePhysics = GetComponent<SpherePhysics>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        if (Input.GetKey(KeyCode.W))
            spherePhysics.velocity += forward * movementSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            spherePhysics.velocity += -forward * movementSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            spherePhysics.velocity += -right * movementSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            spherePhysics.velocity += right * movementSpeed * Time.deltaTime;
    }
}