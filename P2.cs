using System;
using System.Collections.Generic;

namespace UIProject
{
    public class UIWindow
    {
        public string Title { get; set; }

        public UIWindow(string title)
        {
            Title = title;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"[UIWindow]: Rendering base window '{Title}'");
        }
    }

    public class MainWindow : UIWindow
    {
        public MainWindow(string title) : base(title) { }

        public override void Draw()
        {
            Console.WriteLine($"[MainWindow]: Displaying main menu and toolbar for '{Title}'");
        }
    }

    public class ModalWindow : UIWindow
    {
        public ModalWindow(string title) : base(title) { }

        public override void Draw()
        {
            Console.WriteLine($"[ModalWindow]: Blocking background and showing window '{Title}' on top of all others.");
        }
    }

    public class Dialog : UIWindow
    {
        public Dialog(string title) : base(title) { }

        public override void Draw()
        {
            Console.WriteLine($"[Dialog]: Displaying 'Yes/No' buttons in the '{Title}' window");
        }
    }

    class Program
    {
        static void Main()
        {
            List<UIWindow> windows = new List<UIWindow>
            {
                new MainWindow("Workspace"),
                new ModalWindow("Warning"),
                new Dialog("Exit Confirmation")
            };

            foreach (var win in windows)
            {
                win.Draw();
            }
        }
    }
}