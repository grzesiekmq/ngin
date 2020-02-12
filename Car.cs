using System;


namespace rgn
{
	public class Car
	{

		

		

		

		float steerInput = 1;
		/// <summary>
		/// left angle of ackermann steering in degrees
		/// </summary>
		/// <param name="rearTrack"></param>
		/// <param name="wheelBase"></param>
		/// <param name="turnRadius"></param>
		/// 
		/// <returns>angle</returns>
		public double AckermannLeft(float rearTrack, float wheelBase, float turnRadius)
		{
			return Math.RadToDeg(System.Math.Atan(wheelBase / (turnRadius + rearTrack / 2)) * steerInput);
		}
		/// <summary>
		/// right angle of ackermann steering in degrees
		/// </summary>
		/// <param name="rearTrack"></param>
		/// <param name="wheelBase"></param>
		/// <param name="turnRadius"></param>
		/// <returns>angle</returns>
		public double AckermannRight(float rearTrack, float wheelBase, float turnRadius)
		{
			return Math.RadToDeg(System.Math.Atan(wheelBase / (turnRadius - rearTrack / 2)) * steerInput);
		}




	}
}