using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxe : MonoBehaviour
{
    MeshRenderer mesh;
    private float animationSpeed = 1f;

    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        mesh.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime,0);
    }
}
