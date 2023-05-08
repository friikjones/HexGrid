using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexManagerScript : MonoBehaviour
{
    public int numRows = 5;
    public int numColumns = 5;
    public float radius = 1f;
    public float gap = 0.1f;
    public GameObject hexagonPrefab;

    void Start () {
        float height = radius * 2f;
        float width = Mathf.Sqrt(3f) * radius;
        float vertDist = height * 0.75f;

        for (int i = 0; i < numRows; i++) {
            for (int j = 0; j < numColumns; j++) {
                float x = (j + i % 2 * 0.5f) * (width + gap);
                float y = i * vertDist;
                Vector3 position = new Vector3(x, 0f, y);
                GameObject hexagon = Instantiate(hexagonPrefab, position, hexagonPrefab.transform.rotation, transform);
                hexagon.GetComponent<TileCoordinates>().i=i;
                hexagon.GetComponent<TileCoordinates>().j=j;
            }
        }
    }
}