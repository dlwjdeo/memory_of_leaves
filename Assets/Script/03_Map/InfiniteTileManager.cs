
using UnityEngine;

public class InfiniteTileManager : MonoBehaviour
{
    public Transform player;
    public GameObject tilePrefab;
    public int tileSize = 10;

    private GameObject[,] tiles = new GameObject[3, 3];
    private Vector2Int currentCenter = Vector2Int.zero;

    void Start()
    {
        for (int x = -1; x <= 1; x++)
        {
            for (int y = -1; y <= 1; y++)
            {
                Vector2 pos = new Vector2(x * tileSize, y * tileSize);
                GameObject tile = Instantiate(tilePrefab, pos, Quaternion.identity, transform);
                tiles[x + 1, y + 1] = tile;
            }
        }
    }

    void Update()
    {
        Vector2Int playerTileCoord = new Vector2Int(
            Mathf.FloorToInt(player.position.x / tileSize),
            Mathf.FloorToInt(player.position.y / tileSize)
        );

        if (playerTileCoord != currentCenter)
        {
            RecenterTiles(playerTileCoord);
        }
    }

    void RecenterTiles(Vector2Int newCenter)
    {
        currentCenter = newCenter;

        for (int x = -1; x <= 1; x++)
        {
            for (int y = -1; y <= 1; y++)
            {
                Vector2Int tileCoord = newCenter + new Vector2Int(x, y);
                Vector2 newPos = new Vector2(tileCoord.x * tileSize, tileCoord.y * tileSize);
                tiles[x + 1, y + 1].transform.position = newPos;
            }
        }
    }
}
