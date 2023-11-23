namespace oop5;

internal static class HumanRepository
{
    static Dictionary<int, Human> _repository = new();

    public static string GetInfo(int id)
    {
        if (!_repository.ContainsKey(id))
            return "Ошибка";

        Name name = _repository[id].Fullname;

        return $"Информация о человеке с Id - {id}\n" +
            $"ФИО - {name.LastName} {name.FirstName} {name.Patronymic}\n" +
            $"День рождения - {_repository[id].Birthday}\n";
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