using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    private Transform m_transform;
    [SerializeField] Transform other;
    private SpriteRenderer m_renderer;


    private void Start()
    {
        m_transform = this.transform;
        m_renderer = this.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        LAMouse();
    }

    private void LAMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - m_transform.position;

        float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;

        Quaternion rotation = Quaternion.AngleAxis(angle , Vector3.forward);
        m_transform.rotation = rotation;

        if (angle < -90 || angle > 90)
        {
            m_transform.localRotation = Quaternion.Euler(180, 0, -angle);
        }
    }
   
}
