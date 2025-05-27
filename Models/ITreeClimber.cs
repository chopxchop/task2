namespace AnimalApp.Models

{
    public interface ITreeClimber
    {
        bool IsOnTree { get; }

        void ClimbTree();

        void GetDownFromTree();
    }
}