using UnityEngine;

public class InteractableObject: MonoBehaviour {

    [SerializeField] private bool _canBeGrabbed;
    [SerializeField] private bool _canBeStored;
    [SerializeField] private Effect[] _effects;
    //[SerializeField] private AudioSource[] _sounds;

    private bool _isBeingThrown;
    private AudioSource source;

    void Start() {
        source = GetComponent<AudioSource>();
    }

    public bool CanBeGrabbed()
    {
        foreach (var effect in _effects)
        {
            continue;
            if (effect.GetEffect().IsCooldown() || effect.GetEffect().IsActive())
            {
                return false;
            }
        }

        return _canBeGrabbed;
    }

    public bool CanBeStored()
    {
        return _canBeStored;
    }

    private void OnCollisionEnter(Collision other)
    {
        var isFloor = other.transform.GetComponent<Floor>() != null;
        if (!isFloor)
        {
            return;
        }

        EndThrow();
    }

    public void StartThrow(Vector3 speed)
    {
        if (_isBeingThrown)
        {
            return;
        }

        _isBeingThrown = true;


        source.Play();

        gameObject.layer = 9;
        GetComponent<Collider>().isTrigger = false;
        gameObject.AddComponent<Rigidbody>().velocity = speed;
    }

    private void EndThrow()
    {
        if (!_isBeingThrown)
        {
            return;
        }
        _isBeingThrown = false;

        gameObject.layer = 0;
        GetComponent<Collider>().isTrigger = true;
        Destroy(GetComponent<Rigidbody>());

        foreach (var effect in _effects)
        {
            effect.GetEffect().Activate();
        }
    }

    public void PickUp()
    {
        foreach (var effect in _effects)
        {
            var instance = effect.GetEffect();
            if (instance.IsCooldown())
            {
                continue;
            }
            instance.Deactivate();
        }
    }
}