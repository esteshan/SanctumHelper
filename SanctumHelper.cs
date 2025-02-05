using System.Drawing;
using System.Linq;
using ExileCore2;
using ExileCore2.PoEMemory.MemoryObjects;
using Vector2 = System.Numerics.Vector2;
using ExileCore2.Shared.Enums;
using System;


namespace SanctumHelper
{
    public class SanctumHelper : BaseSettingsPlugin<SanctumHelperSettings>
    {
        public override bool Initialise()
        {
            return true;
        }

        public override void AreaChange(AreaInstance area)
        {
            // Perform zone-specific actions
        }

        public override void Tick()
        {
            // Perform non-render-related updates
        }

      public override void Render()
{
    if (!Settings.Enable) return;

    if (Settings.DrawChestCircles)
    {
        string[] keywords = { "Jewels", "test", "test" };

        foreach (var entity in GameController.Entities.Where(entity =>
                     keywords.Any(keyword => entity.Metadata.Contains(keyword))))
        {
            var entityScreenPos = GameController.Game.IngameState.Camera.WorldToScreen(entity.Pos);
            Graphics.DrawCircle(entityScreenPos, Settings.CircleRadius, Settings.ChestCircleColor,
                Settings.CircleThickness, 50);
        }
    }

    if (Settings.DrawTimeTrialCollectCircles)
    {
        foreach (var entity in GameController.Entities.Where(entity =>
                     entity.Metadata.Contains("TimeTrialCollectable")))
        {
            var entityScreenPos = GameController.Game.IngameState.Camera.WorldToScreen(entity.Pos);
            Graphics.DrawCircle(entityScreenPos, Settings.TimeTrialCollectCircleRadius,
                Settings.TimeTrialCollectCircleColor, Settings.TimeTrialThickness, 50);
        }
    }

    if (Settings.DrawTimeProjectiles)
    {
        foreach (var entity in GameController.Entities.Where(entity =>
                     entity.Metadata.Contains("Projectiles") && entity.IsHostile))
        {
            var entityScreenPos = GameController.Game.IngameState.Camera.WorldToScreen(entity.Pos);
            Graphics.DrawCircle(entityScreenPos, Settings.ProjectilesCircleRadius, Settings.ProjectilesCircleColor,
                Settings.ProjectilesThickness, 50);
        }
    }

    if (Settings.DrawTimeWall)
    {
        foreach (var entity in GameController.Entities.Where(entity =>
                     entity.Metadata.Contains("SanctumLogicDoor") && entity.IsHostile))
        {
            var entityScreenPos = GameController.Game.IngameState.Camera.WorldToScreen(entity.Pos);

            // Check if DistancePlayer is within the range 0 to 4.5
            if (entity.DistancePlayer >= 0f && entity.DistancePlayer <= 4.5f)
            {
                Graphics.DrawCircle(entityScreenPos, Settings.WallsCircleRadius, Color.Green,
                    Settings.WallsThickness, 50);
            }
            else
            {
                Graphics.DrawCircle(entityScreenPos, Settings.WallsCircleRadius, Settings.WallsCircleColor,
                    Settings.WallsThickness, 50);
            }
        }
    }

    // ✅ NEW: Draw SanctumMote Circles
    if (Settings.DrawSanctumMote)
    {
        foreach (var entity in GameController.Entities.Where(entity =>
                     entity.Metadata.Contains("SanctumMote")))
        {
            var entityScreenPos = GameController.Game.IngameState.Camera.WorldToScreen(entity.Pos);
            Graphics.DrawCircle(entityScreenPos, Settings.SanctumMoteCircleRadius, Settings.SanctumMoteCircleColor,
                Settings.SanctumMoteThickness, 50);
        }
    }
}




        public override void EntityAdded(Entity entity)
        {
            // Process entity once when added
        }
    }
}
