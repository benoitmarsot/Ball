//Created by Benoit Marsot
//Cube sphere and deformation  by Jasper Flick from: https://catlikecoding.com/unity/tutorials/mesh-deformation/
//
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(MeshFilter))]
public class BallBounce : MonoBehaviour
{
    public AudioSource BounceSound;
    public float force = 10f;
    public float damping=5f;
    public float springForce=20;
    private float uniformScale = 1f;
    private Mesh deformingMesh;
    private Vector3[] originalVertices, displacedVertices, vertexVelocities;
    private float scNextCol=0.0f;
    private float scNextColRate=0.05f;
    void Start()
    {
        deformingMesh = GetComponent<MeshFilter>().mesh;
        originalVertices = deformingMesh.vertices;
        displacedVertices = new Vector3[originalVertices.Length];
        for (int i = 0; i < originalVertices.Length; i++)
        {
            displacedVertices[i] = originalVertices[i];
        }
        vertexVelocities = new Vector3[originalVertices.Length];
    }

    void OnCollisionEnter(Collision collision)
    {
        //only register collision every col rate
        if (Time.time > scNextCol)
        {
            this.scNextCol = Time.time + this.scNextColRate;
            if (BounceSound)
            { // && collision.relativeVelocity.magnitude > 2)
                BounceSound.PlayOneShot(BounceSound.clip);
            }
            List<ContactPoint> contacts = new List<ContactPoint>();
            int limit = collision.GetContacts(contacts);
            for (int i = 0; i < limit; i++)
            {
                this.AddDeformingForce(contacts[i].point, this.force);
            }
        }
        
    }
    public void AddDeformingForce(Vector3 point, float force)
    {
        point = transform.InverseTransformPoint(point);
        for (int i = 0; i < displacedVertices.Length; i++)
        {
            AddForceToVertex(i, point, force);
        }
    }

    void AddForceToVertex(int i, Vector3 point, float force)
    {
        Vector3 pointToVertex = displacedVertices[i] - point;
        pointToVertex *= uniformScale;
        float attenuatedForce = force / (1f + pointToVertex.sqrMagnitude);
        float velocity = attenuatedForce * Time.deltaTime;
        vertexVelocities[i] += pointToVertex.normalized * velocity;
    }
    void Update()
    {
        uniformScale = 1;  // transform.localScale.x;
        for (int i = 0; i < displacedVertices.Length; i++)
        {
            UpdateVertex(i);
        }
        deformingMesh.vertices = displacedVertices;
        deformingMesh.RecalculateNormals();
    }
    void UpdateVertex(int i)
    {
        Vector3 velocity = vertexVelocities[i];
        Vector3 displacement = displacedVertices[i] - originalVertices[i];
        displacement *= uniformScale;
        velocity -= displacement * springForce * Time.deltaTime;
        velocity *= 1f - damping * Time.deltaTime;
        vertexVelocities[i] = velocity;
        displacedVertices[i] += velocity * Time.deltaTime;
    }
}