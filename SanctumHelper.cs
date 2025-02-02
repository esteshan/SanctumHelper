using System.Drawing;
using System.Linq;
using ExileCore2;
using ExileCore2.PoEMemory.MemoryObjects;
using Vector2 = System.Numerics.Vector2;
using ExileCore2.Shared.Enums;

namespace SanctumHelper;

public class SanctumHelper : BaseSettingsPlugin<SanctumHelperSettings>


{
    public override bool Initialise()
    {
        //Perform one-time initialization here

        //Maybe load you custom config (only do so if builtin settings are inadequate for the job)
        //var configPath = Path.Join(ConfigDirectory, "custom_config.txt");
        //if (File.Exists(configPath))
        //{
        //    var data = File.ReadAllText(configPath);
        //}

        return true;
    }

    public override void AreaChange(AreaInstance area)
    {
        //Perform once-per-zone processing here
        //For example, Radar builds the zone map texture here
    }

    public override void Tick()
    {
        //Perform non-render-related work here, e.g. position calculation.
        //var a = Math.Sqrt(7);
    }

    public override void Render()
    {
        //Any Imgui or Graphics calls go here. This is called after Tick
        Graphics.DrawText($"Plugin {GetType().Name} is working.", new Vector2(100, 100), Color.Red);

        if (!Settings.Enable) return;

        // Get player position and draw text
        var playerPos = GameController.Player.Pos;
        var screenPos = GameController.Game.IngameState.Camera.WorldToScreen(playerPos);
        var adjustedScreenPos = screenPos + new Vector2(0, Settings.TextOffset);
        Graphics.DrawText("Plugin Active", adjustedScreenPos, Settings.TextColor, FontAlign.Center);

        if (Settings.DrawChestCircles)
        {
            string[] keywords = { "Jewels", "test", "test" };
            
            foreach (var entity in GameController.Entities.Where(entity =>
                         keywords.Any(keyword => entity.Metadata.Contains(keyword))))

            {
                var entityScreenPos = GameController.Game.IngameState.Camera.WorldToScreen(entity.Pos);
                Graphics.DrawCircle(entityScreenPos, Settings.CircleRadius, Settings.ChestCircleColor, Settings.CircleThickness, 50);
            }
        }
        
        if (Settings.DrawTimeTrialCollectCircles)
        {
            foreach (var entity in GameController.Entities.Where(entity => entity.Metadata.Contains("TimeTrialCollectable")))
            {
                var entityScreenPos = GameController.Game.IngameState.Camera.WorldToScreen(entity.Pos);
                Graphics.DrawCircle(entityScreenPos, Settings.TimeTrialCollectCircleRadius, Settings.TimeTrialCollectCircleColor, Settings.TimeTrialThickness,50);
            }
        }

        if (Settings.DrawTimeProjectiles)
        {
            foreach (var entity in GameController.Entities.Where(entity => entity.Metadata.Contains("Projectiles") && entity.IsHostile))
            {
                var entityScreenPos = GameController.Game.IngameState.Camera.WorldToScreen(entity.Pos);
                Graphics.DrawCircle(entityScreenPos, Settings.ProjectilesCircleRadius, Settings.ProjectilesCircleColor, Settings.ProjectilesThickness,50);
            }
        }
    }

    public override void EntityAdded(Entity entity)
    {
        //If you have a reason to process every entity only once,
        //this is a good place to do so.
        //You may want to use a queue and run the actual
        //processing (if any) inside the Tick method.
    }


}

