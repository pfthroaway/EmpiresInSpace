using Godot;

public class Planet01 : Area2D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    private void _on_Planet01_input_event(object viewport, object @event, int shape_idx)
    {
        if (@event is InputEventMouseButton mouse && mouse.IsPressed())
            if (mouse.ButtonIndex == 1) // left click
            { }
            else if (mouse.ButtonIndex == 2) // right click
            { }
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //
    //  }
}