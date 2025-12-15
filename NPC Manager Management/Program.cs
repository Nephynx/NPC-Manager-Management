namespace NPC_Manager_Management
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new NPCManager());
        }
    }
}