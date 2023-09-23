namespace DriverSchoolApp.Models;

public class CoursesModel
{
    public string TrandingCourses => "Обучение за категории";

    public string CoursesUpskill => "Нашите курсове";

    public string CouresLocation => "шофиорски курсове за територията на община Перник и гр. Радомир";


    public string CategoryBTitle => "категория \"В\"";

    public string CategoryBDescription => "автомобили с ръчни скорости";

    public string CatrgoryBImageUrl { get; set; }



    public string CategoryBAutoTitle => "категория \"В-78\"";

    public string CategoryBAutDescription => "автомобил с автоматични скорости";

    public string CatrgoryBAutoImageUrl { get; set; }



    public string CategoryBETitle => "категория \"ВЕ\"";

    public string CategoryBEDescription => "управление на автомобил с ремарке";

    public string CatrgoryBEImageUrl { get; set; }



    public string CategoryCTitle => "категория \"C\"";

    public string CategoryCDescription => "управление на товрен автомобил";

    public string CatrgoryCImageUrl { get; set; }



    public string CategoryCETitle => "категория \"CE\"";

    public string CategoryCEDescription => "управление на товрен автомобил с ремарке";

    public string CatrgoryCEImageUrl { get; set; }
}
