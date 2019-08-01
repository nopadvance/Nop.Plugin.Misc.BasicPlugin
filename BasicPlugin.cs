using Nop.Services.Plugins;

namespace Nop.Plugin.Misc.BasicPlugin
{
    public class BasicPlugin : BasePlugin
    {
        public override void Install()
        {
            //Put your default installation settings here

            base.Install();
        }
        public override void Uninstall()
        {
            //Remove your default installation settings here

            base.Uninstall();
        }
    }
}
