namespace Battleships.Business
{
    public interface IUserInterface
    {
        string GetUserInput();
        void RenderMessage(string message);
    }
}
