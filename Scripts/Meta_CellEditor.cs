using Godot;
using System;

public class Meta_CellEditor
{
	public namespace CAMERA
	{
		public namespace ZOOM
		{
			public static float FACTOR = 150.f; //how far you zoom in our out with each time you scroll
			public static float SPEED = 0.5f; //how fast you zoom in or out
			public static float DISTANCE_MIN = 300.f;
			public static float DISTANCE_MAX = 1500.f;
		}
		public static float DISTANCE_START = 400.f;
	}
	
	public namespace SCULPTING
	{
		public namespace NODES
		{
			public static float MAXIMUM_PER_ARM = 4.f;
			public static float SIZE_MIN = 50.f;
			public static float SIZE_MAX = 150.f;
			public static float DISTANCE_MIN = 15.f;
			public static float DISTANCE_MAX = 50.f;
			
			public enum ENodeType : uint
			{
				//Only the Editor Base has the base node. This can't be deleted.
				//Every third node can become a split node
				//Every other node is a normal node
				/*
				* Every node starts out as normal except for the base node obviously
				* When one node is split it becomes a split 
				* it's parent^2 and child^2 on the not split axis become a single
				* base is a special case it stays on that type
				* condition for split:
				* node is a normal not a single
				*/
				EBase,
				ENormal,
				ESplit,
				ESingle
			}
			
			public enum ENodePosition : uint
			{
				EAbove,
				EBelow,
				ERight,
				ELeft,
				EBase
			}
		}
		public namespace ARROW
		{
			public static float DISTANCEFROMBASE = 20.f;
		}
		public namespace GRID
		{
			public namespace DIMENSION
			{
				public static float X = 30.f;
				public static float Y = 30.f;
				public static float Z = 10.f;
			}
			public static float SCALE = 10.f;
		}
		public namespace METABALLS
		{
			public static float THRESHOLD = 0.5f;
		}
	}
}
