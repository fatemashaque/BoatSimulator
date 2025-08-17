using UnityEngine;

public class BoatFloatManager : MonoBehaviour
{
    public float floatStrength = 10f;
    public float waterLevel = 0.5f;
    private Rigidbody boatRigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boatRigidBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (transform.position.y < waterLevel)
        {
            float depth = waterLevel - transform.position.y;
            boatRigidBody.AddForce(Vector3.up * floatStrength * depth, ForceMode.Force);
        }
    }
}
