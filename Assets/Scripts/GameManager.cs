using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float bottomLineY = -3.5f; 
    public float[] linePositions; 
    public TextMeshProUGUI accuracyText; 

    public void CheckHit(int lineIndex)
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");

        foreach (GameObject cube in cubes)
        {
            if (IsOnLine(cube, lineIndex))
            {
                float distance = Mathf.Abs(cube.transform.position.y - bottomLineY);

                DisplayAccuracy(distance);

                Destroy(cube);
                break;
            }
        }
    }

    private bool IsOnLine(GameObject cube, int lineIndex)
    {
        return Mathf.Abs(cube.transform.position.x - linePositions[lineIndex]) < 0.1f;
    }

    private void DisplayAccuracy(float distance)
    {
        accuracyText.text = distance.ToString("F2");
    }
}
