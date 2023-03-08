using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsManager : MonoBehaviour
{
    public static PropsManager instance;
    public Material Walls;
    public Material Ceiling;
    public Color[] colorWall;
    public GameObject Lights;
    public void Start()
    {
        instance = this;
        LoadDefaultColor();
    }
    public void ChangeWallColor()
    {
        Walls.color = colorWall[Random.Range(0,colorWall.Length)];
    }
    public void ChangeCeilingColor()
    {
        Ceiling.color = colorWall[Random.Range(0, colorWall.Length)];
    }
    public void TurnLight()
    {
        if (Lights.activeSelf)
        {
            Lights.gameObject.SetActive(false);
        }else
            Lights.gameObject.SetActive(true);
    }
    private void LoadDefaultColor()
    {
        Walls.color = colorWall[4];
        Ceiling.color = colorWall[4];
    }
}
