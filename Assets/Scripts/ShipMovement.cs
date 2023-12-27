using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var pos = transform.position;
        //Debug.LogError(pos);

        var centerDirection = new Vector2(-pos.x, -pos.y);
        
        var relativeForce = centerDirection / 10.0f;
        _rigidbody2D.AddForce(relativeForce);
        
        _rigidbody2D.angularVelocity = 10.0f;
    }
}
