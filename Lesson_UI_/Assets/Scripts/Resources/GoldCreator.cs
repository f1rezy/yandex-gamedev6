using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCreator : MonoBehaviour
{


    [SerializeField] private Gold _goldPrefab;
    [SerializeField] private int _numberOfGoldToCreate = 3;
    [SerializeField] private float _speed = 3f;
    [SerializeField] private Resources _resources;

    public void Create()
    {

        for (int i = 0; i < _numberOfGoldToCreate; i++)
        {
            Gold newGold = Instantiate(_goldPrefab, transform.position, Quaternion.identity);

            Vector3 velocity = Vector3.up;
            float xAngle = Random.Range(-45f, 45f);
            float yAngle = Random.Range(0, 360f);

            velocity = Quaternion.Euler(xAngle, 0f, 0f) * velocity;
            velocity = Quaternion.Euler(0f, yAngle, 0f) * velocity;

            newGold.Setup(velocity * _speed, _resources);
        }
    }
}
