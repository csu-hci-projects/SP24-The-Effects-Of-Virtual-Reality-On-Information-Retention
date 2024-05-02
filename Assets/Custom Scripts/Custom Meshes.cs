using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMeshes : MonoBehaviour
{
    [SerializeField] Material material;
    private Vector3[] vertices = new Vector3[4];
    private Vector2[] uv = new Vector2[4];
    private int[] triangles = new int[6];
    private GameObject meshObject;
    private Mesh mesh;
    // Start is called before the first frame update
    void Start()
    {
        GenerateMeshData();

        mesh = new Mesh();
        mesh.name = "Custom Mesh";

        meshObject = new GameObject("Mesh object", typeof(MeshRenderer), typeof(MeshFilter));
        meshObject.GetComponent<MeshRenderer>().material = material;
        meshObject.GetComponent<MeshFilter>().mesh = mesh;

        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;
    }

    private void GenerateMeshData()
    {
        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 1, 0);
        vertices[2] = new Vector3(1, 1, 0);
        vertices[3] = new Vector3(1, 0, 0);

        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;

        triangles[3] = 0;
        triangles[4] = 2;
        triangles[5] = 3;

        uv[0] = new Vector2(0,0);
        uv[1] = new Vector2(0,1);
        uv[2] = new Vector2(1,1);
        uv[3] = new Vector2(1,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
