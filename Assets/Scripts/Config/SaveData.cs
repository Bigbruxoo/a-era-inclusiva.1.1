using System.Collections.Generic;

public class SaveData
{
    public int Day;
    public int Happiness;
    public string Name;
    public int Points;
    public List<string> Dialogs;    
    public List<int> SelectedActions;
    public int SelectedAvatar;

    public SaveData(string name, PlayerData data)
    {
        Name = name;
        Day = data.Day;
        Happiness = data.Happiness;
        Points = data.Points;
        Dialogs = data.Dialogs;
        SelectedAvatar = data.SelectedAvatar;

        // converte a Classe para  ID
        SelectedActions = new List<int>();
        foreach (var acao in data.SelectedActions)
        {
            SelectedActions.Add(acao.id);
        }
    }

    
    public SaveData(string name, int day, int happiness, int points, List<int> selectedActions, int selectedAvatar)
    {
        Name = name;
        Day = day;
        Happiness = happiness;
        Points = points;
        SelectedActions = selectedActions;
        SelectedAvatar = selectedAvatar;
    }
}
