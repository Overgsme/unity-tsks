using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEngine;
using static UnityEditor.Progress;

public class Sorter : MonoBehaviour
{
    public GameObject baseObject;
    Sort.BubbleSortLtR<int> sort;
    List<GameObject> gameObjects;
    public float sizeX;
    public float sizeY;
    private List<Vector3> vertices;
    private List<int> triangles;
    Mesh chunkMesh;

    // Start is called before the first frame update
    void Start()
    {
        sort = new Sort.BubbleSortLtR<int>(50, () => Random.Range(0, 100));
        gameObjects = new List<GameObject>();

        chunkMesh = new Mesh();
        chunkMesh.indexFormat = UnityEngine.Rendering.IndexFormat.UInt32;

        vertices = new List<Vector3>();
        triangles = new List<int>();

        foreach (var item in sort.sortArray.Select((v, i) => new {i, v}))
        {
            RenderNumber(item.v, this.transform.position + new Vector3(item.i * sizeX, 0));
        }

        chunkMesh.vertices = vertices.ToArray();
        chunkMesh.triangles = triangles.ToArray();

        chunkMesh.Optimize();

        GetComponent<MeshFilter>().mesh = chunkMesh;
    }
    public static List<T> Swap<T>(List<T> list, int indexA, int indexB)
    {
        T tmp = list[indexA];
        list[indexA] = list[indexB];
        list[indexB] = tmp;
        return list;
    }
    // Update is called once per frame
    void Update()
    {
        int i = sort.SortTurn();
        if (i != 0)
        {
            vertices.Clear();
            triangles.Clear();
            foreach (var item in sort.sortArray.Select((v, i) => new { i, v }))
            {
                RenderNumber(item.v, new Vector3(item.i * sizeX, 0));
            }


            chunkMesh.vertices = vertices.ToArray();
            chunkMesh.triangles = triangles.ToArray();
            chunkMesh.Optimize();

            GetComponent<MeshFilter>().mesh = chunkMesh;
        }
    }
    void RenderNumber(int s,Vector3 position)
    {
        int vBase = vertices.Count;

        triangles.Add(vBase);
        triangles.Add(vBase+1);
        triangles.Add(vBase+2);

        triangles.Add(vBase);
        triangles.Add(vBase+2);
        triangles.Add(vBase+3);

        vertices.Add(position);
        vertices.Add(position+new Vector3(0,s*sizeY));
        vertices.Add(position+new Vector3(sizeX, s * sizeY));
        vertices.Add(position+new Vector3(sizeX, 0));

    }
}
