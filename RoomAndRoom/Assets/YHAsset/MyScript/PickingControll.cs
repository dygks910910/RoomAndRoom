using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingControll : MonoBehaviour {
    private static GameObject player;
    private static Camera cam;
    private static GameObject dynamicObjects;
    private BoxCollider colider;
    private Rigidbody rigidBody;
    [Tooltip("게임 매니저 객체")]
    private static GameObject gameManager;
    private static GameManagement gameManagementScript;
    public bool isPicked;
	// Use this for initialization
	void Start () {
        //cam = GameObject.FindObjectOfType<Camera>();
        colider = GetComponent<BoxCollider>();
        rigidBody = GetComponent<Rigidbody>();
        if(player == null)
            player = GameObject.Find("Main Camera");
        if(cam == null)
            cam = player.GetComponent<Camera>();
        if(dynamicObjects == null)
        {
            dynamicObjects =  GameObject.Find("DynamicObjects");
        }
        if(gameManager == null)
        {
            gameManager = GameObject.Find("GameManager");
        }
        if(gameManagementScript == null)
        {
            gameManagementScript = gameManager.GetComponent<GameManagement>();
        }
    }
    public void BindingCamera()
    {
        if (gameManagementScript.isPicked == false)
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
            rigidBody.isKinematic = true;
            colider.enabled = false;
            isPicked = true;

            GetComponent<scaleToIcon>().ScaleToIcon();
            //피키드 오브젝트에 자기자신을 묶어줌.
            gameManagementScript.pickedObj = transform.gameObject;
            gameManagementScript.isPicked = true;
        }
    }
    public void UnbindingCamera()
    {
        if (gameManagementScript.isPicked)
        {
            this.transform.parent = dynamicObjects.transform;
            MeshRenderer meshRenderer = this.GetComponent<MeshRenderer>();
            Material material = meshRenderer.material;
            //this.transform.parent = cam.transform;
            //카메라앞으로 이동.
            //transform.localPosition = new Vector3(0, 0, 1.5f);
            material.SetFloat("_Mode", 4f);
            //0f - opacity
            //1f - cutout
            //2f - fade
            //3f - transparent
            material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
            //블랭드 함.
            // material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
            //블렌드 안함.
            material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.Zero);
            material.DisableKeyword("_ALPHATEST_ON");
            material.EnableKeyword("_ALPHABLEND_ON");
            material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
            material.renderQueue = 3000;
            Color32 col = meshRenderer.material.GetColor("_Color");
            col.a = 255;
            meshRenderer.material.SetColor("_Color", col);
            GetComponent<scaleToIcon>().ScaleToOrigin();
            colider.enabled = true;
            isPicked = false;
            rigidBody.isKinematic = false;
            gameManagementScript.isPicked = false;
        }
    }
    public void InteractionObjSendingToGameMgr()
    {
        gameManagementScript.interactionObj = this.gameObject;
        gameManagementScript.CheckInteraction();
    }

}
