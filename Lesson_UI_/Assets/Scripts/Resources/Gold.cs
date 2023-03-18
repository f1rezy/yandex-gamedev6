using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{

    [SerializeField] private Rigidbody _rigidbody;

    private Resources _resources;

    public  void Setup(Vector3 velocity, Resources resources)
    {
        _resources = resources;
        _rigidbody.velocity = velocity;
    }

    public void Collect()
    {
        _resources.CollectCoins(1, transform.position);
        Destroy(gameObject);
    }
}
