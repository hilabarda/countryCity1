using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Renderer : MonoBehaviour
{
    private MeshRenderer myrenderer;
    [SerializeField]
    private Texture texture;

    private void Start()
    {
        myrenderer = GetComponent<MeshRenderer>();
        myrenderer.material.mainTexture = texture;
    }
}
