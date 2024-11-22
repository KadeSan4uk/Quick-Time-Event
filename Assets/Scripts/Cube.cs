using UnityEngine;

public class Cube : MonoBehaviour
{
    public float fallSpeed;

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }
}
