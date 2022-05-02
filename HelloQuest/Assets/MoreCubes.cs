using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreCubes : MonoBehaviour
{
    public GameObject m_cubesPrefab;
    public GameObject m_parentCube;

    public void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Cube();
        }
    }

    public void Cube()
    {
        GameObject cube = Instantiate(m_cubesPrefab);
        cube.transform.SetParent(m_parentCube.transform);
        cube.transform.position = new Vector3(m_parentCube.transform.position.x, m_parentCube.transform.position.y, m_parentCube.transform.position.z);
    }
}
