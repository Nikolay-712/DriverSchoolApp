﻿namespace DriverSchoolApp.Models.Categories;

public class Category_CE
{
    public string PageTitle => "Ние обучаваме и формираме отлично подготвени бъдещи шофьори";

    public string CategoryName => "категория CE";

    public string CategoryRules => "Какво ни е нужно да започнем";

    public string CategoryDescription => "Лице с правоспособност за управление на МПС от категория СЕ има право да управлява: Състав от пътни превозни средства с теглещо моторно превозно средство от категория С и ремарке с допустима максимална маса над 750 кг";

    public Dictionary<string, string> NecessaryDocuments
        => new Dictionary<string, string>()
    {
            { "Диплома", "Валидна диплома за завършено средно образование"},
            { "Правоспособност" ,"Да притежава правоспособност за управление на МПС от категория C" },
            { "Стаж","Да притежава стаж като водач на МПС от категория С не по-малко от една година" },
            { "Лична карта", "Валиден документ за самоличност"},
            { "Снимка паспортен формат", "Актуална снимка"},
            { "Необходима минимално възраст","Да е на възраст не по-малко от 21 години"}
    };

    public string IncludesTraining => "Какво включва обучението";

    public IReadOnlyList<string> IncludesTrainings
        => new List<string>()
    {
            "Шофьорският курс включва два модула на обучение – теоретичен и практически",
            "Подготовка на автомобила и ремаркето за движение и управление",
            "Управление на МПС товарен автомобил с ремарке, който е с продължителност 16 учебни часа",
            "Провежда се на учебна площадка, на пътища в населено и извън населено място",
            "Безопасно управление на автомобила при различни пътни условия",
            "Изпит за придобиване на правоспособност",
            "Лицата, които кандидатстват за придобиване на правоспособност за управление на МПС от категория СE полагат теоретичен и практически изпит",
    };

    public string ImageUrl => "img/categories_B_car.jpg";
}
