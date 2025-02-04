using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using System.Drawing;

namespace SanctumHelper;

public class SanctumHelperSettings : ISettings
{
    // Mandatory setting to enable/disable the plugin
    public ToggleNode Enable { get; set; } = new ToggleNode(false);

    // Settings for text under the player
    public ColorNode TextColor { get; set; } = new ColorNode(Color.White);
    public RangeNode<int> TextOffset { get; set; } = new RangeNode<int>(50, 0, 200);

    // Settings for entity circles
    public ToggleNode DrawChestCircles { get; set; } = new ToggleNode(true);
    public ColorNode ChestCircleColor { get; set; } = new ColorNode(Color.Blue);
    public RangeNode<int> CircleRadius { get; set; } = new RangeNode<int>(300, 50, 1000);
    
    public RangeNode<int> CircleThickness { get; set; } = new RangeNode<int>(3, 1, 10);
    
    // Settings for TimeTrialCollect circles
    public ToggleNode DrawTimeTrialCollectCircles { get; set; } = new ToggleNode(true);
    public ColorNode TimeTrialCollectCircleColor { get; set; } = new ColorNode(Color.Blue);
    public RangeNode<int> TimeTrialCollectCircleRadius { get; set; } = new RangeNode<int>(300, 50, 1000);
    
    public RangeNode<int> TimeTrialThickness { get; set; } = new RangeNode<int>(3, 1, 10);

        // Settings for Projectiles circles
    public ToggleNode DrawTimeProjectiles { get; set; } = new ToggleNode(true);
    public ColorNode ProjectilesCircleColor { get; set; } = new ColorNode(Color.Blue);
    public RangeNode<int> ProjectilesCircleRadius { get; set; } = new RangeNode<int>(300, 50, 1000);
    
    public RangeNode<int> ProjectilesThickness { get; set; } = new RangeNode<int>(3, 1, 10);
    
        // Setting for Reward Window
}