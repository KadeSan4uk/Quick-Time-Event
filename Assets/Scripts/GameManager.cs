using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float bottomLineY = -3.5f;
    public float[] linePositions = { -3.5f, 0f, 3.5f };
    public TextMeshProUGUI accuracyText;

    public void CheckHit(int lineIndex)
    {
        Debug.Log($"CheckHit {lineIndex}");

        GameObject[] cubes = GameObject.FindGameObjectsWithTag($"Cube{lineIndex}");

        foreach (GameObject cube in cubes)
        {
            if (IsOnLine(cube, lineIndex))
            {
                float distance = Mathf.Abs(cube.transform.position.y - bottomLineY);

                DisplayAccuracy(distance);

                Destroy(cube);

                Debug.Log($"Cube destroyed on line {lineIndex}");
                return;
            }
        }

        Debug.Log($"No cube found on line {lineIndex}");
    }

    private bool IsOnLine(GameObject cube, int lineIndex)
    {
        float tolerance = 4f;

        return Mathf.Abs(cube.transform.position.x - linePositions[lineIndex]) <= tolerance;
    }

    private void DisplayAccuracy(float distance)
    {
        accuracyText.text = "Precision: " + distance.ToString("F2");
    }
}
