using UnityEngine;

public class Cube : MonoBehaviour
{
    public float fallSpeed;
    public float destroyY = -10f;
    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        if (transform.position.y < destroyY)
            Destroy(gameObject);
    }
}
