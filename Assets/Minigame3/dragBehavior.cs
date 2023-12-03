using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragBehavior : MonoBehaviour
{
    private Transform dragging = null;
    private Vector3 offset;
    private Collider2D thisCollider;
    [SerializeField] private LayerMask movableLayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
      RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero,
                                           float.PositiveInfinity, movableLayer);
      if (hit) {
        dragging = hit.transform;
        thisCollider = hit.collider;
        offset = dragging.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
      }
    } else if (Input.GetMouseButtonUp(0)) {
      dragging = null;
      thisCollider.enabled = true;
    }

    if (dragging != null) {
      dragging.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
      thisCollider.enabled = false;
    }
    }
}
