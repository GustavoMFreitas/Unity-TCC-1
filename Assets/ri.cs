using UnityEngine;

public class ri : MonoBehaviour
{

    public Transform target;
    private Vector3 offset = new Vector3(0, 2, -4);

    void FixedUpdate()
    {
        Vector3 desejo = target.position + offset;
        transform.position = desejo;
        transform.LookAt(target);
    }
}
