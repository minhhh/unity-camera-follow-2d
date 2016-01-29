using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private float velocity = 10;

    // Use this for initialization
    void Start ()
    {
    
    }
    
    // Update is called once per frame
    void FixedUpdate ()
    {
        // Cache the inputs.
        float h = Input.GetAxis ("Horizontal");
        float v = Input.GetAxis ("Vertical");

        this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocity * h, this.GetComponent<Rigidbody2D> ().velocity.y);

        if (v != 0) {
            this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (this.GetComponent<Rigidbody2D> ().velocity.x, velocity * v);
        }
    }
}
