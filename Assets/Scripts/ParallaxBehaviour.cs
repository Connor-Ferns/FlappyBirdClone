using UnityEngine;

public class ParallaxBehaviour : MonoBehaviour
{
    public float parallaxSeed = -0.5f;
    private float BgWidth, bgTotalWidth;

    private GameObject bgCloneObj;

    private bool isObjCloned = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        BgWidth = GetComponent<SpriteRenderer>().bounds.size.x;
        bgTotalWidth = BgWidth * 2;

        //Create a Duplicate
        if(isObjCloned == false){
            float bgClonePositionX = transform.position.x + BgWidth;
            Vector3 bgClonePosition = transform.position + new Vector3(bgClonePositionX, 0f, 0f);
            //Create Object
            bgCloneObj = Instantiate(gameObject, bgClonePosition, transform.rotation);

            bgCloneObj.transform.SetParent(transform.parent);

            bgCloneObj.transform.localScale =  transform.localScale;

            isObjCloned = true;
            Destroy(bgCloneObj.GetComponent<ParallaxBehaviour>());
        }
    }

    // Update is called once per frame
    void Update(){
        float newPositionX = Time.deltaTime * parallaxSeed;
        transform.position = transform.position + new Vector3(newPositionX, 0f, 0f);

        bgCloneObj.transform.position = bgCloneObj.transform.position + new Vector3(newPositionX, 0f, 0f);

        if(gameObject.transform.position.x < -bgTotalWidth/2){
            ResetPosition(gameObject);
        }
        if(bgCloneObj.transform.position.x < -bgTotalWidth/2){
            ResetPosition(bgCloneObj);
        }
    }

    void ResetPosition(GameObject obj){
        float resetPositionX = obj.transform.position.x + bgTotalWidth;
        obj.transform.position = new Vector3(resetPositionX, obj.transform.position.y, 0f);
    }
}
