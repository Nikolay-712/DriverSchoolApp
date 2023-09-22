﻿namespace DriverSchoolApp.Models.Categories;

public class Category_BE
{
    public string PageTitle => "Ние обучаваме и формираме отлично подготвени бъдещи шофьори";

    public string CategoryName => "категория B/E ";

    public string CategoryRules => "Какво ни е нужно да започнем";

    public string CategoryDescription => "Притежаването на правоспособност за управление на МПС от категория ВЕ се изисква и когато допустимата максимална маса на ремаркето не надвишава 750 кг, но надвишава масата без товар на теглещото превозно средство.";

    public Dictionary<string, string> NecessaryDocuments
        => new Dictionary<string, string>()
    {
        { "Диплома", "Валидна диплома за завършено средно образование"},
        { "Лична карта", "Валиден документ за самоличност"},
        { "Снимка паспортен формат", "Актуална снимка"},
        { "Категория В","Да притежава категория В" },
        { "Необходима минимално възраст","Да е на възраст не по-малко от 18 години"}
    };

    public string IncludesTraining => "Какво включва обучението";

    public IReadOnlyList<string> IncludesTrainings
        => new List<string>()
    {
            "Обучението по практическия модул “Управление на МПС” се провежда на учебна площадка, на пътища в населено и извън населено място и на автомагистрала (при възможност) със състав от превозни средства – лек автомобил и прикачено ремарке към него",
            "Основни цели на модула са придобиване на навици за работа с уредите за управление на автомобила и ремаркето и заучаване и приложение на правилата за движение по пътищата и безопасно управление на автомобила при различни пътни условия",
            "Часовете по управление на МПС са 12. Ако са недостатъчни, получавате допълнителни моточасове до постигане на желания резултат",
            "Удобна за вас локция на започване на практическата подготовка",
            "Изпитът се провежда след приключване на обучението. Полага се изпит по управление на полигон и в градски условия със състав от учебния автомобил и ремаркето с изпитващия и инструктора и трае 25 минути /съгласно изискаванията на нормативната уредба",
    };

    public string ImageUrl => "img/categories_B_car.jpg";
}