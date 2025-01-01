namespace UlearnOOP;

public class MenuItem
{
    public string Caption { get; set; }
    public string HotKey { get; set; }
    public MenuItem[] Items { get; set; }
    
    public static MenuItem[] GenerateMenu()
    {
        return new[]
        {
            new MenuItem()
            {
                Caption = "File",
                HotKey = "F",
                Items = new MenuItem[]
                {
                    new MenuItem()
                    {
                        Caption = "New",
                        HotKey = "N"
                    },
                    new MenuItem()
                    {
                        Caption = "Save",
                        HotKey = "S"
                    }
                }
            },
            new MenuItem()
            {
                Caption = "Edit",
                HotKey = "E",
                Items = new MenuItem[]
                {
                    new MenuItem()
                    {
                        Caption = "Copy",
                        HotKey = "C"
                    },
                    new MenuItem()
                    {
                        Caption = "Paste",
                        HotKey = "V"
                    }
                }
            }
        };
    }
}