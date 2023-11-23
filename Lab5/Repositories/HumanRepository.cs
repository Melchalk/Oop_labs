namespace oop5;

internal static class HumanRepository
{
    static Dictionary<int, Human> _repository = new();

    public static string GetInfo(int id)
    {
        if (!_repository.TryGetValue(id, out Human? human))
            return "Ошибка";

        Name name = human.Fullname;

        return $"Информация о человеке с Id - {id}\n" +
            $"ФИО - {name.LastName} {name.FirstName} {name.MiddleName}\n" +
            $"День рождения - {human.Birthday}\n";
    }

    public static void AddHuman(Human human)
    {
        _repository.Add(human.ID, human);
    }

    public static int GetCount()
    {
        return _repository.Count;
    }
}