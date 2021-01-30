using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform _camera;
    [SerializeField] private float _forwardSpeed = 2f;
    [SerializeField] private float _directionChange = 2f;
    [SerializeField] private float _lockVerticalViewTop = 340;
    [SerializeField] private float _lockVerticalViewBottom = 30;

    private Rigidbody _rigidbody;

    public Vector2 MoveDeltaDirection { get; set; } = default;
    public Vector2 LookDeltaDirection { get; set; } = default;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var xLookDeltaEuler = new Vector3(0f, LookDeltaDirection.x * _directionChange, 0f);
        transform.Rotate(xLookDeltaEuler * Time.deltaTime);

        var yLookDeltaEuler = new Vector3(-LookDeltaDirection.y * _directionChange, 0f, 0f);
        _camera.Rotate(yLookDeltaEuler * Time.deltaTime);

        var eulerAngles = _camera.eulerAngles;

        if (eulerAngles.x >= _lockVerticalViewTop || eulerAngles.x <= _lockVerticalViewBottom)
        {
            return;
        }

        var half = (_lockVerticalViewTop - _lockVerticalViewBottom) / 2f;
        var eulerX = (_camera.eulerAngles.x - half) < 0 ? _lockVerticalViewBottom : _lockVerticalViewTop;
        _camera.eulerAngles = new Vector3(eulerX, eulerAngles.y, eulerAngles.z);
    }

    private void FixedUpdate()
    {
        var moveDelta = transform.TransformDirection(new Vector3(MoveDeltaDirection.x, 0f, MoveDeltaDirection.y));
        _rigidbody.MovePosition(transform.position + (moveDelta * _forwardSpeed * Time.fixedDeltaTime));
    }
}
