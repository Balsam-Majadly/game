using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public static NewBehaviourScript instance;
    public float forwardSpeed = 25f, strafeSpeed = 7.5f, hoverSpeed = 5f;
    private float activeForwardSpeed, activeStrafeSpeed, activeHoverSpeed;
    private float forwardAcceleration = 2.5f, starfeAcceleration = 2f, hoverAcceleration = 2f;
    public float lookRateSpeed = 90f;
    private Vector2 lookInput, screenCenter, mouseDistance;
    Vector3 tempScale;

    private float rollInput;
    public float rollSpeed = 90f, rollAccelaration = 3.5f;
    private int  Score=0;
    public int playerValue=1;
    private bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        Debug.Log("start");
        screenCenter.x = Screen.width * .5f;
        screenCenter.y = Screen.height * .5f;

    }

    // Update is called once per frame
    void Update()
    {
        lookInput.x = Input.mousePosition.x;
        lookInput.y = Input.mousePosition.y;
        mouseDistance.x = (lookInput.x - screenCenter.x) / screenCenter.y;
        mouseDistance.y= (lookInput.y - screenCenter.y) / screenCenter.y;

        mouseDistance = Vector2.ClampMagnitude(mouseDistance, 1f);

        rollInput = Mathf.Lerp(rollInput, Input.GetAxisRaw(axisName: "Roll"), rollAccelaration * Time.deltaTime);

        transform.Rotate(-mouseDistance.y * lookRateSpeed * Time.deltaTime, mouseDistance.x * lookRateSpeed * Time.deltaTime, rollInput*rollSpeed*Time.deltaTime, Space.Self);
        activeForwardSpeed =Mathf.Lerp(activeForwardSpeed, Input.GetAxisRaw("Vertical") * forwardSpeed,forwardAcceleration*Time.deltaTime);
        activeStrafeSpeed = Mathf.Lerp(activeStrafeSpeed, Input.GetAxisRaw("Horizontal") * strafeSpeed,starfeAcceleration * Time.deltaTime);
        activeHoverSpeed = Mathf.Lerp(activeHoverSpeed, Input.GetAxisRaw("Hover") * hoverSpeed,hoverAcceleration*Time.deltaTime);
        transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;
        transform.position += (transform.right * activeStrafeSpeed * Time.deltaTime) + (transform.up * activeHoverSpeed * Time.deltaTime);
       
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="enemy")
        {
            print("destroying");
            Destroy(other.gameObject);
            int x = ScoreManger.instance.getScore();
            if (x / 5 != Score)
            {
                Score++;
                if (flag == true)
                {
                    playerValue++;
                }
                flag = !flag;
                tempScale = transform.localScale;
                tempScale += new Vector3(1, 1, 0);
                transform.localScale = tempScale;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("bound")==true)
        {
            transform.position += transform.forward * -activeForwardSpeed;
            transform.position += (transform.right *- activeStrafeSpeed ) + (transform.up * -activeHoverSpeed );
        }
    }
     public int getPlayerValue()
    {
        return playerValue;
    }
}
