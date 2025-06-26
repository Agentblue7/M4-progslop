using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HomingBullet : MonoBehaviour
{
    public Transform target;
    public float speed = 10f;
    public float rotateSpeed = 5f;

    void Update()
    {
        if (target == null) return;

        Vector3 direction = (target.position - transform.position).normalized;
        Vector3 moveDirection = Vector3.Lerp(transform.forward, direction, rotateSpeed * Time.deltaTime);
        transform.rotation = Quaternion.LookRotation(moveDirection);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == target)
        {
            Debug.Log("Target Hit!");
            Destroy(gameObject);
        }
    }
}
