using UnityEngine;

public class Sword : MonoBehaviour
{
    public AudioClip splashSound;
    Camera cam;
    public float sliceTime;
    public float maxComboTime;
    public int combo;

    void Start()
    {
        cam = Camera.main;
        Cursor.visible = false;
    }

    void Update()
    {
        Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        transform.position = pos;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Audio.Play(splashSound);
        other.gameObject.GetComponent<Fruit>().Slice();

        if (Time.time - sliceTime < maxComboTime)
        {
            combo++;
        }
        else
        {
            print(combo);
            combo = 1;
        }
        sliceTime = Time.time;
    }
}