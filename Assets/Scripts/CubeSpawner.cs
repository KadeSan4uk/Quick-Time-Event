using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;           
    public Transform[] spawnPoints;         
    public float spawnInterval;            

    void Start()
    {
        InvokeRepeating("SpawnCube", 0f, spawnInterval);
    }

    public void SpawnCube()
    {
        if (spawnPoints == null || spawnPoints.Length != 3)
        {
            Debug.Log("spawnPoints is not 3 lines.");
            return;
        }

        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];
        
        GameObject cube = Instantiate(cubePrefab, spawnPoint.position, Quaternion.identity);
        
        cube.GetComponent<Cube>().fallSpeed = Random.Range(5f, 15f);

        cube.tag = $"Cube{randomIndex}";
    }
}
