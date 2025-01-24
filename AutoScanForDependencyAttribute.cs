namespace AttributeSamples.CustomAttributes;

[AttributeUsage(AttributeTargets.Assembly)]
// به این صورت می تونیم بگیم که اتربیتمون فقط توی سطح اسمبلی قابل استفاده باشه نه جای دیگه ای
public class AutoScanForDependencyAttribute : Attribute
{
}
[AttributeUsage(AttributeTargets.Class| AttributeTargets.Interface| AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
// در اینجا اومدیم و گفتیم که این اتربیتمون توی کلاس ها اینترفیس ها و... قابل دسترسی باشه و همچنین با استفاده از
// AllowMultiple = true
// گفتیم که می تونیم از این اتربیوت چندبار برای یک تایپی استفاده کنیم و با
// Inherited = false
// هم گفتیم که نمیشه ازش ارث بری کرد
public class CodeChangeHistoryAttribute : Attribute
{
    private readonly string _author;

    public string Description { get; set; }
    public DateTime ChangeDateTime { get; set; }
    public bool IsBug { get; }

    public CodeChangeHistoryAttribute(string author, bool isBug = false)
    {
        _author = author;
        IsBug = isBug;
    }
    // در اینجا هم اومدیم و برای اتربیتمون یکسری پراپرتی و یک کانستراکتور تعریف کردیم
}