using AttributeSample.Domain;
using AttributeSamples.CustomAttributes;

//using AttributesSamples.CustomAttributes;
using System.ComponentModel.DataAnnotations;
// با استفاده از این یوزینگ می تونیم از اتربیوت ها برای اعتبارسنجی داده هامون استفاده کنیم.
using System.Diagnostics;
// سه
// attributes
// زیر داخل این یوزینگ قرار دارند
// [DebuggerDisplay]
// توی این اتربیوت می تونیم بگیم که چه اطلاعاتی می خوایم نمایش داده بشه
// [DebuggerBrowsableState]
// توی این اتربیوت می تونیم تعیین کنیم که کدوم یکی از ویژگی هایی که تایپ ما هستند قابل دیدن باشند
// [DebuggerTypeProxy]
// و توی این اتربیوت می تونیم یک پراکسی بنویسیم برای این که یک تایپ خاصی رو بتونیم نمایش بدیم

//namespace AttributeSample.Domain;

[DebuggerDisplay("Person Name is {FirstName} and his/her age is {Age}")]
// اطلاعاتی که اینجا نوشتیم رو تو خود برنامه در زمان دیباگ می تونیم ببینیم

[DebuggerTypeProxy(typeof(PersonDebuggerTypeProxy))]
// به این اتربیوت باید یک تایپ بدیم و اون تایپمون هم حتما باید کانستراکتور داشته باشه
// و درآخر هم کاری که این اتربیوت می کنه اینه که میاد و دوتا پراپرتی ای که داخل این کلاس تعریف کردیم رو در زمان دیباگ نمایش میده

[Serializable]
// با استفاده از این اتربیوت می تونیم تایپمون (کلاسی که در زیر نوشتیم) رو سریالایز کنیم

[CodeChangeHistory("Bahar Farshchian", isBug: false, Description = "Add New Property with Name ...")]
[CodeChangeHistory("Bahar Farshchian", isBug: true, Description = "Fix the bug")]
// به این صورت می تونیم از اتربیوتی که ساختیم استفاده کنیم و اطلاعاتی می خوایم رو توش بنویسیم
public class Person
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    // اینجوی دیگه پراپرتی ای که در زیر نوشتیم در قسمت اتربیوت ها توی
    // program
    // و زمان دیباگ نمایش داده نمیشه
    
    [Required]
    public string FirstName { get; set; } = "bahar";
    [StringLength(100)]
    // اینجا به این صورت میگیم که حداکثر طول رشتمون 100 باشه

    [CodeChangeHistory("Bahar Farshchian", isBug: false, Description = "Use Attribute in code for property")]
    public string LastName { get; set; } = "farshchian";

    public int Age { get; set; }

    [NonSerialized]
    // و به این صورت هم می تونیم جلوی سریالایز شدن یک تایپ (که در اینجا فیلد هست) رو بگیریم
    private int _age;

    public void Print()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    public void InputPrinter(string myinput)
    {
        Console.WriteLine(myinput);
    }
}
