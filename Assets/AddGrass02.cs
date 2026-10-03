using UnityEngine;

public class AddGrass02 : MonoBehaviour
{
    public Terrain terrain;
    public int detailIndex = 0;

    void Start()
    {
        TerrainData data = terrain.terrainData;

        int width = data.detailWidth;
        int height = data.detailHeight;

        int[,] grass = new int[width, height];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                grass[y, x] = Random.Range(5, 15);
            }
        }

        data.SetDetailLayer(0, 0, detailIndex, grass);
    }
}