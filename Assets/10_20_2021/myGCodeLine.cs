using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Art;

public class myGCodeLine : ArtMakerGCode
{
    // [Header("Control the sine wave")]
    // public float position_x = 150f;
    // public float position_y = 130f;

    public Vector2 minFrequency;
    public Vector2 maxFrequency;
    // public Vector2 frequency;
    public Vector2 offset;
    public Vector2 amplitude;
    public Vector2 noffset;
    public Vector2 namplitude;
    public float counterOffset = .01f;

    Vector3[] points;
    float counter;

    // [Space]
    // [Header("Line details")]
    // public LineRenderer lineRenderer;
    public int amountOfPoints = 100;
    public float lineWidth;

    // [Space]
    // [Header("GCode output")]

    public bool writeGCode;

    public Vector3 minInputSize;
    public Vector3 maxInputSize;

    public Vector3 minOutputSize;
    public Vector3 maxOutputSize;

    void Update()
    {
        if (rebuild)
        {
            DrawLine();
        }
    }

    public override void MakeArt()
    {
        DrawLine();
        if (writeGCode)
        {
            WriteGCode.Write(points,minInputSize,maxInputSize,minOutputSize,maxOutputSize);
            writeGCode = false;
        }
    }

    void DrawLine()
    {
        //Instead of time we're making our own counter for mathf.sin
        counter = 0;

        //initialize an array of points, this will recreate the array every time
        points = new Vector3[amountOfPoints];

        //create a new gameobject and assign a linerenderer, 
        //we could also make a public gameobject variable that has a linerenderer attached, 
        //but this allows us to keep everything in code
        GameObject line = new GameObject("Line");
        AddToRoot(line.transform);
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.widthMultiplier = lineWidth;
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = Color.black;

        //I want the frequency to be the same throughout so set the random values outside the loop
        //see what happens when you put this randomization inside the loop
        
        int seed = Random.Range(0, 999);
        Random.seed = seed;
        
        Vector2 frequency = new Vector2(Random.Range(minFrequency.x, maxFrequency.x),
        Random.Range(minFrequency.y, maxFrequency.y));

        // for (int i = 0; i < amountOfPoints; i++)
        // {
        //     //offset the counter then generate the lissajous
        //     counter += counterOffset;
        //     float x = Mathf.Sin(frequency.x * counter + offset.x) * amplitude.x;
        //     float y = Mathf.Sin(frequency.y * counter + offset.y) * amplitude.y;

        //     x = WriteGCode.map(x, minInputSize.x, maxInputSize.x, minOutputSize.x, maxOutputSize.x);
        //     y = WriteGCode.map(y, minInputSize.y, maxInputSize.y, minOutputSize.y, maxOutputSize.y);

        //     //create a point variable with those values
        //     Vector3 point = new Vector3(x, y, 0);
        //     //assign that variable to the array
        //     points[i] = point;
        // }

        
        // for (int i = 0; i < amountOfPoints; i++)
        // {
        //     //offset the counter then generate the lissajous
        //     counter += counterOffset;
        //     float x = Mathf.Sin(frequency.x * counter + offset.x) * amplitude.x * Mathf.Cos(frequency.y * Mathf.Pow(Mathf.PI,frequency.x));
        //     float y = Mathf.Sin(frequency.y * counter + offset.y) * amplitude.y * Mathf.Cos(frequency.x * Mathf.Pow(Mathf.PI,frequency.y));

        //     float combined = Mathf.Sin(x*y);

        //     float nx = Mathf.PerlinNoise(frequency.x * counter + noffset.x * namplitude.x, Mathf.Cos(frequency.y * Mathf.PI));
        //     float ny = Mathf.PerlinNoise(frequency.y * counter + noffset.y * namplitude.y, Mathf.Cos(frequency.x * Mathf.PI));
            
        //     x = WriteGCode.map(x, minInputSize.x, maxInputSize.x, minOutputSize.x, maxOutputSize.x);
        //     y = WriteGCode.map(y, minInputSize.y, maxInputSize.y, minOutputSize.y, maxOutputSize.y);

        //     //create a point variable with those values
        //     Vector3 point = new Vector3(combined, ((float)i / (float)amountOfPoints)*(x + y), 0);

        //     //assign that variable to the array
        //     points[i] = point;
        // }

        for (int i = 0; i < amountOfPoints; i++)
        {
            //offset the counter then generate the lissajous
            counter += counterOffset;
            float x = Mathf.Sin(frequency.x * counter + offset.x) * amplitude.x * Mathf.Cos(frequency.y);
            float y = Mathf.Sin(frequency.y * counter + offset.y) * amplitude.y * Mathf.Cos(frequency.x);

            float nx = Mathf.PerlinNoise(frequency.x * counter + noffset.x * namplitude.x, Mathf.Cos(frequency.y * Mathf.PI));
            float ny = Mathf.PerlinNoise(frequency.y * counter + noffset.y * namplitude.y, Mathf.Cos(frequency.x * Mathf.PI));
            
            x = WriteGCode.map(x, minInputSize.x, maxInputSize.x, minOutputSize.x, maxOutputSize.x);
            y = WriteGCode.map(y, minInputSize.y, maxInputSize.y, minOutputSize.y, maxOutputSize.y);

            //create a point variable with those values
            Vector3 point = new Vector3((x+y), ((float)i / (float)amountOfPoints)*(x + y), 0);

            //assign that variable to the array
            points[i] = point;
        }

        //use that array to set the points of the linerenderer
        lineRenderer.positionCount = points.Length;
        lineRenderer.SetPositions(points);
        // lineRenderer.transform.position = new Vector3(position_x, position_y, 0);
    }
}