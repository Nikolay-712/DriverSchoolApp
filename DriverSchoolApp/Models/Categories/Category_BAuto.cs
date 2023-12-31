﻿namespace DriverSchoolApp.Models.Categories;

public class Category_BAuto
{
    public string PageTitle => "Ние обучаваме и формираме отлично подготвени бъдещи шофьори";

    public string CategoryName => "категория \"В/78\"";

    public string CategoryRules => "Какво ни е нужно да започнем";

    public string CategoryDescription => "Курсът включва теоретична и практическа подготовка. Управлението на автомобила се провежда на полигон, в населено и извън населено място";

    public Dictionary<string, string> NecessaryDocuments
        => new Dictionary<string, string>()
    {
        { "Диплома", "Валидна диплома за завършено средно образование"},
        { "Лична карта", "Валиден документ за самоличност"},
        { "Снимка паспортен формат", "Актуална снимка"},
        { "Навършени 17 години и 9 месеца", "Необходима минимално възраст"}
    };

    public string IncludesTraining => "Какво включва обучението";

    public IReadOnlyList<string> IncludesTrainings
        => new List<string>()
    {
            "Шофьорският курс включва два модула на обучение – теоретичен и практически",
            "Автошкола ПЕТЯ ВВС осигурява необходимите учебни помагала",
            "Шофиране в извън градски условия",
            "Шофиране в градски условия",
            "Часовете по управление на МПС са 31. Ако са недостатъчни, получавате допълнителни моточасове до постигане на желания резултат.",
            "Удобна за вас локция на започване на практическата подготовка",
            "Теоретичен изпит пред ДАИ",
            "Практически изпит пред ДАИ"
    };
}
