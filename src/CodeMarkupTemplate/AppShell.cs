
namespace CodeMarkupTemplate
{
    using CodeMarkup.Maui;

    public class AppShell : Shell
    {
        public AppShell()
        {
            this.Resources.MergedDictionaries.Add(AppResources.Default);

            var tab = new Tab("Main")
            {
                new ShellContent<HelloWorldPage>("Hello Page"),   
            };

            this.Add(tab);
        }
    }
}
