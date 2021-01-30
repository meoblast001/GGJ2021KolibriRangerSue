using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField ] private Transform _camera;

    private Rigidbody _rigidbody;

    public Vector2 MoveDeltaDirection { get; set; } = default;
    public Vector2 LookDeltaDirection { get; set; } = default;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var xLookDeltaEuler = new Vector3(0f, LookDeltaDirection.x, 0f);
        transform.Rotate(xLookDeltaEuler);

        var yLookDeltaEuler = new Vector3(-LookDeltaDirection.y, 0f, 0f);
        _camera.Rotate(yLookDeltaEuler);
    }

    private void FixedUpdate()
    {
        var moveDelta = transform.TransformDirection(new Vector3(MoveDeltaDirection.x, 0f, MoveDeltaDirection.y));
        _rigidbody.MovePosition(transform.position + (moveDelta * 2f * Time.fixedDeltaTime));
    }
}
