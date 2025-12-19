using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody body;
    public float minInitialImpulse = 12f;
    public float maxInitialImpulse = 16f;
    public float maxTorque = 1.5f;
    public float maxInitialX;
    public float initialY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.AddForce(RandomUpwardForce(), ForceMode.Impulse);
        body.AddTorque(RandomTorque(),RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = new Vector2(RandomInitialX(), initialY);
    }

    float RandomInitialX()
    {
        return Random.Range(-maxInitialX, maxInitialX);
    }


    Vector3 RandomUpwardForce()
    {
        return Vector3.up * Random.Range(minInitialImpulse, maxInitialImpulse);
    }


    float RandomTorque()
    {
        return Random.Range(maxTorque, -maxTorque);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }



}
