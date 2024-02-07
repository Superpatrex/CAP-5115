using UnityEngine;

public class CreateTexturedTriangle : MonoBehaviour
{
    public Texture2D texture; // Drag your PNG texture here in the Unity Editor

    void Start()
    {
        Mesh mesh = new Mesh();
        mesh.vertices = new Vector3[] {
            new Vector3(-0.5f, 0, 0),
            new Vector3(0.5f, 0, 0),
            new Vector3(0, 1, 0),
            new Vector3(-0.5f, 0, 1), // Extruded vertex
            new Vector3(0.5f, 0, 1)   // Extruded vertex
        };
        mesh.triangles = new int[] { 0, 1, 2, 2, 1, 3, 1, 4, 3 }; // Two triangles to form a triangle with width

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();

        Vector2[] uv = new Vector2[]
        {
            new Vector2(0, 0),
            new Vector2(1, 0),
            new Vector2(0.5f, 1),
            new Vector2(0, 0),
            new Vector2(1, 0)
        };
        mesh.uv = uv;

        MeshFilter meshFilter = GetComponent<MeshFilter>();
        if (meshFilter == null)
        {
            meshFilter = gameObject.AddComponent<MeshFilter>();
        }

        meshFilter.mesh = mesh;

        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer == null)
        {
            meshRenderer = gameObject.AddComponent<MeshRenderer>();
        }

        if (texture != null)
        {
            meshRenderer.material.mainTexture = texture;
        }
        else
        {
            Debug.LogError("Texture not assigned.");
        }

        Debug.Log("Mesh created with " + mesh.vertices.Length + " vertices and " + mesh.triangles.Length / 3 + " triangles.");
    }
}
