
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private GameObject CellPrefab;
    [SerializeField]
    private GameObject GridParentPrefab;

    public List<GridClass> Grid = new List<GridClass>();
    private int TileCount = 0;

    private void Start()
    {
        SpawnGrid();
        BeginGame();

    }

    private void Update()
    {
        ProcessInput(GetInputDirection());
        
        
    }

    // Spawns grid column-wise
    public void SpawnGrid()
    {
        // Delete all cells before spawning grid
        foreach (GameObject cell in GameObject.FindGameObjectsWithTag("Grid Cell"))
        {
            Destroy(cell);
        }

        // Find / Generate Parent grid object for cells
        GameObject GridParent = GameObject.FindGameObjectWithTag("Grid Parent");
        if (!GridParent)
        {
            GridParent = Instantiate(GridParentPrefab, Vector3.zero, Quaternion.identity);
        }

        // Column 1
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(-1.50f, +1.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(-1.50f, +1.50f)));
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(-1.50f, +0.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(-1.50f, +0.50f)));
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(-1.50f, -0.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(-1.50f, -0.50f)));
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(-1.50f, -1.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(-1.50f, -1.50f)));

        // Column 2
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(-0.50f, +1.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(-0.50f, +1.50f)));
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(-0.50f, +0.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(-0.50f, +0.50f)));
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(-0.50f, -0.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(-0.50f, -0.50f)));
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(-0.50f, -1.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(-0.50f, -1.50f)));

        // Column 3
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(+0.50f, +1.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(+0.50f, +1.50f)));
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(+0.50f, +0.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(+0.50f, +0.50f)));
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(+0.50f, -0.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(+0.50f, -0.50f)));
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(+0.50f, -1.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(+0.50f, -1.50f)));

        // Column 4
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(+1.50f, +1.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(+1.50f, +1.50f)));
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(+1.50f, +0.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(+1.50f, +0.50f)));
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(+1.50f, -0.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(+1.50f, -0.50f)));
        Grid.Add(new GridClass(Instantiate(CellPrefab, new Vector3(+1.50f, -1.50f), Quaternion.identity, GridParent.transform), 0, new Vector3(+1.50f, -1.50f)));
    }

    // Spawn two tiles at random
    public void BeginGame()
    {
        // Clear all tiles
        // Add two tiles
    }

    // Adds a tile
    public void AddTile()
    {

        TileCount++;
        if (IsBoardFull())
            Debug.Log("Game over!");
    }

    // Returns direction of swipe gesture
    public Vector3 GetInputDirection()
    {
        return Vector3.zero;
    }

    // Runs loop to process every tile
    public void ProcessInput(Vector3 Input)
    {

        // Add tile at the end of processing
        AddTile();
    }

    // Combines two like tiles
    public void Combine(int FromIndex, int ToIndex)
    {
        if (FromIndex == ToIndex)
            return;
        TileCount--;
        if (Is2048())
            Debug.Log("Congratulations!");
    }

    // Check win condition 2048 tile
    public bool Is2048()
    {
        bool bIs2048 = false;

        return bIs2048;
    }

    public bool IsBoardFull()
    {
        if (TileCount >= 16)
            return true;
        return false;
    }
}

