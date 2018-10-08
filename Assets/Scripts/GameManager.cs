using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// struct

public class GameManager : MonoBehaviour {

    [SerializeField]
    private GameObject CellPrefab;
    [SerializeField]
    private GameObject GridParentPrefab;

    public List<GameObject> Grid;

    private void Start()
    {
        SpawnGrid();
    }

    // Spawns grid column-wise
    public void SpawnGrid()
    {
        // Delete all cells before spawning grid
        foreach (GameObject cell in GameObject.FindGameObjectsWithTag("Grid Cell"))
        {
            Destroy(cell);
        }

        GameObject GridParent = GameObject.FindGameObjectWithTag("Grid Parent");
        if (!GridParent)
        {
            GridParent = Instantiate(GridParentPrefab, Vector3.zero, Quaternion.identity);
        }

        // Column 1
        Grid.Add(Instantiate(CellPrefab, new Vector3(-1.50f, +1.50f), Quaternion.identity, GridParent.transform));
        Grid.Add(Instantiate(CellPrefab, new Vector3(-1.50f, +0.50f), Quaternion.identity, GridParent.transform));
        Grid.Add(Instantiate(CellPrefab, new Vector3(-1.50f, -0.50f), Quaternion.identity, GridParent.transform));
        Grid.Add(Instantiate(CellPrefab, new Vector3(-1.50f, -1.50f), Quaternion.identity, GridParent.transform));

        // Column 2
        Grid.Add(Instantiate(CellPrefab, new Vector3(-0.50f, +1.50f), Quaternion.identity, GridParent.transform));
        Grid.Add(Instantiate(CellPrefab, new Vector3(-0.50f, +0.50f), Quaternion.identity, GridParent.transform));
        Grid.Add(Instantiate(CellPrefab, new Vector3(-0.50f, -0.50f), Quaternion.identity, GridParent.transform));
        Grid.Add(Instantiate(CellPrefab, new Vector3(-0.50f, -1.50f), Quaternion.identity, GridParent.transform));

        // Column 3
        Grid.Add(Instantiate(CellPrefab, new Vector3(+0.50f, +1.50f), Quaternion.identity, GridParent.transform));
        Grid.Add(Instantiate(CellPrefab, new Vector3(+0.50f, +0.50f), Quaternion.identity, GridParent.transform));
        Grid.Add(Instantiate(CellPrefab, new Vector3(+0.50f, -0.50f), Quaternion.identity, GridParent.transform));
        Grid.Add(Instantiate(CellPrefab, new Vector3(+0.50f, -1.50f), Quaternion.identity, GridParent.transform));

        // Column 4
        Grid.Add(Instantiate(CellPrefab, new Vector3(+1.50f, +1.50f), Quaternion.identity, GridParent.transform));
        Grid.Add(Instantiate(CellPrefab, new Vector3(+1.50f, +0.50f), Quaternion.identity, GridParent.transform));
        Grid.Add(Instantiate(CellPrefab, new Vector3(+1.50f, -0.50f), Quaternion.identity, GridParent.transform));
        Grid.Add(Instantiate(CellPrefab, new Vector3(+1.50f, -1.50f), Quaternion.identity, GridParent.transform));
    }

    
}
