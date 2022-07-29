namespace Outrage.Patternfly.Components.View
{
    public interface IView
    {
        bool Matches(string path);
        void Show(string path);
        void Hide();
    }
}
