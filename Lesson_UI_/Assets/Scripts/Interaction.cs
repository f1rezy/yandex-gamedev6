using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interaction : MonoBehaviour
{

    [SerializeField] private Camera _camera;

    void Update()
    {

        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit)) {
            if (hit.collider.TryGetComponent(out Clickable clickable)) {
                if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject()) {
                    clickable.Hit();
                }
            }

            if (hit.collider.TryGetComponent(out Gold gold))
            {
                gold.Collect();
            }
        }

    }
}
