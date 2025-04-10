﻿namespace OOPConsoleGame.Objects
{
    public abstract class GameObject : IInteractable
    {
        public ConsoleColor color;
        public char symbol;
        public Position position;

        public GameObject(ConsoleColor color, char symbol, Position position)
        {
            this.color = color;
            this.symbol = symbol;
            this.position = position;
        }

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ResetColor();
        }

        public abstract void Interact(Player player);
    }
}
