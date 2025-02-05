using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using System.Drawing;

namespace SanctumHelper;

public class SanctumHelperSettings : ISettings
{
    // Mandatory setting to enable/disable the plugin
    public ToggleNode Enable { get; set; } = new ToggleNode(false);

    // Settings for entity circles
    public ToggleNode DrawJewelsCircles { get; set; } = new ToggleNode(true);
    public ColorNode ChestCircleColor { get; set; } = new ColorNode(Color.Blue);
    public RangeNode<int> CircleRadius { get; set; } = new RangeNode<int>(300, 50, 1000);
    public RangeNode<int> CircleThickness { get; set; } = new RangeNode<int>(3, 1, 10);

    // ✅ Individual Toggles for Each Chest Type (Sharing the same color/radius/thickness)
    public ToggleNode DrawBodyArmour { get; set; } = new ToggleNode(true);
    public ToggleNode DrawBoots { get; set; } = new ToggleNode(true);
    public ToggleNode DrawGeneric { get; set; } = new ToggleNode(true);
    public ToggleNode DrawHelmet { get; set; } = new ToggleNode(true);
    public ToggleNode DrawMeleeWeapons { get; set; } = new ToggleNode(true);
    public ToggleNode DrawRangedWeapons { get; set; } = new ToggleNode(true);
    public ToggleNode DrawShield { get; set; } = new ToggleNode(true);
    public ToggleNode DrawRelic { get; set; } = new ToggleNode(true);
    public ToggleNode DrawCasterWeapons { get; set; } = new ToggleNode(true);
    public ToggleNode DrawGloves { get; set; } = new ToggleNode(true);
    public ToggleNode DrawGrandSpectrum { get; set; } = new ToggleNode(true);

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

    // Settings for wall circles
    public ToggleNode DrawTimeWall { get; set; } = new ToggleNode(true);
    public ColorNode WallsCircleColor { get; set; } = new ColorNode(Color.Blue);
    public RangeNode<int> WallsCircleRadius { get; set; } = new RangeNode<int>(300, 50, 1000);
    public RangeNode<int> WallsThickness { get; set; } = new RangeNode<int>(3, 1, 10);

	 // Settings for SanctumMote circles
    public ToggleNode DrawSanctumMote { get; set; } = new ToggleNode(true);
    public ColorNode SanctumMoteCircleColor { get; set; } = new ColorNode(Color.Yellow);
    public RangeNode<int> SanctumMoteCircleRadius { get; set; } = new RangeNode<int>(250, 50, 1000);
    public RangeNode<int> SanctumMoteThickness { get; set; } = new RangeNode<int>(3, 1, 10);
}
