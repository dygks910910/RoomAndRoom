using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingControll : MonoBehaviour {
    private GameObject player;
    private Camera cam;
    private BoxCollider colider;
    private bool isPicked;
	// Use this for initialization
	void Start () {
        //cam = GameObject.FindObjectOfType<Camera>();
        colider = GetComponent<BoxCollider>();
        player = GameObject.Find("Main Camera");
        cam = player.GetComponent<Camera>();
    }
    public void BindingCamera()
    {
         MeshRenderer meshRenderer = this.GetComponent<MeshRenderer>();
        Material material = meshRenderer.material;
        this.transform.parent = cam.transform;
        //카메라앞으로 이동.
        transform.localPosition = new Vector3(0, 0, 1.5f);

       
        material.SetFloat("_Mode", 4f);

        //0f - opacity
        //1f - cutout
        //2f - fade
        //3f - transparent
        material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        //블랭드 함.
        material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        //블렌드 안함.
        //material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.Zero);

        material.DisableKeyword("_ALPHATEST_ON");
        material.EnableKeyword("_ALPHABLEND_ON");
        material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        material.renderQueue = 3000;

        Color32 col = meshRenderer.material.GetColor("_Color");
        col.a = 255;
        meshRenderer.material.SetColor("_Color", col);

        colider.enabled = false;
        isPicked = true;
    }

    public void UnbindingCamera()
    {
        this.transform.parent = null;
    }
    // Update is called once per frame
    void Update () {

    }
}
