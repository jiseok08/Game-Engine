using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidBody;

    float horizontal;
    float vertical;


    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rigidBody.AddForce(direction * speed, ForceMode.Force);
    }


}
