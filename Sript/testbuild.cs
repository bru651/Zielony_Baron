using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class testbuild : MonoBehaviour
{
    public Tile house;
    public Vector3Int pos;
    public Tilemap map;
    [ContextMenu("test_b")]
    void test_b(){
        map.SetTile(pos,house);
    }
}
