// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using System.Linq;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class GenerateCube : MonoBehaviour
{
    [SerializeField]
    private Shader changeShaderTo;

/*
private void Update(){
    var material = GetComponent<Renderer>().material;
   
   //set color to new value every frame
   //material



}*/


    //public Shader changeShaderTo;
    private void Start()
    {
        // Generate the mesh and assign to the mesh filter.
        GetComponent<MeshFilter>().mesh = CreateMesh();
        
        // Get the material used by this game object's 'Renderer'.
        var material = GetComponent<Renderer>().material;

        // Recall how we set the material's "color" in the first workshop:
        // e.g. material.color = ...;
        // Turns out we can also set the material's shader in a similar way:
        material.shader = this.changeShaderTo;
        //material.color;
    }

    private Mesh CreateMesh()
    {
        // You might need to re-visit workshop 2 for a recap on mesh structures!
        // The cube definitions here are the same except for the addition of UV
        // coordinates, which are one of the topics explored in this workshop.
        var mesh = new Mesh
        {
            name = "Cube"
        };

        // Define the vertex positions (same as workshop 2).
        mesh.SetVertices(new[]
        {
            // Top face
            new Vector3(-1.0f, 1.0f, -1.0f),
            new Vector3(-1.0f, 1.0f, 1.0f),
            new Vector3(1.0f, 1.0f, 1.0f),

            new Vector3(-1.0f, 1.0f, -1.0f),
            new Vector3(1.0f, 1.0f, 1.0f),
            new Vector3(1.0f, 1.0f, -1.0f),

            // Bottom face
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),

            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),

            // Left face
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),
            new Vector3(-1.0f, 1.0f, 1.0f),

            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(-1.0f, 1.0f, 1.0f),
            new Vector3(-1.0f, 1.0f, -1.0f),

            // Right face
            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, 1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),

            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(1.0f, 1.0f, -1.0f),
            new Vector3(1.0f, 1.0f, 1.0f),

            // Front face
            new Vector3(-1.0f, 1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(1.0f, 1.0f, 1.0f),

            new Vector3(-1.0f, 1.0f, 1.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),

            // Back face
            new Vector3(-1.0f, 1.0f, -1.0f),
            new Vector3(1.0f, 1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, -1.0f),

            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(-1.0f, 1.0f, -1.0f),
            new Vector3(1.0f, -1.0f, -1.0f)
        });

        // Define the vertex colours (same as workshop 2).
        mesh.SetColors(new[]
        {
            // Top face
            Color.red,
            Color.red,
            Color.red,

            Color.red,
            Color.red,
            Color.red,

            // Bottom face
            Color.red,
            Color.red,
            Color.red,

            Color.red,
            Color.red,
            Color.red,

            // Left face
            Color.yellow,
            Color.yellow,
            Color.yellow,

            Color.yellow,
            Color.yellow,
            Color.yellow,

            // Right face
            Color.yellow,
            Color.yellow,
            Color.yellow,

            Color.yellow,
            Color.yellow,
            Color.yellow,

            // Front face
            Color.blue,
            Color.blue,
            Color.blue,

            Color.blue,
            Color.blue,
            Color.blue,

            // Back face
            Color.blue,
            Color.blue,
            Color.blue,

            Color.blue,
            Color.blue,
            Color.blue
        });

        // Define the UV coordinates (NEW in this workshop!)
        mesh.SetUVs(0, new[]
        {
            // Top face
            new Vector2(0.0f, 0.666f),
            new Vector2(0.0f, 1.0f),
            new Vector2(0.333f, 1.0f),
            new Vector2(0.0f, 0.666f),
            new Vector2(0.333f, 1.0f),
            new Vector2(0.333f, 0.666f),

            // Bottom face
            new Vector2(0.333f, 0.333f),
            new Vector2(0.666f, 0.0f),
            new Vector2(0.333f, 0.0f),

            new Vector2(0.333f, 0.333f),
            new Vector2(0.666f, 0.333f),
            new Vector2(0.666f, 0.0f),

            // Left face
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 0.0f),

            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 0.0f),

            // Right face
            new Vector2(0.0f, 0.333f),
            new Vector2(0.333f, 0.666f),
            new Vector2(0.333f, 0.333f),

            new Vector2(0.0f, 0.666f),
            new Vector2(0.0f, 0.333f),
            new Vector2(0.333f, 0.666f),

            // Front face
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 0.0f),

            new Vector2(0.666f, 0.666f),
            new Vector2(0.666f, 0.333f),
            new Vector2(0.333f, 0.333f),

            // Back face
            new Vector2(0.0f, 0.333f),
            new Vector2(0.333f, 0.333f),
            new Vector2(0.333f, 0.0f),

            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 0.333f),
            new Vector2(0.333f, 0.0f)
        });

        // Define the indices (same as workshop 2).
        var indices = Enumerable.Range(0, mesh.vertices.Length).ToArray();
        mesh.SetIndices(indices, MeshTopology.Triangles, 0);

        return mesh;
    }
}
