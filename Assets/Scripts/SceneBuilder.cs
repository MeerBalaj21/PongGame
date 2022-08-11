using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBuilder : MonoBehaviour
{
    // Start is called before the first frame update
    private float _width;
    public GameObject WallLeft;
    public GameObject WallRight;
    public GameObject WallTop;
    public GameObject WallBottom;

    void Start()
    {
        WidthCalculator();
        WallPlacer();
        WallScaler();
    }

    private void WidthCalculator()
    {
        _width = Camera.main.aspect * 10;
    }

    private void WallPlacer()
    {
        WallLeft.transform.position = new Vector2(-_width/2, 0);
        WallRight.transform.position = new Vector2(_width/2, 0);
        WallTop.transform.position = new Vector2(0, 5);
        WallBottom.transform.position = new Vector2(0, -5);

    }

    private void WallScaler()
    {
        WallLeft.transform.localScale = new Vector2(0.5f,10);
        WallRight.transform.localScale = new Vector2(0.5f, 10);
        WallTop.transform.localScale = new Vector2(_width, 0.5f);
        WallBottom.transform.localScale = new Vector2(_width,0.5f);
    }

}
