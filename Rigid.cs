using System;
using BulletSharp;
using BulletSharp.Math;

namespace rgn.Physics
{
    public class Rigid
    {
        RigidBody rb;

        public Vector3 LinearVelocity { get; set; }

       // public Rigid(int mass, float inertia, float restitution){}
        
            
         
            
        


        /// <summary>
        /// Adds the force.
        /// </summary>
        /// <param name="engineForce">Engine force.</param>
        public void AddForce(int engineForce)
        {
            var vec = new Vector3(0, 0, engineForce);
            rb.ApplyForce(vec, Vector3.Zero);
        }
        /// <summary>
        /// Adds the torque.
        /// </summary>
        /// <param name="torque">Torque.</param>
        public void AddTorque(int torque)
        {
            var vec = new Vector3(0, torque, 0);
            rb.ApplyTorque(vec);
        }


    }
}
