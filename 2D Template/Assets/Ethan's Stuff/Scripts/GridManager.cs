using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Grid))]
[RequireComponent(typeof(Tilemap))]
public class GridManager : MonoBehaviour
{
    Tilemap tilemap;
    Grid_Test grid;
    [SerializeField] TileBase tilebase;
    [SerializeField] TileBase tilebase2;
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        grid = GetComponent<Grid_Test>();
        grid.Init(10, 8);
        grid.Set(8, 4, true);
        UpdateTileMap();
    }

    void UpdateTileMap()
    {
        for (int x = 0; x < grid.length; x++)
        {
            for (int y = 0; y < grid.height; y++)
            {
                if(grid.Get(x, y))
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), tilebase);
                }
                else
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), tilebase2);
                }
                
            }
        }
    }
   
}
