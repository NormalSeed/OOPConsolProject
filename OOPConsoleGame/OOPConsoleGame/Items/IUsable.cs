namespace OOPConsoleGame.Items
{
    public interface IUsable
    {
        public string Name { get; set; }
        public void Use();
    }
}
