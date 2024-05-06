using Godot;
using System;

public partial class Camera : Camera2D
{
	[Export]
	public Node2D FollowNode { get; set; }

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

		public override void _PhysicsProcess(double delta)
	{

		this.Position += ((FollowNode.Position - this.Position)*4.0f) * (float)delta;
	}
}
