using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridClass : MonoBehaviour {

    [SerializeField]
    private GameObject Tile;
    private Vector3 Center;
    private float Value = 0;

    public GridClass()
    {
        Value = 0f;
    }

    public GridClass(GameObject tile, int value, Vector3 center)
    {
        Tile = tile;
        Value = value;
        Center = center;
    }

    public Vector3 GetLocation() { return Center; }
}
