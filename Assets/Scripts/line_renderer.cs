using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line_renderer : MonoBehaviour
{

    private LineRenderer line;
    private bool isMousePressed;
    public List<Vector3> pointsList;
    public List<Vector2> pointsList2;
    private Vector3 mousePos;
    public GameObject Parent;
    private LineRenderer Body;
    public GameObject ParentBody;
    
    // Structure for line points
    struct myLine
    {
        public Vector3 StartPoint;
        public Vector3 EndPoint;
    };
    //    -----------------------------------    
    void Awake()
    {
        // Create line renderer component and set its property
        line = gameObject.AddComponent<LineRenderer>();
       // line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetVertexCount(0);
        line.SetWidth(0.1f, 0.1f);
        line.SetColors(Color.green, Color.green);
        line.useWorldSpace = true;
        isMousePressed = false;
        pointsList = new List<Vector3>(); 
        //       renderer.material.SetTextureOffset(
    }
    //    -----------------------------------    
    void Update()
    {
        // If mouse button down, remove old line and set its color to green
        if (Input.GetMouseButtonDown(0))
        {
            isMousePressed = true;
            line.SetVertexCount(0);
            pointsList.RemoveRange(0, pointsList.Count);
            line.SetColors(Color.green, Color.green);

        }
       

        if (Input.GetMouseButtonUp(0))
        {
             LineRenderer lineRenderer = line;//.GetComponent<LineRenderer>();
              MeshCollider meshCollider = Parent.GetComponent<MeshCollider>();

              Mesh mesh = new Mesh();
              line.BakeMesh(mesh, true);
              meshCollider.sharedMesh = mesh;

            /* PolygonCollider2D polygonCollider2D = Parent.GetComponent<PolygonCollider2D>();
             pointsList2[pointsList2.Count-1] = pointsList2[0];
             polygonCollider2D.SetPath(0, pointsList2);  */

           /* Body = ParentBody.AddComponent<LineRenderer>();
            LineRenderer lineRenderer = Body;
            MeshCollider meshCollider = ParentBody.GetComponent<MeshCollider>();
            Mesh mesh = new Mesh();
            lineRenderer.BakeMesh(mesh,true);
            meshCollider.sharedMesh = mesh;
           */
            isMousePressed = false;  
            
        }
        // Drawing line when mouse is moving(presses)
        if (isMousePressed)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            if (!pointsList.Contains(mousePos))
            {
                pointsList.Add(mousePos);
                pointsList2.Add(mousePos);
                line.SetVertexCount(pointsList.Count);
                line.SetPosition(pointsList.Count - 1, (Vector3)pointsList[pointsList.Count - 1]);
           
            }
        }
    }

    //    -----------------------------------    
    //  Following method checks is currentLine(line drawn by last two points) collided with line 
    //    -----------------------------------    

    //    -----------------------------------    
    //    Following method checks whether given two points are same or not
    //    -----------------------------------    
    private bool checkPoints(Vector3 pointA, Vector3 pointB)
    {
        return (pointA.x == pointB.x && pointA.y == pointB.y);
    }
    //    -----------------------------------    
    //    Following method checks whether given two line intersect or not
    //    -----------------------------------    
    private bool isLinesIntersect(myLine L1, myLine L2)
    {
        if (checkPoints(L1.StartPoint, L2.StartPoint) ||
            checkPoints(L1.StartPoint, L2.EndPoint) ||
            checkPoints(L1.EndPoint, L2.StartPoint) ||
            checkPoints(L1.EndPoint, L2.EndPoint))
            return false;

        return ((Mathf.Max(L1.StartPoint.x, L1.EndPoint.x) >= Mathf.Min(L2.StartPoint.x, L2.EndPoint.x)) &&
            (Mathf.Max(L2.StartPoint.x, L2.EndPoint.x) >= Mathf.Min(L1.StartPoint.x, L1.EndPoint.x)) &&
            (Mathf.Max(L1.StartPoint.y, L1.EndPoint.y) >= Mathf.Min(L2.StartPoint.y, L2.EndPoint.y)) &&
            (Mathf.Max(L2.StartPoint.y, L2.EndPoint.y) >= Mathf.Min(L1.StartPoint.y, L1.EndPoint.y))
               );
    }
}
