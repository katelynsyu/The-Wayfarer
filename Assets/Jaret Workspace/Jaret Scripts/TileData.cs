using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;





[CreateAssetMenu]
public class TileData : ScriptableObject
{

    public TileBase[] tiles;

    public string name;

    public string direction;
    public int dirInt;


}
