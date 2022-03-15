using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    public LayerMask mask;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo; 
        
        if (Physics.Raycast(ray, out hitInfo, 100, mask, QueryTriggerInteraction.Ignore))
        {
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
            // Esse método desenha uma linha de debug entre o ponto de origem e ponto final do ray.
            // Quando o ray colide com um objeto, a linha fica vermelha.
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 100, Color.green);
            // Enquanto o ray não colide com um objeto, a linha é verde.
            // Ela se estende até 100 unidades além do ponto de origem.
        }

    }

}
