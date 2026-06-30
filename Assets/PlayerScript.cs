using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    bool HasCrashed;
    [SerializeField] float Rotation = 0.1f;
        [SerializeField] float BoostSpeed = 30f;
    [SerializeField] float NoramalSp = 20f;
    Rigidbody2D rg2d;
     SurfaceEffector2D surfaceEffector2D;


    
    void Start()
    {
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
        rg2d = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        if (HasCrashed == false)
        {
            Speed();
            Roatate();
        }
    }
    public void StopControl()
    {
        HasCrashed = true;
        surfaceEffector2D.speed = NoramalSp - 0.5f;
     
    }

    // Update is called once per frame
    void Speed()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = BoostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = NoramalSp;
        }
    }

    void Roatate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rg2d.AddTorque(Rotation);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rg2d.AddTorque(-Rotation);
        }
    }
}
